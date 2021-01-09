Imports System.Data.OleDb

Public Class frmLogBook

#Region "Filling Functions"

    Private Sub FillData(ByVal SqlString As String)
        Me.lstvw.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        Me.lblTotalRecord.Text = FormatNumber(ds.Tables(0).Rows.Count, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                Dim MyItem = Me.lstvw.Items.Add(dr("GenID"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("RoomNo"))

                    .SubItems.Add(dr("Check_IN"))
                    .SubItems.Add(dr("Check_OUT"))

                    .SubItems.Add(dr("Floor"))
                    .SubItems.Add(FormatNumber(dr("Rate")))
                    .SubItems.Add(dr("Description"))
                    .SubItems.Add(dr("Nights"))
                    .SubItems.Add(FormatNumber(dr("AmountPaid")))
                    .SubItems.Add(FormatNumber(dr("AdvancePayment")))
                    .SubItems.Add(FormatNumber(dr("LocalTax")))
                    .SubItems.Add(dr("PaymentType"))
                    .SubItems.Add(dr("ReservationStatus"))
                    'DatePaid
                    Dim strDate As String
                    If IsDBNull(dr("DatePaid")) = False Then
                        strDate = CDate(dr("DatePaid")).ToShortDateString
                    Else
                        strDate = ""
                    End If
                    .SubItems.Add(strDate)
                End With
            Next
        End If
        cn.Close()
    End Sub

#End Region

#Region "Loading List"

    Friend Sub LoadList()

        If Trim(Me.cmbxSearchField.Text).Length = 0 Then Me.cmbxSearchField.Text = "RoomNo"
        Dim strCheckStatus As String
        Dim strStatus As String
        Dim strfield As String

        If Me.cmbxSearchField.Text = "ControlNo" Then
            strfield = "GenID"
        Else
            strfield = Me.cmbxSearchField.Text
        End If

        If Me.cmbxCheckStatus.Text = "Check-In" Then
            strCheckStatus = "Check_IN"
            strStatus = "In"
        Else
            strCheckStatus = "Check_OUT"
            strStatus = "Out"
        End If

        If Me.cmbxCheckStatus.Text = "All" And Me.cmbxReservationStatus.Text = "All" Then
            FillData("SELECT * FROM tblLogBook WHERE " & strfield & " LIKE '" & Me.txtSearch.Text & "%' ORDER BY Check_IN ASC")
        ElseIf Me.cmbxCheckStatus.Text <> "All" And Me.cmbxReservationStatus.Text = "All" Then
            FillData("SELECT * FROM tblLogBook WHERE " & strfield & " LIKE '" & Me.txtSearch.Text & "%' AND " & strCheckStatus & " = #" & Me.dtpDateSearch.Value.ToShortDateString & " " & GetCheckTime(strStatus) & "# ORDER BY Check_IN ASC")
        ElseIf Me.cmbxCheckStatus.Text = "All" And Me.cmbxReservationStatus.Text <> "All" Then
            FillData("SELECT * FROM tblLogBook WHERE " & strfield & " LIKE '" & Me.txtSearch.Text & "%' AND ReservationStatus='" & Me.cmbxReservationStatus.Text & "' ORDER BY Check_IN ASC")
        ElseIf Me.cmbxCheckStatus.Text <> "All" And Me.cmbxReservationStatus.Text <> "All" Then
            FillData("SELECT * FROM tblLogBook WHERE " & strfield & " LIKE '" & Me.txtSearch.Text & "%' AND " & strCheckStatus & " = #" & Me.dtpDateSearch.Value.ToShortDateString & " " & GetCheckTime(strStatus) & "# AND ReservationStatus='" & Me.cmbxReservationStatus.Text & "' ORDER BY Check_IN ASC")
        ElseIf Me.cmbxCheckStatus.Text <> "All" And Me.cmbxReservationStatus.Text <> "All" Then
            FillData("SELECT * FROM tblLogBook WHERE " & strfield & " LIKE '" & Me.txtSearch.Text & "%'  AND " & strCheckStatus & " = #" & Me.dtpDateSearch.Value.ToShortDateString & " " & GetCheckTime(strStatus) & "# AND ReservationStatus='" & Me.cmbxReservationStatus.Text & "' ORDER BY Check_IN ASC")
        End If

        'FillData("SELECT * FROM tblLogBook ORDER BY RoomNo ASC")
        listvwColorChange(Me.lstvw)
    End Sub

#End Region

    Private Sub CMS_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMS.Opening
        If Me.lstvw.SelectedItems.Count > 0 Then
            Me.EditToolStripMenuItem.Enabled = True
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.EditToolStripMenuItem.Enabled = False
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmLogBook_Entry
            .LoadPaymentType()
            .cmbxPaymentType.Text = "<select>"
            .cmbxReservationStatus.Text = "<select>"
            .LoadRooms()
            .btnOccupy.Visible = False
            .btnInvoice.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub frmLogBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbxCheckStatus.Text = "Check-In"
        Me.cmbxReservationStatus.Text = "All"
        Me.cmbxSearchField.Text = "ControlNo"
        LoadList()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim StrSelect As String
        If MessageBox.Show("Are you sure you want to delete reservation " + Me.lstvw.SelectedItems(0).SubItems(1).Text + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM tblLogBook " & _
                 "WHERE GenID = " + Me.lstvw.SelectedItems(0).Text + ""

            CheckConnection(cn)

            Dim cmd As New OleDbCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()
            MsgBox("Entry " & Me.lstvw.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.", MsgBoxStyle.Information, "")

            'SystemLog
            SystemLog("Delete", "Entry " & Me.lstvw.SelectedItems(0).SubItems(1).Text & " has been deleted.", frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Log Book Module")

            LoadList()
            frmRoomMonitoring.LoadListReservation()
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        With frmLogBook_Entry
            .GenID = Me.lstvw.SelectedItems(0).Text
            .LoadAdvances()
            .LoadOthersList()
            .LoadCustomerList()
            .LoadPaymentType()
            .LoadRooms()
            .btnEnter.Text = "&Update"
            .GetReservationData()
            .ShowDialog()
        End With
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadList()
    End Sub

    Private Sub btnSearchReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchReservation.Click
        LoadList()
    End Sub

End Class
Imports System.Data.OleDb

Public Class frmCustomer_View

    Friend EntryType As String

#Region "User Functions"


#End Region

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

                Dim MyItem = Me.lstvw.Items.Add(dr("Id"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("FullName"))
                    .SubItems.Add(dr("Address"))
                    .SubItems.Add(dr("PhoneNo"))
                    .SubItems.Add(dr("ID_Passport"))
                    .SubItems.Add(dr("DateOfBirth"))
                    If IsDBNull(dr("BlockListed")) = True Then
                        .SubItems.Add("-")
                    Else
                        .SubItems.Add(dr("BlockListed"))
                    End If

                End With
            Next
        End If
        cn.Close()
    End Sub

#End Region

#Region "Loading List"

    Friend Sub LoadList()
        FillData("SELECT * FROM tblCustomer WHERE FullName Like '%" & Me.txtSearch.Text & "%' ORDER BY FullName ASC")
        listvwBlockListed(Me.lstvw)
        'listvwColorChange(Me.lstvw)
    End Sub

#End Region

    Private Sub frmCustomer_View_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.InsertToolStripMenuItem.Visible = False
        Me.ToolStripSeparator3.Visible = False
    End Sub

    Private Sub frmCustomer_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadList()
    End Sub

    Private Sub CMS_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMS.Opening
        If Me.lstvw.SelectedItems.Count > 0 Then
            Me.InsertToolStripMenuItem.Enabled = True
            Me.EditToolStripMenuItem.Enabled = True
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.InsertToolStripMenuItem.Enabled = False
            Me.EditToolStripMenuItem.Enabled = False
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmCustomer_Entry
            .btnEnter.Text = "&Save"
            .btnPreview.Enabled = False
            .btnCapture.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim StrSelect As String
        If MessageBox.Show("Are you sure you want to delete customer" + Me.lstvw.SelectedItems(0).SubItems(1).Text + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM tblCustomer " & _
                 "WHERE Id = " + Me.lstvw.SelectedItems(0).Text + ""

            CheckConnection(cn)

            Dim cmd As New OleDbCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()
            MsgBox("Customer " & Me.lstvw.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.", MsgBoxStyle.Information, "")

            'SystemLog
            SystemLog("Delete", "Customer " & Me.lstvw.SelectedItems(0).SubItems(1).Text & " has been deleted.", frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Customer Module")

            LoadList()
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        With frmCustomer_Entry
            .btnEnter.Text = "&Update"
            .Id = Me.lstvw.SelectedItems(0).Text
            .btnPreview.Enabled = True
            .btnCapture.Enabled = True
            .GetInfo()
            .ShowDialog()
        End With
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadList()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadList()
    End Sub

    Private Sub InsertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertToolStripMenuItem.Click

        Dim ItemFound As Boolean = False
        Dim x As Integer
        Dim y As Integer
        If Me.lstvw.SelectedItems(0).SubItems(6).Text = "Block" Then
            MsgBox("This customer is blocked! Please select other customer.", MsgBoxStyle.Exclamation, "Blocked")
        Else
            With frmLogBook_Entry
                For y = 0 To .lstvwCustomer.Items.Count - 1
                    If .lstvwCustomer.Items(y).SubItems(0).Text = Me.lstvw.SelectedItems(0).SubItems(0).Text Then
                        MsgBox("Customer already exist in the logbook.", MsgBoxStyle.Exclamation, "Duplicate")
                        ItemFound = True
                    End If
                Next
                If ItemFound = False Then
                    Dim MyItem = .lstvwCustomer.Items.Add(Me.lstvw.SelectedItems(0).SubItems(0).Text)
                    MyItem.Tag = x
                    x = x + 1
                    With MyItem
                        .SubItems.Add(Me.lstvw.SelectedItems(0).SubItems(1).Text)
                        .SubItems.Add(Me.lstvw.SelectedItems(0).SubItems(2).Text)
                    End With
                    Me.Close()
                End If
            End With
        End If


    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyValue = Keys.Enter Then
            Me.btnSearch_Click(sender, e)
        End If
    End Sub

End Class
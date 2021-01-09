Imports System.Data.OleDb

Public Class frmAdvancePayment_Entry

#Region "Filling Functions"

    Private Sub FillPaymentType(ByVal Sqlstring As String)
        Me.cmbxPaymentType.Items.Clear()
        CheckConnection(cn)
        oledbda.SelectCommand = New OleDbCommand(Sqlstring, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        ds.Clear()
        oledbda.Fill(ds)
        Me.cmbxPaymentType.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxPaymentType.Items.Add(dr("Title"))
            Next
        End If
        Me.cmbxPaymentType.Text = "<select>"
    End Sub

#End Region

#Region "Loading"

    Public Sub LoadPaymentType()
        FillPaymentType("SELECT * FROM tblPaymentType")
    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdvAmount.TextChanged
        If Trim(Me.txtAdvAmount.Text).Length = 0 Then
            Me.txtAdvAmount.Text = "0.00"
        End If
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If IsNumeric(Me.txtAdvAmount.Text) = False Then
            MessageBox.Show("Please enter a valid amount for the advance payment.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtAdvAmount.Focus()
            Me.txtAdvAmount.Text = "0.00"
        ElseIf Me.cmbxPaymentType.Text = "<select>" Then
            MessageBox.Show("Please select a valid Payment type.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbxPaymentType.Focus()
        Else
            Dim x As Integer
            With frmLogBook_Entry
                Dim MyItem = .lstvwAdvances.Items.Add(Me.dtpDateAdv.Value)
                MyItem.Tag = x
                x = x + 1
                With MyItem
                    .SubItems.Add(Me.cmbxPaymentType.Text)
                    .SubItems.Add(frmRoomMonitoring.ToolStripStatuslblUsername.Text)
                    .SubItems.Add(FormatNumber(Me.txtAdvAmount.Text))
                End With
            End With
            frmLogBook_Entry.ComputeTotal()
            Me.btnCancel_Click(sender, e)
            frmLogBook_Entry.ComputeTotal()
        End If
    End Sub

    Private Sub frmAdvancePayment_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadPaymentType()
    End Sub

End Class
Imports System.Data.OleDb

Public Class frmPaymentType_Entry

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim strSelect As String

        If Trim(Me.txtDescription.Text).Length = 0 Then
            MsgBox("Please enter a title for the payment type", MsgBoxStyle.Exclamation, "Required")
            Me.txtDescription.Focus()
        Else
            strSelect = "INSERT INTO tblPaymentType" & _
                                "([Title])VALUES " + _
                                "('" + CSQ(Me.txtDescription.Text) + "')"

            CheckConnection(cn)
            Dim cmdSave As New OleDbCommand(strSelect, cn)
            cmdSave.ExecuteNonQuery()
            MsgBox(Me.txtDescription.Text & " payment type has been successfully saved.", MsgBoxStyle.Information, "Saved")

            'SystemLog
            SystemLog("Add", Me.txtDescription.Text & " payment type has been added.", frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Payment type Module")

            frmPaymentType_View.LoadList()
            Me.btnCancel_Click(sender, e)
        End If
    End Sub

End Class
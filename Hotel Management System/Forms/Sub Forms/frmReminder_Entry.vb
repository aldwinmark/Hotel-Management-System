Imports System.Data.OleDb

Public Class frmReminder_Entry

    Friend Id As Integer

    Friend strDate As String
    Friend strTime As String
    Friend Remarks As String

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim strSelect As String

        If Trim(Me.txtRemarks.Text).Length = 0 Then
            MsgBox("Please enter a remark for the reminder", MsgBoxStyle.Exclamation, "Required")
            Me.txtRemarks.Focus()
        Else
            If Me.btnEnter.Text = "&Save" Then
                strSelect = "INSERT INTO tblReminders" & _
                                               "([RemDate],[RemTime],[Remarks])VALUES " + _
                                               "('" + (Me.dtpDate.Value.ToShortDateString) + "','" + Me.dtpTime.Value.ToString("HH:mm:ss tt") + "','" + CSQ(Me.txtRemarks.Text) + "')"

                CheckConnection(cn)
                Dim cmdSave As New OleDbCommand(strSelect, cn)
                cmdSave.ExecuteNonQuery()

                'SystemLog
                SystemLog("Add", Me.txtRemarks.Text & " has been added.", frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Reminder Module")

                MsgBox("Reminder has been successfully saved.", MsgBoxStyle.Information, "Saved")
            Else
                strSelect = "UPDATE tblReminders SET" & _
                   "[RemDate]='" & Me.dtpDate.Value.ToShortDateString & _
                   "',[RemTime]='" & Me.dtpTime.Value.ToString("HH:mm:ss tt") & _
                   "',[Remarks]='" & Me.txtRemarks.Text & _
                   "'WHERE Id=" & Id & ""

                CheckConnection(cn)

                Dim cmd As New OleDbCommand(strSelect, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Reminder has been successfully updated.", MsgBoxStyle.Information, "Updated")

                'SystemLog
                Dim str As String = ""
                If strDate <> dtpDate.Text Then
                    str = str & "Date(" & strDate & ">" & Me.dtpDate.Text & ")"
                End If
                If strTime <> dtpTime.Text Then
                    str = str & "Time(" & strTime & ">" & Me.dtpTime.Text & ")"
                End If
                If Remarks <> txtRemarks.Text Then
                    str = str & "Remarks(" & Remarks & ">" & Me.txtRemarks.Text & ")"
                End If
                If str <> "" Then
                    SystemLog("Edit", "Changes in " & str, frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Reminder Module")
                End If
            End If
            frmRoomMonitoring.LoadListReminder()
            Me.btnCancel_Click(sender, e)
        End If
    End Sub

End Class
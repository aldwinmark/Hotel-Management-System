Imports System.Data.OleDb

Public Class frmUserAccount_Entry

    Dim StrSelect As String

    Friend Username As String
    Friend Password As String
    Friend UserLevel As String

#Region "Varaible declaration"
    Friend Id As Integer
#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If Me.cmbxUserLevel.Text = "" Then
            MsgBox("User level is empty, please select a user level in the list.", MsgBoxStyle.Exclamation, "Required")
            Me.cmbxUserLevel.Focus()
        ElseIf Len(Me.txtUsername.Text.Trim) <= 0 Then
            MsgBox("Username is empty, please enter a valid username.", MsgBoxStyle.Exclamation, "Required")
            Me.txtUsername.Focus()
        ElseIf Len(Me.txtUsername.Text.Trim) < 6 Then
            MsgBox("Username is <6 character, please enter a valid username.", MsgBoxStyle.Exclamation, "Required")
            Me.txtUsername.Focus()
        ElseIf Len(Me.txtPassword.Text.Trim) <= 0 Then
            MsgBox("Password is empty, please enter a valid password.", MsgBoxStyle.Exclamation, "Required")
            Me.txtPassword.Focus()
        ElseIf Len(Me.txtPassword.Text.Trim) < 5 Then
            MsgBox("Password is <5 character, please enter a valid Password.", MsgBoxStyle.Exclamation, "Required")
            Me.txtPassword.Focus()
        ElseIf Not Me.txtPassword.Text = Me.txtConfirmed.Text Then
            MsgBox("The password entered is not equal to the confirmed password.", MsgBoxStyle.Exclamation, "Required")
            Me.txtConfirmed.Focus()
        Else
            If Me.btnEnter.Text = "&Save" Then
                StrSelect = "INSERT INTO tblUserAccount" & _
                                    "([Username],[Password],[UserLevel])VALUES " + _
                                    "('" + (Me.txtUsername.Text) + "','" + _
                                    "" + (Me.txtPassword.Text) + _
                                    "', '" + Me.cmbxUserLevel.Text + "')"

                CheckConnection(cn)
                Dim cmdSave As New OleDbCommand(StrSelect, cn)
                cmdSave.ExecuteNonQuery()

                'SystemLog
                SystemLog("Add", Me.txtUsername.Text & " has been added.", frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "User Account Module")

                MsgBox(Me.txtUsername.Text & " user account has been successfully saved.", MsgBoxStyle.Information, "Saved")
            Else
                'update the record
                StrSelect = "UPDATE tblUserAccount SET " & _
                "[Username]='" & CSQ(Me.txtUsername.Text) & _
                "',[Password]='" & CSQ(Me.txtPassword.Text) & _
                "',[UserLevel]='" & CSQ(Me.cmbxUserLevel.Text) & _
                "'WHERE Id=" & Id & ""

                CheckConnection(cn)

                Dim cmd As New OleDbCommand(StrSelect, cn)
                cmd.ExecuteNonQuery()

                'SystemLog
                Dim str As String = ""
                If Username <> txtUsername.Text Then
                    str = str & "(" & Username & ">" & Me.txtUsername.Text & ")"
                End If
                If Password <> txtPassword.Text Then
                    str = str & "(" & Password & ">" & Me.txtPassword.Text & ")"
                End If
                If UserLevel <> cmbxUserLevel.Text Then
                    str = str & "(" & UserLevel & ">" & Me.cmbxUserLevel.Text & ")"
                End If
                If str <> "" Then
                    SystemLog("Edit", "Changes in " & str, frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "User Account Module")
                End If
                MsgBox(Me.txtUsername.Text & " user account has been successfully updated.", MsgBoxStyle.Information, "Updated")
            End If
            frmUserAccount_View.LoadUserAccountList()
            Me.btnCancel_Click(sender, e)
        End If
    End Sub

End Class
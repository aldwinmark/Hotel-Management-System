Imports System.Data.OleDb

Public Class frmDeletionAccess

#Region "User Functions"

    Private Sub GetUserCode()

        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblUserAccount WHERE UserLevel=" & 4 & ""
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            Me.txtUserCode.Text = Reader("Password")
            Me.txtConfirmUserCode.Text = Reader("Password")
        End If

        'close the reader
        Reader.Close()

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim strSelect As String

        If Trim(Me.txtUserCode.Text).Length = 0 Then
            MsgBox("Please enter a user code to be use.", MsgBoxStyle.Exclamation, "Required")
            Me.txtUserCode.Focus()
        ElseIf Trim(Me.txtConfirmUserCode.Text).Length = 0 Then
            MsgBox("Please enter a confirm user code to be use.", MsgBoxStyle.Exclamation, "Required")
            Me.txtConfirmUserCode.Focus()
        ElseIf Not Me.txtConfirmUserCode.Text = Me.txtUserCode.Text Then
            MsgBox("Please enter a confirm user code to be use.", MsgBoxStyle.Exclamation, "Required")
            Me.txtConfirmUserCode.Focus()
        Else
            strSelect = "UPDATE tblUserAccount SET" & _
                        "[Password]='" & Me.txtUserCode.Text & _
                        "'WHERE UserLevel=" & 4 & ""

            CheckConnection(cn)

            Dim cmd As New OleDbCommand(strSelect, cn)
            cmd.ExecuteNonQuery()
            MsgBox("User code has been successfully updated.", MsgBoxStyle.Information, "Updated")
            Me.btnCancel_Click(sender, e)
        End If
    End Sub

    Private Sub frmDeletionAccess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetUserCode()
    End Sub

End Class
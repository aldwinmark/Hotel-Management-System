Imports System.Data.OleDb

Public Class frmLogin

#Region "Variable Declaration"
    Friend Level As Integer
#End Region

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        If MessageBox.Show("Are you sure you want to quit the application?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        'check if username textbox is not empty
        If Len(Me.txtUsername.Text.Trim) <= 0 Then
            MsgBox("Username is empty, please enter a valid username.", MsgBoxStyle.Exclamation, "Required")
            Me.txtUsername.Focus()
        ElseIf Len(Me.txtPassword.Text.Trim) <= 0 Then
            MsgBox("Password is empty, please enter a valid password.", MsgBoxStyle.Exclamation, "Required")
            Me.txtPassword.Focus()
        Else
            CheckConnection(cn)
            Dim StrSelect = "SELECT * FROM tblUserAccount WHERE Username='" & CSQ(Me.txtUsername.Text) & "' AND Password = '" & CSQ(Me.txtPassword.Text) & "'"
            Dim cmd As New OleDbCommand(StrSelect, cn)
            Dim Reader As OleDbDataReader = cmd.ExecuteReader
            Reader.Read()
            If Reader.HasRows = True Then
                Level = Reader("UserLevel")
                With frmRoomMonitoring

                    .ToolStripStatuslblUsername.Text = Reader("Username")
                    .ToolStripStatuslblLevel.Text = Reader("UserLevel")
                    .ToolStripStatusUserId.Text = Reader("Id")

                    SystemLog("Edit", "User " & Reader("Username") & "(" & Reader("UserLevel") & ") has log-in.", frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Log-in Module")

                    If Level = 1 Then
                        'main menu
                        .MaintenanceToolStripMenuItem.Visible = True
                        .DatabaseToolStripMenuItem.Visible = True
                        .RestoreFromBackupToolStripMenuItem.Visible = True
                        .LogBookToolStripMenuItem.Visible = True
                        'sub menu
                        .DelTaskToolStripMenuItem.Visible = True
                        .DeleteResToolStripMenuItem.Visible = True
                        .DeleteToolStripMenuItem.Visible = True

                        .SystemLogToolStripMenuItem.Visible = True
                        .TransactionReportToolStripMenuItem.Visible = True
                        .AdvancePaymentToolStripMenuItem.Visible = True
                    ElseIf Level = 2 Then
                        .MaintenanceToolStripMenuItem.Visible = False
                        .DatabaseToolStripMenuItem.Visible = True
                        .RestoreFromBackupToolStripMenuItem.Visible = False
                        .LogBookToolStripMenuItem.Visible = False
                        'sub menu
                        .DelTaskToolStripMenuItem.Visible = False
                        .DeleteResToolStripMenuItem.Visible = False
                        '.DeleteToolStripMenuItem.Visible = False

                        .SystemLogToolStripMenuItem.Visible = False
                        .TransactionReportToolStripMenuItem.Visible = False
                        .AdvancePaymentToolStripMenuItem.Visible = False
                    ElseIf Level = 3 Then
                        .MaintenanceToolStripMenuItem.Visible = False
                        .DatabaseToolStripMenuItem.Visible = False
                        .LogBookToolStripMenuItem.Visible = False

                        'sub menu
                        .DelTaskToolStripMenuItem.Visible = False
                        .DeleteResToolStripMenuItem.Visible = False
                        .DeleteToolStripMenuItem.Visible = False

                        .SystemLogToolStripMenuItem.Visible = False
                        .TransactionReportToolStripMenuItem.Visible = False
                        .AdvancePaymentToolStripMenuItem.Visible = False
                    End If

                End With

                With frmRoomMonitoring
                    .tmReminder.Start()
                    .tmRoomAlarm.Start()
                End With

                Me.Dispose()
                'Me.Close()
            Else
                MsgBox("Username or password is invalid, please enter a valid username or password.", MsgBoxStyle.Information, "invalid username or password")
                Me.txtUsername.Focus()
            End If

            'close the reader
            Reader.Close()
        End If

    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyValue = Keys.Enter Then
            Me.txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyValue = Keys.Enter Then
            Me.btnEnter.Focus()
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtUsername.Text = "administrator"
        Me.txtPassword.Text = "admin"
    End Sub

End Class
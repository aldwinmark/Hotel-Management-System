Imports System.IO.File

Public Class frmDatabase

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPath.Click
        Me.OFDDatabase.Title = "Please select a database source"
        Me.OFDDatabase.Filter = "Microsoft Access Database (*.accdb)|*.accdb"
        Me.OFDDatabase.DefaultExt = ".accdb"
        Me.OFDDatabase.FileName = "HMDB"

        If Not Me.OFDDatabase.ShowDialog = Windows.Forms.DialogResult.Cancel = True Then
            Me.txtDBPath.Text = Me.OFDDatabase.FileName
        Else
            Me.txtDBPath.Text = ""
        End If
    End Sub

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        If Len(Me.txtDBPath.Text) = 0 Or Exists(Me.txtDBPath.Text) = False Then
            MsgBox("Please select a valid database source to restore.")
            Me.btnPath.Focus()
        Else
            FileCopy(Me.txtDBPath.Text, Application.StartupPath & "\HMDB.accdb")
            MsgBox("Database has been successfully restored.", MsgBoxStyle.Information, "Restore")

            'SystemLog
            SystemLog("Restore back-up", "Restore from " & Me.txtDBPath.Text, frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Database Module")

            With frmRoomMonitoring
                .LoadListRoomCleaning()
                .LoadListRoomAlarm()
                .LoadListReminder()
                .LoadList()
                .LoadListReservation()
            End With


            Me.Close()
        End If
    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        If Len(Me.txtDBPath.Text) = 0 Or Exists(Me.txtDBPath.Text) = False Then
            MsgBox("Please select a valid database source to back-up.")
            Me.btnPath.Focus()
        Else
            Me.SFDDatabase.Filter = "Microsoft Access Database (*.accdb)|*.accdb"
            Me.SFDDatabase.DefaultExt = ".accdb"
            Me.SFDDatabase.FileName = "HMDB(Backup)"

            If Not Me.SFDDatabase.ShowDialog = Windows.Forms.DialogResult.Cancel = True Then
                FileCopy(Me.txtDBPath.Text, Me.SFDDatabase.FileName)
                MsgBox("Database has been successfully back-up.", MsgBoxStyle.Information, "Back-up")

                'SystemLog
                SystemLog("Back-up database", "Back-up to " & Me.txtDBPath.Text, frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Database Module")

                Me.Close()
            End If

        End If
    End Sub

    Private Sub txtDBPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDBPath.TextChanged
        If Len(Me.txtDBPath.Text) = 0 Then
            Me.btnBackup.Enabled = False
            Me.btnRestore.Enabled = False
        Else
            Me.btnBackup.Enabled = True
            Me.btnRestore.Enabled = True
        End If
    End Sub

    Private Sub frmDatabase_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        With frmRoomMonitoring
            .tmReminder.Start()
            .tmRoomAlarm.Start()
        End With
        Me.Dispose()
    End Sub

End Class
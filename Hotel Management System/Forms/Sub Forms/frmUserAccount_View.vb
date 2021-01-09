Imports System.Data.OleDb

Public Class frmUserAccount_View

#Region "Functions"

    Private Sub FillUserAccount(ByVal SqlString As String)
        Me.lstvwUserAccount.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        Me.lblTotalNo.Text = FormatNumber(ds.Tables(0).Rows.Count, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                Dim MyItem = Me.lstvwUserAccount.Items.Add(dr("Id"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Username"))
                    .SubItems.Add(dr("Password"))
                    .SubItems.Add(dr("UserLevel"))
                End With
            Next
        End If
        cn.Close()
    End Sub

#End Region

#Region "Loading List"

    Friend Sub LoadUserAccountList()
        FillUserAccount("SELECT * FROM tblUserAccount ORDER BY UserLevel ASC")
        listvwColorChange(Me.lstvwUserAccount)
    End Sub

#End Region

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmUserAccount_Entry
            .btnEnter.Text = "&Save"
            .ShowDialog()
            .cmbxUserLevel.Text = "3"
            .cmbxUserLevel.Focus()
        End With
    End Sub

    Private Sub frmUserAccount_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadUserAccountList()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        With frmUserAccount_Entry
            .cmbxUserLevel.Text = Me.lstvwUserAccount.SelectedItems(0).SubItems(3).Text
            .txtUsername.Text = Me.lstvwUserAccount.SelectedItems(0).SubItems(1).Text
            .txtPassword.Text = Me.lstvwUserAccount.SelectedItems(0).SubItems(2).Text

            .UserLevel = Me.lstvwUserAccount.SelectedItems(0).SubItems(3).Text
            .Username = Me.lstvwUserAccount.SelectedItems(0).SubItems(1).Text
            .Password = Me.lstvwUserAccount.SelectedItems(0).SubItems(2).Text

            .txtConfirmed.Text = .txtPassword.Text
            .Id = Me.lstvwUserAccount.SelectedItems(0).SubItems(0).Text
            .btnEnter.Text = "&Update"
            .ShowDialog()
        End With
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim StrSelect As String
        If MessageBox.Show("Are you sure you want to delete user " + Me.lstvwUserAccount.SelectedItems(0).SubItems(1).Text + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM tblUserAccount " & _
                 "WHERE Id = " + Me.lstvwUserAccount.SelectedItems(0).Text + ""

            CheckConnection(cn)

            Dim cmd As New OleDbCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()
            MsgBox(Me.lstvwUserAccount.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.", MsgBoxStyle.Information, "")

            'SystemLog
            SystemLog("Delete", Me.lstvwUserAccount.SelectedItems(0).SubItems(1).Text & " has been deleted.", frmRoomMonitoring.ToolStripStatuslblUsername.Text & " has been deleted.", frmRoomMonitoring.ToolStripStatuslblLevel.Text, "User Account Module")

            LoadUserAccountList()
        End If
    End Sub

    Private Sub CMS_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMS.Opening
        If Me.lstvwUserAccount.Items.Count > 0 And Me.lstvwUserAccount.SelectedItems.Count > 0 Then
            Me.EditToolStripMenuItem.Enabled = True
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.EditToolStripMenuItem.Enabled = False
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

End Class
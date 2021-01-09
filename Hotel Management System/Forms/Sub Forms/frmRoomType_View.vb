Imports System.Data.OleDb

Public Class frmRoomType_View

#Region "Functions"

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
                    .SubItems.Add(dr("Description"))
                End With
            Next
        End If
        cn.Close()
    End Sub

#End Region

#Region "Loading List"

    Friend Sub LoadList()
        FillData("SELECT * FROM tblRoomType ORDER BY Description ASC")
        listvwColorChange(Me.lstvw)
    End Sub

#End Region

    Private Sub CMS_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMS.Opening
        If Me.lstvw.SelectedItems.Count > 0 Then
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub frmRoomType_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadList()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmRoomType_Entry
            .ShowDialog()
        End With
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim StrSelect As String
        If MessageBox.Show("Are you sure you want to delete room type " + Me.lstvw.SelectedItems(0).SubItems(1).Text + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM tblRoomType " & _
                 "WHERE Id = " + Me.lstvw.SelectedItems(0).Text + ""

            CheckConnection(cn)

            Dim cmd As New OleDbCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()

            'SystemLog
            SystemLog("Delete", Me.lstvw.SelectedItems(0).SubItems(1).Text & "has been deleted.", frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Room type Module")

            MsgBox(Me.lstvw.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.", MsgBoxStyle.Information, "")
            LoadList()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadList()
    End Sub

End Class
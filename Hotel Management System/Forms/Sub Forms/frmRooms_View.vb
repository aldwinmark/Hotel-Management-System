Imports System.Data.OleDb

Public Class frmRooms_View

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
                    .SubItems.Add(dr("RoomNo"))
                    .SubItems.Add(dr("FloorNo"))
                    .SubItems.Add(dr("RoomType"))
                    .SubItems.Add(dr("SB"))
                    .SubItems.Add(dr("DB"))
                    .SubItems.Add(dr("ExtraBed"))
                    .SubItems.Add(dr("RoomDescription"))
                    .SubItems.Add(dr("Rate"))
                    .SubItems.Add(dr("RoomStatus"))
                End With
            Next
        End If
        cn.Close()
    End Sub

#End Region

#Region "Loading List"

    Friend Sub LoadList()
        FillData("SELECT * FROM tblRooms ORDER BY RoomNo ASC")
        listvwColorChange(Me.lstvw)
    End Sub

#End Region

    Private Sub CMS_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMS.Opening
        If Me.lstvw.SelectedItems.Count > 0 Then
            Me.EditToolStripMenuItem.Enabled = True
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.EditToolStripMenuItem.Enabled = False
            Me.DeleteToolStripMenuItem.Enabled = False
        End If

    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmRoom_Entry
            .LoadRoomType()
            .btnEnter.Text = "&Save"
            .cmbxRoomStatus.Text = "0"
            .cmbxRoomStatus.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub frmRooms_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadList()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim StrSelect As String
        If MessageBox.Show("Are you sure you want to delete room No." + Me.lstvw.SelectedItems(0).SubItems(1).Text + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM tblRooms " & _
                 "WHERE Id = " + Me.lstvw.SelectedItems(0).Text + ""

            CheckConnection(cn)

            Dim cmd As New OleDbCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()
            MsgBox("Room no." & Me.lstvw.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.", MsgBoxStyle.Information, "")
            SystemLog("Delete", "Room no." & Me.lstvw.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.", frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Rooms Module")
            LoadList()
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        With frmRoom_Entry
            .btnEnter.Text = "&Update"
            .LoadRoomType()
            .Id = Me.lstvw.SelectedItems(0).Text
            .GetRoomInfo()
            .ShowDialog()
        End With

    End Sub

End Class
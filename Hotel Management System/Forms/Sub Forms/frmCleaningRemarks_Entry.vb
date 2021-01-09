Imports System.Data.OleDb

Public Class frmCleaningRemarks_Entry

    Friend GenID As String

#Region "Filling Functions"

    Private Sub FillRooms(ByVal Sqlstring As String)
        Me.cmbxRoomNo.Items.Clear()
        CheckConnection(cn)
        oledbda.SelectCommand = New OleDbCommand(Sqlstring, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        ds.Clear()
        oledbda.Fill(ds)
        Me.cmbxRoomNo.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxRoomNo.Items.Add(dr("RoomNo"))
            Next
        End If
        Me.cmbxRoomNo.Text = "<select>"
    End Sub

#End Region

#Region "Loading Functions"

    Public Sub LoadRooms()
        FillRooms("SELECT RoomNo FROM tblRooms")
    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        If Me.cmbxRoomNo.Text = "<select>" Then
            MsgBox("Please select a room for the cleaning remarks.", MsgBoxStyle.Exclamation, "Required")
            Me.cmbxRoomNo.Focus()
        ElseIf Me.cmbxStatus.Text = "<select>" Then
            MsgBox("Please select a status for the cleaning remarks.", MsgBoxStyle.Exclamation, "Required")
            Me.cmbxStatus.Focus()
        ElseIf Me.cmbxChangeBeddings.Text = "<select>" Then
            MsgBox("Please select a change of beddings for the cleaning remarks.", MsgBoxStyle.Exclamation, "Required")
            Me.cmbxChangeBeddings.Focus()
        ElseIf Trim(Me.txtRemarks.Text).Length = 0 Then
            MsgBox("Please enter a remarks.", MsgBoxStyle.Exclamation, "Required")
            Me.txtRemarks.Focus()
        Else
            Dim strSelect As String

            If GenID = "" Then GenID = 0

            strSelect = "INSERT INTO tblRoomCleaning" & _
                                        "([RoomNo],[RoomStatus],[ChangeBeddings],[DatetimeCreated],[Remarks],[GenID],[DatetimeCleaned])VALUES " & _
                                        "('" & Me.cmbxRoomNo.Text & "','" & _
                                        "" & Me.cmbxStatus.Text & _
                                        "','" & Me.cmbxChangeBeddings.Text & _
                                        "','" & Date.Now & _
                                        "','" & CSQ(Me.txtRemarks.Text) & _
                                         "'," & GenID & _
                                        ", '" + "" + "')"

            CheckConnection(cn)
            Dim cmdSave As New OleDbCommand(strSelect, cn)
            cmdSave.ExecuteNonQuery()
            MsgBox("Remarks has been successfully saved.", MsgBoxStyle.Information, "Saved")

            'SystemLog
            SystemLog("Add", "Remark " & Me.txtRemarks.Text & " has been added.", frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Cleaning remarks Module")

            frmRoomMonitoring.LoadListRoomCleaning()
            Me.btnCancel_Click(sender, e)
        End If

    End Sub

End Class
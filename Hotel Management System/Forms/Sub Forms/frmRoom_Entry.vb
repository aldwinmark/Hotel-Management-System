Imports System.Data.OleDb

Public Class frmRoom_Entry

    Friend Id As Integer

    Dim RoomNo As String
    Dim Floor As String
    Dim RoomType As String
    Dim SB As String
    Dim DB As String
    Dim ExtraBed As String
    Dim RoomDescription As String
    Dim Rate As String
    Dim RoomStatus As String
    Dim Equipments As String

#Region "User Functions"

    Private Function CheckIfRoomExist(ByVal RoomNo As String) As Boolean

        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblRooms WHERE RoomNo='" & RoomNo & "'"
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            CheckIfRoomExist = True
        Else
            CheckIfRoomExist = False
        End If

        'close the reader
        Reader.Close()

        Return CheckIfRoomExist

    End Function

    Public Sub GetRoomInfo()

        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblRooms WHERE Id=" & Id & ""
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            Me.mtxtRoomNo.Text = Reader("RoomNo")
            Me.cmbxFloor.Text = Reader("FloorNo")
            Me.cmbxRoomType.Text = Reader("RoomType")
            Me.nudSB.Text = Reader("SB")
            Me.nudDB.Text = Reader("DB")
            Me.nudExtra.Text = Reader("ExtraBed")
            Me.txtDescription.Text = Reader("RoomDescription")
            Me.txtRate.Text = Reader("Rate")
            Me.cmbxRoomStatus.Text = Reader("RoomStatus")
            Me.txtRoomEquipement.Text = Reader("Equipments")

            RoomNo = Reader("RoomNo")
            Floor = Reader("FloorNo")
            RoomType = Reader("RoomType")
            SB = Reader("SB")
            DB = Reader("DB")
            ExtraBed = Reader("ExtraBed")
            RoomDescription = Reader("RoomDescription")
            Rate = Reader("Rate")
            RoomStatus = Reader("RoomStatus")
            Equipments = Reader("Equipments")

        End If

        'close the reader
        Reader.Close()

    End Sub

#End Region

#Region "Filling Functions"

    Private Sub FillRooms(ByVal Sqlstring As String)
        Me.cmbxRoomType.Items.Clear()
        CheckConnection(cn)
        oledbda.SelectCommand = New OleDbCommand(Sqlstring, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        ds.Clear()
        oledbda.Fill(ds)
        Me.cmbxRoomType.Items.Add("<select>")
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxRoomType.Items.Add(dr("Description"))
            Next
        End If
        Me.cmbxRoomType.Text = "<select>"
    End Sub

#End Region

#Region "Loading Functions"

    Public Sub LoadRoomType()
        FillRooms("SELECT * FROM tblRoomType")
    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        Dim strSelect As String

        If Me.mtxtRoomNo.TextLength = 0 Then
            MsgBox("Please enter a valid room no.", MsgBoxStyle.Exclamation, "Required")
            Me.mtxtRoomNo.Focus()
        ElseIf Me.cmbxFloor.Text = "" Then
            MsgBox("Please select floor for the room", MsgBoxStyle.Exclamation, "Required")
            Me.cmbxFloor.Focus()
        ElseIf Me.cmbxRoomType.Text = "<select>" Then
            MsgBox("Please select a valid room type.", MsgBoxStyle.Exclamation, "Required")
            Me.cmbxRoomType.Focus()
        ElseIf Trim(Me.txtDescription.Text).Length <= 0 Then
            MsgBox("Please enter a description for the room.", MsgBoxStyle.Exclamation, "Required")
            Me.txtDescription.Focus()
        ElseIf Me.cmbxRoomStatus.Text = "" Then
            MsgBox("Please select a status for the room.", MsgBoxStyle.Exclamation, "Required")
            Me.cmbxRoomStatus.Focus()
        ElseIf IsNumeric(Me.txtRate.Text) = False Then
            MsgBox("Please enter a valid room rate.", MsgBoxStyle.Exclamation, "Required")
            Me.txtRate.Focus()
        Else
            If Me.btnEnter.Text = "&Save" Then
                If CheckIfRoomExist(Me.mtxtRoomNo.Text) = True Then
                    MsgBox("Room no. already exist, please enter a different room no.", MsgBoxStyle.Exclamation, "Required")
                    Me.mtxtRoomNo.Focus()
                Else
                    strSelect = "INSERT INTO tblRooms" & _
                                    "([RoomNo],[FloorNo],[RoomType],[SB],[DB],[ExtraBed],[RoomDescription],[Rate],[RoomStatus],[GenID],[Equipments])VALUES " + _
                                    "('" & Me.mtxtRoomNo.Text & "','" & _
                                    "" & Me.cmbxFloor.Text & "','" & _
                                    "" & CSQ(Me.cmbxRoomType.Text) & "','" & _
                                    "" & Me.nudSB.Value.ToString & "','" & _
                                    "" & Me.nudDB.Value.ToString & "','" & _
                                    "" & Me.nudExtra.Value.ToString & "','" & _
                                    "" & CSQ(Me.txtDescription.Text) & "','" & _
                                    "" & (Me.txtRate.Text) & "','" & _
                                    "" & CSQ(Me.cmbxRoomStatus.Text) & "'," & _
                                    "" & 0 & _
                                    ", '" & Me.txtRoomEquipement.Text & "')"

                    CheckConnection(cn)
                    Dim cmdSave As New OleDbCommand(strSelect, cn)
                    cmdSave.ExecuteNonQuery()
                    MsgBox("Room no." & Me.mtxtRoomNo.Text & " has been successfully saved.", MsgBoxStyle.Information, "Saved")
                    SystemLog("Add", Me.mtxtRoomNo.Text & " has been added.", frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Rooms Module")
                End If
            Else
                strSelect = "UPDATE tblRooms SET" & _
                    "[RoomNo]='" & Me.mtxtRoomNo.Text & _
                    "',[FloorNo]='" & Me.cmbxFloor.Text & _
                    "',[RoomType]='" & Me.cmbxRoomType.Text & _
                    "',[SB]='" & Me.nudSB.Value & _
                    "',[DB]='" & Me.nudDB.Text & _
                    "',[ExtraBed]='" & Me.nudExtra.Text & _
                    "',[RoomDescription]='" & Me.txtDescription.Text & _
                    "',[Rate]='" & Me.txtRate.Text & _
                    "',[RoomStatus]='" & Me.cmbxRoomStatus.Text & _
                    "',[Equipments]='" & Me.txtRoomEquipement.Text & _
                    "'WHERE Id=" & Id & ""

                CheckConnection(cn)

                Dim cmd As New OleDbCommand(strSelect, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Room no." & Me.mtxtRoomNo.Text & " has been successfully updated.", MsgBoxStyle.Information, "Updated")

                'SystemLog
                Dim str As String = ""
                If RoomNo <> mtxtRoomNo.Text Then
                    str = str & "Room no(" & RoomNo & ">" & Me.mtxtRoomNo.Text & ")"
                End If
                If Floor <> Me.cmbxFloor.Text Then
                    str = str & "Floor(" & Floor & ">" & Me.cmbxFloor.Text & ")"
                End If
                If RoomType <> Me.cmbxRoomType.Text Then
                    str = str & "Room Type(" & RoomType & ">" & Me.cmbxRoomType.Text & ")"
                End If
                If SB <> Me.nudSB.Text Then
                    str = str & "SB(" & SB & ">" & Me.nudSB.Text & ")"
                End If
                If DB <> Me.nudDB.Text Then
                    str = str & "DB(" & DB & ">" & Me.nudDB.Text & ")"
                End If
                If ExtraBed <> Me.nudExtra.Text Then
                    str = str & "Extra Bed(" & ExtraBed & ">" & Me.nudExtra.Text & ")"
                End If
                If RoomDescription <> Me.txtDescription.Text Then
                    str = str & "Description(" & RoomDescription & ">" & Me.txtDescription.Text & ")"
                End If
                If Rate <> Me.txtRate.Text Then
                    str = str & "Rate(" & Rate & ">" & Me.txtRate.Text & ")"
                End If
                If RoomStatus <> Me.cmbxRoomStatus.Text Then
                    str = str & "Status(" & RoomStatus & ">" & Me.cmbxRoomStatus.Text & ")"
                End If
                If Equipments <> Me.txtRoomEquipement.Text Then
                    str = str & "Equipments(" & Equipments & ">" & Me.txtRoomEquipement.Text & ")"
                End If
                If str <> "" Then
                    SystemLog("Edit", "changes in " & str, frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Rooms Module")
                End If
            End If
            frmRooms_View.LoadList()
            Me.btnCancel_Click(sender, e)
        End If
    End Sub

    Private Sub txtRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRate.TextChanged
        If Trim(Me.txtRate.Text).Length = 0 Then
            Me.txtRate.Text = "0.00"
        End If
    End Sub

End Class
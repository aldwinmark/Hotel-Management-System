Imports System.IO
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmRoomMonitoring

    Dim RoomStatus As String
    Dim LimgLst As New ImageList

#Region "User Functions"

    Private Function getCustomerData_FullName(ByVal ID As Integer) As String

        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblCustomer WHERE Id=" & ID & ""
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            getCustomerData_FullName = Reader("FullName")
        Else
            getCustomerData_FullName = ""
        End If

        'close the reader
        Reader.Close()

        Return getCustomerData_FullName

    End Function

    Private Function CheckReservedRoom(ByVal RoomNo As String, ByVal SDate As Date) As Boolean

        Dim StrSelect As String
        CheckConnection(cn)

        'StrSelect = "SELECT * FROM tblLogBook WHERE RoomNo='" & Me.cmbxRoomNo.Text & "' AND (Check_IN BETWEEN #" & CDate(Me.dtpCheckIn.Value.ToShortDateString & " " & GetCheckTime("In")) & "# AND #" & CDate(Me.dtpCheckOut.Value.ToShortDateString & " " & GetCheckTime("Out")) & "#) OR (Check_OUT BETWEEN #" & CDate(Me.dtpCheckIn.Value.ToShortDateString & " " & GetCheckTime("In")) & "# AND #" & CDate(Me.dtpCheckIn.Value.ToShortDateString & " " & GetCheckTime("Out")) & "#) "
        StrSelect = "SELECT * FROM tblLogBook WHERE RoomNo='" & RoomNo & "' AND ReservationStatus='Reserved' AND Check_IN = #" & CDate(SDate.ToShortDateString & " " & GetCheckTime("In")) & "#"

        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()

        If Reader.HasRows = True Then
            CheckReservedRoom = True
        Else
            CheckReservedRoom = False
        End If

        'close the reader
        Reader.Close()

        Return CheckReservedRoom

    End Function

    Private Sub DeleteLogOthers(ByVal GenId As String)

        Dim StrSelect As String

        StrSelect = "DELETE FROM tblLogOthers " & _
                 "WHERE GenID = '" + GenId + "'"

        CheckConnection(cn)
        Dim cmd As New OleDbCommand(StrSelect, cn)
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub DeleteLogCustomer(ByVal GenId As String)

        Dim StrSelect As String

        StrSelect = "DELETE FROM tblLogCustomer " & _
                 "WHERE GenID = '" + GenId + "'"

        CheckConnection(cn)
        Dim cmd As New OleDbCommand(StrSelect, cn)
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub GetRoomInfo(ByVal RoomNo As String)

        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblRooms WHERE RoomNo='" & RoomNo & "'"
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            Me.lblDescription.Text = Reader("RoomDescription")
            Me.lblRate.Text = Reader("Rate")
            Me.lblFloor.Text = Reader("FloorNo")
            Me.lblEquipments.Text = Reader("Equipments")
            Me.lblSB.Text = Reader("SB")
            Me.lblDB.Text = Reader("DB")
            Me.lblExtraBed.Text = Reader("ExtraBed")
            Me.lblRoomType.Text = Reader("RoomType")
        End If

        'close the reader
        Reader.Close()

    End Sub

    Private Sub GetReservationInfo(ByVal GenID As Integer)

        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblLogBook WHERE GenID=" & GenID & ""
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            Me.lblCheckIn.Text = Reader("Check_IN")
            Me.lblCheckOut.Text = Reader("Check_OUT")
            Me.lblNights.Text = Reader("Nights")
            RoomStatus = Reader("ReservationStatus")
        Else
            RoomStatus = ""
        End If

        'close the reader
        Reader.Close()

    End Sub

    Function LoadImagesToImageList(ByVal imgs() As String) As ImageList

        'Bitmap
        Dim pimg As Bitmap

        Dim image As String
        Dim num As Integer
        num = LimgLst.Images.Count
        For Each image In imgs

            'Try
            pimg = New Bitmap(image)
            LimgLst.Images.Add(pimg)
            'lstvwImage.Items.Add("", 1)
            'Catch ex As Exception
            'MsgBox(ex.Message)
            'LimgLst.Images.Clear()
            'End Try
        Next

        Return LimgLst

    End Function

    Private Sub LoadRoomImage()

        Me.lstvwImage.Items.Clear()

        Dim thmbNailWidth As Integer
        Dim thmbNailHeight As Integer

        Dim IMAGE_DIRECTORY As String = Application.StartupPath & "\Room Images"
        Dim files As String() = Directory.GetFiles(IMAGE_DIRECTORY)
        Dim fname As String = ""
        Dim pth As String = ""
        Dim f() As String

        For Each pth In files 'op.filenames

            f = Split(pth, "\") 'to get the file name
            'Array.Reverse(f)

        Next

        'Default size
        thmbNailWidth = 60
        thmbNailHeight = 60
        LimgLst.ImageSize = New Size(thmbNailWidth, thmbNailHeight)

        LimgLst.ColorDepth = ColorDepth.Depth32Bit

        Me.lstvwImage.LargeImageList = LoadImagesToImageList(files)

    End Sub

#End Region

#Region "Filling Functions"

    Private Sub FillCustomerData(ByVal SqlString As String)
        Me.lstbxCustomer.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Me.lstbxCustomer.Items.Add(getCustomerData_FullName(dr("CustomerID")))
            Next
        End If
        cn.Close()

    End Sub

    Private Sub FillDataRoomCleaning(ByVal SqlString As String)
        Me.lstvwRoomCleaning.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        'Me.lblTotalRecord.Text = FormatNumber(ds.Tables(0).Rows.Count, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                Dim MyItem = Me.lstvwRoomCleaning.Items.Add(dr("ID"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("RoomNo"))
                    .SubItems.Add(dr("RoomStatus"))
                    .SubItems.Add(dr("ChangeBeddings"))
                End With
            Next
        End If
        cn.Close()

        listvwColorChange(Me.lstvwRoomCleaning)

    End Sub

    Private Sub FillDataRoomAlarm(ByVal SqlString As String)
        Me.lstvwRoomAlarm.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        'Me.lblTotalRecord.Text = FormatNumber(ds.Tables(0).Rows.Count, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                Dim MyItem = Me.lstvwRoomAlarm.Items.Add(dr("RoomNo"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Check_OUT"))
                    '.SubItems.Add(dr("RemTime"))
                    '.SubItems.Add(dr("Remarks"))
                End With
            Next
        End If
        cn.Close()

        listvwColorChange(Me.lstvwRoomAlarm)

    End Sub

    Private Sub FillDataReminders(ByVal SqlString As String)
        Me.lstvwReminders.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        'Me.lblTotalRecord.Text = FormatNumber(ds.Tables(0).Rows.Count, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                Dim MyItem = Me.lstvwReminders.Items.Add(dr("Id"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("RemDate"))
                    .SubItems.Add(dr("RemTime"))
                    .SubItems.Add(dr("Remarks"))
                End With
            Next
        End If
        cn.Close()

        listvwColorChange(Me.lstvwReminders)

    End Sub

    Private Sub FillDataReservation(ByVal SqlString As String)
        Me.lstvwReservation.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        'Me.lblTotalRecord.Text = FormatNumber(ds.Tables(0).Rows.Count, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                Dim MyItem = Me.lstvwReservation.Items.Add(dr("GenID"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("RoomNo"))

                    .SubItems.Add(dr("Check_IN"))
                    .SubItems.Add(dr("Check_OUT"))

                    .SubItems.Add(dr("CustomerName"))
                    .SubItems.Add(dr("Floor"))
                    .SubItems.Add(FormatNumber(dr("Rate")))
                    .SubItems.Add(dr("Description"))
                    .SubItems.Add(dr("Nights"))
                    .SubItems.Add(FormatNumber(dr("AmountPaid")))
                    .SubItems.Add(FormatNumber(dr("AdvancePayment")))
                    .SubItems.Add(FormatNumber(dr("LocalTax")))
                    .SubItems.Add(dr("PaymentType"))
                    .SubItems.Add(dr("Check_IN"))
                    .SubItems.Add(dr("Check_OUT"))
                    .SubItems.Add(dr("ReservationStatus"))
                End With
            Next
        End If
        cn.Close()

        listvwColorChange(Me.lstvwReservation)

    End Sub

    Private Sub FillData(ByVal SqlString As String)
        Dim Occupied As Integer = 0
        Dim Vacant As Integer = 0
        Dim Reserved As Integer = 0

        Dim ImageStatus As Integer
        Me.lstvwImage.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                If CheckReservedRoom(dr("RoomNo"), Date.Now) = True And dr("RoomStatus") = 0 Then
                    ImageStatus = 2 'Reserved
                    Reserved += 1
                Else
                    If dr("RoomStatus") = 0 Then
                        ImageStatus = 1 'vacant
                        Vacant += 1
                    ElseIf dr("RoomStatus") = 1 Then
                        ImageStatus = 0 'occupied
                        Occupied += 1
                    End If
                End If

                'If CheckReservedRoom(dr("RoomNo"), Date.Now) = True Then
                '    ImageStatus = 2 'Reserved
                'Else
                '    If dr("RoomStatus") = 0 Then
                '        ImageStatus = 1 'vacant
                '    ElseIf dr("RoomStatus") = 1 Then
                '        ImageStatus = 0 'occupied
                '    End If
                'End If

                Dim MyItem = Me.lstvwImage.Items.Add(dr("RoomNo"), ImageStatus)
                MyItem.Tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("RoomNo"))
                    If IsDBNull(dr("GenID")) = True Or Trim(dr("GenID")).Length = 0 Then
                        .SubItems.Add("")
                    Else
                        .SubItems.Add(dr("GenID"))
                    End If
                    .SubItems.Add(dr("RoomStatus"))
                End With
            Next
        End If
        cn.Close()
        Me.OccupiedToolStripStatusLabel.Text = Occupied
        Me.VacantToolStripStatusLabel.Text = Vacant
        Me.ReservedToolStripStatusLabel.Text = Reserved
    End Sub

#End Region

#Region "Loading List"

    Friend Sub LoadCustomerList(ByVal GenID As String)
        FillCustomerData("SELECT * FROM tblLogCustomer WHERE GenID='" & GenID & "'")
    End Sub

    Friend Sub LoadListRoomCleaning()
        FillDataRoomCleaning("SELECT * FROM tblRoomCleaning WHERE DatetimeCleaned='' ORDER BY RoomNo ASC")
    End Sub

    Friend Sub LoadListRoomAlarm()
        FillDataRoomAlarm("SELECT RoomNo,Check_OUT,ReservationStatus FROM tblLogBook WHERE Check_OUT <#" & Date.Now & "# AND ReservationStatus='Occupied'")
    End Sub

    Friend Sub LoadListReminder()
        FillDataReminders("SELECT * FROM tblReminders WHERE RemDate='" & Me.dtpDateRem.Value.ToShortDateString & "' ORDER BY RemDate ASC")
    End Sub

    Friend Sub LoadListReservation()
        'FillDataReservation("SELECT * FROM tblLogBook WHERE ReservationStatus='Reserved' ORDER BY Check_IN ASC")
        'FillDataReservation("SELECT * FROM tblLogBook WHERE ReservationStatus='" & Me.cmbxReservationStatus.Text & "' ORDER BY Check_IN ASC")
        Dim strCheckStatus As String
        Dim strStatus As String
        Dim strfield As String

        If Me.cmbxSearchField.Text = "ControlNo" Then
            strfield = "GenID"
        Else
            strfield = Me.cmbxSearchField.Text
        End If

        If Me.cmbxCheckStatus.Text = "Check-In" Then
            strCheckStatus = "Check_IN"
            strStatus = "In"
        Else
            strCheckStatus = "Check_OUT"
            strStatus = "Out"
        End If

        If Me.cmbxCheckStatus.Text = "All" And Me.cmbxReservationStatus.Text = "All" Then
            FillDataReservation("SELECT * FROM tblLogBook WHERE " & strfield & " LIKE '" & Me.txtSearch.Text & "%' ORDER BY Check_IN DESC")
        ElseIf Me.cmbxCheckStatus.Text <> "All" And Me.cmbxReservationStatus.Text = "All" Then
            FillDataReservation("SELECT * FROM tblLogBook WHERE " & strfield & " LIKE '" & Me.txtSearch.Text & "%' AND " & strCheckStatus & " = #" & Me.dtpDateSearch.Value.ToShortDateString & " " & GetCheckTime(strStatus) & "# ORDER BY Check_IN DESC")
        ElseIf Me.cmbxCheckStatus.Text = "All" And Me.cmbxReservationStatus.Text <> "All" Then
            FillDataReservation("SELECT * FROM tblLogBook WHERE " & strfield & " LIKE '" & Me.txtSearch.Text & "%' AND ReservationStatus='" & Me.cmbxReservationStatus.Text & "' ORDER BY Check_IN DESC")
        ElseIf Me.cmbxCheckStatus.Text <> "All" And Me.cmbxReservationStatus.Text <> "All" Then
            FillDataReservation("SELECT * FROM tblLogBook WHERE " & strfield & " LIKE '" & Me.txtSearch.Text & "%' AND " & strCheckStatus & " = #" & Me.dtpDateSearch.Value.ToShortDateString & " " & GetCheckTime(strStatus) & "# AND ReservationStatus='" & Me.cmbxReservationStatus.Text & "' ORDER BY Check_IN DESC")
        ElseIf Me.cmbxCheckStatus.Text <> "All" And Me.cmbxReservationStatus.Text <> "All" Then
            FillDataReservation("SELECT * FROM tblLogBook WHERE " & strfield & " LIKE '" & Me.txtSearch.Text & "%'  AND " & strCheckStatus & " = #" & Me.dtpDateSearch.Value.ToShortDateString & " " & GetCheckTime(strStatus) & "# AND ReservationStatus='" & Me.cmbxReservationStatus.Text & "' ORDER BY Check_IN DESC")
        End If

    End Sub

    Friend Sub LoadList()
        FillData("SELECT RoomNo,RoomStatus,GenID FROM tblRooms ORDER BY RoomNo ASC")
    End Sub

#End Region

    Private Sub fmRoomMonitoring_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmLogin.ShowDialog()
        Me.ToolStripStatuslblDate.Text = Date.Now
        LoadListRoomCleaning()
        LoadListRoomAlarm()
        LoadListReminder()
        Me.cmbxCheckStatus.Text = "Check-In"
        Me.cmbxReservationStatus.Text = "All"
        Me.cmbxSearchField.Text = "ControlNo"
        LoadRoomImage()
        LoadList()
        LoadListReservation()
    End Sub

    Private Sub CMS_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMS.Opening
        '0=vacant,1=Occupied
        If Me.lstvwImage.SelectedItems.Count > 0 Then
            Me.DeleteToolStripMenuItem.Enabled = True

            If Me.lstvwImage.SelectedItems(0).SubItems(3).Text = "0" Then
                Me.OccupyToolStripMenuItem.Enabled = True
                Me.CheckOutToolStripMenuItem.Enabled = False
                Me.EditToolStripMenuItem.Enabled = False
            Else
                Me.EditToolStripMenuItem.Enabled = True
                Me.CheckOutToolStripMenuItem.Enabled = True
                Me.OccupyToolStripMenuItem.Enabled = False
            End If

            If Not Me.lstvwImage.SelectedItems(0).SubItems(3).Text = "0" Then
                DeleteToolStripMenuItem.Enabled = True
            Else
                DeleteToolStripMenuItem.Enabled = False
            End If

        Else
            Me.CheckOutToolStripMenuItem.Enabled = False
            Me.OccupyToolStripMenuItem.Enabled = False
            Me.EditToolStripMenuItem.Enabled = False
            Me.DeleteToolStripMenuItem.Enabled = False
        End If

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadList()
    End Sub

    Private Sub OccupyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OccupyToolStripMenuItem.Click
        With frmLogBook_Entry
            .LoadPaymentType()
            .cmbxPaymentType.Text = "<select>"
            .cmbxReservationStatus.Text = "Occupied"
            .LoadRooms()
            .cmbxRoomNo.Text = Me.lstvwImage.SelectedItems(0).Text
            .cmbxRoomNo.Enabled = False
            .cmbxReservationStatus.Enabled = False
            .btnInvoice.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub lstvwImage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstvwImage.Click
        'If Me.lstvwImage.SelectedItems(0).SubItems(2).Text > 0 Then
        GetReservationInfo(Me.lstvwImage.SelectedItems(0).SubItems(2).Text)
        GetRoomInfo(Me.lstvwImage.SelectedItems(0).SubItems(0).Text)
        LoadCustomerList(Me.lstvwImage.SelectedItems(0).SubItems(2).Text)
        'Else
        'Me.lblRate.Text = ""
        'Me.lblFloor.Text = ""
        'Me.lblEquipments.Text = ""
        'Me.lblSB.Text = ""
        'Me.lblDB.Text = ""
        'Me.lblExtraBed.Text = ""
        'Me.lblCheckIn.Text = ""
        'Me.lblCheckOut.Text = ""
        'Me.lblNights.Text = ""
        'Me.lblDescription.Text = ""
        'End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click

        Dim strcode As String

        'insert todo codes
        If Me.ToolStripStatuslblLevel.Text = 2 Then

            strcode = InputBox("Please enter your code", "Deletion code")

            CheckConnection(cn)
            Dim StrSelectChecking = "SELECT * FROM tblUserAccount WHERE Username='" & CSQ(strcode) & "' AND UserLevel=4"
            Dim cmdCheck As New OleDbCommand(StrSelectChecking, cn)
            Dim Reader As OleDbDataReader = cmdCheck.ExecuteReader
            Reader.Read()
            If Reader.HasRows = True Then
                Dim StrSelect As String = ""
                If MessageBox.Show("Are you sure you want to delete reservation to this room?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    StrSelect = "DELETE FROM tblLogBook " & _
                         "WHERE GenID = " + Me.lstvwImage.SelectedItems(0).SubItems(2).Text + ""

                    CheckConnection(cn)

                    Dim cmd As New OleDbCommand(StrSelect, cn)

                    cmd.ExecuteNonQuery()

                    'delete log customer
                    DeleteLogCustomer(Me.lstvwImage.SelectedItems(0).SubItems(2).Text)
                    'delete log others
                    DeleteLogOthers(Me.lstvwImage.SelectedItems(0).SubItems(2).Text)

                    MsgBox("Reservation of Room " & Me.lstvwImage.SelectedItems(0).SubItems(1).Text & " has been successfully cancelled.", MsgBoxStyle.Information, "")
                    frmLogBook_Entry.SetRoomStatus(0, Me.lstvwImage.SelectedItems(0).SubItems(0).Text, 0)
                    'SystemLog
                    SystemLog("Cancelled", Me.lstvwImage.SelectedItems(0).SubItems(0).Text & " has been deleted.", Me.ToolStripStatuslblUsername.Text & " has been deleted.", Me.ToolStripStatuslblLevel.Text, "Log-Book Module")
                    LoadList()
                    LoadListReservation()
                End If
            Else
                MessageBox.Show("sorry you don't have access to delete the record", "Invalid")
            End If
        Else
            Dim StrSelect As String = ""
            If MessageBox.Show("Are you sure you want to delete reservation to this room?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                StrSelect = "DELETE FROM tblLogBook " & _
                     "WHERE GenID = " + Me.lstvwImage.SelectedItems(0).SubItems(2).Text + ""

                CheckConnection(cn)

                Dim cmd As New OleDbCommand(StrSelect, cn)

                cmd.ExecuteNonQuery()

                'delete log customer
                DeleteLogCustomer(Me.lstvwImage.SelectedItems(0).SubItems(2).Text)
                'delete log others
                DeleteLogOthers(Me.lstvwImage.SelectedItems(0).SubItems(2).Text)

                MsgBox("Reservation of Room " & Me.lstvwImage.SelectedItems(0).SubItems(1).Text & " has been successfully cancelled.", MsgBoxStyle.Information, "")
                frmLogBook_Entry.SetRoomStatus(0, Me.lstvwImage.SelectedItems(0).SubItems(0).Text, 0)
                'SystemLog
                SystemLog("Cancelled", Me.lstvwImage.SelectedItems(0).SubItems(0).Text & " has been deleted.", Me.ToolStripStatuslblUsername.Text & " has been deleted.", Me.ToolStripStatuslblLevel.Text, "Log-Book Module")
                LoadList()
                LoadListReservation()
            End If
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        With frmLogBook_Entry
            .GenID = Me.lstvwImage.SelectedItems(0).SubItems(2).Text
            .LoadAdvances()
            .LoadOthersList()
            .LoadCustomerList()
            .LoadPaymentType()
            .LoadRooms()
            .btnEnter.Text = "&Update"
            .cmbxReservationStatus.Enabled = False
            .cmbxRoomNo.Enabled = False
            .grpbxOthers.Enabled = True
            .GetReservationData()
            .ShowDialog()
        End With
    End Sub

    Private Sub CMSReservation_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMSReservation.Opening
        If Me.lstvwReservation.SelectedItems.Count > 0 Then
            Me.EditResToolStripMenuItem.Enabled = True
            Me.DeleteResToolStripMenuItem.Enabled = True
            Me.ViewLogToolStripMenuItem.Enabled = True
            'for reserved only
            If Me.lstvwReservation.SelectedItems(0).SubItems(15).Text = "Reserved" Then
                Me.EditResToolStripMenuItem.Visible = True
                Me.DeleteResToolStripMenuItem.Visible = True
            Else
                Me.EditResToolStripMenuItem.Visible = False
                Me.DeleteResToolStripMenuItem.Visible = False
            End If

        Else
            Me.EditResToolStripMenuItem.Enabled = False
            Me.DeleteResToolStripMenuItem.Enabled = False
            Me.ViewLogToolStripMenuItem.Enabled = False
        End If

    End Sub

    Private Sub AddResToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddResToolStripMenuItem.Click
        With frmLogBook_Entry
            .LoadPaymentType()
            .cmbxPaymentType.Text = "<select>"
            .cmbxReservationStatus.Text = "Reserved"
            .LoadRooms()
            '.cmbxRoomNo.Text = Me.lstvwImage.SelectedItems(0).Text
            '.cmbxRoomNo.Enabled = False
            .cmbxReservationStatus.Enabled = False
            .btnOccupy.Visible = False
            .btnInvoice.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub RefreshResToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshResToolStripMenuItem.Click
        LoadListReservation()
    End Sub

    Private Sub btnSearchReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchReservation.Click
        LoadListReservation()
    End Sub

    Private Sub CMSReminders_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMSReminders.Opening
        If Me.lstvwReminders.SelectedItems.Count > 0 Then
            Me.EditRemToolStripMenuItem.Enabled = True
            Me.DelRemToolStripMenuItem.Enabled = True
        Else
            Me.EditRemToolStripMenuItem.Enabled = False
            Me.DelRemToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub AddRemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRemToolStripMenuItem.Click
        With frmReminder_Entry
            .btnEnter.Text = "&Save"
            .ShowDialog()
        End With
    End Sub

    Private Sub tmReminder_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmReminder.Tick

        Dim x As Integer

        For x = 0 To Me.lstvwReminders.Items.Count - 1
            'MsgBox(Me.lstvwReminders.Items(x).SubItems(1).Text & " " & Now.Date.ToShortDateString & " " & Me.lstvwReminders.Items(x).SubItems(2).Text & " " & Now.ToString("HH:mm:ss tt"))
            If Me.lstvwReminders.Items(x).SubItems(1).Text = Now.Date.ToShortDateString And Me.lstvwReminders.Items(x).SubItems(2).Text = Now.ToString("HH:mm:ss tt") Then
                My.Computer.Audio.Play(Application.StartupPath & "\\DTR.wav", AudioPlayMode.Background)
                MessageBox.Show(Me.lstvwReminders.Items(x).SubItems(3).Text)
            End If
        Next

    End Sub

    Private Sub DelRemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelRemToolStripMenuItem.Click
        Dim StrSelect As String
        If MessageBox.Show("Are you sure you want to delete reminder?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM tblReminders " & _
                 "WHERE Id = " + Me.lstvwReminders.SelectedItems(0).SubItems(0).Text + ""

            CheckConnection(cn)

            Dim cmd As New OleDbCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()

            'SystemLog
            SystemLog("Delete", "Reminder " & Me.lstvwReminders.SelectedItems(0).SubItems(3).Text & " has been deleted.", Me.ToolStripStatuslblUsername.Text, Me.ToolStripStatuslblLevel.Text, "Reminder Module")

            MsgBox("Reminder has been successfully cancelled.", MsgBoxStyle.Information, "")
            LoadListReminder()
        End If
    End Sub

    Private Sub dtpDateRem_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateRem.ValueChanged
        LoadListReminder()
    End Sub

    Private Sub EditRemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditRemToolStripMenuItem.Click
        With frmReminder_Entry
            .Id = Me.lstvwReminders.SelectedItems(0).Text
            .dtpDate.Value = Me.lstvwReminders.SelectedItems(0).SubItems(1).Text
            .dtpTime.Text = Me.lstvwReminders.SelectedItems(0).SubItems(2).Text
            .txtRemarks.Text = Me.lstvwReminders.SelectedItems(0).SubItems(3).Text

            .strDate = Me.lstvwReminders.SelectedItems(0).SubItems(1).Text
            .strTime = Me.lstvwReminders.SelectedItems(0).SubItems(2).Text
            .Remarks = Me.lstvwReminders.SelectedItems(0).SubItems(3).Text

            .ShowDialog()
        End With
    End Sub

    Private Sub tmRoomAlarm_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmRoomAlarm.Tick
        LoadListRoomAlarm()
    End Sub

    Private Sub CheckOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckOutToolStripMenuItem.Click
        With frmLogBook_Entry
            .GenID = Me.lstvwImage.SelectedItems(0).SubItems(2).Text
            .LoadAdvances()
            .LoadOthersList()
            .LoadCustomerList()
            .LoadPaymentType()
            .LoadRooms()
            .btnEnter.Text = "&Check-Out"
            .GetReservationData()
            .cmbxRoomNo.Enabled = False
            .grpbxReservation.Enabled = False
            .grpbxCustomer.Enabled = False
            .grpbxOthers.Enabled = False
            .cmbxReservationStatus.Enabled = False
            .ComputeTotal()
            .ShowDialog()
        End With
    End Sub

    Private Sub CMSRoomCleaning_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMSRoomCleaning.Opening
        If Me.lstvwRoomCleaning.SelectedItems.Count > 0 Then
            ClearTaskToolStripMenuItem.Enabled = True
            DelTaskToolStripMenuItem.Enabled = True
        Else
            ClearTaskToolStripMenuItem.Enabled = False
            DelTaskToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub RefreshTaskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshTaskToolStripMenuItem.Click
        LoadListRoomCleaning()
    End Sub

    Private Sub DelTaskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelTaskToolStripMenuItem.Click

        Dim StrSelect As String
        If MessageBox.Show("Are you sure you want to delete task?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM tblRoomCleaning " & _
                 "WHERE Id = " + Me.lstvwRoomCleaning.SelectedItems(0).SubItems(0).Text + ""

            CheckConnection(cn)

            Dim cmd As New OleDbCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()

            'SystemLog
            SystemLog("Delete", "Task from " & Me.lstvwRoomCleaning.SelectedItems(0).SubItems(1).Text & " has been deleted.", Me.ToolStripStatuslblUsername.Text, Me.ToolStripStatuslblLevel.Text, "Task Module")

            MsgBox("Task has been successfully cancelled.", MsgBoxStyle.Information, "")
            LoadListRoomCleaning()
        End If

    End Sub

    Private Sub ClearTaskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearTaskToolStripMenuItem.Click
        Dim StrSelect As String
        If MessageBox.Show("Are you sure you want to clear this task?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "UPDATE tblRoomCleaning SET [DatetimeCleaned]='" & Date.Now & "',[RoomStatus]='Cleaned',[ChangeBeddings]='Done' WHERE ID=" & Me.lstvwRoomCleaning.SelectedItems(0).Text & ""

            CheckConnection(cn)

            Dim cmd As New OleDbCommand(StrSelect, cn)
            cmd.ExecuteNonQuery()

            'SystemLog
            SystemLog("Add", "Task from " & Me.lstvwRoomCleaning.SelectedItems(0).SubItems(1).Text & " has been cleared.", Me.ToolStripStatuslblUsername.Text, Me.ToolStripStatuslblLevel.Text, "Task Module")

            MsgBox("Task has been successfully done.", MsgBoxStyle.Information, "Done Task")
            LoadListRoomCleaning()
        End If
    End Sub

    Private Sub LogBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogBookToolStripMenuItem.Click
        frmLogBook.ShowDialog()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        frmCustomer_View.ShowDialog()
    End Sub

    Private Sub UserAccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccountsToolStripMenuItem.Click
        frmUserAccount_View.Show()
    End Sub

    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click
        'Dim frm As New frmRooms_View
        'frm.MdiParent = Me
        'frm.Show()
        frmRooms_View.ShowDialog()
    End Sub

    Private Sub RoomTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomTypeToolStripMenuItem.Click
        'Dim frm As New frmRoomType_View
        'frm.MdiParent = Me
        'frm.Show()
        frmRoomType_View.ShowDialog()
    End Sub

    Private Sub PaymentTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentTypeToolStripMenuItem.Click
        frmPaymentType_View.ShowDialog()
    End Sub

    Private Sub ChangeCheckingTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeCheckingTimeToolStripMenuItem.Click
        frmCheckTime.ShowDialog()
    End Sub

    Private Sub tmNow_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmNow.Tick
        Me.ToolStripStatuslblDate.Text = Date.Now
    End Sub

    Private Sub EditResToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditResToolStripMenuItem.Click
        With frmLogBook_Entry
            .GenID = Me.lstvwReservation.SelectedItems(0).SubItems(0).Text
            .LoadAdvances()
            .LoadOthersList()
            .LoadCustomerList()
            .LoadPaymentType()
            .LoadRooms()
            .btnEnter.Text = "&Update"
            .GetReservationData()
            .cmbxReservationStatus.Enabled = False
            .cmbxRoomNo.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub DeleteResToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteResToolStripMenuItem.Click

        Dim StrSelect As String
        If MessageBox.Show("Are you sure you want to delete this reservation?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM tblLogBook " & _
                 "WHERE GenID = " + Me.lstvwReservation.SelectedItems(0).SubItems(0).Text + ""

            CheckConnection(cn)

            Dim cmd As New OleDbCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()

            'delete log customer
            DeleteLogCustomer(Me.lstvwReservation.SelectedItems(0).SubItems(0).Text)
            'delete log others
            DeleteLogOthers(Me.lstvwReservation.SelectedItems(0).SubItems(0).Text)

            'SystemLog
            SystemLog("Delete", "Reservation of Room " & Me.lstvwReservation.SelectedItems(0).SubItems(1).Text & " has been deleted.", Me.ToolStripStatuslblUsername.Text, Me.ToolStripStatuslblLevel.Text, "Log-Book(Reservation) Module")

            MsgBox("Reservation of Room " & Me.lstvwReservation.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.", MsgBoxStyle.Information, "")
            LoadList()
            LoadListReservation()
        End If
    End Sub

    Private Sub AddTaskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTaskToolStripMenuItem.Click
        With frmCleaningRemarks_Entry
            .LoadRooms()
            .cmbxChangeBeddings.Text = "Yes"
            .cmbxStatus.Text = "Needs Cleaning"
            .ShowDialog()
        End With

    End Sub

    Private Sub RoomsLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomsLogToolStripMenuItem.Click
        frmPrevRoomsLog.ShowDialog()
    End Sub

    Private Sub BackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupToolStripMenuItem.Click
        With Me
            .tmReminder.Stop()
            .tmRoomAlarm.Stop()
        End With

        With frmDatabase
            .btnBackup.Visible = True
            .btnRestore.Visible = False
            .ShowDialog()
        End With
    End Sub

    Private Sub RestoreFromBackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreFromBackupToolStripMenuItem.Click
        With Me
            .tmReminder.Stop()
            .tmRoomAlarm.Stop()
        End With
        With frmDatabase
            .btnBackup.Visible = False
            .btnRestore.Visible = True
            .ShowDialog()
        End With
    End Sub

    Private Sub ReportHeaderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportHeaderToolStripMenuItem.Click
        frmReportHeader.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.ToolStripStatuslblUsername.Text = "-----"
        Me.ToolStripStatuslblLevel.Text = "-----"
        Me.ToolStripStatuslblDate.Text = "-----"
        frmLogin.ShowDialog()
    End Sub

    Private Sub lstvwImage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvwImage.SelectedIndexChanged
        If Me.lstvwImage.SelectedItems.Count = 0 Then
            Me.lblRate.Text = ""
            Me.lblFloor.Text = ""
            Me.lblEquipments.Text = ""
            Me.lblSB.Text = ""
            Me.lblDB.Text = ""
            Me.lblExtraBed.Text = ""
            Me.lblCheckIn.Text = ""
            Me.lblCheckOut.Text = ""
            Me.lblNights.Text = ""
            Me.lblDescription.Text = ""
            Me.lblRoomType.Text = ""
        End If
    End Sub

    Private Sub SystemLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemLogToolStripMenuItem.Click
        frmPrevSystemLog.ShowDialog()
    End Sub

    Private Sub TaskLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskLogToolStripMenuItem.Click
        frmPrevTaskLog.ShowDialog()
    End Sub

    Private Sub TransactionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionReportToolStripMenuItem.Click
        frmPrevTransaction.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Are you sure you want to exit application?", MsgBoxStyle.YesNo, "Exit Application") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub AdvancePaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvancePaymentToolStripMenuItem.Click
        frmPrevAdvances.ShowDialog()
    End Sub

    Private Sub ViewLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewLogToolStripMenuItem.Click
        With frmLogBook_Entry
            .GenID = Me.lstvwReservation.SelectedItems(0).SubItems(0).Text
            .LoadAdvances()
            .LoadOthersList()
            .LoadCustomerList()
            .LoadPaymentType()
            .LoadRooms()
            .btnEnter.Text = "&Update"
            .GetReservationData()
            .cmbxReservationStatus.Enabled = False
            .cmbxRoomNo.Enabled = False
            '************Locking
            .grpbxDetails.Enabled = False
            .grpbxReservation.Enabled = False
            .grpbxCustomer.Enabled = False
            .grpbxComments.Enabled = False
            .pnOption.Enabled = False
            .grpbxAdvancePayment.Enabled = False
            .btnEnter.Enabled = False
            '************
            .ShowDialog()
        End With
    End Sub

    Private Sub CleaningLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CleaningLogToolStripMenuItem.Click

        Dim Header1 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Header2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Header3 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Header4 As CrystalDecisions.CrystalReports.Engine.TextObject
        'Date from & to
        'Dim DateFrom As CrystalDecisions.CrystalReports.Engine.TextObject
        'Dim DateTo As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim crSections As Sections
        Dim crSection As Section
        Dim crReportObjects As ReportObjects

        Dim myTable As CrystalDecisions.CrystalReports.Engine.Table
        Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo

        Dim repDoc

        repDoc = New crptCleaningLog

        Header1 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader1")
        Header2 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader2")
        Header3 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader3")
        Header4 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader4")

        'DateFrom = repDoc.ReportDefinition.ReportObjects.Item("txtDateFrom")
        'DateTo = repDoc.ReportDefinition.ReportObjects.Item("txtDateTo")

        GetHeaderInfo()

        Header1.Text = strHeader1
        Header2.Text = strHeader2
        Header3.Text = strHeader3
        Header4.Text = strHeader4

        'DateFrom.Text = Me.dtpDatefrom.Value.ToShortDateString
        'DateTo.Text = Me.dtpDateto.Value.ToShortDateString

        For Each myTable In repDoc.Database.Tables
            myLogin = myTable.LogOnInfo
            myLogin.ConnectionInfo.ServerName = GetcrptDBPath() & "\HMDB.accdb"
            'myLogin.ConnectionInfo.DatabaseName = GetcrptDBPath() & "\HMDB.accdb"
            myLogin.ConnectionInfo.UserID = UserID
            myLogin.ConnectionInfo.Password = Password
            myTable.ApplyLogOnInfo(myLogin)
        Next

        crSections = repDoc.ReportDefinition.Sections
        'loop through all the sections to find all the report objects
        For Each crSection In crSections
            crReportObjects = crSection.ReportObjects
        Next

        rptfrmCleaningLog.CrystalReportViewerCleaningLog.ReportSource = repDoc


        'rptfrmDailyTrans.CrystalReportViewerDailyTrans.SelectionFormula = "{tblAdvances.DatePaid}>=#" & Me.dtpDatefrom.Value.ToShortDateString & " 12:00:00 AM# AND {tblAdvances.DatePaid}<=#" & Me.dtpDateto.Value.AddDays(1).ToShortDateString & " 12:00:00 AM#"

        rptfrmCleaningLog.ShowDialog()

    End Sub

    Private Sub DeletionAccessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeletionAccessToolStripMenuItem.Click
        frmDeletionAccess.ShowDialog()
    End Sub

    Private Sub ShowReservToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowReservToolStripMenuItem.Click
        frmShowReservations.Show()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyValue = Keys.Enter = True Then
            Me.btnSearchReservation_Click(sender, e)
        End If
    End Sub

    Private Sub CashCountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashCountToolStripMenuItem.Click
        frmPrevCashCount.ShowDialog()
    End Sub

End Class
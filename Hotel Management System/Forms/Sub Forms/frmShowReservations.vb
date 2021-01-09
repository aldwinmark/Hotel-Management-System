Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class frmShowReservations

    'Code for image subitems partially from source: http://www.groupsrv.com/dotnet/about180142.html

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Auto)> _
    Friend Structure LVITEM
        Friend mask As Integer
        Friend iItem As Integer
        Friend subItem As Integer
        Friend state As Integer
        Friend stateMask As Integer
        <MarshalAs(UnmanagedType.LPTStr)>
        Friend lpszText As String
        Friend cchTextMax As Integer
        Friend iImage As Integer
        Friend lParam As IntPtr
        Friend iIndent As Integer
    End Structure

    Friend Const LVM_FIRST As Integer = &H1000
    Friend Const LVM_SETEXTENDEDLISTVIEWSTYLE As Integer = LVM_FIRST + 54
    Friend Const LVS_EX_SUBITEMIMAGES As Integer = &H2
    Friend Const LVIF_IMAGE As Integer = &H2
    Friend Const LVM_SETITEMA As Integer = LVM_FIRST + 6
    Friend Const LVM_SETITEMW As Integer = LVM_FIRST + 76

    Friend Shared ReadOnly LVM_SETITEM As Integer =
  CInt(IIf(Marshal.SystemDefaultCharSize = 1, LVM_SETITEMA, LVM_SETITEMW))

    Friend Overloads Declare Auto Function SendMessage Lib "User32.dll" (ByVal hwnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByRef lParam As LVITEM) As Integer
    Friend Overloads Declare Auto Function SendMessage Lib "User32.dll" (ByVal hwnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    Friend Shared Function ListView_SetItem(ByVal hwnd As IntPtr, ByRef lvi As LVITEM) As Boolean
        Return CBool(SendMessage(hwnd, LVM_SETITEM,
        IntPtr.Zero, lvi))
    End Function

    Friend Shared Sub ListView_SetSubItemImageIndex(ByVal hwnd As IntPtr, ByVal index As Integer, ByVal subItemIndex As Integer, ByVal imageIndex As Integer)

        Dim lvi As LVITEM

        lvi = Nothing
        lvi.state = 1
        lvi.iItem = index
        lvi.subItem = subItemIndex
        lvi.iImage = imageIndex
        lvi.mask = LVIF_IMAGE
        ListView_SetItem(hwnd, lvi)

    End Sub

#Region "Functions"

#Region "Filling Functions"

    Private Function checkRoomReservation(ByVal RoomNo As String, ByVal SDate As String) As String
        checkRoomReservation = ""
        'StrSelect = "SELECT * FROM tblLogBook WHERE (Check_IN BETWEEN #" & CDate(Me.dtpCheckIn.Value.ToShortDateString & " " & GetCheckTime("In")) & "# AND #" & CDate(Me.dtpCheckOut.Value.ToShortDateString & " " & GetCheckTime("Out")) & "#) OR (Check_OUT BETWEEN #" & CDate(Me.dtpCheckIn.Value.ToShortDateString & " " & GetCheckTime("Out")) & "# AND #" & CDate(Me.dtpCheckIn.Value.ToShortDateString & " " & GetCheckTime("Out")) & "#) "

        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblLogBook WHERE RoomNo='" & RoomNo & "' AND ReservationStatus='Reserved' AND Check_IN= #" & SDate & " " & GetCheckTime("IN") & "#"
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            checkRoomReservation = "<"
            GoTo done
        Else
            checkRoomReservation = ""
        End If
        'close the reader
        Reader.Close()

        CheckConnection(cn)
        Dim StrSelect1 = "SELECT * FROM tblLogBook WHERE RoomNo='" & RoomNo & "' AND ReservationStatus='Reserved' AND Check_OUT= #" & SDate & " " & GetCheckTime("Out") & "#"
        Dim cmd1 As New OleDbCommand(StrSelect1, cn)
        Dim Reader1 As OleDbDataReader = cmd1.ExecuteReader
        Reader1.Read()
        If Reader1.HasRows = True Then
            checkRoomReservation = ">"
        Else
            checkRoomReservation = ""
        End If
        'close the reader
        Reader1.Close()
done:
        Return checkRoomReservation

    End Function

    Private Sub FillCalendar()
        Dim Start As Integer
        'Dim temp As String
        Dim intY As Integer = 0

        Dim CalDate As Date
        Dim Cal As Integer
        Dim RoomNo As String
        Dim x As Integer
        Dim z As Integer
        Dim Count As Integer
        Me.lstvw.Items.Clear()
        Me.lstvw.Columns.Clear()
        ds.Clear()
        Dim DateCount As TimeSpan
        Dim Header As ColumnHeader

        'get the Counted days
        DateCount = Me.dtpDateto.Value - Me.dtpDatefrom.Value
        Count = DateCount.Days + 2

        'loop to list the columns
        Header = New ColumnHeader
        Header.Text = "Room #"
        Header.TextAlign = HorizontalAlignment.Center
        Header.Width = 100
        Me.lstvw.Columns.Add(Header)
        For x = 0 To Count - 1
            Header = New ColumnHeader
            Header.Text = Me.dtpDatefrom.Value.AddDays(x).Date
            Header.TextAlign = HorizontalAlignment.Center
            Header.Width = 100
            Me.lstvw.Columns.Add(Header)
        Next

        '++++++++++++++++++++++++Load the rooms
        oledbda.SelectCommand = New OleDbCommand("SELECT * FROM tblRooms ORDER BY RoomNo ASC", cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)
        oledbda.Fill(ds)

        'in the imagelist1 are 2 icons, set this imagelist to smallimagelist on listview1
        Me.lstvw.SmallImageList = Me.ImgLst

        'set listview to allow changes on subitems
        SendMessage(lstvw.Handle, LVM_SETEXTENDEDLISTVIEWSTYLE, LVS_EX_SUBITEMIMAGES, LVS_EX_SUBITEMIMAGES)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim y = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows
                Start = 0
                RoomNo = dr("RoomNo")
                Dim MyItem = Me.lstvw.Items.Add(RoomNo)
                MyItem.tag = x
                x = x + 1
                'If RoomNo = "310" Then
                '    MsgBox(RoomNo)
                'End If
                With MyItem
                    For Cal = 1 To Me.lstvw.Columns.Count - 1
                        CalDate = Me.lstvw.Columns(Cal).Text
                        If checkRoomReservation(RoomNo, CalDate) = "<" Then
                            .SubItems.Add("<")
                            Start = 1
                        ElseIf checkRoomReservation(RoomNo, CalDate) = ">" Then
                            .SubItems.Add(">")
                            Start = 0
                        ElseIf checkRoomReservation(RoomNo, CalDate) = "" And Start = 1 Then
                            .SubItems.Add("-")
                        Else
                            .SubItems.Add(" ")
                        End If
                        '.SubItems.Add("", 1, 1)
                        'temp = checkRoomReservation(RoomNo, CalDate)
                        'If checkRoomReservation(RoomNo, CalDate) = "<" Then
                        '    ListView_SetSubItemImageIndex(lstvw.Handle, intY, lstvw.Columns(Cal).Index, 0)
                        'ElseIf checkRoomReservation(RoomNo, CalDate) = ">" Then
                        '    ListView_SetSubItemImageIndex(lstvw.Handle, intY, lstvw.Columns(Cal).Index, 1)
                        'Else
                        '    ListView_SetSubItemImageIndex(lstvw.Handle, intY, lstvw.Columns(Cal).Index, 2)
                        'End If


                        'Me.lstvw.StateImageList = ImgLst
                        '.subitems.add(Bitmap.FromFile("C:\Users\User\Desktop\updated Hotel\Hotel Management System(old)\Hotel Management System\Designs\led-icons\accept.png"))
                        '.LSI = .ListSubItems.Add(, , "Subitem")
                        ' .LSI.ReportIcon = "icon_key_from_imagelist_control"
                    Next
                End With
                intY += 1
            Next
        End If
        '++++++++++++++++++++++++
    End Sub

#End Region

#Region "Loading List"

    Friend Sub LoadList()
        FillCalendar()
        'listvwColorChange(Me.lstvw)
        listvwColumnColor(Me.lstvw)
    End Sub

#End Region

#End Region

    Private Sub frmShowReservations_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmShowReservations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpDateto.Value = Me.dtpDateto.Value.AddDays(5)
        LoadList()
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        LoadList()
    End Sub

End Class
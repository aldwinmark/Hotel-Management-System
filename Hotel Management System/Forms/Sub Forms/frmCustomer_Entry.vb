Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Drawing.Imaging.ImageFormat

Public Class frmCustomer_Entry

    Friend Id As Integer

    Dim FullName As String
    Dim Company As String
    Dim Address As String
    Dim PhoneNo As String
    Dim Email As String
    Dim ID_Passport As String
    Dim DateOfBirth As String
    Dim Comment As String

    Dim iDevice As Integer = 0 ' Current device ID
    Dim hHwnd As Integer ' Handle to preview window
    Dim data As IDataObject
    Dim bmap As Image

#Region "User Functions"

#Region "Camera"

    Const WM_CAP_START = &H400S
    Const WS_CHILD = &H40000000
    Const WS_VISIBLE = &H10000000

    Const WM_CAP_DRIVER_CONNECT = WM_CAP_START + 10
    Const WM_CAP_DRIVER_DISCONNECT = WM_CAP_START + 11
    Const WM_CAP_EDIT_COPY = WM_CAP_START + 30
    Const WM_CAP_SEQUENCE = WM_CAP_START + 62
    Const WM_CAP_FILE_SAVEAS = WM_CAP_START + 23

    Const WM_CAP_SET_SCALE = WM_CAP_START + 53
    Const WM_CAP_SET_PREVIEWRATE = WM_CAP_START + 52
    Const WM_CAP_SET_PREVIEW = WM_CAP_START + 50

    Const SWP_NOMOVE = &H2S
    Const SWP_NOSIZE = 1
    Const SWP_NOZORDER = &H4S
    Const HWND_BOTTOM = 1

    Private Sub SavePicture()
        Try
            Dim FilePath As String
            FilePath = GetcrptDBPath() & "\CustPic\" & Me.txtFullName.Text & Me.txtIDPassport.Text & ".jpg"
            bmap.Save(FilePath, Imaging.ImageFormat.Jpeg)
            MsgBox("Picture successfully saved!", vbInformation)
            'Me.lstVideoSources.Items.Clear()
            'Me.pcbxID.Image = Nothing
        Catch ex As Exception
            MsgBox("Invalid inputted character (/ or \) in Full Name or Id!", MsgBoxStyle.Critical, "Invalid input")
        End Try

    End Sub

    Private Sub ClosePreviewWindow()
        ' Disconnect from device
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)
        ' close window
        DestroyWindow(hHwnd)
    End Sub

    Private Sub OpenPreviewWindow()
        Dim iHeight As Integer = pcbxID.Height
        Dim iWidth As Integer = pcbxID.Width
        ' Open Preview window in picturebox
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, _
            480, pcbxID.Handle.ToInt32, 0)
        ' Connect to device
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            'Set the preview scale
            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)
            'Set the preview rate in milliseconds
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)
            'Start previewing the image from the camera
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)
            ' Resize window to fit in picturebox
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, pcbxID.Width, pcbxID.Height, _
                    SWP_NOMOVE Or SWP_NOZORDER)
            btnCapture.Enabled = True
            btnPreview.Enabled = False
        Else
            ' Error connecting to device close window
            DestroyWindow(hHwnd)
        End If
    End Sub

    '--The capGetDriverDescription function retrieves the version 
    ' description of the capture driver--
    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" _
       (ByVal wDriverIndex As Short, _
        ByVal lpszName As String, ByVal cbName As Integer, _
        ByVal lpszVer As String, _
        ByVal cbVer As Integer) As Boolean

    '--The capCreateCaptureWindow function creates a capture window--
    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
       (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
        ByVal nHeight As Short, ByVal hWnd As Integer, _
        ByVal nID As Integer) As Integer

    '--This function sends the specified message to a window or windows--
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
       (ByVal hwnd As Integer, ByVal Msg As Integer, _
        ByVal wParam As Integer, _
       <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    '--Sets the position of the window relative to the screen buffer--
    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" _
       (ByVal hwnd As Integer, _
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, _
        ByVal y As Integer, _
        ByVal cx As Integer, ByVal cy As Integer, _
        ByVal wFlags As Integer) As Integer

    '--This function destroys the specified window--
    Declare Function DestroyWindow Lib "user32" _
       (ByVal hndw As Integer) As Boolean

    '---used to identify the video source---
    Dim VideoSource As Integer
    '---used as a window handle---
    Dim hWnd As Integer

    '---preview the selected video source---
    Private Sub PreviewVideo(ByVal pbCtrl As PictureBox)
        hWnd = capCreateCaptureWindowA(VideoSource, _
            WS_VISIBLE Or WS_CHILD, 0, 0, 0, _
            0, pbCtrl.Handle.ToInt32, 0)
        If SendMessage( _
           hWnd, WM_CAP_DRIVER_CONNECT, _
           VideoSource, 0) Then
            '---set the preview scale---
            SendMessage(hWnd, WM_CAP_SET_SCALE, True, 0)
            '---set the preview rate (ms)---
            SendMessage(hWnd, WM_CAP_SET_PREVIEWRATE, 30, 0)
            '---start previewing the image---
            SendMessage(hWnd, WM_CAP_SET_PREVIEW, True, 0)
            '---resize window to fit in PictureBox control---
            SetWindowPos(hWnd, HWND_BOTTOM, 0, 0, _
               pbCtrl.Width, pbCtrl.Height, _
               SWP_NOMOVE Or SWP_NOZORDER)
        Else
            '--error connecting to video source---
            DestroyWindow(hWnd)
        End If
    End Sub

    Private Sub ListVideoSources()
        Dim DriverName As String = Space(80)
        Dim DriverVersion As String = Space(80)
        For i As Integer = 0 To 9
            If capGetDriverDescriptionA(i, DriverName, 80, _
               DriverVersion, 80) Then
                lstVideoSources.Items.Add(DriverName.Trim)
            End If
        Next
    End Sub

#End Region

    Private Function GetBlockListed() As String

        If Me.chkbxBlockListed.Checked = True Then
            GetBlockListed = "Block"
        Else
            GetBlockListed = ""
        End If

        Return GetBlockListed
    End Function

    Public Sub GetInfo()
        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblCustomer WHERE Id=" & Id & ""
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            Me.txtFullName.Text = Reader("FullName")
            Me.txtCompany.Text = Reader("Company")
            Me.txtAddress.Text = Reader("Address")
            Me.txtPhone.Text = Reader("PhoneNo")
            Me.txtEmail.Text = Reader("Email")
            Me.txtIDPassport.Text = Reader("ID_Passport")
            If Reader("DateOfBirth") = "" Then
                Me.chkbxBirthdate.Checked = True
                Me.dtpDateOfBirth.Enabled = False
            Else
                Me.chkbxBirthdate.Checked = False
                Me.dtpDateOfBirth.Text = Reader("DateOfBirth")
            End If
            If IsDBNull(Reader("BlockListed")) = False Then
                If Reader("BlockListed") = "Block" Then
                    Me.chkbxBlockListed.Checked = True
                Else
                    Me.chkbxBlockListed.Checked = False
                End If
            End If


            Me.txtComment.Text = Reader("Comment")

            'System log
            FullName = Reader("FullName")
            Company = Reader("Company")
            Address = Reader("Address")
            PhoneNo = Reader("PhoneNo")
            Email = Reader("Email")
            ID_Passport = Reader("ID_Passport")
            DateOfBirth = Reader("DateOfBirth")
            Comment = Reader("Comment")

        End If

        pcbxID.ImageLocation = Application.StartupPath & "\CustPic\" & Me.txtFullName.Text & Me.txtIDPassport.Text & ".jpg"

        'close the reader
        Reader.Close()

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim strSelect As String

        If Trim(Me.txtFullName.Text).Length = 0 Then
            MsgBox("Please enter a valid name of customer.", MsgBoxStyle.Exclamation, "Required")
            Me.txtFullName.Focus()
        ElseIf Trim(Me.txtAddress.Text).Length = 0 Then
            MsgBox("Please enter an address of the customer.", MsgBoxStyle.Exclamation, "Required")
            Me.txtAddress.Focus()
        ElseIf Trim(Me.txtPhone.Text).Length <= 0 Then
            MsgBox("Please enter a phone no of the customer.", MsgBoxStyle.Exclamation, "Required")
            Me.txtPhone.Focus()
        ElseIf Trim(Me.txtIDPassport.Text).Length <= 0 Then
            MsgBox("Please enter an ID or Passport.", MsgBoxStyle.Exclamation, "Required")
            Me.txtIDPassport.Focus()
        Else
            Dim strBirthDate As String

            If Me.dtpDateOfBirth.Enabled = False Then
                strBirthDate = ""
            Else
                strBirthDate = Me.dtpDateOfBirth.Value.ToString
            End If

            If Me.btnEnter.Text = "&Save" Then

                strSelect = "INSERT INTO tblCustomer" & _
                                    "([FullName],[Company],[Address],[PhoneNo],[Email],[ID_Passport],[DateOfBirth],[BlockListed],[Comment])VALUES " + _
                                    "('" + CSQ(Me.txtFullName.Text) + "','" + _
                                    "" + CSQ(Me.txtCompany.Text) + "','" + _
                                    "" + CSQ(Me.txtAddress.Text) + "','" + _
                                    "" + CSQ(Me.txtPhone.Text) + "','" + _
                                    "" + CSQ(Me.txtEmail.Text) + "','" + _
                                    "" + CSQ(Me.txtIDPassport.Text) + "','" + _
                                    "" + (strBirthDate) + "','" + _
                                    "" + (GetBlockListed()) + _
                                    "', '" + CSQ(Me.txtComment.Text) + "')"

                CheckConnection(cn)
                Dim cmdSave As New OleDbCommand(strSelect, cn)
                cmdSave.ExecuteNonQuery()
                MsgBox("Customer " & Me.txtFullName.Text & " has been successfully saved.", MsgBoxStyle.Information, "Saved")

                'SystemLog
                SystemLog("Add", "Customer " & Me.txtFullName.Text & " has been added.", frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Customer Module")

            Else
                strSelect = "UPDATE tblCustomer SET" & _
                    "[FullName]='" & Me.txtFullName.Text & _
                    "',[Company]='" & Me.txtCompany.Text & _
                    "',[Address]='" & Me.txtAddress.Text & _
                    "',[PhoneNo]='" & Me.txtPhone.Text & _
                    "',[Email]='" & Me.txtEmail.Text & _
                    "',[ID_Passport]='" & Me.txtIDPassport.Text & _
                    "',[DateOfBirth]='" & strBirthDate & _
                    "',[BlockListed]='" & GetBlockListed() & _
                    "',[Comment]='" & Me.txtComment.Text & _
                    "'WHERE Id=" & Id & ""

                CheckConnection(cn)

                Dim cmd As New OleDbCommand(strSelect, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Customer " & Me.txtFullName.Text & " has been successfully updated.", MsgBoxStyle.Information, "Updated")

                'SystemLog
                Dim str As String = ""
                If FullName <> Me.txtFullName.Text Then
                    str = str & "Full name(" & FullName & ">" & Me.txtFullName.Text & ")"
                End If
                If Company <> Me.txtCompany.Text Then
                    str = str & "Company(" & Company & ">" & Me.txtCompany.Text & ")"
                End If
                If Address <> Me.txtAddress.Text Then
                    str = str & "Address(" & Address & ">" & Me.txtAddress.Text & ")"
                End If
                If PhoneNo <> Me.txtPhone.Text Then
                    str = str & "Phone no(" & PhoneNo & ">" & Me.txtPhone.Text & ")"
                End If
                If Email <> Me.txtEmail.Text Then
                    str = str & "Email(" & Email & ">" & Me.txtEmail.Text & ")"
                End If
                If ID_Passport <> Me.txtIDPassport.Text Then
                    str = str & "ID or Passport(" & ID_Passport & ">" & Me.txtIDPassport.Text & ")"
                End If
                If DateOfBirth <> strBirthDate Then
                    str = str & "Date of Birth(" & DateOfBirth & ">" & strBirthDate & ")"
                End If
                If Comment <> Me.txtComment.Text Then
                    str = str & "Comment(" & Comment & ">" & Me.txtComment.Text & ")"
                End If
                If str <> "" Then
                    SystemLog("Edit", "Changes in " & str, frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Customer Module")
                End If

                SavePicture()

            End If
                frmCustomer_View.LoadList()
                Me.btnCancel_Click(sender, e)
        End If

    End Sub

    Private Sub chkbxBirthdate_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkbxBirthdate.CheckStateChanged
        If Me.chkbxBirthdate.Checked = True Then
            Me.dtpDateOfBirth.Enabled = False
        Else
            Me.dtpDateOfBirth.Enabled = True
        End If
    End Sub

    Private Sub chkbxBirthdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkbxBirthdate.Click
       
    End Sub

    Private Sub frmCustomer_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '---list all the video sources---
        ListVideoSources()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        iDevice = lstVideoSources.SelectedIndex
        OpenPreviewWindow()
    End Sub

    Private Sub btnCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapture.Click
        ' Copy image to clipboard
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
        ' Get image from clipboard and convert it to a bitmap
        Data = Clipboard.GetDataObject()
        Data.GetDataPresent(GetType(System.Drawing.Bitmap))
        bmap = CType(Data.GetData(GetType(System.Drawing.Bitmap)), Image)
        Me.pcbxID.Image = bmap
        ClosePreviewWindow()
        Me.btnPreview.Enabled = True
        Me.btnCapture.Enabled = False
    End Sub

End Class
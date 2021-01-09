Imports System.Data.OleDb

Module Functions

    Public strHeader1 As String
    Public strHeader2 As String
    Public strHeader3 As String
    Public strHeader4 As String

    ''' <summary>
    ''' System Log
    ''' </summary>
    ''' <param name="LogType"></param>
    ''' <param name="Username"></param>
    ''' <param name="UserLevel"></param>
    ''' <param name="SysModule"></param>
    ''' <remarks></remarks>
    Public Sub SystemLog(ByVal LogType As String, ByVal LogItems As String, ByVal Username As String, ByVal UserLevel As String, ByVal SysModule As String)

        Dim SQL As String

        CheckConnection(cn)

        SQL = "INSERT INTO tblSystemLog ([LogType],[LogItems],[LogDateTime],[Username],[UserLevel],[Module]) VALUES ('" & LogType & "','" & LogItems & "','" & Date.Now & "','" & Username & "','" & UserLevel & "','" & SysModule & "')"

        Dim cmd As New OleDbCommand(SQL, cn)
        cmd.ExecuteNonQuery()

    End Sub

    Public Sub GetHeaderInfo()

        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblHeaders WHERE ID=" & 1 & ""
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            strHeader1 = Reader("Header1")
            strHeader2 = Reader("Header2")
            strHeader3 = Reader("Header3")
            strHeader4 = Reader("Header4")
        End If

        'close the reader
        Reader.Close()

    End Sub

    Public Function GetCheckTime(ByVal CheckStatus As String) As String
        'Out,In
        Dim StrSelect As String
        StrSelect = "SELECT * FROM tblCheckIN_CheckOUT WHERE ID = 1"

        CheckConnection(cn)
        Dim cmdSearch As New OleDbCommand(StrSelect, cn)

        Dim objReader As OleDbDataReader = cmdSearch.ExecuteReader
        objReader.Read()

        If objReader.HasRows = True Then
            If CheckStatus = "Out" Then
                GetCheckTime = objReader("CheckOUT")
            Else
                GetCheckTime = objReader("CheckIN")
            End If
        Else
            GetCheckTime = ""
        End If

        'close the reader
        objReader.Close()

        Return GetCheckTime
    End Function

    Public Sub listvwColumnColor(ByVal lstvw As ListView)
        Dim x As Integer
        Dim y As Integer
        'Dynamic back color of listview
        For x = 0 To lstvw.Items.Count - 1
            'If lstvw.Items(x). 
            ' 'lstvw.Items(x).BackColor = Color.MintCream
            'Me.lstvwTimedata.Items(x).ForeColor = Color.Blue

        Next
    End Sub

    Public Sub listvwColorChange(ByVal lstvw As ListView)
        Dim x As Integer
        'Dynamic back color of listview
        For x = 0 To lstvw.Items.Count - 1
            If x Mod 2 <> 0 Then
                lstvw.Items(x).BackColor = Color.MintCream
                'Me.lstvwTimedata.Items(x).ForeColor = Color.Blue
            End If
        Next
    End Sub

    Public Sub listvwBlockListed(ByVal lstvw As ListView)
        Dim x As Integer
        'Dynamic back color of listview
        For x = 0 To lstvw.Items.Count - 1
            If lstvw.Items(x).SubItems(6).Text = "Block" Then
                lstvw.Items(x).BackColor = Color.OrangeRed
            End If
        Next
    End Sub

    Public Function CSQ(ByVal str)
        If IsDBNull(str) Then str = ""
        CSQ = Replace(str, "'", "''")

        'Function CSQ(byVal str)
        'If IsNull(str) Then str = ""
        'CSQ = Replace(str, "'", "''")
        'End Function

        'myvar = "Bob's Diner"

        'Sql = "INSERT INTO tablename (myvar, myvar2) VALUES ('" & CSQ(myvar) & "','" & CSQ(myvar2) & "')"
        'rs = Conn.Execute(Sql)

    End Function

    Public Function GenerateID() As String

        Dim StrSelect As String
FindNext:
        Dim RandomClass As New Random
        Dim code = (RandomClass.Next(999999))

        StrSelect = "SELECT * FROM tblLogBook WHERE GenID = " & (code) & " "
        CheckConnection(cn)
        Dim cmdSearch As New OleDbCommand(StrSelect, cn)

        Dim objReader As OleDbDataReader = cmdSearch.ExecuteReader
        objReader.Read()

        If objReader.HasRows = True Then
            'close the reader
            objReader.Close()
            GoTo FindNext
        End If

        'close the reader
        objReader.Close()

        GenerateID = code

    End Function

End Module

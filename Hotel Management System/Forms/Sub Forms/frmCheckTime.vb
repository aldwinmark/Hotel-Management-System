Imports System.Data.OleDb

Public Class frmCheckTime

    Dim CheckIN As String
    Dim CheckOut As String

#Region "User Functions"

    Private Sub UpdCheckIN()
        Dim strTime As String
        Dim strSelect As String
        Dim OirgDate As Date
        Dim str As String
        ds.Clear()
        oledbda.SelectCommand = New OleDbCommand("SELECT * FROM tblLogBook", cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        strTime = Me.dtpCheckIN.Value.ToString("hh:mm:ss tt")

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                OirgDate = CDate(dr("Check_IN"))

                str = OirgDate.ToShortDateString & " " & OirgDate.ToString("hh:mm:ss tt")
                If dr("Check_IN") <> CDate(OirgDate.ToShortDateString & " " & strTime) Then

                    strSelect = "UPDATE tblLogBook SET" & _
                     "[Check_IN]='" & CDate(OirgDate.ToShortDateString & " " & strTime) & "' WHERE ID=" & dr("ID")

                    CheckConnection(cn)

                    Dim cmd As New OleDbCommand(strSelect, cn)
                    cmd.ExecuteNonQuery()

                End If

            Next
        End If
        cn.Close()
    End Sub

    Private Sub UpdCheckOUT()
        Dim strTime As String
        Dim strSelect As String
        Dim OirgDate As Date
        Dim str As String
        ds.Clear()
        oledbda.SelectCommand = New OleDbCommand("SELECT * FROM tblLogBook", cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        strTime = Me.dtpCheckOUT.Value.ToString("hh:mm:ss tt")

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                OirgDate = CDate(dr("Check_OUT"))

                str = OirgDate.ToShortDateString & " " & OirgDate.ToString("hh:mm:ss tt")
                If dr("Check_OUT") <> CDate(OirgDate.ToShortDateString & " " & strTime) Then

                    strSelect = "UPDATE tblLogBook SET" & _
                     "[Check_OUT]='" & CDate(OirgDate.ToShortDateString & " " & strTime) & "' WHERE ID=" & dr("ID")

                    CheckConnection(cn)

                    Dim cmd As New OleDbCommand(strSelect, cn)
                    cmd.ExecuteNonQuery()

                End If

            Next
        End If
        cn.Close()
    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        Dim strSelect As String

        strSelect = "UPDATE tblCheckIN_CheckOUT SET" & _
                   "[CheckIN]='" & Me.dtpCheckIN.Value.ToShortTimeString & "',[CheckOUT]='" & Me.dtpCheckOUT.Value.ToShortTimeString & "'"

        CheckConnection(cn)

        Dim cmd As New OleDbCommand(strSelect, cn)
        cmd.ExecuteNonQuery()
        'update all the records with the new check-in and check-out time
        UpdCheckIN()
        UpdCheckOUT()
        MsgBox("Check Time has been successfully updated.", MsgBoxStyle.Information, "Updated")

        'SystemLog
        Dim str As String = ""
        If CheckIN <> Me.dtpCheckIN.Value.ToShortTimeString Then
            str = str & "Check-IN(" & CheckIN & ">" & Me.dtpCheckIN.Value.ToShortTimeString & ")"
        End If
        If CheckOut <> Me.dtpCheckOUT.Value.ToShortTimeString Then
            str = str & "Check-OUT(" & CheckOut & ">" & Me.dtpCheckOUT.Value.ToShortTimeString & ")"
        End If
        If str <> "" Then
            SystemLog("Edit", "Changes in " & str, frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Checking time Module")
        End If
        Me.btnCancel_Click(sender, e)

    End Sub

    Private Sub frmCheckTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblCheckIN_CheckOUT " 'WHERE GenID=" & GenID & ""
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            Me.dtpCheckIN.Text = Reader("CheckIN")
            Me.dtpCheckOUT.Text = Reader("CheckOUT")
            'system log
            CheckIN = Reader("CheckIN")
            CheckOut = Reader("CheckOUT")
        End If

        'close the reader
        Reader.Close()
    End Sub

End Class
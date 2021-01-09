Imports System.Data.OleDb

Public Class frmReportHeader

    Dim Header1 As String
    Dim Header2 As String
    Dim Header3 As String
    Dim Header4 As String

#Region "User Functions"

    Private Sub GetHeaderInfo()

        CheckConnection(cn)
        Dim StrSelect = "SELECT * FROM tblHeaders WHERE ID=" & 1 & ""
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            Me.txtHeader1.Text = Reader("Header1")
            Me.txtHeader2.Text = Reader("Header2")
            Me.txtHeader3.Text = Reader("Header3")
            Me.txtHeader4.Text = Reader("Header4")

            Header1 = Reader("Header1")
            Header2 = Reader("Header2")
            Header3 = Reader("Header3")
            Header4 = Reader("Header4")

        End If

        'close the reader
        Reader.Close()

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim strSelect As String
        strSelect = "UPDATE tblHeaders SET" & _
                    "[Header1]='" & Me.txtHeader1.Text & _
                    "',[Header2]='" & Me.txtHeader2.Text & _
                    "',[Header3]='" & Me.txtHeader3.Text & _
                    "',[Header4]='" & Me.txtHeader4.Text & _
                    "'WHERE ID=" & 1 & ""

        CheckConnection(cn)

        Dim cmd As New OleDbCommand(strSelect, cn)
        cmd.ExecuteNonQuery()
        MsgBox("Headers has been successfully updated.", MsgBoxStyle.Information, "Updated")

        'SystemLog
        Dim str As String = ""
        If Header1 <> Me.txtHeader1.Text Then
            str = str & "Header1(" & Header1 & ">" & Me.txtHeader1.Text & ")"
        End If
        If Header2 <> Me.txtHeader2.Text Then
            str = str & "Header2(" & Header2 & ">" & Me.txtHeader2.Text & ")"
        End If

        If Header3 <> Me.txtHeader3.Text Then
            str = str & "Header3(" & Header3 & ">" & Me.txtHeader3.Text & ")"
        End If
        If Header4 <> Me.txtHeader4.Text Then
            str = str & "Header4(" & Header4 & ">" & Me.txtHeader4.Text & ")"
        End If
        If str <> "" Then
            SystemLog("Edit", "Changes in " & str, frmRoomMonitoring.ToolStripStatuslblUsername.Text, frmRoomMonitoring.ToolStripStatuslblLevel.Text, "Report Header Module")
        End If
        Me.btnCancel_Click(sender, e)
    End Sub

    Private Sub frmReportHeader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetHeaderInfo()
    End Sub

End Class
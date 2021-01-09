Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPrevRoomsLog

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        Dim Header1 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Header2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Header3 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Header4 As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim crSections As Sections
        Dim crSection As Section
        Dim crReportObjects As ReportObjects

        Dim myTable As CrystalDecisions.CrystalReports.Engine.Table
        Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo

        Dim repDoc

        repDoc = New crptRoomsLog

        If Me.cmbxReservationStatus.Text = "Occupied" Then
            repDoc = New crptRoomsLogOccupied
        ElseIf Me.cmbxReservationStatus.Text = "Paid" Then
            repDoc = New crptRoomsLog
        ElseIf Me.cmbxReservationStatus.Text = "Reserved" Then
            repDoc = New crptRoomsLogOccupied
        End If

        Header1 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader1")
        Header2 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader2")
        Header3 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader3")
        Header4 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader4")

        GetHeaderInfo()

        Header1.Text = strHeader1
        Header2.Text = strHeader2
        Header3.Text = strHeader3
        Header4.Text = strHeader4

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

        rptfrmRoomsLog.CrystalReportViewerRoomsLog.ReportSource = repDoc

        If Me.cmbxReservationStatus.Text = "Occupied" Then
            rptfrmRoomsLog.CrystalReportViewerRoomsLog.SelectionFormula = "{tblLogBook.Check_IN}>=#" & Me.dtpDate.Value.ToShortDateString & " 12:00:00 AM# AND {tblLogBook.Check_IN}<=#" & Me.dtpDate.Value.AddDays(1).ToShortDateString & " 12:00:00 AM# AND {tblLogBook.ReservationStatus}='Occupied'"
        ElseIf Me.cmbxReservationStatus.Text = "Paid" Then
            rptfrmRoomsLog.CrystalReportViewerRoomsLog.SelectionFormula = "{vwRoomsLog.DatePaid}>=#" & Me.dtpDate.Value.ToShortDateString & " 12:00:00 AM# AND {vwRoomsLog.DatePaid}<=#" & Me.dtpDate.Value.AddDays(1).ToShortDateString & " 12:00:00 AM#"
        ElseIf Me.cmbxReservationStatus.Text = "Reserved" Then
            rptfrmRoomsLog.CrystalReportViewerRoomsLog.SelectionFormula = "{tblLogBook.Check_IN}>=#" & Me.dtpDate.Value.ToShortDateString & " 12:00:00 AM# AND {tblLogBook.Check_IN}<=#" & Me.dtpDate.Value.AddDays(1).ToShortDateString & " 12:00:00 AM# AND {tblLogBook.ReservationStatus}='Reserved'"
        End If

        rptfrmRoomsLog.ShowDialog()

    End Sub

    Private Sub frmPrevRoomsLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbxReservationStatus.Text = "Occupied"
    End Sub

End Class
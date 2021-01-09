Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPrevCashCount

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim Header1 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Header2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Header3 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Header4 As CrystalDecisions.CrystalReports.Engine.TextObject
        'Date and Time from & to
        Dim sDate As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim TimeFrom As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim TimeTo As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim crSections As Sections
        Dim crSection As Section
        Dim crReportObjects As ReportObjects

        Dim myTable As CrystalDecisions.CrystalReports.Engine.Table
        Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo

        Dim repDoc

        repDoc = New crptCashCount

        Header1 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader1")
        Header2 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader2")
        Header3 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader3")
        Header4 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader4")

        sDate = repDoc.ReportDefinition.ReportObjects.Item("txtDate")
        TimeFrom = repDoc.ReportDefinition.ReportObjects.Item("txtTimeFrom")
        TimeTo = repDoc.ReportDefinition.ReportObjects.Item("txtTimeTo")

        GetHeaderInfo()

        Header1.Text = strHeader1
        Header2.Text = strHeader2
        Header3.Text = strHeader3
        Header4.Text = strHeader4

        sDate.Text = Me.dtpDate.Value.ToShortDateString
        TimeFrom.Text = Me.dtpTimeFrom.Value.ToShortTimeString
        TimeTo.Text = Me.dtpTimeTo.Value.ToShortTimeString

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

        rptfrmDailyTrans.CrystalReportViewerDailyTrans.ReportSource = repDoc

        Dim str As String
        str = "{tblAdvances.DatePaid}>=#" & Me.dtpDate.Value.ToShortDateString & " " & Me.dtpTimeFrom.Value.ToShortTimeString & "# AND {tblAdvances.DatePaid}<#" & Me.dtpDate.Value.ToShortDateString & " " & Me.dtpTimeTo.Value.AddMinutes(1).ToShortTimeString & "#"
        rptfrmDailyTrans.CrystalReportViewerDailyTrans.SelectionFormula = "{tblAdvances.DatePaid}>=#" & Me.dtpDate.Value.ToShortDateString & " " & Me.dtpTimeFrom.Value.ToShortTimeString & "# AND {tblAdvances.DatePaid}<#" & Me.dtpDate.Value.ToShortDateString & " " & Me.dtpTimeTo.Value.AddMinutes(1).ToShortTimeString & "#"
       
        rptfrmDailyTrans.ShowDialog()

    End Sub

End Class
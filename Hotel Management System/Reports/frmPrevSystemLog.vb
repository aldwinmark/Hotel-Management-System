﻿Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPrevSystemLog

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        Dim Header1 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Header2 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Header3 As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Header4 As CrystalDecisions.CrystalReports.Engine.TextObject
        'Date from & to
        Dim DateFrom As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim DateTo As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim crSections As Sections
        Dim crSection As Section
        Dim crReportObjects As ReportObjects

        Dim myTable As CrystalDecisions.CrystalReports.Engine.Table
        Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo

        Dim repDoc

        repDoc = New crptSystemLog

        Header1 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader1")
        Header2 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader2")
        Header3 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader3")
        Header4 = repDoc.ReportDefinition.ReportObjects.Item("txtHeader4")

        DateFrom = repDoc.ReportDefinition.ReportObjects.Item("txtDateFrom")
        DateTo = repDoc.ReportDefinition.ReportObjects.Item("txtDateTo")

        GetHeaderInfo()

        Header1.Text = strHeader1
        Header2.Text = strHeader2
        Header3.Text = strHeader3
        Header4.Text = strHeader4

        DateFrom.Text = Me.dtpDatefrom.Value.ToShortDateString
        DateTo.Text = Me.dtpDateto.Value.ToShortDateString

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

        rptfrmSystemLog.CrystalReportViewerSystemLog.ReportSource = repDoc

        rptfrmSystemLog.CrystalReportViewerSystemLog.SelectionFormula = "{tblSystemLog.LogDateTime}>=#" & Me.dtpDatefrom.Value.ToShortDateString & " 12:00:00 AM# AND {tblSystemLog.LogDateTime}<=#" & Me.dtpDateto.Value.AddDays(1).ToShortDateString & " 12:00:00 AM#"

        rptfrmSystemLog.ShowDialog()

    End Sub

End Class
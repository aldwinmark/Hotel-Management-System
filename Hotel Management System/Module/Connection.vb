Imports System.Data.OleDb
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
Imports System.IO

Module Connection

    Public UserID = "Admin"
    Public Password = "wongdatabase"

    Public ds As DataSet = New DataSet
    Public oledbda As OleDbDataAdapter = New OleDbDataAdapter
    Public oledbcmbldr As OleDbCommandBuilder
    Public dr As DataRow

    Public Function CheckConnection(ByVal conn As OleDbConnection) As OleDbConnection
reco:
        Try
            'This function checks the recordset if it is open.
            'if it is open, then it will close the recordset
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If
            Return conn
        Catch ex As Exception
            If MessageBox.Show(ex.Message, "Connection to Server failed, Try to reconnect", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                GoTo reco
            Else
                End
            End If
            End
        End Try

    End Function

    'open a database connection.
    'Public strConnection As String = "Provider = Microsoft.jet.OLEDB.4.0;Data Source =" & Application.StartupPath & "\ElectriPartsDB.mdb;"
    'Public strConnection As String = "File Name=" & Application.StartupPath & "\DBPath.udl;"
    Public strConnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & GetcrptDBPath() & "\HMDB.accdb;Persist Security Info=False;Jet OLEDB:Database Password=wongdatabase;"

    Public cn As OleDbConnection = New OleDbConnection(strConnection)

    Public Function GetcrptDBPath() As String

        Dim oRead As System.IO.StreamReader

        oRead = IO.File.OpenText(Application.StartupPath & "\crptPath.txt")
        GetcrptDBPath = oRead.ReadToEnd()

        Return GetcrptDBPath

    End Function

    'Public Function CheckrptConnection(ByVal strCrystal As String) As CrystalDecisions.CrystalReports.Engine.ReportDocument

    '    Dim intCounter As Integer
    '    'Crystal Report's report document object
    '    Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    '    'object of table Log on info of Crystal report
    '    Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo

    '    Try
    '        'Load the report
    '        'objReport.Load(Application.StartupPath & "\crptWinners.rpt")
    '        'objReport.DataSourceConnections(0).SetConnection("", GetcrptDBPath, False)
    '        objReport.Load(strCrystal)

    '        'CheckConnection(cn)

    '        ConInfo.ConnectionInfo.UserID = "Admin"
    '        ConInfo.ConnectionInfo.Password = "Admin"
    '        ConInfo.ConnectionInfo.ServerName = ""
    '        ConInfo.ConnectionInfo.DatabaseName = GetcrptDBPath()

    '        For intCounter = 0 To objReport.Database.Tables.Count - 1
    '            objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
    '        Next

    '    Catch ex As System.Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    Return objReport

    'End Function

    'Public Function ViewReport(ByVal sReportName As String, _
    'Optional ByVal sSelectionFormula As String = "", _
    'Optional ByVal param As String = "") As Boolean

    '    'Declaring variablesables

    '    Dim intCounter As Integer
    '    Dim intCounter1 As Integer

    '    'Crystal Report's report document object

    '    Dim objReport As New  _
    '        CrystalDecisions.CrystalReports.Engine.ReportDocument

    '    'object of table Log on info of Crystal report

    '    Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo

    '    'Parameter value object of crystal report 
    '    ' parameters used for adding the value to parameter.
    '    Dim paraValue As New CrystalDecisions.Shared.ParameterDiscreteValue

    '    'Current parameter value object(collection) of crystal report parameters.
    '    Dim currValue As CrystalDecisions.Shared.ParameterValues

    '    'Sub report object of crystal report.
    '    Dim mySubReportObject As  _
    '        CrystalDecisions.CrystalReports.Engine.SubreportObject

    '    'Sub report document of crystal report.
    '    Dim mySubRepDoc As New  _
    '        CrystalDecisions.CrystalReports.Engine.ReportDocument

    '    Dim strParValPair() As String
    '    Dim strVal() As String
    '    Dim index As Integer

    '    Try

    '        'Load the report
    '        objReport.Load(sReportName)

    '        'Check if there are parameters or not in report.
    '        intCounter = objReport.DataDefinition.ParameterFields.Count

    '        'As parameter fields collection also picks the selection 
    '        ' formula which is not the parameter
    '        ' so if total parameter count is 1 then we check whether 
    '        ' its a parameter or selection formula.

    '        If intCounter = 1 Then
    '            If InStr(objReport.DataDefinition.ParameterFields(0).ParameterFieldName, ".", CompareMethod.Text) > 0 Then
    '                intCounter = 0
    '            End If
    '        End If

    '        'If there are parameters in report and 
    '        'user has passed them then split the 
    '        'parameter string and Apply the values 
    '        'to their concurrent parameters.

    '        If intCounter > 0 And Trim(param) <> "" Then
    '            strParValPair = param.Split("&")

    '            For index = 0 To UBound(strParValPair)
    '                If InStr(strParValPair(index), "=") > 0 Then
    '                    strVal = strParValPair(index).Split("=")
    '                    paraValue.Value = strVal(1)
    '                    currValue = _
    '                        objReport.DataDefinition.ParameterFields(strVal(0)).CurrentValues
    '                    currValue.Add(paraValue)
    '                    objReport.DataDefinition.ParameterFields(strVal(0)).ApplyCurrentValues(currValue)
    '                End If
    '            Next
    '        End If

    '        'Set the connection information to ConInfo 
    '        'object so that we can apply the 
    '        'connection information on each table in the report

    '        ConInfo.ConnectionInfo.UserID = "Admin"
    '        'ConInfo.ConnectionInfo.Password = ""
    '        'ConInfo.ConnectionInfo.ServerName = GetcrptDBPath() ' & "ElectriPartsDB.mdb"
    '        ConInfo.ConnectionInfo.DatabaseName = "ElectriPartsDB"

    '        For intCounter = 0 To objReport.Database.Tables.Count - 1
    '            objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
    '        Next

    '        ' Loop through each section on the report then look 
    '        ' through each object in the section
    '        ' if the object is a subreport, then apply logon info 
    '        ' on each table of that sub report

    '        For index = 0 To objReport.ReportDefinition.Sections.Count - 1
    '            For intCounter = 0 To _
    '                objReport.ReportDefinition.Sections(index).ReportObjects.Count - 1
    '                With objReport.ReportDefinition.Sections(index)
    '                    If .ReportObjects(intCounter).Kind = _
    '                    CrystalDecisions.Shared.ReportObjectKind.SubreportObject Then
    '                        mySubReportObject = CType(.ReportObjects(intCounter),  _
    '                          CrystalDecisions.CrystalReports.Engine.SubreportObject)
    '                        mySubRepDoc = _
    '                 mySubReportObject.OpenSubreport(mySubReportObject.SubreportName)
    '                        For intCounter1 = 0 To mySubRepDoc.Database.Tables.Count - 1
    '                            mySubRepDoc.Database.Tables(intCounter1).ApplyLogOnInfo(ConInfo) 'sp;
    '                            mySubRepDoc.Database.Tables(intCounter1).ApplyLogOnInfo(ConInfo)
    '                        Next
    '                    End If
    '                End With
    '            Next
    '        Next
    '        'If there is a selection formula passed to this function then use that
    '        If sSelectionFormula.Length > 0 Then
    '            objReport.RecordSelectionFormula = sSelectionFormula
    '        End If
    '        'Re setting control 
    '        vwfrmAdmin.crptvwAdmin.ReportSource = Nothing

    '        'Set the current report object to report.
    '        vwfrmAdmin.crptvwAdmin.ReportSource = objReport

    '        'Show the report

    '        vwfrmAdmin.Show()
    '        Return True
    '    Catch ex As System.Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Function

End Module

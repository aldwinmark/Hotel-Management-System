<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptfrmRoomsLog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptfrmRoomsLog))
        Me.CrystalReportViewerRoomsLog = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewerRoomsLog
        '
        Me.CrystalReportViewerRoomsLog.ActiveViewIndex = -1
        Me.CrystalReportViewerRoomsLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerRoomsLog.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerRoomsLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerRoomsLog.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerRoomsLog.Name = "CrystalReportViewerRoomsLog"
        Me.CrystalReportViewerRoomsLog.Size = New System.Drawing.Size(597, 358)
        Me.CrystalReportViewerRoomsLog.TabIndex = 1
        Me.CrystalReportViewerRoomsLog.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'rptfrmRoomsLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 358)
        Me.Controls.Add(Me.CrystalReportViewerRoomsLog)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "rptfrmRoomsLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rooms Log"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewerRoomsLog As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

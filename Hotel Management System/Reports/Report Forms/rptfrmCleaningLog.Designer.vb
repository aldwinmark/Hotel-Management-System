<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptfrmCleaningLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptfrmCleaningLog))
        Me.CrystalReportViewerCleaningLog = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewerCleaningLog
        '
        Me.CrystalReportViewerCleaningLog.ActiveViewIndex = -1
        Me.CrystalReportViewerCleaningLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerCleaningLog.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerCleaningLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerCleaningLog.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerCleaningLog.Name = "CrystalReportViewerCleaningLog"
        Me.CrystalReportViewerCleaningLog.Size = New System.Drawing.Size(534, 381)
        Me.CrystalReportViewerCleaningLog.TabIndex = 2
        Me.CrystalReportViewerCleaningLog.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'rptfrmCleaningLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 381)
        Me.Controls.Add(Me.CrystalReportViewerCleaningLog)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rptfrmCleaningLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cleaning Log"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewerCleaningLog As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

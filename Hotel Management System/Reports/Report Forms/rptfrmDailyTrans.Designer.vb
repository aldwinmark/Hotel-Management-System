<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptfrmDailyTrans
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptfrmDailyTrans))
        Me.CrystalReportViewerDailyTrans = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewerDailyTrans
        '
        Me.CrystalReportViewerDailyTrans.ActiveViewIndex = -1
        Me.CrystalReportViewerDailyTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerDailyTrans.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerDailyTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerDailyTrans.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerDailyTrans.Name = "CrystalReportViewerDailyTrans"
        Me.CrystalReportViewerDailyTrans.Size = New System.Drawing.Size(549, 373)
        Me.CrystalReportViewerDailyTrans.TabIndex = 1
        Me.CrystalReportViewerDailyTrans.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'rptfrmDailyTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 373)
        Me.Controls.Add(Me.CrystalReportViewerDailyTrans)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rptfrmDailyTrans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Transaction Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewerDailyTrans As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

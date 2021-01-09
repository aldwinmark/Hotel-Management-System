<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptfrmInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptfrmInvoice))
        Me.CrystalReportViewerInvoice = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewerInvoice
        '
        Me.CrystalReportViewerInvoice.ActiveViewIndex = -1
        Me.CrystalReportViewerInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerInvoice.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerInvoice.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerInvoice.Name = "CrystalReportViewerInvoice"
        Me.CrystalReportViewerInvoice.Size = New System.Drawing.Size(719, 458)
        Me.CrystalReportViewerInvoice.TabIndex = 0
        Me.CrystalReportViewerInvoice.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'rptfrmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 458)
        Me.Controls.Add(Me.CrystalReportViewerInvoice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rptfrmInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewerInvoice As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

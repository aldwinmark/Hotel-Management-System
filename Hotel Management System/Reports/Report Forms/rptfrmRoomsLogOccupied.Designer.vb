<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptfrmRoomsLogOccupied
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptfrmRoomsLogOccupied))
        Me.CrystalReportViewerRoomsLogOccupied = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewerRoomsLogOccupied
        '
        Me.CrystalReportViewerRoomsLogOccupied.ActiveViewIndex = -1
        Me.CrystalReportViewerRoomsLogOccupied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewerRoomsLogOccupied.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewerRoomsLogOccupied.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerRoomsLogOccupied.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerRoomsLogOccupied.Name = "CrystalReportViewerRoomsLogOccupied"
        Me.CrystalReportViewerRoomsLogOccupied.Size = New System.Drawing.Size(752, 422)
        Me.CrystalReportViewerRoomsLogOccupied.TabIndex = 1
        Me.CrystalReportViewerRoomsLogOccupied.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'rptfrmRoomsLogOccupied
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 422)
        Me.Controls.Add(Me.CrystalReportViewerRoomsLogOccupied)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rptfrmRoomsLogOccupied"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rooms Log (Occupied)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewerRoomsLogOccupied As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

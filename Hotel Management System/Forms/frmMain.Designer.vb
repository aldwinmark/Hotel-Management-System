<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MS = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomMonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeCheckingTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatuslbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatuslblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatuslblLevel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatuslblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusUserId = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmNow = New System.Windows.Forms.Timer(Me.components)
        Me.ShowReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MS.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MS
        '
        Me.MS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem, Me.MaintenanceToolStripMenuItem})
        Me.MS.Location = New System.Drawing.Point(0, 0)
        Me.MS.Name = "MS"
        Me.MS.Size = New System.Drawing.Size(739, 24)
        Me.MS.TabIndex = 0
        Me.MS.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.LogoutToolStripMenuItem.Text = "Log-out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogBookToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.RoomMonitoringToolStripMenuItem, Me.ShowReservationsToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'LogBookToolStripMenuItem
        '
        Me.LogBookToolStripMenuItem.Name = "LogBookToolStripMenuItem"
        Me.LogBookToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.LogBookToolStripMenuItem.Text = "Log Book"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'RoomMonitoringToolStripMenuItem
        '
        Me.RoomMonitoringToolStripMenuItem.Name = "RoomMonitoringToolStripMenuItem"
        Me.RoomMonitoringToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.RoomMonitoringToolStripMenuItem.Text = "Room Monitoring"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserAccountsToolStripMenuItem, Me.RoomToolStripMenuItem, Me.RoomTypeToolStripMenuItem, Me.PaymentTypeToolStripMenuItem, Me.ChangeCheckingTimeToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenance"
        '
        'UserAccountsToolStripMenuItem
        '
        Me.UserAccountsToolStripMenuItem.Name = "UserAccountsToolStripMenuItem"
        Me.UserAccountsToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.UserAccountsToolStripMenuItem.Text = "User Accounts"
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.RoomToolStripMenuItem.Text = "Rooms"
        '
        'RoomTypeToolStripMenuItem
        '
        Me.RoomTypeToolStripMenuItem.Name = "RoomTypeToolStripMenuItem"
        Me.RoomTypeToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.RoomTypeToolStripMenuItem.Text = "Room Type"
        '
        'PaymentTypeToolStripMenuItem
        '
        Me.PaymentTypeToolStripMenuItem.Name = "PaymentTypeToolStripMenuItem"
        Me.PaymentTypeToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.PaymentTypeToolStripMenuItem.Text = "Payment Type"
        '
        'ChangeCheckingTimeToolStripMenuItem
        '
        Me.ChangeCheckingTimeToolStripMenuItem.Name = "ChangeCheckingTimeToolStripMenuItem"
        Me.ChangeCheckingTimeToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ChangeCheckingTimeToolStripMenuItem.Text = "Change checking time"
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.WhiteSmoke
        Me.StatusStrip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatuslbl, Me.ToolStripStatuslblUsername, Me.ToolStripStatusLabel1, Me.ToolStripStatuslblLevel, Me.ToolStripStatusLabel2, Me.ToolStripStatuslblDate, Me.ToolStripStatusUserId})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 369)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(739, 22)
        Me.StatusStrip.TabIndex = 2
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatuslbl
        '
        Me.ToolStripStatuslbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripStatuslbl.Name = "ToolStripStatuslbl"
        Me.ToolStripStatuslbl.Size = New System.Drawing.Size(73, 17)
        Me.ToolStripStatuslbl.Text = "Username:"
        '
        'ToolStripStatuslblUsername
        '
        Me.ToolStripStatuslblUsername.Name = "ToolStripStatuslblUsername"
        Me.ToolStripStatuslblUsername.Size = New System.Drawing.Size(63, 17)
        Me.ToolStripStatuslblUsername.Text = "-----------"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel1.Text = "Level:"
        '
        'ToolStripStatuslblLevel
        '
        Me.ToolStripStatuslblLevel.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatuslblLevel.Name = "ToolStripStatuslblLevel"
        Me.ToolStripStatuslblLevel.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatuslblLevel.Text = "------"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(103, 17)
        Me.ToolStripStatusLabel2.Text = "Date and Time:"
        Me.ToolStripStatusLabel2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripStatuslblDate
        '
        Me.ToolStripStatuslblDate.Name = "ToolStripStatuslblDate"
        Me.ToolStripStatuslblDate.Size = New System.Drawing.Size(86, 17)
        Me.ToolStripStatuslblDate.Text = "MM-dd-yyyy"
        '
        'ToolStripStatusUserId
        '
        Me.ToolStripStatusUserId.Name = "ToolStripStatusUserId"
        Me.ToolStripStatusUserId.Size = New System.Drawing.Size(33, 17)
        Me.ToolStripStatusUserId.Text = "-----"
        Me.ToolStripStatusUserId.Visible = False
        '
        'tmNow
        '
        Me.tmNow.Enabled = True
        '
        'ShowReservationsToolStripMenuItem
        '
        Me.ShowReservationsToolStripMenuItem.Name = "ShowReservationsToolStripMenuItem"
        Me.ShowReservationsToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ShowReservationsToolStripMenuItem.Text = "Show Reservations"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 391)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MS
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MS.ResumeLayout(False)
        Me.MS.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MS As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserAccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatuslbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatuslblUsername As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatuslblLevel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatuslblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusUserId As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmNow As System.Windows.Forms.Timer
    Friend WithEvents RoomTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomMonitoringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeCheckingTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowReservationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

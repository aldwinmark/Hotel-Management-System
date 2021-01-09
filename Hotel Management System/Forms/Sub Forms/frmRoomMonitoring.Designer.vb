<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomMonitoring
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoomMonitoring))
        Me.lstvwImage = New System.Windows.Forms.ListView()
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UserMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OccupyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowReservToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lstbxCustomer = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblRoomType = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblEquipments = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblFloor = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblExtraBed = New System.Windows.Forms.Label()
        Me.lblDB = New System.Windows.Forms.Label()
        Me.lblSB = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblNights = New System.Windows.Forms.Label()
        Me.lblCheckOut = New System.Windows.Forms.Label()
        Me.lblCheckIn = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.dtpDateRem = New System.Windows.Forms.DateTimePicker()
        Me.lstvwReminders = New System.Windows.Forms.ListView()
        Me.RemID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RemDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RemTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Remarks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMSReminders = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddRemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditRemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelRemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshRemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitConTopRight = New System.Windows.Forms.SplitContainer()
        Me.lstvwRoomAlarm = New System.Windows.Forms.ListView()
        Me.AlarmRoomNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AlarmCheckOUT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbxSearchField = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbxReservationStatus = New System.Windows.Forms.ComboBox()
        Me.cmbxCheckStatus = New System.Windows.Forms.ComboBox()
        Me.dtpDateSearch = New System.Windows.Forms.DateTimePicker()
        Me.btnSearchReservation = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.lstvwReservation = New System.Windows.Forms.ListView()
        Me.ResId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResRoom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResCheckIn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResCheckOut = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResCustomerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResFloor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RestRate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResNights = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResPaid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResAdvance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResLocalTax = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResPaymentType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResIN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResOut = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMSReservation = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddResToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditResToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteResToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshResToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstvwRoomCleaning = New System.Windows.Forms.ListView()
        Me.RCId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RCRoomNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RCStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RCBeddings = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMSRoomCleaning = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstvw = New System.Windows.Forms.ListView()
        Me.GenID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RoomNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Floor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Rate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nights = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Paid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Advance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LocalTax = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PaymentType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tmReminder = New System.Windows.Forms.Timer(Me.components)
        Me.tmRoomAlarm = New System.Windows.Forms.Timer(Me.components)
        Me.MS = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomsLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancePaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleaningLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeCheckingTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportHeaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeletionAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreFromBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatuslbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatuslblUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatuslblLevel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatuslblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusUserId = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OccupiedToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.VacantToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ReservedToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmNow = New System.Windows.Forms.Timer(Me.components)
        Me.CMS.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.CMSReminders.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitConTopRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitConTopRight.Panel1.SuspendLayout()
        Me.SplitConTopRight.Panel2.SuspendLayout()
        Me.SplitConTopRight.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.CMSReservation.SuspendLayout()
        Me.CMSRoomCleaning.SuspendLayout()
        Me.MS.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvwImage
        '
        Me.lstvwImage.BackColor = System.Drawing.Color.White
        Me.lstvwImage.BackgroundImageTiled = True
        Me.lstvwImage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstvwImage.ContextMenuStrip = Me.CMS
        Me.lstvwImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvwImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwImage.ForeColor = System.Drawing.Color.Black
        Me.lstvwImage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstvwImage.Location = New System.Drawing.Point(0, 0)
        Me.lstvwImage.MultiSelect = False
        Me.lstvwImage.Name = "lstvwImage"
        Me.lstvwImage.Size = New System.Drawing.Size(681, 277)
        Me.lstvwImage.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstvwImage.TabIndex = 59
        Me.lstvwImage.TileSize = New System.Drawing.Size(100, 200)
        Me.lstvwImage.UseCompatibleStateImageBehavior = False
        '
        'CMS
        '
        Me.CMS.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserMenuToolStripMenuItem, Me.ToolStripSeparator1, Me.OccupyToolStripMenuItem, Me.CheckOutToolStripMenuItem, Me.ToolStripSeparator3, Me.EditToolStripMenuItem, Me.ShowReservToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(281, 198)
        '
        'UserMenuToolStripMenuItem
        '
        Me.UserMenuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UserMenuToolStripMenuItem.Enabled = False
        Me.UserMenuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UserMenuToolStripMenuItem.Name = "UserMenuToolStripMenuItem"
        Me.UserMenuToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UserMenuToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.UserMenuToolStripMenuItem.Text = "Room Reservation"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(277, 6)
        '
        'OccupyToolStripMenuItem
        '
        Me.OccupyToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.door_in
        Me.OccupyToolStripMenuItem.Name = "OccupyToolStripMenuItem"
        Me.OccupyToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.OccupyToolStripMenuItem.Text = "&Occupy this room"
        '
        'CheckOutToolStripMenuItem
        '
        Me.CheckOutToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.door
        Me.CheckOutToolStripMenuItem.Name = "CheckOutToolStripMenuItem"
        Me.CheckOutToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.CheckOutToolStripMenuItem.Text = "Check-Out This Room"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(277, 6)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.page_white_edit
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.EditToolStripMenuItem.Text = "&Edit reservation data in this room"
        '
        'ShowReservToolStripMenuItem
        '
        Me.ShowReservToolStripMenuItem.Image = CType(resources.GetObject("ShowReservToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowReservToolStripMenuItem.Name = "ShowReservToolStripMenuItem"
        Me.ShowReservToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.ShowReservToolStripMenuItem.Text = "Show Reservations"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.delete
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(277, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.arrow_refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.RefreshToolStripMenuItem.Text = "&Refresh list of rooms"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.Splitter1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1221, 600)
        Me.SplitContainer1.SplitterDistance = 295
        Me.SplitContainer1.TabIndex = 60
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 600)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'SplitContainer4
        '
        Me.SplitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer4.IsSplitterFixed = True
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.GroupBox4)
        Me.SplitContainer4.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer4.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.dtpDateRem)
        Me.SplitContainer4.Panel2.Controls.Add(Me.lstvwReminders)
        Me.SplitContainer4.Size = New System.Drawing.Size(295, 600)
        Me.SplitContainer4.SplitterDistance = 440
        Me.SplitContainer4.TabIndex = 4
        Me.SplitContainer4.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lstbxCustomer)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 258)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(275, 54)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Customer Details"
        '
        'lstbxCustomer
        '
        Me.lstbxCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstbxCustomer.FormattingEnabled = True
        Me.lstbxCustomer.ItemHeight = 15
        Me.lstbxCustomer.Location = New System.Drawing.Point(10, 20)
        Me.lstbxCustomer.Name = "lstbxCustomer"
        Me.lstbxCustomer.Size = New System.Drawing.Size(248, 17)
        Me.lstbxCustomer.TabIndex = 46
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblRoomType)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblEquipments)
        Me.GroupBox1.Controls.Add(Me.lblDescription)
        Me.GroupBox1.Controls.Add(Me.lblFloor)
        Me.GroupBox1.Controls.Add(Me.lblRate)
        Me.GroupBox1.Controls.Add(Me.lblExtraBed)
        Me.GroupBox1.Controls.Add(Me.lblDB)
        Me.GroupBox1.Controls.Add(Me.lblSB)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 240)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Details"
        '
        'lblRoomType
        '
        Me.lblRoomType.BackColor = System.Drawing.Color.White
        Me.lblRoomType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRoomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomType.ForeColor = System.Drawing.Color.Black
        Me.lblRoomType.Location = New System.Drawing.Point(110, 145)
        Me.lblRoomType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRoomType.Name = "lblRoomType"
        Me.lblRoomType.Size = New System.Drawing.Size(148, 20)
        Me.lblRoomType.TabIndex = 45
        Me.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 16)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Room Type:"
        '
        'lblEquipments
        '
        Me.lblEquipments.BackColor = System.Drawing.Color.White
        Me.lblEquipments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEquipments.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquipments.ForeColor = System.Drawing.Color.Black
        Me.lblEquipments.Location = New System.Drawing.Point(110, 179)
        Me.lblEquipments.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEquipments.Name = "lblEquipments"
        Me.lblEquipments.Size = New System.Drawing.Size(148, 53)
        Me.lblEquipments.TabIndex = 43
        Me.lblEquipments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.White
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Location = New System.Drawing.Point(110, 115)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(148, 20)
        Me.lblDescription.TabIndex = 42
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFloor
        '
        Me.lblFloor.BackColor = System.Drawing.Color.White
        Me.lblFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFloor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFloor.ForeColor = System.Drawing.Color.Black
        Me.lblFloor.Location = New System.Drawing.Point(110, 85)
        Me.lblFloor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFloor.Name = "lblFloor"
        Me.lblFloor.Size = New System.Drawing.Size(148, 20)
        Me.lblFloor.TabIndex = 40
        Me.lblFloor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRate
        '
        Me.lblRate.BackColor = System.Drawing.Color.White
        Me.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.ForeColor = System.Drawing.Color.Black
        Me.lblRate.Location = New System.Drawing.Point(191, 53)
        Me.lblRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(67, 20)
        Me.lblRate.TabIndex = 39
        Me.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExtraBed
        '
        Me.lblExtraBed.BackColor = System.Drawing.Color.White
        Me.lblExtraBed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblExtraBed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtraBed.ForeColor = System.Drawing.Color.Black
        Me.lblExtraBed.Location = New System.Drawing.Point(110, 54)
        Me.lblExtraBed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExtraBed.Name = "lblExtraBed"
        Me.lblExtraBed.Size = New System.Drawing.Size(27, 20)
        Me.lblExtraBed.TabIndex = 38
        Me.lblExtraBed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDB
        '
        Me.lblDB.BackColor = System.Drawing.Color.White
        Me.lblDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDB.ForeColor = System.Drawing.Color.Black
        Me.lblDB.Location = New System.Drawing.Point(231, 23)
        Me.lblDB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDB.Name = "lblDB"
        Me.lblDB.Size = New System.Drawing.Size(27, 20)
        Me.lblDB.TabIndex = 37
        Me.lblDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSB
        '
        Me.lblSB.BackColor = System.Drawing.Color.White
        Me.lblSB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSB.ForeColor = System.Drawing.Color.Black
        Me.lblSB.Location = New System.Drawing.Point(110, 23)
        Me.lblSB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSB.Name = "lblSB"
        Me.lblSB.Size = New System.Drawing.Size(27, 20)
        Me.lblSB.TabIndex = 36
        Me.lblSB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Equipments:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Floor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(144, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Rate:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Extra bed:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(144, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Double bed:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Single bed:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblNights)
        Me.GroupBox2.Controls.Add(Me.lblCheckOut)
        Me.GroupBox2.Controls.Add(Me.lblCheckIn)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 318)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 116)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Room Details"
        '
        'lblNights
        '
        Me.lblNights.BackColor = System.Drawing.Color.White
        Me.lblNights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNights.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNights.ForeColor = System.Drawing.Color.Black
        Me.lblNights.Location = New System.Drawing.Point(110, 85)
        Me.lblNights.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNights.Name = "lblNights"
        Me.lblNights.Size = New System.Drawing.Size(148, 20)
        Me.lblNights.TabIndex = 40
        Me.lblNights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCheckOut
        '
        Me.lblCheckOut.BackColor = System.Drawing.Color.White
        Me.lblCheckOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCheckOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckOut.ForeColor = System.Drawing.Color.Black
        Me.lblCheckOut.Location = New System.Drawing.Point(110, 54)
        Me.lblCheckOut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCheckOut.Name = "lblCheckOut"
        Me.lblCheckOut.Size = New System.Drawing.Size(148, 20)
        Me.lblCheckOut.TabIndex = 38
        Me.lblCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCheckIn
        '
        Me.lblCheckIn.BackColor = System.Drawing.Color.White
        Me.lblCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCheckIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckIn.ForeColor = System.Drawing.Color.Black
        Me.lblCheckIn.Location = New System.Drawing.Point(110, 23)
        Me.lblCheckIn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCheckIn.Name = "lblCheckIn"
        Me.lblCheckIn.Size = New System.Drawing.Size(148, 20)
        Me.lblCheckIn.TabIndex = 36
        Me.lblCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(7, 89)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(84, 16)
        Me.Label28.TabIndex = 6
        Me.Label28.Text = "No of Nights:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(7, 54)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(82, 16)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "Check-OUT:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(7, 27)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(66, 16)
        Me.Label32.TabIndex = 2
        Me.Label32.Text = "Check-IN:"
        '
        'dtpDateRem
        '
        Me.dtpDateRem.Dock = System.Windows.Forms.DockStyle.Left
        Me.dtpDateRem.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateRem.Location = New System.Drawing.Point(0, 0)
        Me.dtpDateRem.Name = "dtpDateRem"
        Me.dtpDateRem.Size = New System.Drawing.Size(87, 21)
        Me.dtpDateRem.TabIndex = 7
        Me.dtpDateRem.TabStop = False
        '
        'lstvwReminders
        '
        Me.lstvwReminders.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.RemID, Me.RemDate, Me.RemTime, Me.Remarks})
        Me.lstvwReminders.ContextMenuStrip = Me.CMSReminders
        Me.lstvwReminders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwReminders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvwReminders.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwReminders.FullRowSelect = True
        Me.lstvwReminders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwReminders.Location = New System.Drawing.Point(0, 0)
        Me.lstvwReminders.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.lstvwReminders.MultiSelect = False
        Me.lstvwReminders.Name = "lstvwReminders"
        Me.lstvwReminders.Size = New System.Drawing.Size(291, 152)
        Me.lstvwReminders.TabIndex = 6
        Me.lstvwReminders.UseCompatibleStateImageBehavior = False
        Me.lstvwReminders.View = System.Windows.Forms.View.Details
        '
        'RemID
        '
        Me.RemID.Text = ""
        Me.RemID.Width = 0
        '
        'RemDate
        '
        Me.RemDate.Text = "Date"
        Me.RemDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RemDate.Width = 80
        '
        'RemTime
        '
        Me.RemTime.Text = "Time"
        Me.RemTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RemTime.Width = 93
        '
        'Remarks
        '
        Me.Remarks.Text = "Remarks"
        Me.Remarks.Width = 110
        '
        'CMSReminders
        '
        Me.CMSReminders.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMSReminders.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripSeparator6, Me.AddRemToolStripMenuItem, Me.EditRemToolStripMenuItem, Me.DelRemToolStripMenuItem, Me.ToolStripSeparator7, Me.RefreshRemToolStripMenuItem})
        Me.CMSReminders.Name = "CMS"
        Me.CMSReminders.Size = New System.Drawing.Size(227, 126)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Enabled = False
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(226, 22)
        Me.ToolStripMenuItem2.Text = "Reminder"
        Me.ToolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripMenuItem2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(223, 6)
        '
        'AddRemToolStripMenuItem
        '
        Me.AddRemToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.add
        Me.AddRemToolStripMenuItem.Name = "AddRemToolStripMenuItem"
        Me.AddRemToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.AddRemToolStripMenuItem.Text = "&Add new reminder"
        '
        'EditRemToolStripMenuItem
        '
        Me.EditRemToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.page_white_edit
        Me.EditRemToolStripMenuItem.Name = "EditRemToolStripMenuItem"
        Me.EditRemToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.EditRemToolStripMenuItem.Text = "&Edit selected reminder"
        '
        'DelRemToolStripMenuItem
        '
        Me.DelRemToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.delete
        Me.DelRemToolStripMenuItem.Name = "DelRemToolStripMenuItem"
        Me.DelRemToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.DelRemToolStripMenuItem.Text = "&Delete selected reminder"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(223, 6)
        '
        'RefreshRemToolStripMenuItem
        '
        Me.RefreshRemToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.arrow_refresh
        Me.RefreshRemToolStripMenuItem.Name = "RefreshRemToolStripMenuItem"
        Me.RefreshRemToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.RefreshRemToolStripMenuItem.Text = "Refresh list of reminder"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitConTopRight)
        Me.SplitContainer2.Panel1MinSize = 40
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lstvw)
        Me.SplitContainer2.Panel2MinSize = 10
        Me.SplitContainer2.Size = New System.Drawing.Size(922, 600)
        Me.SplitContainer2.SplitterDistance = 281
        Me.SplitContainer2.TabIndex = 60
        Me.SplitContainer2.TabStop = False
        '
        'SplitConTopRight
        '
        Me.SplitConTopRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitConTopRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitConTopRight.Location = New System.Drawing.Point(0, 0)
        Me.SplitConTopRight.Name = "SplitConTopRight"
        '
        'SplitConTopRight.Panel1
        '
        Me.SplitConTopRight.Panel1.Controls.Add(Me.lstvwImage)
        '
        'SplitConTopRight.Panel2
        '
        Me.SplitConTopRight.Panel2.Controls.Add(Me.lstvwRoomAlarm)
        Me.SplitConTopRight.Size = New System.Drawing.Size(918, 277)
        Me.SplitConTopRight.SplitterDistance = 681
        Me.SplitConTopRight.TabIndex = 60
        '
        'lstvwRoomAlarm
        '
        Me.lstvwRoomAlarm.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.AlarmRoomNo, Me.AlarmCheckOUT})
        Me.lstvwRoomAlarm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwRoomAlarm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvwRoomAlarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwRoomAlarm.ForeColor = System.Drawing.Color.Red
        Me.lstvwRoomAlarm.FullRowSelect = True
        Me.lstvwRoomAlarm.GridLines = True
        Me.lstvwRoomAlarm.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwRoomAlarm.Location = New System.Drawing.Point(0, 0)
        Me.lstvwRoomAlarm.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.lstvwRoomAlarm.MultiSelect = False
        Me.lstvwRoomAlarm.Name = "lstvwRoomAlarm"
        Me.lstvwRoomAlarm.Size = New System.Drawing.Size(233, 277)
        Me.lstvwRoomAlarm.TabIndex = 7
        Me.lstvwRoomAlarm.UseCompatibleStateImageBehavior = False
        Me.lstvwRoomAlarm.View = System.Windows.Forms.View.Details
        '
        'AlarmRoomNo
        '
        Me.AlarmRoomNo.Text = "Room"
        Me.AlarmRoomNo.Width = 53
        '
        'AlarmCheckOUT
        '
        Me.AlarmCheckOUT.Text = "Check-Out"
        Me.AlarmCheckOUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.AlarmCheckOUT.Width = 170
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer5)
        Me.SplitContainer3.Size = New System.Drawing.Size(918, 311)
        Me.SplitContainer3.SplitterDistance = 54
        Me.SplitContainer3.TabIndex = 61
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbxSearchField)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cmbxReservationStatus)
        Me.GroupBox3.Controls.Add(Me.cmbxCheckStatus)
        Me.GroupBox3.Controls.Add(Me.dtpDateSearch)
        Me.GroupBox3.Controls.Add(Me.btnSearchReservation)
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(918, 54)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reservation"
        '
        'cmbxSearchField
        '
        Me.cmbxSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSearchField.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxSearchField.ForeColor = System.Drawing.Color.Navy
        Me.cmbxSearchField.FormattingEnabled = True
        Me.cmbxSearchField.Items.AddRange(New Object() {"ControlNo", "RoomNo", "CustomerName", "Rate", "Floor", "Description", "Nights", "PaymentType"})
        Me.cmbxSearchField.Location = New System.Drawing.Point(205, 19)
        Me.cmbxSearchField.Name = "cmbxSearchField"
        Me.cmbxSearchField.Size = New System.Drawing.Size(102, 23)
        Me.cmbxSearchField.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(622, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Reservation Status:"
        '
        'cmbxReservationStatus
        '
        Me.cmbxReservationStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbxReservationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxReservationStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxReservationStatus.ForeColor = System.Drawing.Color.Navy
        Me.cmbxReservationStatus.FormattingEnabled = True
        Me.cmbxReservationStatus.Items.AddRange(New Object() {"All", "Occupied", "Reserved", "Paid"})
        Me.cmbxReservationStatus.Location = New System.Drawing.Point(771, 17)
        Me.cmbxReservationStatus.Name = "cmbxReservationStatus"
        Me.cmbxReservationStatus.Size = New System.Drawing.Size(137, 23)
        Me.cmbxReservationStatus.TabIndex = 4
        '
        'cmbxCheckStatus
        '
        Me.cmbxCheckStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxCheckStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxCheckStatus.ForeColor = System.Drawing.Color.Navy
        Me.cmbxCheckStatus.FormattingEnabled = True
        Me.cmbxCheckStatus.Items.AddRange(New Object() {"All", "Check-In", "Check-OUT"})
        Me.cmbxCheckStatus.Location = New System.Drawing.Point(379, 19)
        Me.cmbxCheckStatus.Name = "cmbxCheckStatus"
        Me.cmbxCheckStatus.Size = New System.Drawing.Size(117, 23)
        Me.cmbxCheckStatus.TabIndex = 3
        '
        'dtpDateSearch
        '
        Me.dtpDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateSearch.Location = New System.Drawing.Point(502, 19)
        Me.dtpDateSearch.Name = "dtpDateSearch"
        Me.dtpDateSearch.Size = New System.Drawing.Size(105, 21)
        Me.dtpDateSearch.TabIndex = 2
        '
        'btnSearchReservation
        '
        Me.btnSearchReservation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchReservation.Location = New System.Drawing.Point(313, 19)
        Me.btnSearchReservation.Name = "btnSearchReservation"
        Me.btnSearchReservation.Size = New System.Drawing.Size(60, 23)
        Me.btnSearchReservation.TabIndex = 1
        Me.btnSearchReservation.Text = "Search"
        Me.btnSearchReservation.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(6, 20)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(193, 21)
        Me.txtSearch.TabIndex = 0
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.lstvwReservation)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.lstvwRoomCleaning)
        Me.SplitContainer5.Size = New System.Drawing.Size(918, 253)
        Me.SplitContainer5.SplitterDistance = 621
        Me.SplitContainer5.TabIndex = 6
        '
        'lstvwReservation
        '
        Me.lstvwReservation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ResId, Me.ResRoom, Me.ResCheckIn, Me.ResCheckOut, Me.ResCustomerName, Me.ResFloor, Me.RestRate, Me.ResDescription, Me.ResNights, Me.ResPaid, Me.ResAdvance, Me.ResLocalTax, Me.ResPaymentType, Me.ResIN, Me.ResOut, Me.ResStatus})
        Me.lstvwReservation.ContextMenuStrip = Me.CMSReservation
        Me.lstvwReservation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwReservation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvwReservation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwReservation.FullRowSelect = True
        Me.lstvwReservation.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwReservation.Location = New System.Drawing.Point(0, 0)
        Me.lstvwReservation.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.lstvwReservation.MultiSelect = False
        Me.lstvwReservation.Name = "lstvwReservation"
        Me.lstvwReservation.Size = New System.Drawing.Size(621, 253)
        Me.lstvwReservation.TabIndex = 5
        Me.lstvwReservation.UseCompatibleStateImageBehavior = False
        Me.lstvwReservation.View = System.Windows.Forms.View.Details
        '
        'ResId
        '
        Me.ResId.Text = "Control #"
        Me.ResId.Width = 100
        '
        'ResRoom
        '
        Me.ResRoom.Text = "Room"
        Me.ResRoom.Width = 106
        '
        'ResCheckIn
        '
        Me.ResCheckIn.Text = "Check-In"
        Me.ResCheckIn.Width = 150
        '
        'ResCheckOut
        '
        Me.ResCheckOut.Text = "Check-Out"
        Me.ResCheckOut.Width = 150
        '
        'ResCustomerName
        '
        Me.ResCustomerName.Text = "Customer Name"
        Me.ResCustomerName.Width = 172
        '
        'ResFloor
        '
        Me.ResFloor.Text = "Floor"
        Me.ResFloor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ResFloor.Width = 58
        '
        'RestRate
        '
        Me.RestRate.Text = "Rate"
        '
        'ResDescription
        '
        Me.ResDescription.Text = "Description"
        Me.ResDescription.Width = 179
        '
        'ResNights
        '
        Me.ResNights.Text = "Nights"
        Me.ResNights.Width = 56
        '
        'ResPaid
        '
        Me.ResPaid.Text = "Paid"
        '
        'ResAdvance
        '
        Me.ResAdvance.Text = "Advance"
        Me.ResAdvance.Width = 85
        '
        'ResLocalTax
        '
        Me.ResLocalTax.Text = "Local Tax"
        Me.ResLocalTax.Width = 85
        '
        'ResPaymentType
        '
        Me.ResPaymentType.Text = "Payment Type"
        Me.ResPaymentType.Width = 114
        '
        'ResIN
        '
        Me.ResIN.Text = "Check-IN"
        Me.ResIN.Width = 0
        '
        'ResOut
        '
        Me.ResOut.Text = "Check-OUT"
        Me.ResOut.Width = 0
        '
        'ResStatus
        '
        Me.ResStatus.Text = "Status"
        Me.ResStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ResStatus.Width = 100
        '
        'CMSReservation
        '
        Me.CMSReservation.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMSReservation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator4, Me.AddResToolStripMenuItem, Me.EditResToolStripMenuItem, Me.DeleteResToolStripMenuItem, Me.ToolStripSeparator5, Me.RefreshResToolStripMenuItem, Me.ToolStripSeparator10, Me.ViewLogToolStripMenuItem})
        Me.CMSReservation.Name = "CMS"
        Me.CMSReservation.Size = New System.Drawing.Size(240, 176)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(239, 22)
        Me.ToolStripMenuItem1.Text = "Reservation"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(236, 6)
        '
        'AddResToolStripMenuItem
        '
        Me.AddResToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.add
        Me.AddResToolStripMenuItem.Name = "AddResToolStripMenuItem"
        Me.AddResToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.AddResToolStripMenuItem.Text = "&Add new reservation"
        '
        'EditResToolStripMenuItem
        '
        Me.EditResToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.page_white_edit
        Me.EditResToolStripMenuItem.Name = "EditResToolStripMenuItem"
        Me.EditResToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.EditResToolStripMenuItem.Text = "&Edit selected reservation"
        '
        'DeleteResToolStripMenuItem
        '
        Me.DeleteResToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.delete
        Me.DeleteResToolStripMenuItem.Name = "DeleteResToolStripMenuItem"
        Me.DeleteResToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.DeleteResToolStripMenuItem.Text = "&Delete selected reservation"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(236, 6)
        '
        'RefreshResToolStripMenuItem
        '
        Me.RefreshResToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.arrow_refresh
        Me.RefreshResToolStripMenuItem.Name = "RefreshResToolStripMenuItem"
        Me.RefreshResToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.RefreshResToolStripMenuItem.Text = "Refresh list of reservation"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(236, 6)
        '
        'ViewLogToolStripMenuItem
        '
        Me.ViewLogToolStripMenuItem.Name = "ViewLogToolStripMenuItem"
        Me.ViewLogToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.ViewLogToolStripMenuItem.Text = "View Log"
        '
        'lstvwRoomCleaning
        '
        Me.lstvwRoomCleaning.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.RCId, Me.RCRoomNo, Me.RCStatus, Me.RCBeddings})
        Me.lstvwRoomCleaning.ContextMenuStrip = Me.CMSRoomCleaning
        Me.lstvwRoomCleaning.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwRoomCleaning.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstvwRoomCleaning.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwRoomCleaning.ForeColor = System.Drawing.Color.Red
        Me.lstvwRoomCleaning.FullRowSelect = True
        Me.lstvwRoomCleaning.GridLines = True
        Me.lstvwRoomCleaning.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwRoomCleaning.Location = New System.Drawing.Point(0, 0)
        Me.lstvwRoomCleaning.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.lstvwRoomCleaning.MultiSelect = False
        Me.lstvwRoomCleaning.Name = "lstvwRoomCleaning"
        Me.lstvwRoomCleaning.Size = New System.Drawing.Size(293, 253)
        Me.lstvwRoomCleaning.TabIndex = 8
        Me.lstvwRoomCleaning.UseCompatibleStateImageBehavior = False
        Me.lstvwRoomCleaning.View = System.Windows.Forms.View.Details
        '
        'RCId
        '
        Me.RCId.Text = "Room"
        Me.RCId.Width = 0
        '
        'RCRoomNo
        '
        Me.RCRoomNo.Text = "Room"
        Me.RCRoomNo.Width = 54
        '
        'RCStatus
        '
        Me.RCStatus.Text = "Status"
        Me.RCStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RCStatus.Width = 140
        '
        'RCBeddings
        '
        Me.RCBeddings.Text = "Beddings"
        Me.RCBeddings.Width = 83
        '
        'CMSRoomCleaning
        '
        Me.CMSRoomCleaning.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMSRoomCleaning.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripSeparator8, Me.AddTaskToolStripMenuItem, Me.ClearTaskToolStripMenuItem, Me.DelTaskToolStripMenuItem, Me.ToolStripSeparator9, Me.RefreshTaskToolStripMenuItem})
        Me.CMSRoomCleaning.Name = "CMS"
        Me.CMSRoomCleaning.Size = New System.Drawing.Size(205, 126)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Enabled = False
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(204, 22)
        Me.ToolStripMenuItem3.Text = "Room Cleaning task"
        Me.ToolStripMenuItem3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripMenuItem3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(201, 6)
        '
        'AddTaskToolStripMenuItem
        '
        Me.AddTaskToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.add
        Me.AddTaskToolStripMenuItem.Name = "AddTaskToolStripMenuItem"
        Me.AddTaskToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AddTaskToolStripMenuItem.Text = "Add task"
        '
        'ClearTaskToolStripMenuItem
        '
        Me.ClearTaskToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.page_white_edit
        Me.ClearTaskToolStripMenuItem.Name = "ClearTaskToolStripMenuItem"
        Me.ClearTaskToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ClearTaskToolStripMenuItem.Text = "&Clear selected task"
        '
        'DelTaskToolStripMenuItem
        '
        Me.DelTaskToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.delete
        Me.DelTaskToolStripMenuItem.Name = "DelTaskToolStripMenuItem"
        Me.DelTaskToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.DelTaskToolStripMenuItem.Text = "&Delete selected task"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(201, 6)
        '
        'RefreshTaskToolStripMenuItem
        '
        Me.RefreshTaskToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.arrow_refresh
        Me.RefreshTaskToolStripMenuItem.Name = "RefreshTaskToolStripMenuItem"
        Me.RefreshTaskToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.RefreshTaskToolStripMenuItem.Text = "Refresh list of Rooms"
        '
        'lstvw
        '
        Me.lstvw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.GenID, Me.RoomNo, Me.Floor, Me.Rate, Me.Description, Me.Nights, Me.Paid, Me.Advance, Me.LocalTax, Me.PaymentType, Me.Status})
        Me.lstvw.ContextMenuStrip = Me.CMS
        Me.lstvw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvw.FullRowSelect = True
        Me.lstvw.GridLines = True
        Me.lstvw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvw.Location = New System.Drawing.Point(239, 39)
        Me.lstvw.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.lstvw.MultiSelect = False
        Me.lstvw.Name = "lstvw"
        Me.lstvw.Size = New System.Drawing.Size(487, 176)
        Me.lstvw.TabIndex = 5
        Me.lstvw.UseCompatibleStateImageBehavior = False
        Me.lstvw.View = System.Windows.Forms.View.Details
        '
        'GenID
        '
        Me.GenID.Text = ""
        Me.GenID.Width = 0
        '
        'RoomNo
        '
        Me.RoomNo.Text = "Room"
        Me.RoomNo.Width = 106
        '
        'Floor
        '
        Me.Floor.Text = "Floor"
        Me.Floor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Floor.Width = 58
        '
        'Rate
        '
        Me.Rate.Text = "Rate"
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 179
        '
        'Nights
        '
        Me.Nights.Text = "Nights"
        Me.Nights.Width = 56
        '
        'Paid
        '
        Me.Paid.Text = "Paid"
        '
        'Advance
        '
        Me.Advance.Text = "Advance"
        Me.Advance.Width = 85
        '
        'LocalTax
        '
        Me.LocalTax.Text = "Local Tax"
        Me.LocalTax.Width = 85
        '
        'PaymentType
        '
        Me.PaymentType.Text = "Payment Type"
        Me.PaymentType.Width = 114
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 92
        '
        'tmReminder
        '
        Me.tmReminder.Enabled = True
        Me.tmReminder.Interval = 1000
        '
        'tmRoomAlarm
        '
        Me.tmRoomAlarm.Enabled = True
        Me.tmRoomAlarm.Interval = 5000
        '
        'MS
        '
        Me.MS.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.MS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.DatabaseToolStripMenuItem})
        Me.MS.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MS.Location = New System.Drawing.Point(0, 0)
        Me.MS.MdiWindowListItem = Me.DataToolStripMenuItem
        Me.MS.Name = "MS"
        Me.MS.Size = New System.Drawing.Size(1221, 24)
        Me.MS.TabIndex = 61
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = CType(resources.GetObject("FileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.LogoutToolStripMenuItem.Text = "&Log-out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogBookToolStripMenuItem, Me.CustomerToolStripMenuItem})
        Me.DataToolStripMenuItem.Image = CType(resources.GetObject("DataToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.DataToolStripMenuItem.Text = "&Data"
        '
        'LogBookToolStripMenuItem
        '
        Me.LogBookToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.book_addresses
        Me.LogBookToolStripMenuItem.Name = "LogBookToolStripMenuItem"
        Me.LogBookToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.LogBookToolStripMenuItem.Text = "&Log Book"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.user_business_boss
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.CustomerToolStripMenuItem.Text = "&Customer"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RoomsLogToolStripMenuItem, Me.SystemLogToolStripMenuItem, Me.TaskLogToolStripMenuItem, Me.TransactionReportToolStripMenuItem, Me.AdvancePaymentToolStripMenuItem, Me.CleaningLogToolStripMenuItem, Me.CashCountToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Image = CType(resources.GetObject("ReportsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'RoomsLogToolStripMenuItem
        '
        Me.RoomsLogToolStripMenuItem.Name = "RoomsLogToolStripMenuItem"
        Me.RoomsLogToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.RoomsLogToolStripMenuItem.Text = "&Rooms Log"
        Me.RoomsLogToolStripMenuItem.Visible = False
        '
        'SystemLogToolStripMenuItem
        '
        Me.SystemLogToolStripMenuItem.Name = "SystemLogToolStripMenuItem"
        Me.SystemLogToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SystemLogToolStripMenuItem.Text = "&System Log"
        '
        'TaskLogToolStripMenuItem
        '
        Me.TaskLogToolStripMenuItem.Name = "TaskLogToolStripMenuItem"
        Me.TaskLogToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.TaskLogToolStripMenuItem.Text = "&Task Log"
        '
        'TransactionReportToolStripMenuItem
        '
        Me.TransactionReportToolStripMenuItem.Name = "TransactionReportToolStripMenuItem"
        Me.TransactionReportToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.TransactionReportToolStripMenuItem.Text = "T&ransaction Report"
        '
        'AdvancePaymentToolStripMenuItem
        '
        Me.AdvancePaymentToolStripMenuItem.Name = "AdvancePaymentToolStripMenuItem"
        Me.AdvancePaymentToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.AdvancePaymentToolStripMenuItem.Text = "&Advance Payment"
        '
        'CleaningLogToolStripMenuItem
        '
        Me.CleaningLogToolStripMenuItem.Name = "CleaningLogToolStripMenuItem"
        Me.CleaningLogToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CleaningLogToolStripMenuItem.Text = "&Cleaning Log"
        '
        'CashCountToolStripMenuItem
        '
        Me.CashCountToolStripMenuItem.Name = "CashCountToolStripMenuItem"
        Me.CashCountToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CashCountToolStripMenuItem.Text = "Cash Count"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserAccountsToolStripMenuItem, Me.RoomToolStripMenuItem, Me.RoomTypeToolStripMenuItem, Me.PaymentTypeToolStripMenuItem, Me.ChangeCheckingTimeToolStripMenuItem, Me.ReportHeaderToolStripMenuItem, Me.DeletionAccessToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Image = CType(resources.GetObject("MaintenanceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.MaintenanceToolStripMenuItem.Text = "&Maintenance"
        '
        'UserAccountsToolStripMenuItem
        '
        Me.UserAccountsToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.user_silhouette1
        Me.UserAccountsToolStripMenuItem.Name = "UserAccountsToolStripMenuItem"
        Me.UserAccountsToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.UserAccountsToolStripMenuItem.Text = "&User Accounts"
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.door1
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.RoomToolStripMenuItem.Text = "&Rooms"
        '
        'RoomTypeToolStripMenuItem
        '
        Me.RoomTypeToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.package
        Me.RoomTypeToolStripMenuItem.Name = "RoomTypeToolStripMenuItem"
        Me.RoomTypeToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.RoomTypeToolStripMenuItem.Text = "&Room Type"
        '
        'PaymentTypeToolStripMenuItem
        '
        Me.PaymentTypeToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.money
        Me.PaymentTypeToolStripMenuItem.Name = "PaymentTypeToolStripMenuItem"
        Me.PaymentTypeToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.PaymentTypeToolStripMenuItem.Text = "&Payment Type"
        '
        'ChangeCheckingTimeToolStripMenuItem
        '
        Me.ChangeCheckingTimeToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.counter_reset
        Me.ChangeCheckingTimeToolStripMenuItem.Name = "ChangeCheckingTimeToolStripMenuItem"
        Me.ChangeCheckingTimeToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ChangeCheckingTimeToolStripMenuItem.Text = "&Change checking time"
        '
        'ReportHeaderToolStripMenuItem
        '
        Me.ReportHeaderToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.report
        Me.ReportHeaderToolStripMenuItem.Name = "ReportHeaderToolStripMenuItem"
        Me.ReportHeaderToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ReportHeaderToolStripMenuItem.Text = "R&eport Header"
        '
        'DeletionAccessToolStripMenuItem
        '
        Me.DeletionAccessToolStripMenuItem.Name = "DeletionAccessToolStripMenuItem"
        Me.DeletionAccessToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.DeletionAccessToolStripMenuItem.Text = "&Deletion Access"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupToolStripMenuItem, Me.RestoreFromBackupToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Image = CType(resources.GetObject("DatabaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.DatabaseToolStripMenuItem.Text = "&Database"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Image = CType(resources.GetObject("BackupToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.BackupToolStripMenuItem.Text = "&Back-up"
        '
        'RestoreFromBackupToolStripMenuItem
        '
        Me.RestoreFromBackupToolStripMenuItem.Image = CType(resources.GetObject("RestoreFromBackupToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RestoreFromBackupToolStripMenuItem.Name = "RestoreFromBackupToolStripMenuItem"
        Me.RestoreFromBackupToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.RestoreFromBackupToolStripMenuItem.Text = "&Restore from Back-up"
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.StatusStrip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatuslbl, Me.ToolStripStatuslblUsername, Me.ToolStripStatusLabel1, Me.ToolStripStatuslblLevel, Me.ToolStripStatusLabel2, Me.ToolStripStatuslblDate, Me.ToolStripStatusUserId, Me.ToolStripStatusLabel3, Me.OccupiedToolStripStatusLabel, Me.ToolStripStatusLabel6, Me.VacantToolStripStatusLabel, Me.ToolStripStatusLabel4, Me.ReservedToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 624)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip.Size = New System.Drawing.Size(1221, 22)
        Me.StatusStrip.TabIndex = 62
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatuslbl
        '
        Me.ToolStripStatuslbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripStatuslbl.Image = CType(resources.GetObject("ToolStripStatuslbl.Image"), System.Drawing.Image)
        Me.ToolStripStatuslbl.Name = "ToolStripStatuslbl"
        Me.ToolStripStatuslbl.Size = New System.Drawing.Size(89, 17)
        Me.ToolStripStatuslbl.Text = "Username:"
        '
        'ToolStripStatuslblUsername
        '
        Me.ToolStripStatuslblUsername.Name = "ToolStripStatuslblUsername"
        Me.ToolStripStatuslblUsername.Size = New System.Drawing.Size(33, 17)
        Me.ToolStripStatuslblUsername.Text = "-----"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripStatusLabel1.Image = CType(resources.GetObject("ToolStripStatusLabel1.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(60, 17)
        Me.ToolStripStatusLabel1.Text = "Level:"
        '
        'ToolStripStatuslblLevel
        '
        Me.ToolStripStatuslblLevel.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatuslblLevel.Name = "ToolStripStatuslblLevel"
        Me.ToolStripStatuslblLevel.Size = New System.Drawing.Size(33, 17)
        Me.ToolStripStatuslblLevel.Text = "-----"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Image = CType(resources.GetObject("ToolStripStatusLabel2.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(119, 17)
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
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(77, 17)
        Me.ToolStripStatusLabel3.Text = "Occupied:  "
        '
        'OccupiedToolStripStatusLabel
        '
        Me.OccupiedToolStripStatusLabel.Name = "OccupiedToolStripStatusLabel"
        Me.OccupiedToolStripStatusLabel.Size = New System.Drawing.Size(15, 17)
        Me.OccupiedToolStripStatusLabel.Text = "0"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(62, 17)
        Me.ToolStripStatusLabel6.Text = "Vacant:  "
        '
        'VacantToolStripStatusLabel
        '
        Me.VacantToolStripStatusLabel.Name = "VacantToolStripStatusLabel"
        Me.VacantToolStripStatusLabel.Size = New System.Drawing.Size(15, 17)
        Me.VacantToolStripStatusLabel.Text = "0"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(75, 17)
        Me.ToolStripStatusLabel4.Text = "Reserved:  "
        '
        'ReservedToolStripStatusLabel
        '
        Me.ReservedToolStripStatusLabel.Name = "ReservedToolStripStatusLabel"
        Me.ReservedToolStripStatusLabel.Size = New System.Drawing.Size(15, 17)
        Me.ReservedToolStripStatusLabel.Text = "0"
        '
        'tmNow
        '
        Me.tmNow.Enabled = True
        '
        'frmRoomMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 646)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MS)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRoomMonitoring"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Monitoring"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CMS.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.CMSReminders.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitConTopRight.Panel1.ResumeLayout(False)
        Me.SplitConTopRight.Panel2.ResumeLayout(False)
        CType(Me.SplitConTopRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitConTopRight.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.CMSReservation.ResumeLayout(False)
        Me.CMSRoomCleaning.ResumeLayout(False)
        Me.MS.ResumeLayout(False)
        Me.MS.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstvwImage As System.Windows.Forms.ListView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UserMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OccupyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblEquipments As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblFloor As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents lblExtraBed As System.Windows.Forms.Label
    Friend WithEvents lblDB As System.Windows.Forms.Label
    Friend WithEvents lblSB As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNights As System.Windows.Forms.Label
    Friend WithEvents lblCheckOut As System.Windows.Forms.Label
    Friend WithEvents lblCheckIn As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lstvw As System.Windows.Forms.ListView
    Friend WithEvents GenID As System.Windows.Forms.ColumnHeader
    Friend WithEvents RoomNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Floor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Rate As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents Nights As System.Windows.Forms.ColumnHeader
    Friend WithEvents Paid As System.Windows.Forms.ColumnHeader
    Friend WithEvents Advance As System.Windows.Forms.ColumnHeader
    Friend WithEvents LocalTax As System.Windows.Forms.ColumnHeader
    Friend WithEvents PaymentType As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents lstvwReservation As System.Windows.Forms.ListView
    Friend WithEvents ResId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ResRoom As System.Windows.Forms.ColumnHeader
    Friend WithEvents ResFloor As System.Windows.Forms.ColumnHeader
    Friend WithEvents RestRate As System.Windows.Forms.ColumnHeader
    Friend WithEvents ResDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents ResNights As System.Windows.Forms.ColumnHeader
    Friend WithEvents ResPaid As System.Windows.Forms.ColumnHeader
    Friend WithEvents ResAdvance As System.Windows.Forms.ColumnHeader
    Friend WithEvents ResLocalTax As System.Windows.Forms.ColumnHeader
    Friend WithEvents ResPaymentType As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchReservation As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbxCheckStatus As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDateSearch As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMSReservation As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddResToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditResToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteResToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshResToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResIN As System.Windows.Forms.ColumnHeader
    Friend WithEvents ResOut As System.Windows.Forms.ColumnHeader
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents lstvwReminders As System.Windows.Forms.ListView
    Friend WithEvents RemID As System.Windows.Forms.ColumnHeader
    Friend WithEvents RemTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents Remarks As System.Windows.Forms.ColumnHeader
    Friend WithEvents CMSReminders As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddRemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditRemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelRemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshRemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents tmReminder As System.Windows.Forms.Timer
    Friend WithEvents dtpDateRem As System.Windows.Forms.DateTimePicker
    Friend WithEvents SplitConTopRight As System.Windows.Forms.SplitContainer
    Friend WithEvents lstvwRoomAlarm As System.Windows.Forms.ListView
    Friend WithEvents AlarmRoomNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents tmRoomAlarm As System.Windows.Forms.Timer
    Friend WithEvents AlarmCheckOUT As System.Windows.Forms.ColumnHeader
    Friend WithEvents CheckOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents lstvwRoomCleaning As System.Windows.Forms.ListView
    Friend WithEvents RCId As System.Windows.Forms.ColumnHeader
    Friend WithEvents RCStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents RCBeddings As System.Windows.Forms.ColumnHeader
    Friend WithEvents RCRoomNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents CMSRoomCleaning As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearTaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelTaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshTaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MS As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserAccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeCheckingTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatuslbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatuslblUsername As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatuslblLevel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatuslblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusUserId As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmNow As System.Windows.Forms.Timer
    Friend WithEvents cmbxReservationStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbxSearchField As System.Windows.Forms.ComboBox
    Friend WithEvents ResStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents AddTaskToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomsLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResCustomerName As System.Windows.Forms.ColumnHeader
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreFromBackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportHeaderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaskLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblRoomType As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents AdvancePaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResCheckIn As System.Windows.Forms.ColumnHeader
    Friend WithEvents ResCheckOut As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CleaningLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeletionAccessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowReservToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CashCountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents OccupiedToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents VacantToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ReservedToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lstbxCustomer As System.Windows.Forms.ListBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogBook))
        Me.lstvw = New System.Windows.Forms.ListView()
        Me.GenID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RoomNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CheckIn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CheckOut = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Floor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Rate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nights = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Paid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Advance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LocalTax = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PaymentType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UserMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTotalRecord = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbxSearchField = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbxReservationStatus = New System.Windows.Forms.ComboBox()
        Me.cmbxCheckStatus = New System.Windows.Forms.ComboBox()
        Me.dtpDateSearch = New System.Windows.Forms.DateTimePicker()
        Me.btnSearchReservation = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DatePaid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvw
        '
        Me.lstvw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.GenID, Me.RoomNo, Me.CheckIn, Me.CheckOut, Me.Floor, Me.Rate, Me.Description, Me.Nights, Me.Paid, Me.Advance, Me.LocalTax, Me.PaymentType, Me.Status, Me.DatePaid})
        Me.lstvw.ContextMenuStrip = Me.CMS
        Me.lstvw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvw.FullRowSelect = True
        Me.lstvw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvw.Location = New System.Drawing.Point(12, 57)
        Me.lstvw.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.lstvw.MultiSelect = False
        Me.lstvw.Name = "lstvw"
        Me.lstvw.Size = New System.Drawing.Size(923, 296)
        Me.lstvw.TabIndex = 4
        Me.lstvw.UseCompatibleStateImageBehavior = False
        Me.lstvw.View = System.Windows.Forms.View.Details
        '
        'GenID
        '
        Me.GenID.Text = "Control #"
        Me.GenID.Width = 100
        '
        'RoomNo
        '
        Me.RoomNo.Text = "Room"
        Me.RoomNo.Width = 106
        '
        'CheckIn
        '
        Me.CheckIn.Text = "CheckIn"
        Me.CheckIn.Width = 150
        '
        'CheckOut
        '
        Me.CheckOut.Text = "Check-Out"
        Me.CheckOut.Width = 150
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
        'CMS
        '
        Me.CMS.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserMenuToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(191, 148)
        '
        'UserMenuToolStripMenuItem
        '
        Me.UserMenuToolStripMenuItem.Enabled = False
        Me.UserMenuToolStripMenuItem.Name = "UserMenuToolStripMenuItem"
        Me.UserMenuToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UserMenuToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.UserMenuToolStripMenuItem.Text = "Log Book"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(187, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.add
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AddToolStripMenuItem.Text = "&Add new log"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.page_white_edit
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.EditToolStripMenuItem.Text = "&Edit selected log"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.delete
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete selected log"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(187, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.arrow_refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh list of log"
        '
        'lblTotalRecord
        '
        Me.lblTotalRecord.AutoSize = True
        Me.lblTotalRecord.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRecord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalRecord.Location = New System.Drawing.Point(116, 359)
        Me.lblTotalRecord.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalRecord.Name = "lblTotalRecord"
        Me.lblTotalRecord.Size = New System.Drawing.Size(15, 16)
        Me.lblTotalRecord.TabIndex = 33
        Me.lblTotalRecord.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 359)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Total record(s):"
        '
        'cmbxSearchField
        '
        Me.cmbxSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSearchField.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxSearchField.ForeColor = System.Drawing.Color.Navy
        Me.cmbxSearchField.FormattingEnabled = True
        Me.cmbxSearchField.Items.AddRange(New Object() {"ControlNo", "RoomNo", "CustomerName", "Rate", "Floor", "Description", "Nights", "PaymentType"})
        Me.cmbxSearchField.Location = New System.Drawing.Point(235, 23)
        Me.cmbxSearchField.Name = "cmbxSearchField"
        Me.cmbxSearchField.Size = New System.Drawing.Size(102, 23)
        Me.cmbxSearchField.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(663, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 15)
        Me.Label1.TabIndex = 39
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
        Me.cmbxReservationStatus.Location = New System.Drawing.Point(800, 24)
        Me.cmbxReservationStatus.Name = "cmbxReservationStatus"
        Me.cmbxReservationStatus.Size = New System.Drawing.Size(137, 23)
        Me.cmbxReservationStatus.TabIndex = 38
        '
        'cmbxCheckStatus
        '
        Me.cmbxCheckStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxCheckStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxCheckStatus.ForeColor = System.Drawing.Color.Navy
        Me.cmbxCheckStatus.FormattingEnabled = True
        Me.cmbxCheckStatus.Items.AddRange(New Object() {"All", "Check-In", "Check-Out"})
        Me.cmbxCheckStatus.Location = New System.Drawing.Point(424, 25)
        Me.cmbxCheckStatus.Name = "cmbxCheckStatus"
        Me.cmbxCheckStatus.Size = New System.Drawing.Size(117, 23)
        Me.cmbxCheckStatus.TabIndex = 37
        '
        'dtpDateSearch
        '
        Me.dtpDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateSearch.Location = New System.Drawing.Point(547, 25)
        Me.dtpDateSearch.Name = "dtpDateSearch"
        Me.dtpDateSearch.Size = New System.Drawing.Size(105, 20)
        Me.dtpDateSearch.TabIndex = 36
        '
        'btnSearchReservation
        '
        Me.btnSearchReservation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchReservation.Location = New System.Drawing.Point(343, 23)
        Me.btnSearchReservation.Name = "btnSearchReservation"
        Me.btnSearchReservation.Size = New System.Drawing.Size(60, 23)
        Me.btnSearchReservation.TabIndex = 35
        Me.btnSearchReservation.Text = "Search"
        Me.btnSearchReservation.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(14, 24)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(215, 20)
        Me.txtSearch.TabIndex = 34
        '
        'DatePaid
        '
        Me.DatePaid.Text = "Date Paid"
        Me.DatePaid.Width = 100
        '
        'frmLogBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(949, 384)
        Me.Controls.Add(Me.cmbxSearchField)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbxReservationStatus)
        Me.Controls.Add(Me.cmbxCheckStatus)
        Me.Controls.Add(Me.dtpDateSearch)
        Me.Controls.Add(Me.btnSearchReservation)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblTotalRecord)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstvw)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Log Book"
        Me.CMS.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstvw As System.Windows.Forms.ListView
    Friend WithEvents GenID As System.Windows.Forms.ColumnHeader
    Friend WithEvents RoomNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Floor As System.Windows.Forms.ColumnHeader
    Friend WithEvents CMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UserMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Rate As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents Nights As System.Windows.Forms.ColumnHeader
    Friend WithEvents Paid As System.Windows.Forms.ColumnHeader
    Friend WithEvents Advance As System.Windows.Forms.ColumnHeader
    Friend WithEvents LocalTax As System.Windows.Forms.ColumnHeader
    Friend WithEvents PaymentType As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTotalRecord As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbxSearchField As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbxReservationStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbxCheckStatus As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDateSearch As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSearchReservation As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents CheckIn As System.Windows.Forms.ColumnHeader
    Friend WithEvents CheckOut As System.Windows.Forms.ColumnHeader
    Friend WithEvents DatePaid As System.Windows.Forms.ColumnHeader
End Class

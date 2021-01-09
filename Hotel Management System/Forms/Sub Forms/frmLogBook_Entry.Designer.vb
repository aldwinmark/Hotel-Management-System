<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogBook_Entry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogBook_Entry))
        Me.cmbxRoomNo = New System.Windows.Forms.ComboBox()
        Me.grpbxDetails = New System.Windows.Forms.GroupBox()
        Me.lblRoomType = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblFloor = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblExtraB = New System.Windows.Forms.Label()
        Me.lblDB = New System.Windows.Forms.Label()
        Me.lblSB = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblRoomDescription = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblRoomEquipments = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpbxReservation = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.nudNights = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.dtpCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.grpbxCustomer = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstvwCustomer = New System.Windows.Forms.ListView()
        Me.Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CustomerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMSCustomer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UserMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpbxComments = New System.Windows.Forms.GroupBox()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.tblcntrlPayments = New System.Windows.Forms.TabControl()
        Me.tbpgPayment = New System.Windows.Forms.TabPage()
        Me.pnOption = New System.Windows.Forms.Panel()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.cmbxPaymentType = New System.Windows.Forms.ComboBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txtLocalTax = New System.Windows.Forms.TextBox()
        Me.txtAmountPaid = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblAmountDue = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.grpbxOthers = New System.Windows.Forms.GroupBox()
        Me.txtReferenceID = New System.Windows.Forms.TextBox()
        Me.dtpDateOthers = New System.Windows.Forms.DateTimePicker()
        Me.txtOthersDescription = New System.Windows.Forms.TextBox()
        Me.txtAmountOthers = New System.Windows.Forms.TextBox()
        Me.lstvwOthers = New System.Windows.Forms.ListView()
        Me.OthersId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateInput = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ReferenceID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMSOthers = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteOtherItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cmbxReservationStatus = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lblAmountDueWtTax = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblLocalTax = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.lblNoOfNights = New System.Windows.Forms.Label()
        Me.lblTotalAccomodation = New System.Windows.Forms.Label()
        Me.lblExtras = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbpgAdvances = New System.Windows.Forms.TabPage()
        Me.grpbxAdvancePayment = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAdvance = New System.Windows.Forms.TextBox()
        Me.lstvwAdvances = New System.Windows.Forms.ListView()
        Me.colmAdvDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PaymentType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colmAdvAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMSAdvances = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItemAddAdv = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemDeleteAdv = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOccupy = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.colmnReceivedBy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpbxDetails.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpbxReservation.SuspendLayout()
        CType(Me.nudNights, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxCustomer.SuspendLayout()
        Me.CMSCustomer.SuspendLayout()
        Me.grpbxComments.SuspendLayout()
        Me.tblcntrlPayments.SuspendLayout()
        Me.tbpgPayment.SuspendLayout()
        Me.pnOption.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.grpbxOthers.SuspendLayout()
        Me.CMSOthers.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.tbpgAdvances.SuspendLayout()
        Me.grpbxAdvancePayment.SuspendLayout()
        Me.CMSAdvances.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbxRoomNo
        '
        Me.cmbxRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxRoomNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxRoomNo.FormattingEnabled = True
        Me.cmbxRoomNo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbxRoomNo.Location = New System.Drawing.Point(10, 49)
        Me.cmbxRoomNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbxRoomNo.Name = "cmbxRoomNo"
        Me.cmbxRoomNo.Size = New System.Drawing.Size(91, 24)
        Me.cmbxRoomNo.TabIndex = 0
        '
        'grpbxDetails
        '
        Me.grpbxDetails.BackColor = System.Drawing.Color.Transparent
        Me.grpbxDetails.Controls.Add(Me.lblRoomType)
        Me.grpbxDetails.Controls.Add(Me.Label7)
        Me.grpbxDetails.Controls.Add(Me.lblFloor)
        Me.grpbxDetails.Controls.Add(Me.Label2)
        Me.grpbxDetails.Controls.Add(Me.lblRate)
        Me.grpbxDetails.Controls.Add(Me.Label9)
        Me.grpbxDetails.Controls.Add(Me.GroupBox2)
        Me.grpbxDetails.Controls.Add(Me.GroupBox4)
        Me.grpbxDetails.Controls.Add(Me.GroupBox3)
        Me.grpbxDetails.Controls.Add(Me.cmbxRoomNo)
        Me.grpbxDetails.Controls.Add(Me.Label3)
        Me.grpbxDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxDetails.Location = New System.Drawing.Point(12, 3)
        Me.grpbxDetails.Name = "grpbxDetails"
        Me.grpbxDetails.Size = New System.Drawing.Size(529, 177)
        Me.grpbxDetails.TabIndex = 0
        Me.grpbxDetails.TabStop = False
        Me.grpbxDetails.Text = "Room Details"
        '
        'lblRoomType
        '
        Me.lblRoomType.BackColor = System.Drawing.Color.White
        Me.lblRoomType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomType.ForeColor = System.Drawing.Color.Black
        Me.lblRoomType.Location = New System.Drawing.Point(334, 87)
        Me.lblRoomType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRoomType.Name = "lblRoomType"
        Me.lblRoomType.Size = New System.Drawing.Size(189, 25)
        Me.lblRoomType.TabIndex = 37
        Me.lblRoomType.Text = "-------"
        Me.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(261, 91)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Room type:"
        '
        'lblFloor
        '
        Me.lblFloor.BackColor = System.Drawing.Color.White
        Me.lblFloor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFloor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFloor.ForeColor = System.Drawing.Color.Black
        Me.lblFloor.Location = New System.Drawing.Point(204, 87)
        Me.lblFloor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFloor.Name = "lblFloor"
        Me.lblFloor.Size = New System.Drawing.Size(45, 25)
        Me.lblFloor.TabIndex = 35
        Me.lblFloor.Text = "0"
        Me.lblFloor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(160, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Floor:"
        '
        'lblRate
        '
        Me.lblRate.BackColor = System.Drawing.Color.White
        Me.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.ForeColor = System.Drawing.Color.Red
        Me.lblRate.Location = New System.Drawing.Point(55, 87)
        Me.lblRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(97, 25)
        Me.lblRate.TabIndex = 33
        Me.lblRate.Text = "0.00"
        Me.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(7, 91)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Rate:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblExtraB)
        Me.GroupBox2.Controls.Add(Me.lblDB)
        Me.GroupBox2.Controls.Add(Me.lblSB)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(108, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 54)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "No. of beds"
        '
        'lblExtraB
        '
        Me.lblExtraB.BackColor = System.Drawing.Color.White
        Me.lblExtraB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblExtraB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtraB.ForeColor = System.Drawing.Color.Black
        Me.lblExtraB.Location = New System.Drawing.Point(370, 21)
        Me.lblExtraB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExtraB.Name = "lblExtraB"
        Me.lblExtraB.Size = New System.Drawing.Size(32, 20)
        Me.lblExtraB.TabIndex = 33
        Me.lblExtraB.Text = "0"
        Me.lblExtraB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDB
        '
        Me.lblDB.BackColor = System.Drawing.Color.White
        Me.lblDB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDB.ForeColor = System.Drawing.Color.Black
        Me.lblDB.Location = New System.Drawing.Point(239, 21)
        Me.lblDB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDB.Name = "lblDB"
        Me.lblDB.Size = New System.Drawing.Size(32, 20)
        Me.lblDB.TabIndex = 32
        Me.lblDB.Text = "0"
        Me.lblDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSB
        '
        Me.lblSB.BackColor = System.Drawing.Color.White
        Me.lblSB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSB.ForeColor = System.Drawing.Color.Black
        Me.lblSB.Location = New System.Drawing.Point(109, 21)
        Me.lblSB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSB.Name = "lblSB"
        Me.lblSB.Size = New System.Drawing.Size(32, 20)
        Me.lblSB.TabIndex = 31
        Me.lblSB.Text = "0"
        Me.lblSB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(279, 23)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Extra bed(s):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(149, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Double(DB):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Single(SB):"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblRoomDescription)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 119)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(253, 48)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Description"
        '
        'lblRoomDescription
        '
        Me.lblRoomDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblRoomDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomDescription.ForeColor = System.Drawing.Color.Black
        Me.lblRoomDescription.Location = New System.Drawing.Point(18, 22)
        Me.lblRoomDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRoomDescription.Name = "lblRoomDescription"
        Me.lblRoomDescription.Size = New System.Drawing.Size(225, 16)
        Me.lblRoomDescription.TabIndex = 30
        Me.lblRoomDescription.Text = "--------------"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblRoomEquipments)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(275, 119)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 48)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Equipments"
        '
        'lblRoomEquipments
        '
        Me.lblRoomEquipments.BackColor = System.Drawing.Color.Transparent
        Me.lblRoomEquipments.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomEquipments.ForeColor = System.Drawing.Color.Black
        Me.lblRoomEquipments.Location = New System.Drawing.Point(10, 18)
        Me.lblRoomEquipments.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRoomEquipments.Name = "lblRoomEquipments"
        Me.lblRoomEquipments.Size = New System.Drawing.Size(225, 20)
        Me.lblRoomEquipments.TabIndex = 31
        Me.lblRoomEquipments.Text = "--------------"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Room No."
        '
        'grpbxReservation
        '
        Me.grpbxReservation.BackColor = System.Drawing.Color.Transparent
        Me.grpbxReservation.Controls.Add(Me.Label14)
        Me.grpbxReservation.Controls.Add(Me.nudNights)
        Me.grpbxReservation.Controls.Add(Me.Label13)
        Me.grpbxReservation.Controls.Add(Me.Label12)
        Me.grpbxReservation.Controls.Add(Me.dtpCheckOut)
        Me.grpbxReservation.Controls.Add(Me.dtpCheckIn)
        Me.grpbxReservation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxReservation.Location = New System.Drawing.Point(12, 184)
        Me.grpbxReservation.Name = "grpbxReservation"
        Me.grpbxReservation.Size = New System.Drawing.Size(529, 69)
        Me.grpbxReservation.TabIndex = 1
        Me.grpbxReservation.TabStop = False
        Me.grpbxReservation.Text = "Reservation Dates"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(468, 21)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 16)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Nights"
        '
        'nudNights
        '
        Me.nudNights.Location = New System.Drawing.Point(471, 40)
        Me.nudNights.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNights.Name = "nudNights"
        Me.nudNights.Size = New System.Drawing.Size(39, 21)
        Me.nudNights.TabIndex = 2
        Me.nudNights.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(231, 21)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 16)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Check-Out"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(7, 21)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 16)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Check-In"
        '
        'dtpCheckOut
        '
        Me.dtpCheckOut.Location = New System.Drawing.Point(234, 40)
        Me.dtpCheckOut.Name = "dtpCheckOut"
        Me.dtpCheckOut.Size = New System.Drawing.Size(222, 21)
        Me.dtpCheckOut.TabIndex = 1
        '
        'dtpCheckIn
        '
        Me.dtpCheckIn.Location = New System.Drawing.Point(6, 40)
        Me.dtpCheckIn.Name = "dtpCheckIn"
        Me.dtpCheckIn.Size = New System.Drawing.Size(222, 21)
        Me.dtpCheckIn.TabIndex = 0
        '
        'grpbxCustomer
        '
        Me.grpbxCustomer.BackColor = System.Drawing.Color.Transparent
        Me.grpbxCustomer.Controls.Add(Me.Label8)
        Me.grpbxCustomer.Controls.Add(Me.lstvwCustomer)
        Me.grpbxCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxCustomer.Location = New System.Drawing.Point(12, 259)
        Me.grpbxCustomer.Name = "grpbxCustomer"
        Me.grpbxCustomer.Size = New System.Drawing.Size(529, 166)
        Me.grpbxCustomer.TabIndex = 2
        Me.grpbxCustomer.TabStop = False
        Me.grpbxCustomer.Text = "Customer Data"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(105, 13)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(369, 15)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Note: The first customername on the list will be the main customer."
        '
        'lstvwCustomer
        '
        Me.lstvwCustomer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.CustomerName, Me.Address})
        Me.lstvwCustomer.ContextMenuStrip = Me.CMSCustomer
        Me.lstvwCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwCustomer.FullRowSelect = True
        Me.lstvwCustomer.GridLines = True
        Me.lstvwCustomer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwCustomer.Location = New System.Drawing.Point(8, 32)
        Me.lstvwCustomer.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.lstvwCustomer.MultiSelect = False
        Me.lstvwCustomer.Name = "lstvwCustomer"
        Me.lstvwCustomer.Size = New System.Drawing.Size(515, 124)
        Me.lstvwCustomer.TabIndex = 2
        Me.lstvwCustomer.UseCompatibleStateImageBehavior = False
        Me.lstvwCustomer.View = System.Windows.Forms.View.Details
        '
        'Id
        '
        Me.Id.Text = ""
        Me.Id.Width = 0
        '
        'CustomerName
        '
        Me.CustomerName.Text = "Name"
        Me.CustomerName.Width = 206
        '
        'Address
        '
        Me.Address.Text = "Address"
        Me.Address.Width = 294
        '
        'CMSCustomer
        '
        Me.CMSCustomer.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMSCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserMenuToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.CMSCustomer.Name = "CMS"
        Me.CMSCustomer.Size = New System.Drawing.Size(229, 76)
        '
        'UserMenuToolStripMenuItem
        '
        Me.UserMenuToolStripMenuItem.Enabled = False
        Me.UserMenuToolStripMenuItem.Name = "UserMenuToolStripMenuItem"
        Me.UserMenuToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UserMenuToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.UserMenuToolStripMenuItem.Text = "Customer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(225, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.add
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.AddToolStripMenuItem.Text = "&Add new customer"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.delete
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete selected customer"
        '
        'grpbxComments
        '
        Me.grpbxComments.BackColor = System.Drawing.Color.Transparent
        Me.grpbxComments.Controls.Add(Me.txtComment)
        Me.grpbxComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxComments.Location = New System.Drawing.Point(12, 424)
        Me.grpbxComments.Name = "grpbxComments"
        Me.grpbxComments.Size = New System.Drawing.Size(529, 79)
        Me.grpbxComments.TabIndex = 3
        Me.grpbxComments.TabStop = False
        Me.grpbxComments.Text = "Comments"
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(7, 17)
        Me.txtComment.MaxLength = 500
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComment.Size = New System.Drawing.Size(516, 55)
        Me.txtComment.TabIndex = 0
        '
        'tblcntrlPayments
        '
        Me.tblcntrlPayments.Controls.Add(Me.tbpgPayment)
        Me.tblcntrlPayments.Controls.Add(Me.tbpgAdvances)
        Me.tblcntrlPayments.Location = New System.Drawing.Point(550, 3)
        Me.tblcntrlPayments.Name = "tblcntrlPayments"
        Me.tblcntrlPayments.SelectedIndex = 0
        Me.tblcntrlPayments.Size = New System.Drawing.Size(492, 456)
        Me.tblcntrlPayments.TabIndex = 4
        '
        'tbpgPayment
        '
        Me.tbpgPayment.Controls.Add(Me.pnOption)
        Me.tbpgPayment.Location = New System.Drawing.Point(4, 22)
        Me.tbpgPayment.Name = "tbpgPayment"
        Me.tbpgPayment.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpgPayment.Size = New System.Drawing.Size(484, 430)
        Me.tbpgPayment.TabIndex = 0
        Me.tbpgPayment.Text = "Payment Option"
        Me.tbpgPayment.UseVisualStyleBackColor = True
        '
        'pnOption
        '
        Me.pnOption.BackColor = System.Drawing.Color.Transparent
        Me.pnOption.Controls.Add(Me.btnInvoice)
        Me.pnOption.Controls.Add(Me.GroupBox11)
        Me.pnOption.Controls.Add(Me.GroupBox9)
        Me.pnOption.Controls.Add(Me.lblAmountDue)
        Me.pnOption.Controls.Add(Me.Label37)
        Me.pnOption.Controls.Add(Me.grpbxOthers)
        Me.pnOption.Controls.Add(Me.GroupBox8)
        Me.pnOption.Controls.Add(Me.Label36)
        Me.pnOption.Controls.Add(Me.lblAmountDueWtTax)
        Me.pnOption.Controls.Add(Me.Label34)
        Me.pnOption.Controls.Add(Me.Label29)
        Me.pnOption.Controls.Add(Me.lblLocalTax)
        Me.pnOption.Controls.Add(Me.Label28)
        Me.pnOption.Controls.Add(Me.txtDiscount)
        Me.pnOption.Controls.Add(Me.lblNoOfNights)
        Me.pnOption.Controls.Add(Me.lblTotalAccomodation)
        Me.pnOption.Controls.Add(Me.lblExtras)
        Me.pnOption.Controls.Add(Me.lblGrandTotal)
        Me.pnOption.Controls.Add(Me.Label20)
        Me.pnOption.Controls.Add(Me.Label19)
        Me.pnOption.Controls.Add(Me.Label18)
        Me.pnOption.Controls.Add(Me.Label17)
        Me.pnOption.Controls.Add(Me.Label15)
        Me.pnOption.Controls.Add(Me.Label11)
        Me.pnOption.Location = New System.Drawing.Point(6, 7)
        Me.pnOption.Name = "pnOption"
        Me.pnOption.Size = New System.Drawing.Size(484, 423)
        Me.pnOption.TabIndex = 61
        '
        'btnInvoice
        '
        Me.btnInvoice.BackColor = System.Drawing.Color.Black
        Me.btnInvoice.BackgroundImage = CType(resources.GetObject("btnInvoice.BackgroundImage"), System.Drawing.Image)
        Me.btnInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvoice.ForeColor = System.Drawing.Color.White
        Me.btnInvoice.Image = Global.Hotel_Management_System.My.Resources.Resources.report
        Me.btnInvoice.Location = New System.Drawing.Point(349, 391)
        Me.btnInvoice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(125, 27)
        Me.btnInvoice.TabIndex = 7
        Me.btnInvoice.Text = "Print Statement"
        Me.btnInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInvoice.UseVisualStyleBackColor = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.cmbxPaymentType)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox11.Location = New System.Drawing.Point(3, 306)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(193, 54)
        Me.GroupBox11.TabIndex = 2
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Payment type"
        '
        'cmbxPaymentType
        '
        Me.cmbxPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxPaymentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxPaymentType.FormattingEnabled = True
        Me.cmbxPaymentType.Location = New System.Drawing.Point(10, 20)
        Me.cmbxPaymentType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbxPaymentType.Name = "cmbxPaymentType"
        Me.cmbxPaymentType.Size = New System.Drawing.Size(172, 24)
        Me.cmbxPaymentType.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txtLocalTax)
        Me.GroupBox9.Controls.Add(Me.txtAmountPaid)
        Me.GroupBox9.Controls.Add(Me.Label32)
        Me.GroupBox9.Controls.Add(Me.Label30)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox9.Location = New System.Drawing.Point(5, 4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(146, 149)
        Me.GroupBox9.TabIndex = 47
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Payment"
        '
        'txtLocalTax
        '
        Me.txtLocalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalTax.ForeColor = System.Drawing.Color.Red
        Me.txtLocalTax.Location = New System.Drawing.Point(6, 103)
        Me.txtLocalTax.Name = "txtLocalTax"
        Me.txtLocalTax.Size = New System.Drawing.Size(119, 22)
        Me.txtLocalTax.TabIndex = 2
        Me.txtLocalTax.Text = "0.00"
        Me.txtLocalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountPaid.ForeColor = System.Drawing.Color.Red
        Me.txtAmountPaid.Location = New System.Drawing.Point(6, 51)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.ReadOnly = True
        Me.txtAmountPaid.Size = New System.Drawing.Size(119, 22)
        Me.txtAmountPaid.TabIndex = 0
        Me.txtAmountPaid.Text = "0.00"
        Me.txtAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(7, 85)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(60, 15)
        Me.Label32.TabIndex = 46
        Me.Label32.Text = "Local Tax"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(7, 32)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(77, 15)
        Me.Label30.TabIndex = 43
        Me.Label30.Text = "Amount Paid"
        '
        'lblAmountDue
        '
        Me.lblAmountDue.BackColor = System.Drawing.Color.Transparent
        Me.lblAmountDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountDue.ForeColor = System.Drawing.Color.Red
        Me.lblAmountDue.Location = New System.Drawing.Point(377, 318)
        Me.lblAmountDue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmountDue.Name = "lblAmountDue"
        Me.lblAmountDue.Size = New System.Drawing.Size(96, 16)
        Me.lblAmountDue.TabIndex = 60
        Me.lblAmountDue.Text = "0.00"
        Me.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Blue
        Me.Label37.Location = New System.Drawing.Point(276, 318)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(121, 16)
        Me.Label37.TabIndex = 59
        Me.Label37.Text = "Amount due:     ="
        '
        'grpbxOthers
        '
        Me.grpbxOthers.Controls.Add(Me.txtReferenceID)
        Me.grpbxOthers.Controls.Add(Me.dtpDateOthers)
        Me.grpbxOthers.Controls.Add(Me.txtOthersDescription)
        Me.grpbxOthers.Controls.Add(Me.txtAmountOthers)
        Me.grpbxOthers.Controls.Add(Me.lstvwOthers)
        Me.grpbxOthers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxOthers.Location = New System.Drawing.Point(3, 154)
        Me.grpbxOthers.Name = "grpbxOthers"
        Me.grpbxOthers.Size = New System.Drawing.Size(472, 152)
        Me.grpbxOthers.TabIndex = 1
        Me.grpbxOthers.TabStop = False
        Me.grpbxOthers.Text = "Others"
        '
        'txtReferenceID
        '
        Me.txtReferenceID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferenceID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenceID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtReferenceID.Location = New System.Drawing.Point(108, 18)
        Me.txtReferenceID.MaxLength = 50
        Me.txtReferenceID.Name = "txtReferenceID"
        Me.txtReferenceID.Size = New System.Drawing.Size(74, 22)
        Me.txtReferenceID.TabIndex = 1
        '
        'dtpDateOthers
        '
        Me.dtpDateOthers.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateOthers.Location = New System.Drawing.Point(10, 18)
        Me.dtpDateOthers.Name = "dtpDateOthers"
        Me.dtpDateOthers.Size = New System.Drawing.Size(92, 21)
        Me.dtpDateOthers.TabIndex = 0
        '
        'txtOthersDescription
        '
        Me.txtOthersDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOthersDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOthersDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOthersDescription.Location = New System.Drawing.Point(188, 18)
        Me.txtOthersDescription.MaxLength = 50
        Me.txtOthersDescription.Name = "txtOthersDescription"
        Me.txtOthersDescription.Size = New System.Drawing.Size(206, 22)
        Me.txtOthersDescription.TabIndex = 2
        '
        'txtAmountOthers
        '
        Me.txtAmountOthers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountOthers.ForeColor = System.Drawing.Color.Red
        Me.txtAmountOthers.Location = New System.Drawing.Point(400, 18)
        Me.txtAmountOthers.Name = "txtAmountOthers"
        Me.txtAmountOthers.Size = New System.Drawing.Size(64, 22)
        Me.txtAmountOthers.TabIndex = 3
        Me.txtAmountOthers.Text = "0.00"
        Me.txtAmountOthers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lstvwOthers
        '
        Me.lstvwOthers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OthersId, Me.DateInput, Me.ReferenceID, Me.ItemDescription, Me.ItemAmount})
        Me.lstvwOthers.ContextMenuStrip = Me.CMSOthers
        Me.lstvwOthers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwOthers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwOthers.FullRowSelect = True
        Me.lstvwOthers.GridLines = True
        Me.lstvwOthers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwOthers.Location = New System.Drawing.Point(10, 44)
        Me.lstvwOthers.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.lstvwOthers.MultiSelect = False
        Me.lstvwOthers.Name = "lstvwOthers"
        Me.lstvwOthers.Size = New System.Drawing.Size(454, 99)
        Me.lstvwOthers.TabIndex = 30
        Me.lstvwOthers.UseCompatibleStateImageBehavior = False
        Me.lstvwOthers.View = System.Windows.Forms.View.Details
        '
        'OthersId
        '
        Me.OthersId.Text = ""
        Me.OthersId.Width = 0
        '
        'DateInput
        '
        Me.DateInput.Text = "Date"
        Me.DateInput.Width = 100
        '
        'ReferenceID
        '
        Me.ReferenceID.Text = "Ref. #"
        Me.ReferenceID.Width = 77
        '
        'ItemDescription
        '
        Me.ItemDescription.Text = "Description"
        Me.ItemDescription.Width = 190
        '
        'ItemAmount
        '
        Me.ItemAmount.Text = "Amount"
        Me.ItemAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ItemAmount.Width = 79
        '
        'CMSOthers
        '
        Me.CMSOthers.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMSOthers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator2, Me.DeleteOtherItemToolStripMenuItem})
        Me.CMSOthers.Name = "CMS"
        Me.CMSOthers.Size = New System.Drawing.Size(243, 76)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(242, 22)
        Me.ToolStripMenuItem1.Text = "Other Items"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(239, 6)
        '
        'DeleteOtherItemToolStripMenuItem
        '
        Me.DeleteOtherItemToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.delete
        Me.DeleteOtherItemToolStripMenuItem.Name = "DeleteOtherItemToolStripMenuItem"
        Me.DeleteOtherItemToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.DeleteOtherItemToolStripMenuItem.Text = "&Delete selected other Items"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cmbxReservationStatus)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(3, 362)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(193, 52)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Reservation Status"
        '
        'cmbxReservationStatus
        '
        Me.cmbxReservationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxReservationStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxReservationStatus.FormattingEnabled = True
        Me.cmbxReservationStatus.Items.AddRange(New Object() {"<select>", "Vacant", "Occupied", "Reserved", "Paid"})
        Me.cmbxReservationStatus.Location = New System.Drawing.Point(7, 18)
        Me.cmbxReservationStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbxReservationStatus.Name = "cmbxReservationStatus"
        Me.cmbxReservationStatus.Size = New System.Drawing.Size(175, 24)
        Me.cmbxReservationStatus.TabIndex = 0
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Black
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(374, 125)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(93, 2)
        Me.Label36.TabIndex = 58
        '
        'lblAmountDueWtTax
        '
        Me.lblAmountDueWtTax.BackColor = System.Drawing.Color.Transparent
        Me.lblAmountDueWtTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountDueWtTax.ForeColor = System.Drawing.Color.Red
        Me.lblAmountDueWtTax.Location = New System.Drawing.Point(377, 368)
        Me.lblAmountDueWtTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmountDueWtTax.Name = "lblAmountDueWtTax"
        Me.lblAmountDueWtTax.Size = New System.Drawing.Size(96, 16)
        Me.lblAmountDueWtTax.TabIndex = 57
        Me.lblAmountDueWtTax.Text = "0.00"
        Me.lblAmountDueWtTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(206, 368)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(176, 16)
        Me.Label34.TabIndex = 55
        Me.Label34.Text = "Amount due incl. local tax:   ="
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Black
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(311, 363)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(93, 2)
        Me.Label29.TabIndex = 54
        '
        'lblLocalTax
        '
        Me.lblLocalTax.BackColor = System.Drawing.Color.Transparent
        Me.lblLocalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalTax.ForeColor = System.Drawing.Color.Red
        Me.lblLocalTax.Location = New System.Drawing.Point(377, 344)
        Me.lblLocalTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLocalTax.Name = "lblLocalTax"
        Me.lblLocalTax.Size = New System.Drawing.Size(96, 16)
        Me.lblLocalTax.TabIndex = 53
        Me.lblLocalTax.Text = "0.00"
        Me.lblLocalTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(288, 344)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(92, 16)
        Me.Label28.TabIndex = 52
        Me.Label28.Text = "Local Tax:     +"
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.Red
        Me.txtDiscount.Location = New System.Drawing.Point(381, 97)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(89, 22)
        Me.txtDiscount.TabIndex = 0
        Me.txtDiscount.Text = "0.00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNoOfNights
        '
        Me.lblNoOfNights.BackColor = System.Drawing.Color.Transparent
        Me.lblNoOfNights.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfNights.ForeColor = System.Drawing.Color.Black
        Me.lblNoOfNights.Location = New System.Drawing.Point(416, 25)
        Me.lblNoOfNights.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoOfNights.Name = "lblNoOfNights"
        Me.lblNoOfNights.Size = New System.Drawing.Size(54, 16)
        Me.lblNoOfNights.TabIndex = 46
        Me.lblNoOfNights.Text = "1"
        Me.lblNoOfNights.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalAccomodation
        '
        Me.lblTotalAccomodation.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAccomodation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAccomodation.ForeColor = System.Drawing.Color.Red
        Me.lblTotalAccomodation.Location = New System.Drawing.Point(374, 52)
        Me.lblTotalAccomodation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalAccomodation.Name = "lblTotalAccomodation"
        Me.lblTotalAccomodation.Size = New System.Drawing.Size(96, 16)
        Me.lblTotalAccomodation.TabIndex = 44
        Me.lblTotalAccomodation.Text = "0.00"
        Me.lblTotalAccomodation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblExtras
        '
        Me.lblExtras.BackColor = System.Drawing.Color.Transparent
        Me.lblExtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtras.ForeColor = System.Drawing.Color.Red
        Me.lblExtras.Location = New System.Drawing.Point(375, 76)
        Me.lblExtras.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExtras.Name = "lblExtras"
        Me.lblExtras.Size = New System.Drawing.Size(96, 16)
        Me.lblExtras.TabIndex = 42
        Me.lblExtras.Text = "0.00"
        Me.lblExtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.ForeColor = System.Drawing.Color.Red
        Me.lblGrandTotal.Location = New System.Drawing.Point(378, 129)
        Me.lblGrandTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(96, 16)
        Me.lblGrandTotal.TabIndex = 41
        Me.lblGrandTotal.Text = "0.00"
        Me.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(292, 97)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 16)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Discount:     -"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(111, 166)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 16)
        Me.Label19.TabIndex = 38
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(273, 129)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 16)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Grand Total:     ="
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(307, 76)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 16)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Extras:     +"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(224, 52)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(153, 16)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Total accomodation:     ="
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(261, 25)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 16)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "No. of night(s):     x"
        '
        'tbpgAdvances
        '
        Me.tbpgAdvances.Controls.Add(Me.grpbxAdvancePayment)
        Me.tbpgAdvances.Location = New System.Drawing.Point(4, 22)
        Me.tbpgAdvances.Name = "tbpgAdvances"
        Me.tbpgAdvances.Size = New System.Drawing.Size(484, 430)
        Me.tbpgAdvances.TabIndex = 1
        Me.tbpgAdvances.Text = "Advances"
        Me.tbpgAdvances.UseVisualStyleBackColor = True
        '
        'grpbxAdvancePayment
        '
        Me.grpbxAdvancePayment.Controls.Add(Me.Label6)
        Me.grpbxAdvancePayment.Controls.Add(Me.txtAdvance)
        Me.grpbxAdvancePayment.Controls.Add(Me.lstvwAdvances)
        Me.grpbxAdvancePayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxAdvancePayment.Location = New System.Drawing.Point(6, 6)
        Me.grpbxAdvancePayment.Name = "grpbxAdvancePayment"
        Me.grpbxAdvancePayment.Size = New System.Drawing.Size(472, 421)
        Me.grpbxAdvancePayment.TabIndex = 2
        Me.grpbxAdvancePayment.TabStop = False
        Me.grpbxAdvancePayment.Text = "Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 394)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 15)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Total:"
        '
        'txtAdvance
        '
        Me.txtAdvance.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtAdvance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdvance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdvance.ForeColor = System.Drawing.Color.Red
        Me.txtAdvance.Location = New System.Drawing.Point(51, 391)
        Me.txtAdvance.Name = "txtAdvance"
        Me.txtAdvance.ReadOnly = True
        Me.txtAdvance.Size = New System.Drawing.Size(413, 22)
        Me.txtAdvance.TabIndex = 3
        Me.txtAdvance.Text = "0.00"
        Me.txtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lstvwAdvances
        '
        Me.lstvwAdvances.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colmAdvDate, Me.PaymentType, Me.colmnReceivedBy, Me.colmAdvAmount})
        Me.lstvwAdvances.ContextMenuStrip = Me.CMSAdvances
        Me.lstvwAdvances.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwAdvances.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwAdvances.FullRowSelect = True
        Me.lstvwAdvances.GridLines = True
        Me.lstvwAdvances.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwAdvances.Location = New System.Drawing.Point(10, 23)
        Me.lstvwAdvances.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.lstvwAdvances.MultiSelect = False
        Me.lstvwAdvances.Name = "lstvwAdvances"
        Me.lstvwAdvances.Size = New System.Drawing.Size(454, 361)
        Me.lstvwAdvances.TabIndex = 30
        Me.lstvwAdvances.UseCompatibleStateImageBehavior = False
        Me.lstvwAdvances.View = System.Windows.Forms.View.Details
        '
        'colmAdvDate
        '
        Me.colmAdvDate.Text = "Date"
        Me.colmAdvDate.Width = 150
        '
        'PaymentType
        '
        Me.PaymentType.Text = "Pay Type"
        Me.PaymentType.Width = 100
        '
        'colmAdvAmount
        '
        Me.colmAdvAmount.Text = "Amount"
        Me.colmAdvAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colmAdvAmount.Width = 100
        '
        'CMSAdvances
        '
        Me.CMSAdvances.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMSAdvances.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripSeparator3, Me.ToolStripMenuItemAddAdv, Me.ToolStripMenuItemDeleteAdv})
        Me.CMSAdvances.Name = "CMS"
        Me.CMSAdvances.Size = New System.Drawing.Size(227, 76)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Enabled = False
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(226, 22)
        Me.ToolStripMenuItem2.Text = "Advance Payment"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(223, 6)
        '
        'ToolStripMenuItemAddAdv
        '
        Me.ToolStripMenuItemAddAdv.Image = Global.Hotel_Management_System.My.Resources.Resources.add
        Me.ToolStripMenuItemAddAdv.Name = "ToolStripMenuItemAddAdv"
        Me.ToolStripMenuItemAddAdv.Size = New System.Drawing.Size(226, 22)
        Me.ToolStripMenuItemAddAdv.Text = "&Add advance payment"
        '
        'ToolStripMenuItemDeleteAdv
        '
        Me.ToolStripMenuItemDeleteAdv.Image = Global.Hotel_Management_System.My.Resources.Resources.delete
        Me.ToolStripMenuItemDeleteAdv.Name = "ToolStripMenuItemDeleteAdv"
        Me.ToolStripMenuItemDeleteAdv.Size = New System.Drawing.Size(226, 22)
        Me.ToolStripMenuItemDeleteAdv.Text = "&Delete advance payment"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Image = Global.Hotel_Management_System.My.Resources.Resources.cancel
        Me.btnCancel.Location = New System.Drawing.Point(936, 476)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 27)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOccupy
        '
        Me.btnOccupy.BackColor = System.Drawing.Color.Black
        Me.btnOccupy.BackgroundImage = CType(resources.GetObject("btnOccupy.BackgroundImage"), System.Drawing.Image)
        Me.btnOccupy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOccupy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOccupy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOccupy.ForeColor = System.Drawing.Color.White
        Me.btnOccupy.Image = Global.Hotel_Management_System.My.Resources.Resources.door_in
        Me.btnOccupy.Location = New System.Drawing.Point(554, 476)
        Me.btnOccupy.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOccupy.Name = "btnOccupy"
        Me.btnOccupy.Size = New System.Drawing.Size(238, 27)
        Me.btnOccupy.TabIndex = 8
        Me.btnOccupy.Text = "&Occupy Reservation"
        Me.btnOccupy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOccupy.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Black
        Me.btnEnter.BackgroundImage = CType(resources.GetObject("btnEnter.BackgroundImage"), System.Drawing.Image)
        Me.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.Image = Global.Hotel_Management_System.My.Resources.Resources.page_save
        Me.btnEnter.Location = New System.Drawing.Point(800, 476)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(128, 27)
        Me.btnEnter.TabIndex = 6
        Me.btnEnter.Text = "&Save"
        Me.btnEnter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'colmnReceivedBy
        '
        Me.colmnReceivedBy.Text = "Received by"
        Me.colmnReceivedBy.Width = 90
        '
        'frmLogBook_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1048, 509)
        Me.ControlBox = False
        Me.Controls.Add(Me.tblcntrlPayments)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOccupy)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.grpbxDetails)
        Me.Controls.Add(Me.grpbxComments)
        Me.Controls.Add(Me.grpbxCustomer)
        Me.Controls.Add(Me.grpbxReservation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogBook_Entry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log Book Add/Edit"
        Me.grpbxDetails.ResumeLayout(False)
        Me.grpbxDetails.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.grpbxReservation.ResumeLayout(False)
        Me.grpbxReservation.PerformLayout()
        CType(Me.nudNights, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxCustomer.ResumeLayout(False)
        Me.grpbxCustomer.PerformLayout()
        Me.CMSCustomer.ResumeLayout(False)
        Me.grpbxComments.ResumeLayout(False)
        Me.grpbxComments.PerformLayout()
        Me.tblcntrlPayments.ResumeLayout(False)
        Me.tbpgPayment.ResumeLayout(False)
        Me.pnOption.ResumeLayout(False)
        Me.pnOption.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.grpbxOthers.ResumeLayout(False)
        Me.grpbxOthers.PerformLayout()
        Me.CMSOthers.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.tbpgAdvances.ResumeLayout(False)
        Me.grpbxAdvancePayment.ResumeLayout(False)
        Me.grpbxAdvancePayment.PerformLayout()
        Me.CMSAdvances.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbxRoomNo As System.Windows.Forms.ComboBox
    Friend WithEvents grpbxDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblExtraB As System.Windows.Forms.Label
    Friend WithEvents lblDB As System.Windows.Forms.Label
    Friend WithEvents lblSB As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRoomDescription As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents grpbxReservation As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpCheckOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCheckIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents nudNights As System.Windows.Forms.NumericUpDown
    Friend WithEvents grpbxCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents lstvwCustomer As System.Windows.Forms.ListView
    Friend WithEvents Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents CustomerName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Address As System.Windows.Forms.ColumnHeader
    Friend WithEvents CMSCustomer As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UserMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpbxComments As System.Windows.Forms.GroupBox
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents tblcntrlPayments As System.Windows.Forms.TabControl
    Friend WithEvents tbpgPayment As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbxReservationStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblTotalAccomodation As System.Windows.Forms.Label
    Friend WithEvents lblExtras As System.Windows.Forms.Label
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblNoOfNights As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalTax As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lblLocalTax As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblAmountDue As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents grpbxOthers As System.Windows.Forms.GroupBox
    Friend WithEvents lstvwOthers As System.Windows.Forms.ListView
    Friend WithEvents ItemDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItemAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblAmountDueWtTax As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRoomEquipments As System.Windows.Forms.Label
    Friend WithEvents lblFloor As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRoomType As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtOthersDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountOthers As System.Windows.Forms.TextBox
    Friend WithEvents CMSOthers As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteOtherItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbxPaymentType As System.Windows.Forms.ComboBox
    Friend WithEvents OthersId As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtpDateOthers As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtReferenceID As System.Windows.Forms.TextBox
    Friend WithEvents DateInput As System.Windows.Forms.ColumnHeader
    Friend WithEvents ReferenceID As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnOccupy As System.Windows.Forms.Button
    Friend WithEvents btnInvoice As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbpgAdvances As System.Windows.Forms.TabPage
    Friend WithEvents grpbxAdvancePayment As System.Windows.Forms.GroupBox
    Friend WithEvents txtAdvance As System.Windows.Forms.TextBox
    Friend WithEvents lstvwAdvances As System.Windows.Forms.ListView
    Friend WithEvents colmAdvDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmAdvAmount As System.Windows.Forms.ColumnHeader
    Friend WithEvents CMSAdvances As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItemDeleteAdv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemAddAdv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnOption As System.Windows.Forms.Panel
    Friend WithEvents PaymentType As System.Windows.Forms.ColumnHeader
    Friend WithEvents colmnReceivedBy As System.Windows.Forms.ColumnHeader
End Class

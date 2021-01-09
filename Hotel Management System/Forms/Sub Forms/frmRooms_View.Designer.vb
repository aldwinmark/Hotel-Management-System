<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRooms_View
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRooms_View))
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UserMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstvw = New System.Windows.Forms.ListView()
        Me.Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Room = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Floor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Extra = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Rate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RoomStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalRecord = New System.Windows.Forms.Label()
        Me.CMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMS
        '
        Me.CMS.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserMenuToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(205, 126)
        '
        'UserMenuToolStripMenuItem
        '
        Me.UserMenuToolStripMenuItem.Enabled = False
        Me.UserMenuToolStripMenuItem.Name = "UserMenuToolStripMenuItem"
        Me.UserMenuToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UserMenuToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.UserMenuToolStripMenuItem.Text = "Rooms"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(201, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.add
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AddToolStripMenuItem.Text = "&Add new room"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.page_white_edit
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.EditToolStripMenuItem.Text = "&Edit selected room"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.delete
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete selected room"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(201, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.arrow_refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh list of room"
        '
        'lstvw
        '
        Me.lstvw.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.Room, Me.Floor, Me.Type, Me.SB, Me.DB, Me.Extra, Me.Description, Me.Rate, Me.RoomStatus})
        Me.lstvw.ContextMenuStrip = Me.CMS
        Me.lstvw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvw.ForeColor = System.Drawing.Color.Navy
        Me.lstvw.FullRowSelect = True
        Me.lstvw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvw.Location = New System.Drawing.Point(14, 15)
        Me.lstvw.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.lstvw.MultiSelect = False
        Me.lstvw.Name = "lstvw"
        Me.lstvw.Size = New System.Drawing.Size(828, 343)
        Me.lstvw.TabIndex = 5
        Me.lstvw.UseCompatibleStateImageBehavior = False
        Me.lstvw.View = System.Windows.Forms.View.Details
        '
        'Id
        '
        Me.Id.Text = ""
        Me.Id.Width = 0
        '
        'Room
        '
        Me.Room.Text = "Room"
        Me.Room.Width = 75
        '
        'Floor
        '
        Me.Floor.Text = "Floor"
        Me.Floor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Floor.Width = 61
        '
        'Type
        '
        Me.Type.Text = "Type"
        Me.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Type.Width = 141
        '
        'SB
        '
        Me.SB.Text = "SB"
        Me.SB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SB.Width = 41
        '
        'DB
        '
        Me.DB.Text = "DB"
        Me.DB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DB.Width = 42
        '
        'Extra
        '
        Me.Extra.Text = "Extra"
        Me.Extra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Extra.Width = 64
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 218
        '
        'Rate
        '
        Me.Rate.Text = "Rate"
        '
        'RoomStatus
        '
        Me.RoomStatus.Text = "Status"
        Me.RoomStatus.Width = 105
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 364)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Total record(s):"
        '
        'lblTotalRecord
        '
        Me.lblTotalRecord.AutoSize = True
        Me.lblTotalRecord.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRecord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalRecord.Location = New System.Drawing.Point(118, 364)
        Me.lblTotalRecord.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalRecord.Name = "lblTotalRecord"
        Me.lblTotalRecord.Size = New System.Drawing.Size(15, 16)
        Me.lblTotalRecord.TabIndex = 28
        Me.lblTotalRecord.Text = "0"
        '
        'frmRooms_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(856, 388)
        Me.Controls.Add(Me.lblTotalRecord)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstvw)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRooms_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rooms"
        Me.CMS.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UserMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstvw As System.Windows.Forms.ListView
    Friend WithEvents Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents Room As System.Windows.Forms.ColumnHeader
    Friend WithEvents Floor As System.Windows.Forms.ColumnHeader
    Friend WithEvents SB As System.Windows.Forms.ColumnHeader
    Friend WithEvents DB As System.Windows.Forms.ColumnHeader
    Friend WithEvents Extra As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents Rate As System.Windows.Forms.ColumnHeader
    Friend WithEvents Type As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalRecord As System.Windows.Forms.Label
    Friend WithEvents RoomStatus As System.Windows.Forms.ColumnHeader
End Class

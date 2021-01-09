<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAccount_View
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserAccount_View))
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UserMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstvwUserAccount = New System.Windows.Forms.ListView()
        Me.Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UserLevel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTotalNo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMS
        '
        Me.CMS.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserMenuToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(199, 148)
        '
        'UserMenuToolStripMenuItem
        '
        Me.UserMenuToolStripMenuItem.Enabled = False
        Me.UserMenuToolStripMenuItem.Name = "UserMenuToolStripMenuItem"
        Me.UserMenuToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UserMenuToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.UserMenuToolStripMenuItem.Text = "User Account"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(195, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.add
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AddToolStripMenuItem.Text = "&Add user"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.page_white_edit
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.EditToolStripMenuItem.Text = "&Edit user"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.delete
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete user"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(195, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Hotel_Management_System.My.Resources.Resources.arrow_refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh user account"
        '
        'lstvwUserAccount
        '
        Me.lstvwUserAccount.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.Username, Me.Password, Me.UserLevel})
        Me.lstvwUserAccount.ContextMenuStrip = Me.CMS
        Me.lstvwUserAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwUserAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwUserAccount.FullRowSelect = True
        Me.lstvwUserAccount.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwUserAccount.Location = New System.Drawing.Point(14, 15)
        Me.lstvwUserAccount.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.lstvwUserAccount.MultiSelect = False
        Me.lstvwUserAccount.Name = "lstvwUserAccount"
        Me.lstvwUserAccount.Size = New System.Drawing.Size(402, 329)
        Me.lstvwUserAccount.TabIndex = 2
        Me.lstvwUserAccount.UseCompatibleStateImageBehavior = False
        Me.lstvwUserAccount.View = System.Windows.Forms.View.Details
        '
        'Id
        '
        Me.Id.Text = ""
        Me.Id.Width = 0
        '
        'Username
        '
        Me.Username.Text = "Username"
        Me.Username.Width = 153
        '
        'Password
        '
        Me.Password.Text = "Password"
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Password.Width = 0
        '
        'UserLevel
        '
        Me.UserLevel.Text = "Level"
        Me.UserLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UserLevel.Width = 59
        '
        'lblTotalNo
        '
        Me.lblTotalNo.AutoSize = True
        Me.lblTotalNo.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNo.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotalNo.Location = New System.Drawing.Point(124, 348)
        Me.lblTotalNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalNo.Name = "lblTotalNo"
        Me.lblTotalNo.Size = New System.Drawing.Size(17, 18)
        Me.lblTotalNo.TabIndex = 5
        Me.lblTotalNo.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 348)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total record:"
        '
        'frmUserAccount_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(432, 373)
        Me.Controls.Add(Me.lblTotalNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstvwUserAccount)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserAccount_View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Account View"
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
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstvwUserAccount As System.Windows.Forms.ListView
    Friend WithEvents Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents Username As System.Windows.Forms.ColumnHeader
    Friend WithEvents Password As System.Windows.Forms.ColumnHeader
    Friend WithEvents UserLevel As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblTotalNo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrevTransaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrevTransaction))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnMonthly = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDatefrom = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateto = New System.Windows.Forms.DateTimePicker()
        Me.rbtnMonthly = New System.Windows.Forms.RadioButton()
        Me.pnDaily = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDaily = New System.Windows.Forms.DateTimePicker()
        Me.rbtnDaily = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.pnMonthly.SuspendLayout()
        Me.pnDaily.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.pnMonthly)
        Me.GroupBox1.Controls.Add(Me.rbtnMonthly)
        Me.GroupBox1.Controls.Add(Me.pnDaily)
        Me.GroupBox1.Controls.Add(Me.rbtnDaily)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 203)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'pnMonthly
        '
        Me.pnMonthly.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.pnMonthly.Controls.Add(Me.Label4)
        Me.pnMonthly.Controls.Add(Me.dtpDatefrom)
        Me.pnMonthly.Controls.Add(Me.Label3)
        Me.pnMonthly.Controls.Add(Me.dtpDateto)
        Me.pnMonthly.Location = New System.Drawing.Point(4, 80)
        Me.pnMonthly.Name = "pnMonthly"
        Me.pnMonthly.Size = New System.Drawing.Size(228, 115)
        Me.pnMonthly.TabIndex = 23
        Me.pnMonthly.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Date from:"
        '
        'dtpDatefrom
        '
        Me.dtpDatefrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatefrom.Location = New System.Drawing.Point(6, 33)
        Me.dtpDatefrom.Name = "dtpDatefrom"
        Me.dtpDatefrom.Size = New System.Drawing.Size(215, 22)
        Me.dtpDatefrom.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Date to:"
        '
        'dtpDateto
        '
        Me.dtpDateto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateto.Location = New System.Drawing.Point(6, 87)
        Me.dtpDateto.Name = "dtpDateto"
        Me.dtpDateto.Size = New System.Drawing.Size(215, 22)
        Me.dtpDateto.TabIndex = 10
        '
        'rbtnMonthly
        '
        Me.rbtnMonthly.AutoSize = True
        Me.rbtnMonthly.Location = New System.Drawing.Point(21, 47)
        Me.rbtnMonthly.Name = "rbtnMonthly"
        Me.rbtnMonthly.Size = New System.Drawing.Size(72, 20)
        Me.rbtnMonthly.TabIndex = 13
        Me.rbtnMonthly.Text = "Monthly"
        Me.rbtnMonthly.UseVisualStyleBackColor = True
        '
        'pnDaily
        '
        Me.pnDaily.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.pnDaily.Controls.Add(Me.Label1)
        Me.pnDaily.Controls.Add(Me.dtpDaily)
        Me.pnDaily.Location = New System.Drawing.Point(4, 80)
        Me.pnDaily.Name = "pnDaily"
        Me.pnDaily.Size = New System.Drawing.Size(228, 115)
        Me.pnDaily.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Date:"
        '
        'dtpDaily
        '
        Me.dtpDaily.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDaily.Location = New System.Drawing.Point(6, 35)
        Me.dtpDaily.Name = "dtpDaily"
        Me.dtpDaily.Size = New System.Drawing.Size(215, 22)
        Me.dtpDaily.TabIndex = 10
        '
        'rbtnDaily
        '
        Me.rbtnDaily.AutoSize = True
        Me.rbtnDaily.Checked = True
        Me.rbtnDaily.Location = New System.Drawing.Point(21, 22)
        Me.rbtnDaily.Name = "rbtnDaily"
        Me.rbtnDaily.Size = New System.Drawing.Size(57, 20)
        Me.rbtnDaily.TabIndex = 12
        Me.rbtnDaily.TabStop = True
        Me.rbtnDaily.Text = "Daily"
        Me.rbtnDaily.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Image = Global.Hotel_Management_System.My.Resources.Resources.cancel
        Me.btnCancel.Location = New System.Drawing.Point(169, 249)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(81, 39)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Black
        Me.btnEnter.BackgroundImage = CType(resources.GetObject("btnEnter.BackgroundImage"), System.Drawing.Image)
        Me.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.Image = Global.Hotel_Management_System.My.Resources.Resources.report
        Me.btnEnter.Location = New System.Drawing.Point(33, 249)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(128, 39)
        Me.btnEnter.TabIndex = 19
        Me.btnEnter.Text = "&Print Preview"
        Me.btnEnter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'frmPrevTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(266, 306)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEnter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrevTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnMonthly.ResumeLayout(False)
        Me.pnMonthly.PerformLayout()
        Me.pnDaily.ResumeLayout(False)
        Me.pnDaily.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDateto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDatefrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents rbtnMonthly As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnDaily As System.Windows.Forms.RadioButton
    Friend WithEvents pnDaily As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDaily As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnMonthly As System.Windows.Forms.Panel
End Class

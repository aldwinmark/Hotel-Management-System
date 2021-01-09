<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowReservations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShowReservations))
        Me.lstvw = New System.Windows.Forms.ListView()
        Me.ImgLst = New System.Windows.Forms.ImageList(Me.components)
        Me.pnMonthly = New System.Windows.Forms.Panel()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDateto = New System.Windows.Forms.DateTimePicker()
        Me.dtpDatefrom = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnMonthly.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvw
        '
        Me.lstvw.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstvw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstvw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvw.ForeColor = System.Drawing.Color.Navy
        Me.lstvw.FullRowSelect = True
        Me.lstvw.GridLines = True
        Me.lstvw.Location = New System.Drawing.Point(19, 64)
        Me.lstvw.Margin = New System.Windows.Forms.Padding(7)
        Me.lstvw.MultiSelect = False
        Me.lstvw.Name = "lstvw"
        Me.lstvw.Size = New System.Drawing.Size(775, 547)
        Me.lstvw.StateImageList = Me.ImgLst
        Me.lstvw.TabIndex = 30
        Me.lstvw.UseCompatibleStateImageBehavior = False
        Me.lstvw.View = System.Windows.Forms.View.Details
        '
        'ImgLst
        '
        Me.ImgLst.ImageStream = CType(resources.GetObject("ImgLst.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgLst.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgLst.Images.SetKeyName(0, "buutons1 copy.png")
        Me.ImgLst.Images.SetKeyName(1, "bg2 copy copy.jpg")
        '
        'pnMonthly
        '
        Me.pnMonthly.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnMonthly.Controls.Add(Me.btnLoad)
        Me.pnMonthly.Controls.Add(Me.Label4)
        Me.pnMonthly.Controls.Add(Me.dtpDateto)
        Me.pnMonthly.Controls.Add(Me.dtpDatefrom)
        Me.pnMonthly.Controls.Add(Me.Label3)
        Me.pnMonthly.Location = New System.Drawing.Point(19, 15)
        Me.pnMonthly.Margin = New System.Windows.Forms.Padding(4)
        Me.pnMonthly.Name = "pnMonthly"
        Me.pnMonthly.Size = New System.Drawing.Size(775, 38)
        Me.pnMonthly.TabIndex = 31
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(632, 7)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(140, 26)
        Me.btnLoad.TabIndex = 33
        Me.btnLoad.Text = "Load Reservation"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Date from:"
        '
        'dtpDateto
        '
        Me.dtpDateto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateto.Location = New System.Drawing.Point(373, 7)
        Me.dtpDateto.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateto.Name = "dtpDateto"
        Me.dtpDateto.Size = New System.Drawing.Size(204, 22)
        Me.dtpDateto.TabIndex = 10
        '
        'dtpDatefrom
        '
        Me.dtpDatefrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatefrom.Location = New System.Drawing.Point(91, 7)
        Me.dtpDatefrom.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDatefrom.Name = "dtpDatefrom"
        Me.dtpDatefrom.Size = New System.Drawing.Size(204, 22)
        Me.dtpDatefrom.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(303, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Date to:"
        '
        'frmShowReservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 627)
        Me.Controls.Add(Me.lstvw)
        Me.Controls.Add(Me.pnMonthly)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShowReservations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show Reservations"
        Me.pnMonthly.ResumeLayout(False)
        Me.pnMonthly.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstvw As System.Windows.Forms.ListView
    Friend WithEvents pnMonthly As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDateto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDatefrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ImgLst As System.Windows.Forms.ImageList
    Friend WithEvents btnLoad As System.Windows.Forms.Button
End Class

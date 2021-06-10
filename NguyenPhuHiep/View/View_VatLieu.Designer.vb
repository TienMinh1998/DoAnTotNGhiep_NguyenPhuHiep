<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_VatLieu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_VatLieu))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbb_betong = New System.Windows.Forms.ComboBox()
        Me.txtEb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRbt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbb_thep = New System.Windows.Forms.ComboBox()
        Me.txtEs = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRsc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Pn_tieuDe = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Pn_tieuDe.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbb_betong)
        Me.GroupBox1.Controls.Add(Me.txtEb)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtRbt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtRb)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 158)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vật Liệu Bê Tông"
        '
        'cbb_betong
        '
        Me.cbb_betong.FormattingEnabled = True
        Me.cbb_betong.Items.AddRange(New Object() {"B20", "B25", "B30", "B35"})
        Me.cbb_betong.Location = New System.Drawing.Point(62, 31)
        Me.cbb_betong.Name = "cbb_betong"
        Me.cbb_betong.Size = New System.Drawing.Size(66, 21)
        Me.cbb_betong.TabIndex = 2
        Me.cbb_betong.Text = "B25"
        '
        'txtEb
        '
        Me.txtEb.Enabled = False
        Me.txtEb.Location = New System.Drawing.Point(62, 112)
        Me.txtEb.Name = "txtEb"
        Me.txtEb.Size = New System.Drawing.Size(66, 20)
        Me.txtEb.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Eb:"
        '
        'txtRbt
        '
        Me.txtRbt.Enabled = False
        Me.txtRbt.Location = New System.Drawing.Point(62, 85)
        Me.txtRbt.Name = "txtRbt"
        Me.txtRbt.Size = New System.Drawing.Size(66, 20)
        Me.txtRbt.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Rbt:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(136, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "kN/m2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(136, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "kN/m2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(136, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "kN/m2"
        '
        'txtRb
        '
        Me.txtRb.Enabled = False
        Me.txtRb.Location = New System.Drawing.Point(62, 58)
        Me.txtRb.Name = "txtRb"
        Me.txtRb.Size = New System.Drawing.Size(66, 20)
        Me.txtRb.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Rb:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bê Tông:"
        '
        'cbb_thep
        '
        Me.cbb_thep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbb_thep.DropDownWidth = 70
        Me.cbb_thep.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbb_thep.FormattingEnabled = True
        Me.cbb_thep.Items.AddRange(New Object() {"CB240-T", "CB300-V", "CB400-V", "CB500-V", "Test"})
        Me.cbb_thep.Location = New System.Drawing.Point(82, 31)
        Me.cbb_thep.Name = "cbb_thep"
        Me.cbb_thep.Size = New System.Drawing.Size(66, 21)
        Me.cbb_thep.TabIndex = 2
        Me.cbb_thep.Text = "CB300-V"
        '
        'txtEs
        '
        Me.txtEs.Enabled = False
        Me.txtEs.Location = New System.Drawing.Point(83, 112)
        Me.txtEs.Name = "txtEs"
        Me.txtEs.Size = New System.Drawing.Size(66, 20)
        Me.txtEs.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbb_thep)
        Me.GroupBox2.Controls.Add(Me.txtEs)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtRsc)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtRs)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(209, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(203, 157)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vật Liệu Thép"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Es:"
        '
        'txtRsc
        '
        Me.txtRsc.Enabled = False
        Me.txtRsc.Location = New System.Drawing.Point(83, 85)
        Me.txtRsc.Name = "txtRsc"
        Me.txtRsc.Size = New System.Drawing.Size(66, 20)
        Me.txtRsc.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Rsc:"
        '
        'txtRs
        '
        Me.txtRs.Enabled = False
        Me.txtRs.Location = New System.Drawing.Point(83, 58)
        Me.txtRs.Name = "txtRs"
        Me.txtRs.Size = New System.Drawing.Size(66, 20)
        Me.txtRs.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Rs:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(156, 115)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "kN/m2"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(156, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "kN/m2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(156, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "kN/m2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nhóm Thép:"
        '
        'Pn_tieuDe
        '
        Me.Pn_tieuDe.BackColor = System.Drawing.Color.DodgerBlue
        Me.Pn_tieuDe.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Pn_tieuDe.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn_tieuDe.FillColor = System.Drawing.Color.Silver
        Me.Pn_tieuDe.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Pn_tieuDe.Location = New System.Drawing.Point(0, 0)
        Me.Pn_tieuDe.Name = "Pn_tieuDe"
        Me.Pn_tieuDe.ShadowDecoration.Parent = Me.Pn_tieuDe
        Me.Pn_tieuDe.Size = New System.Drawing.Size(442, 61)
        Me.Pn_tieuDe.TabIndex = 13
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(20, 15)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(401, 27)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "NHẬP VẬT LIỆU CỦA CÔT ĐỊNH TÍNH"
        '
        'BunifuButton1
        '
        Me.BunifuButton1.AllowToggling = False
        Me.BunifuButton1.AnimationSpeed = 200
        Me.BunifuButton1.AutoGenerateColors = False
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackColor1 = System.Drawing.Color.Green
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot
        Me.BunifuButton1.ButtonText = "Done"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.ColorContrastOnClick = 45
        Me.BunifuButton1.ColorContrastOnHover = 45
        Me.BunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BunifuButton1.CustomizableEdges = BorderEdges1
        Me.BunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.Empty
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.BunifuButton1.ForeColor = System.Drawing.Color.Gainsboro
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuButton1.IconMarginLeft = 11
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.DarkTurquoise
        Me.BunifuButton1.IdleBorderRadius = 5
        Me.BunifuButton1.IdleBorderThickness = 1
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.Green
        Me.BunifuButton1.IdleIconLeftImage = Nothing
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.IndicateFocus = False
        Me.BunifuButton1.Location = New System.Drawing.Point(160, 244)
        Me.BunifuButton1.Name = "BunifuButton1"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties1.BorderRadius = 5
        StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 5
        StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.BunifuButton1.OnPressedState = StateProperties2
        Me.BunifuButton1.Size = New System.Drawing.Size(105, 34)
        Me.BunifuButton1.TabIndex = 14
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.TextMarginLeft = 0
        Me.BunifuButton1.UseDefaultRadiusAndThickness = True
        '
        'View_VatLieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 290)
        Me.Controls.Add(Me.BunifuButton1)
        Me.Controls.Add(Me.Pn_tieuDe)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "View_VatLieu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chọn Vật Liệu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Pn_tieuDe.ResumeLayout(False)
        Me.Pn_tieuDe.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbb_betong As ComboBox
    Friend WithEvents txtEb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRbt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbb_thep As ComboBox
    Friend WithEvents txtEs As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRsc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRs As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Pn_tieuDe As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class

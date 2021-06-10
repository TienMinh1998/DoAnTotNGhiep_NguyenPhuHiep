<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_thongsocot
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_thongsocot))
        Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar1 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_chieudaitinhtoan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_n = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_m = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_lopbaove = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_duongkinhcot = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_xong = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_ID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'barManager1
        '
        Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.bar3})
        Me.barManager1.DockControls.Add(Me.barDockControlTop)
        Me.barManager1.DockControls.Add(Me.barDockControlBottom)
        Me.barManager1.DockControls.Add(Me.barDockControlLeft)
        Me.barManager1.DockControls.Add(Me.barDockControlRight)
        Me.barManager1.Form = Me
        Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3})
        Me.barManager1.MainMenu = Me.bar2
        Me.barManager1.MaxItemId = 3
        Me.barManager1.StatusBar = Me.bar3
        '
        'bar1
        '
        Me.bar1.BarName = "Tools"
        Me.bar1.DockCol = 0
        Me.bar1.DockRow = 1
        Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.bar1.Text = "Tools"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'bar2
        '
        Me.bar2.BarName = "Main menu"
        Me.bar2.DockCol = 0
        Me.bar2.DockRow = 0
        Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3)})
        Me.bar2.OptionsBar.MultiLine = True
        Me.bar2.OptionsBar.UseWholeRow = True
        Me.bar2.Text = "Main menu"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'bar3
        '
        Me.bar3.BarName = "Status bar"
        Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.bar3.DockCol = 0
        Me.bar3.DockRow = 0
        Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.bar3.OptionsBar.AllowQuickCustomization = False
        Me.bar3.OptionsBar.DrawDragBorder = False
        Me.bar3.OptionsBar.UseWholeRow = True
        Me.bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.barManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(369, 55)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 348)
        Me.barDockControlBottom.Manager = Me.barManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(369, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 55)
        Me.barDockControlLeft.Manager = Me.barManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 293)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(369, 55)
        Me.barDockControlRight.Manager = Me.barManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 293)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(6, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Lực Dọc"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(6, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Moment"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(300, 209)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "mm"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(7, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Chiều Dài của cột"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(297, 83)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(23, 13)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "mm"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(297, 113)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(23, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "mm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(6, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Lớp Bảo vệ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(6, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Đường Kính của cột"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "KN/m"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Kn"
        '
        'txt_chieudaitinhtoan
        '
        Me.txt_chieudaitinhtoan.BorderRadius = 5
        Me.txt_chieudaitinhtoan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_chieudaitinhtoan.DefaultText = "3000"
        Me.txt_chieudaitinhtoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_chieudaitinhtoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_chieudaitinhtoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_chieudaitinhtoan.DisabledState.Parent = Me.txt_chieudaitinhtoan
        Me.txt_chieudaitinhtoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_chieudaitinhtoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_chieudaitinhtoan.FocusedState.Parent = Me.txt_chieudaitinhtoan
        Me.txt_chieudaitinhtoan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_chieudaitinhtoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_chieudaitinhtoan.HoverState.Parent = Me.txt_chieudaitinhtoan
        Me.txt_chieudaitinhtoan.Location = New System.Drawing.Point(201, 206)
        Me.txt_chieudaitinhtoan.Name = "txt_chieudaitinhtoan"
        Me.txt_chieudaitinhtoan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_chieudaitinhtoan.PlaceholderText = "Lực Dọc"
        Me.txt_chieudaitinhtoan.SelectedText = ""
        Me.txt_chieudaitinhtoan.SelectionStart = 4
        Me.txt_chieudaitinhtoan.ShadowDecoration.Parent = Me.txt_chieudaitinhtoan
        Me.txt_chieudaitinhtoan.Size = New System.Drawing.Size(90, 20)
        Me.txt_chieudaitinhtoan.TabIndex = 13
        '
        'txt_n
        '
        Me.txt_n.BorderRadius = 5
        Me.txt_n.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_n.DefaultText = "800"
        Me.txt_n.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_n.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_n.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_n.DisabledState.Parent = Me.txt_n
        Me.txt_n.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_n.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_n.FocusedState.Parent = Me.txt_n
        Me.txt_n.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_n.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_n.HoverState.Parent = Me.txt_n
        Me.txt_n.Location = New System.Drawing.Point(201, 173)
        Me.txt_n.Name = "txt_n"
        Me.txt_n.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_n.PlaceholderText = "Lực Dọc"
        Me.txt_n.SelectedText = ""
        Me.txt_n.SelectionStart = 3
        Me.txt_n.ShadowDecoration.Parent = Me.txt_n
        Me.txt_n.Size = New System.Drawing.Size(90, 20)
        Me.txt_n.TabIndex = 14
        '
        'txt_m
        '
        Me.txt_m.BorderRadius = 5
        Me.txt_m.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_m.DefaultText = "176"
        Me.txt_m.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_m.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_m.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_m.DisabledState.Parent = Me.txt_m
        Me.txt_m.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_m.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_m.FocusedState.Parent = Me.txt_m
        Me.txt_m.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_m.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_m.HoverState.Parent = Me.txt_m
        Me.txt_m.Location = New System.Drawing.Point(201, 143)
        Me.txt_m.Name = "txt_m"
        Me.txt_m.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_m.PlaceholderText = "Moment"
        Me.txt_m.SelectedText = ""
        Me.txt_m.SelectionStart = 3
        Me.txt_m.ShadowDecoration.Parent = Me.txt_m
        Me.txt_m.Size = New System.Drawing.Size(90, 20)
        Me.txt_m.TabIndex = 15
        '
        'txt_lopbaove
        '
        Me.txt_lopbaove.BorderRadius = 5
        Me.txt_lopbaove.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_lopbaove.DefaultText = "40"
        Me.txt_lopbaove.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_lopbaove.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_lopbaove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lopbaove.DisabledState.Parent = Me.txt_lopbaove
        Me.txt_lopbaove.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lopbaove.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lopbaove.FocusedState.Parent = Me.txt_lopbaove
        Me.txt_lopbaove.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_lopbaove.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lopbaove.HoverState.Parent = Me.txt_lopbaove
        Me.txt_lopbaove.Location = New System.Drawing.Point(201, 113)
        Me.txt_lopbaove.Name = "txt_lopbaove"
        Me.txt_lopbaove.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_lopbaove.PlaceholderText = "Lớp bảo vệ"
        Me.txt_lopbaove.SelectedText = ""
        Me.txt_lopbaove.SelectionStart = 2
        Me.txt_lopbaove.ShadowDecoration.Parent = Me.txt_lopbaove
        Me.txt_lopbaove.Size = New System.Drawing.Size(90, 20)
        Me.txt_lopbaove.TabIndex = 16
        '
        'txt_duongkinhcot
        '
        Me.txt_duongkinhcot.BorderRadius = 5
        Me.txt_duongkinhcot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_duongkinhcot.DefaultText = "400"
        Me.txt_duongkinhcot.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_duongkinhcot.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_duongkinhcot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_duongkinhcot.DisabledState.Parent = Me.txt_duongkinhcot
        Me.txt_duongkinhcot.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_duongkinhcot.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_duongkinhcot.FocusedState.Parent = Me.txt_duongkinhcot
        Me.txt_duongkinhcot.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_duongkinhcot.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_duongkinhcot.HoverState.Parent = Me.txt_duongkinhcot
        Me.txt_duongkinhcot.Location = New System.Drawing.Point(201, 83)
        Me.txt_duongkinhcot.Name = "txt_duongkinhcot"
        Me.txt_duongkinhcot.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_duongkinhcot.PlaceholderText = "Nhập Bán Kính"
        Me.txt_duongkinhcot.SelectedText = ""
        Me.txt_duongkinhcot.SelectionStart = 3
        Me.txt_duongkinhcot.ShadowDecoration.Parent = Me.txt_duongkinhcot
        Me.txt_duongkinhcot.Size = New System.Drawing.Size(90, 20)
        Me.txt_duongkinhcot.TabIndex = 17
        '
        'btn_xong
        '
        Me.btn_xong.BorderColor = System.Drawing.Color.Aqua
        Me.btn_xong.BorderRadius = 10
        Me.btn_xong.BorderThickness = 1
        Me.btn_xong.CheckedState.Parent = Me.btn_xong
        Me.btn_xong.CustomImages.Parent = Me.btn_xong
        Me.btn_xong.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_xong.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_xong.ForeColor = System.Drawing.Color.White
        Me.btn_xong.HoverState.Parent = Me.btn_xong
        Me.btn_xong.Location = New System.Drawing.Point(140, 315)
        Me.btn_xong.Name = "btn_xong"
        Me.btn_xong.ShadowDecoration.Parent = Me.btn_xong
        Me.btn_xong.Size = New System.Drawing.Size(101, 31)
        Me.btn_xong.TabIndex = 32
        Me.btn_xong.Text = "Xong"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_chieudaitinhtoan)
        Me.GroupBox1.Controls.Add(Me.txt_n)
        Me.GroupBox1.Controls.Add(Me.txt_ID)
        Me.GroupBox1.Controls.Add(Me.txt_m)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.txt_lopbaove)
        Me.GroupBox1.Controls.Add(Me.txt_duongkinhcot)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 248)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'txt_name
        '
        Me.txt_name.BorderRadius = 5
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_name.DefaultText = "Cột 1"
        Me.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_name.DisabledState.Parent = Me.txt_name
        Me.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_name.FocusedState.Parent = Me.txt_name
        Me.txt_name.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_name.HoverState.Parent = Me.txt_name
        Me.txt_name.Location = New System.Drawing.Point(202, 53)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_name.PlaceholderText = "Nhập Bán Kính"
        Me.txt_name.SelectedText = ""
        Me.txt_name.ShadowDecoration.Parent = Me.txt_name
        Me.txt_name.Size = New System.Drawing.Size(90, 20)
        Me.txt_name.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(7, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Name Col"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(298, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "mm"
        '
        'txt_ID
        '
        Me.txt_ID.BorderRadius = 5
        Me.txt_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_ID.DefaultText = "12345"
        Me.txt_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ID.DisabledState.Parent = Me.txt_ID
        Me.txt_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ID.FocusedState.Parent = Me.txt_ID
        Me.txt_ID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ID.HoverState.Parent = Me.txt_ID
        Me.txt_ID.Location = New System.Drawing.Point(201, 17)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ID.PlaceholderText = "Nhập Bán Kính"
        Me.txt_ID.SelectedText = ""
        Me.txt_ID.ShadowDecoration.Parent = Me.txt_ID
        Me.txt_ID.Size = New System.Drawing.Size(90, 20)
        Me.txt_ID.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(6, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "ID Col"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(297, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "mm"
        '
        'View_thongsocot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 371)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_xong)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "View_thongsocot"
        Me.Text = "Nhập Các Thông Số Cho Cột"
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend barManager1 As DevExpress.XtraBars.BarManager
    Friend bar1 As DevExpress.XtraBars.Bar
    Friend bar2 As DevExpress.XtraBars.Bar
    Friend bar3 As DevExpress.XtraBars.Bar
    Friend barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_chieudaitinhtoan As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_n As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_m As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_lopbaove As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_duongkinhcot As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_xong As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_ID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_name As Guna.UI2.WinForms.Guna2TextBox
End Class

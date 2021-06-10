<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class kiemtra_view
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_kiemtra = New Guna.UI2.WinForms.Guna2Button()
        Me.Gg_bieudo = New System.Windows.Forms.GroupBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lb_as = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lb_XK = New System.Windows.Forms.Label()
        Me.lb_YK = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbbdiameter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txt_duongkinh = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_sothanh = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lb_hamluongthep = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_lucdoc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_moment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_chieudaicot = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        Me.Gg_bieudo.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(997, 49)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(45, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kiểm Tra Thép bằng biểu đồ tương tác"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(15, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Đường Kính Thép"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(12, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Số thanh : "
        '
        'btn_kiemtra
        '
        Me.btn_kiemtra.BorderColor = System.Drawing.Color.Aqua
        Me.btn_kiemtra.BorderRadius = 10
        Me.btn_kiemtra.BorderThickness = 1
        Me.btn_kiemtra.CheckedState.Parent = Me.btn_kiemtra
        Me.btn_kiemtra.CustomImages.Parent = Me.btn_kiemtra
        Me.btn_kiemtra.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_kiemtra.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_kiemtra.ForeColor = System.Drawing.Color.White
        Me.btn_kiemtra.HoverState.Parent = Me.btn_kiemtra
        Me.btn_kiemtra.Location = New System.Drawing.Point(881, 551)
        Me.btn_kiemtra.Name = "btn_kiemtra"
        Me.btn_kiemtra.ShadowDecoration.Parent = Me.btn_kiemtra
        Me.btn_kiemtra.Size = New System.Drawing.Size(101, 31)
        Me.btn_kiemtra.TabIndex = 2
        Me.btn_kiemtra.Text = "Đóng"
        '
        'Gg_bieudo
        '
        Me.Gg_bieudo.Controls.Add(Me.Chart1)
        Me.Gg_bieudo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gg_bieudo.Location = New System.Drawing.Point(470, 55)
        Me.Gg_bieudo.Name = "Gg_bieudo"
        Me.Gg_bieudo.Size = New System.Drawing.Size(515, 490)
        Me.Gg_bieudo.TabIndex = 3
        Me.Gg_bieudo.TabStop = False
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Gainsboro
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 16)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(509, 471)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(16, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Diện Tích AS : "
        '
        'lb_as
        '
        Me.lb_as.AutoSize = True
        Me.lb_as.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_as.ForeColor = System.Drawing.Color.Navy
        Me.lb_as.Location = New System.Drawing.Point(182, 325)
        Me.lb_as.Name = "lb_as"
        Me.lb_as.Size = New System.Drawing.Size(55, 25)
        Me.lb_as.TabIndex = 1
        Me.lb_as.Text = "lb_as"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(16, 403)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Tọa Độ K =>"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(123, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "X : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(123, 434)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 21)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Y :"
        '
        'lb_XK
        '
        Me.lb_XK.AutoSize = True
        Me.lb_XK.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_XK.ForeColor = System.Drawing.Color.Navy
        Me.lb_XK.Location = New System.Drawing.Point(182, 399)
        Me.lb_XK.Name = "lb_XK"
        Me.lb_XK.Size = New System.Drawing.Size(66, 25)
        Me.lb_XK.TabIndex = 1
        Me.lb_XK.Text = "Lb_XK"
        '
        'lb_YK
        '
        Me.lb_YK.AutoSize = True
        Me.lb_YK.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_YK.ForeColor = System.Drawing.Color.Navy
        Me.lb_YK.Location = New System.Drawing.Point(182, 431)
        Me.lb_YK.Name = "lb_YK"
        Me.lb_YK.Size = New System.Drawing.Size(61, 25)
        Me.lb_YK.TabIndex = 1
        Me.lb_YK.Text = "lb_YK"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbbdiameter)
        Me.GroupBox1.Controls.Add(Me.txt_chieudaicot)
        Me.GroupBox1.Controls.Add(Me.txt_moment)
        Me.GroupBox1.Controls.Add(Me.txt_lucdoc)
        Me.GroupBox1.Controls.Add(Me.txt_duongkinh)
        Me.GroupBox1.Controls.Add(Me.txt_sothanh)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lb_YK)
        Me.GroupBox1.Controls.Add(Me.lb_XK)
        Me.GroupBox1.Controls.Add(Me.lb_hamluongthep)
        Me.GroupBox1.Controls.Add(Me.lb_as)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(13, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 468)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kết Quả"
        '
        'cbbdiameter
        '
        Me.cbbdiameter.BackColor = System.Drawing.Color.Transparent
        Me.cbbdiameter.BorderRadius = 10
        Me.cbbdiameter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbbdiameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbdiameter.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbbdiameter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbbdiameter.FocusedState.Parent = Me.cbbdiameter
        Me.cbbdiameter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbbdiameter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbbdiameter.HoverState.Parent = Me.cbbdiameter
        Me.cbbdiameter.ItemHeight = 30
        Me.cbbdiameter.Items.AddRange(New Object() {"6", "10", "12", "14", "16", "18", "20", "22", "25"})
        Me.cbbdiameter.ItemsAppearance.Parent = Me.cbbdiameter
        Me.cbbdiameter.Location = New System.Drawing.Point(188, 270)
        Me.cbbdiameter.Name = "cbbdiameter"
        Me.cbbdiameter.ShadowDecoration.Parent = Me.cbbdiameter
        Me.cbbdiameter.Size = New System.Drawing.Size(110, 36)
        Me.cbbdiameter.TabIndex = 5
        '
        'txt_duongkinh
        '
        Me.txt_duongkinh.BorderColor = System.Drawing.Color.White
        Me.txt_duongkinh.BorderRadius = 10
        Me.txt_duongkinh.BorderThickness = 0
        Me.txt_duongkinh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_duongkinh.DefaultText = ""
        Me.txt_duongkinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_duongkinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_duongkinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_duongkinh.DisabledState.Parent = Me.txt_duongkinh
        Me.txt_duongkinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_duongkinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_duongkinh.FocusedState.Parent = Me.txt_duongkinh
        Me.txt_duongkinh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_duongkinh.ForeColor = System.Drawing.Color.Green
        Me.txt_duongkinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_duongkinh.HoverState.Parent = Me.txt_duongkinh
        Me.txt_duongkinh.Location = New System.Drawing.Point(188, 48)
        Me.txt_duongkinh.Name = "txt_duongkinh"
        Me.txt_duongkinh.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_duongkinh.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txt_duongkinh.PlaceholderText = "Chọn Số Thanh"
        Me.txt_duongkinh.SelectedText = ""
        Me.txt_duongkinh.ShadowDecoration.Parent = Me.txt_duongkinh
        Me.txt_duongkinh.Size = New System.Drawing.Size(121, 22)
        Me.txt_duongkinh.TabIndex = 4
        '
        'txt_sothanh
        '
        Me.txt_sothanh.BorderColor = System.Drawing.Color.White
        Me.txt_sothanh.BorderRadius = 10
        Me.txt_sothanh.BorderThickness = 0
        Me.txt_sothanh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_sothanh.DefaultText = ""
        Me.txt_sothanh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_sothanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_sothanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sothanh.DisabledState.Parent = Me.txt_sothanh
        Me.txt_sothanh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_sothanh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sothanh.FocusedState.Parent = Me.txt_sothanh
        Me.txt_sothanh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_sothanh.ForeColor = System.Drawing.Color.Green
        Me.txt_sothanh.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sothanh.HoverState.Parent = Me.txt_sothanh
        Me.txt_sothanh.Location = New System.Drawing.Point(189, 230)
        Me.txt_sothanh.Name = "txt_sothanh"
        Me.txt_sothanh.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_sothanh.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txt_sothanh.PlaceholderText = "Chọn Số Thanh"
        Me.txt_sothanh.SelectedText = ""
        Me.txt_sothanh.ShadowDecoration.Parent = Me.txt_sothanh
        Me.txt_sothanh.Size = New System.Drawing.Size(121, 22)
        Me.txt_sothanh.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(15, 365)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 21)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = " Hàm Lượng Thép  µ% :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Green
        Me.Label9.Location = New System.Drawing.Point(14, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 21)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Chọn Đường Kính Cột"
        '
        'lb_hamluongthep
        '
        Me.lb_hamluongthep.AutoSize = True
        Me.lb_hamluongthep.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_hamluongthep.ForeColor = System.Drawing.Color.Navy
        Me.lb_hamluongthep.Location = New System.Drawing.Point(220, 361)
        Me.lb_hamluongthep.Name = "lb_hamluongthep"
        Me.lb_hamluongthep.Size = New System.Drawing.Size(128, 25)
        Me.lb_hamluongthep.TabIndex = 1
        Me.lb_hamluongthep.Text = "lb_hamluong"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(13, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 21)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Lực Dọc : "
        '
        'txt_lucdoc
        '
        Me.txt_lucdoc.BorderColor = System.Drawing.Color.White
        Me.txt_lucdoc.BorderRadius = 10
        Me.txt_lucdoc.BorderThickness = 0
        Me.txt_lucdoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_lucdoc.DefaultText = ""
        Me.txt_lucdoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_lucdoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_lucdoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lucdoc.DisabledState.Parent = Me.txt_lucdoc
        Me.txt_lucdoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lucdoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lucdoc.FocusedState.Parent = Me.txt_lucdoc
        Me.txt_lucdoc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_lucdoc.ForeColor = System.Drawing.Color.Green
        Me.txt_lucdoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lucdoc.HoverState.Parent = Me.txt_lucdoc
        Me.txt_lucdoc.Location = New System.Drawing.Point(187, 86)
        Me.txt_lucdoc.Name = "txt_lucdoc"
        Me.txt_lucdoc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_lucdoc.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txt_lucdoc.PlaceholderText = "Lực Dọc"
        Me.txt_lucdoc.SelectedText = ""
        Me.txt_lucdoc.ShadowDecoration.Parent = Me.txt_lucdoc
        Me.txt_lucdoc.Size = New System.Drawing.Size(121, 22)
        Me.txt_lucdoc.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Green
        Me.Label11.Location = New System.Drawing.Point(13, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 21)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Moment"
        '
        'txt_moment
        '
        Me.txt_moment.BorderColor = System.Drawing.Color.White
        Me.txt_moment.BorderRadius = 10
        Me.txt_moment.BorderThickness = 0
        Me.txt_moment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_moment.DefaultText = ""
        Me.txt_moment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_moment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_moment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_moment.DisabledState.Parent = Me.txt_moment
        Me.txt_moment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_moment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_moment.FocusedState.Parent = Me.txt_moment
        Me.txt_moment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_moment.ForeColor = System.Drawing.Color.Green
        Me.txt_moment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_moment.HoverState.Parent = Me.txt_moment
        Me.txt_moment.Location = New System.Drawing.Point(187, 128)
        Me.txt_moment.Name = "txt_moment"
        Me.txt_moment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_moment.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txt_moment.PlaceholderText = "Moment"
        Me.txt_moment.SelectedText = ""
        Me.txt_moment.ShadowDecoration.Parent = Me.txt_moment
        Me.txt_moment.Size = New System.Drawing.Size(121, 22)
        Me.txt_moment.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Green
        Me.Label12.Location = New System.Drawing.Point(13, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 21)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Chiều Dài Cột"
        '
        'txt_chieudaicot
        '
        Me.txt_chieudaicot.BorderColor = System.Drawing.Color.White
        Me.txt_chieudaicot.BorderRadius = 10
        Me.txt_chieudaicot.BorderThickness = 0
        Me.txt_chieudaicot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_chieudaicot.DefaultText = ""
        Me.txt_chieudaicot.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_chieudaicot.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_chieudaicot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_chieudaicot.DisabledState.Parent = Me.txt_chieudaicot
        Me.txt_chieudaicot.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_chieudaicot.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_chieudaicot.FocusedState.Parent = Me.txt_chieudaicot
        Me.txt_chieudaicot.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_chieudaicot.ForeColor = System.Drawing.Color.Green
        Me.txt_chieudaicot.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_chieudaicot.HoverState.Parent = Me.txt_chieudaicot
        Me.txt_chieudaicot.Location = New System.Drawing.Point(187, 172)
        Me.txt_chieudaicot.Name = "txt_chieudaicot"
        Me.txt_chieudaicot.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_chieudaicot.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txt_chieudaicot.PlaceholderText = "Chiều Dài cột"
        Me.txt_chieudaicot.SelectedText = ""
        Me.txt_chieudaicot.ShadowDecoration.Parent = Me.txt_chieudaicot
        Me.txt_chieudaicot.Size = New System.Drawing.Size(121, 22)
        Me.txt_chieudaicot.TabIndex = 4
        '
        'kiemtra_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 585)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Gg_bieudo)
        Me.Controls.Add(Me.btn_kiemtra)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "kiemtra_view"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "kiemtra_view"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Gg_bieudo.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_kiemtra As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Gg_bieudo As GroupBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label3 As Label
    Friend WithEvents lb_as As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lb_XK As Label
    Friend WithEvents lb_YK As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lb_hamluongthep As Label
    Friend WithEvents cbbdiameter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txt_sothanh As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_duongkinh As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_chieudaicot As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_moment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_lucdoc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
End Class

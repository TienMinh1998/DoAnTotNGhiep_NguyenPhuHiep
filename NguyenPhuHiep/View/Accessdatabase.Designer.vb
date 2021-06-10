<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accessdatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accessdatabase))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.chucnamg = New System.Windows.Forms.GroupBox()
        Me.btn_laydulieu = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgv_excel = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar1 = New DevExpress.XtraBars.Bar()
        Me.bar2 = New DevExpress.XtraBars.Bar()
        Me.bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.chucnamg.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.dgv_excel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Column11
        '
        Me.Column11.HeaderText = "M3"
        Me.Column11.Name = "Column11"
        '
        'Column9
        '
        Me.Column9.HeaderText = "T"
        Me.Column9.Name = "Column9"
        '
        'Column8
        '
        Me.Column8.HeaderText = "V3"
        Me.Column8.Name = "Column8"
        '
        'Column7
        '
        Me.Column7.HeaderText = "V2"
        Me.Column7.Name = "Column7"
        '
        'Column6
        '
        Me.Column6.HeaderText = "P"
        Me.Column6.Name = "Column6"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Station"
        Me.Column5.Name = "Column5"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Trường Hợp Tải"
        Me.Column3.Name = "Column3"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cột "
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Story"
        Me.Column1.Name = "Column1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Back"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "File"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'Column10
        '
        Me.Column10.HeaderText = "M2"
        Me.Column10.Name = "Column10"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'chucnamg
        '
        Me.chucnamg.Controls.Add(Me.btn_laydulieu)
        Me.chucnamg.Location = New System.Drawing.Point(-179, -46)
        Me.chucnamg.Name = "chucnamg"
        Me.chucnamg.Size = New System.Drawing.Size(292, 781)
        Me.chucnamg.TabIndex = 7
        Me.chucnamg.TabStop = False
        Me.chucnamg.Text = "Chức Năng"
        '
        'btn_laydulieu
        '
        Me.btn_laydulieu.BorderColor = System.Drawing.Color.Aqua
        Me.btn_laydulieu.BorderRadius = 10
        Me.btn_laydulieu.BorderThickness = 1
        Me.btn_laydulieu.CheckedState.Parent = Me.btn_laydulieu
        Me.btn_laydulieu.CustomImages.Parent = Me.btn_laydulieu
        Me.btn_laydulieu.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_laydulieu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_laydulieu.ForeColor = System.Drawing.Color.White
        Me.btn_laydulieu.HoverState.Parent = Me.btn_laydulieu
        Me.btn_laydulieu.Location = New System.Drawing.Point(185, 20)
        Me.btn_laydulieu.Name = "btn_laydulieu"
        Me.btn_laydulieu.ShadowDecoration.Parent = Me.btn_laydulieu
        Me.btn_laydulieu.Size = New System.Drawing.Size(101, 42)
        Me.btn_laydulieu.TabIndex = 3
        Me.btn_laydulieu.Text = "Lấy Dữ Liệu Excel"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.dgv_excel)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(124, -41)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1572, 776)
        Me.Guna2GroupBox1.TabIndex = 6
        Me.Guna2GroupBox1.Text = "File Excel- Bảng Nội Lực"
        '
        'dgv_excel
        '
        Me.dgv_excel.AllowCustomTheming = False
        Me.dgv_excel.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgv_excel.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_excel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_excel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_excel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_excel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_excel.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_excel.ColumnHeadersHeight = 40
        Me.dgv_excel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.dgv_excel.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dgv_excel.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgv_excel.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv_excel.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.dgv_excel.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_excel.CurrentTheme.BackColor = System.Drawing.Color.Navy
        Me.dgv_excel.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.dgv_excel.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy
        Me.dgv_excel.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.dgv_excel.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_excel.CurrentTheme.Name = Nothing
        Me.dgv_excel.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgv_excel.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgv_excel.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv_excel.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.dgv_excel.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_excel.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_excel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_excel.EnableHeadersVisualStyles = False
        Me.dgv_excel.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.dgv_excel.HeaderBackColor = System.Drawing.Color.Navy
        Me.dgv_excel.HeaderBgColor = System.Drawing.Color.Empty
        Me.dgv_excel.HeaderForeColor = System.Drawing.Color.White
        Me.dgv_excel.Location = New System.Drawing.Point(0, 0)
        Me.dgv_excel.Name = "dgv_excel"
        Me.dgv_excel.RowHeadersVisible = False
        Me.dgv_excel.RowTemplate.Height = 40
        Me.dgv_excel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_excel.Size = New System.Drawing.Size(1572, 776)
        Me.dgv_excel.TabIndex = 0
        Me.dgv_excel.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 51)
        Me.barDockControlLeft.Manager = Me.barManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 614)
        '
        'barManager1
        '
        Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.bar3})
        Me.barManager1.DockControls.Add(Me.barDockControlTop)
        Me.barManager1.DockControls.Add(Me.barDockControlBottom)
        Me.barManager1.DockControls.Add(Me.barDockControlLeft)
        Me.barManager1.DockControls.Add(Me.barDockControlRight)
        Me.barManager1.Form = Me
        Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2})
        Me.barManager1.MainMenu = Me.bar2
        Me.barManager1.MaxItemId = 2
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
        'bar2
        '
        Me.bar2.BarName = "Main menu"
        Me.bar2.DockCol = 0
        Me.bar2.DockRow = 0
        Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar2.OptionsBar.MultiLine = True
        Me.bar2.OptionsBar.UseWholeRow = True
        Me.bar2.Text = "Main menu"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1517, 51)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 665)
        Me.barDockControlBottom.Manager = Me.barManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1517, 23)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1517, 51)
        Me.barDockControlRight.Manager = Me.barManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 614)
        '
        'Accessdatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1517, 688)
        Me.Controls.Add(Me.chucnamg)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "Accessdatabase"
        Me.Text = "Accessdatabase"
        Me.chucnamg.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.dgv_excel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents chucnamg As GroupBox
    Friend WithEvents btn_laydulieu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dgv_excel As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class

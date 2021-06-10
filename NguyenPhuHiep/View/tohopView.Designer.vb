<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tohopView
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvnl = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvnl)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1219, 478)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bảng tổ hợp nội lực"
        '
        'dgvnl
        '
        Me.dgvnl.AllowCustomTheming = False
        Me.dgvnl.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(198, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvnl.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvnl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvnl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvnl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvnl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvnl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvnl.ColumnHeadersHeight = 40
        Me.dgvnl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.dgvnl.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.dgvnl.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgvnl.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvnl.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dgvnl.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvnl.CurrentTheme.BackColor = System.Drawing.Color.Chocolate
        Me.dgvnl.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.dgvnl.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Chocolate
        Me.dgvnl.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.dgvnl.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvnl.CurrentTheme.Name = Nothing
        Me.dgvnl.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.dgvnl.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgvnl.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvnl.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dgvnl.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(120, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvnl.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvnl.EnableHeadersVisualStyles = False
        Me.dgvnl.GridColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.dgvnl.HeaderBackColor = System.Drawing.Color.Chocolate
        Me.dgvnl.HeaderBgColor = System.Drawing.Color.Empty
        Me.dgvnl.HeaderForeColor = System.Drawing.Color.White
        Me.dgvnl.Location = New System.Drawing.Point(3, 17)
        Me.dgvnl.Name = "dgvnl"
        Me.dgvnl.RowHeadersVisible = False
        Me.dgvnl.RowTemplate.Height = 40
        Me.dgvnl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvnl.Size = New System.Drawing.Size(1213, 458)
        Me.dgvnl.TabIndex = 3
        Me.dgvnl.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Chocolate
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tên Cột"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Vị Trí"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nội Lực"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "TT"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "HT"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "GXP"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "GXT"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "GYP"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "GYT"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Mx(max) , My,N"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "mxtu, My(max), Ntu"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Mxtu, Mytu, N(max)"
        Me.Column12.Name = "Column12"
        '
        'tohopView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 478)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "tohopView"
        Me.Text = "tohopView"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvnl As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
End Class

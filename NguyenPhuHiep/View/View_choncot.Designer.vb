<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_choncot
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
        Me.cbb_cot = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btn_chon = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'cbb_cot
        '
        Me.cbb_cot.BackColor = System.Drawing.Color.Transparent
        Me.cbb_cot.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbb_cot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_cot.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbb_cot.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbb_cot.FocusedState.Parent = Me.cbb_cot
        Me.cbb_cot.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbb_cot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbb_cot.HoverState.Parent = Me.cbb_cot
        Me.cbb_cot.ItemHeight = 30
        Me.cbb_cot.ItemsAppearance.Parent = Me.cbb_cot
        Me.cbb_cot.Location = New System.Drawing.Point(28, 19)
        Me.cbb_cot.Name = "cbb_cot"
        Me.cbb_cot.ShadowDecoration.Parent = Me.cbb_cot
        Me.cbb_cot.Size = New System.Drawing.Size(317, 36)
        Me.cbb_cot.TabIndex = 0
        '
        'btn_chon
        '
        Me.btn_chon.BorderColor = System.Drawing.Color.Aqua
        Me.btn_chon.BorderRadius = 10
        Me.btn_chon.BorderThickness = 1
        Me.btn_chon.CheckedState.Parent = Me.btn_chon
        Me.btn_chon.CustomImages.Parent = Me.btn_chon
        Me.btn_chon.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_chon.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_chon.ForeColor = System.Drawing.Color.White
        Me.btn_chon.HoverState.Parent = Me.btn_chon
        Me.btn_chon.Location = New System.Drawing.Point(376, 22)
        Me.btn_chon.Name = "btn_chon"
        Me.btn_chon.ShadowDecoration.Parent = Me.btn_chon
        Me.btn_chon.Size = New System.Drawing.Size(101, 31)
        Me.btn_chon.TabIndex = 3
        Me.btn_chon.Text = "Chọn"
        '
        'View_choncot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 75)
        Me.Controls.Add(Me.btn_chon)
        Me.Controls.Add(Me.cbb_cot)
        Me.Name = "View_choncot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Chọn Cột Để Tính"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbb_cot As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btn_chon As Guna.UI2.WinForms.Guna2Button
End Class

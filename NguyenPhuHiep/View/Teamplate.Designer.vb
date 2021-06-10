<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teamplate
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
        Me.btn_laydulieu = New Guna.UI2.WinForms.Guna2Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        Me.btn_laydulieu.Location = New System.Drawing.Point(87, 101)
        Me.btn_laydulieu.Name = "btn_laydulieu"
        Me.btn_laydulieu.ShadowDecoration.Parent = Me.btn_laydulieu
        Me.btn_laydulieu.Size = New System.Drawing.Size(75, 30)
        Me.btn_laydulieu.TabIndex = 7
        Me.btn_laydulieu.Text = "Lọc"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(363, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 25)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Lọc dữ liệu."
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.UseWaitCursor = True
        '
        'Teamplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_laydulieu)
        Me.Name = "Teamplate"
        Me.Text = "Teamplate"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_laydulieu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Button1 As Button
End Class

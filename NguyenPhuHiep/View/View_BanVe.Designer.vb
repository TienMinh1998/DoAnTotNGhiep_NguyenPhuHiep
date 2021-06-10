<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_BanVe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_BanVe))
        Me.vdr = New AxVDProLib5.AxVDPro()
        CType(Me.vdr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vdr
        '
        Me.vdr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vdr.Enabled = True
        Me.vdr.Location = New System.Drawing.Point(0, 0)
        Me.vdr.Name = "vdr"
        Me.vdr.OcxState = CType(resources.GetObject("vdr.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vdr.Size = New System.Drawing.Size(727, 476)
        Me.vdr.TabIndex = 0
        '
        'View_BanVe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 476)
        Me.Controls.Add(Me.vdr)
        Me.Name = "View_BanVe"
        Me.Text = "View_BanVe"
        CType(Me.vdr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents vdr As AxVDProLib5.AxVDPro
End Class

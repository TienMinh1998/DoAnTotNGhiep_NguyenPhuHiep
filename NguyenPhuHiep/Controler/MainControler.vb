Public Class MainControler
    Public Sub DisPlay(frm As Form)
        'Me.CenterToScreen()
        frm.MdiParent = View_BanVe
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        frm.FormBorderStyle = FormBorderStyle.None
        frm.BringToFront()
        frm.Show()
    End Sub
End Class

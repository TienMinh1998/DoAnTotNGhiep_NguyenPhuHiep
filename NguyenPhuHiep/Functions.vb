Module Functions
    ' Hàm hiển Thị Lên FRM chính : 
    Public Sub DisPlay(childForm As Form)
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        View_main.Pn_Display.Controls.Add(childForm)
        View_main.Pn_Display.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
End Module

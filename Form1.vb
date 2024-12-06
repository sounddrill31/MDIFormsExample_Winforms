Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        Form2.TopLevel = False
        Form2.MdiParent = Me
        Form2.Show()
    End Sub
End Class

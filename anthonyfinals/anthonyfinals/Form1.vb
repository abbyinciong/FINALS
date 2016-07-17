Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        start()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Finish(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Finishlabel.MouseEnter
        MessageBox.Show("coool")
        Me.Hide()

    End Sub
    Private Sub start()
        Dim startpoint = Panel1.Location
        startpoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startpoint)
    End Sub

    Private Sub start(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        start()
        Form2.Show()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("turn your volume up")
    End Sub
End Class

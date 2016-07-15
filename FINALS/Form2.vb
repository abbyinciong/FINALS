Public Class Form2
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Start()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Finish(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Finishlabel.MouseEnter
        MessageBox.Show("You did it!, nextlevel")
        Me.Hide()
        Form4.Show()
    End Sub
    Private Sub Start()
        Dim StartPoint = Panel1.Location
        StartPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(StartPoint)
    End Sub

    Private Sub Start(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        Start()
        Me.Hide()
        Form5.Show()

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("For excitement, TURN UP your volume XD")
    End Sub

    Private Sub Form2_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
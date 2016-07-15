Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Start()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Finish(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Finishlabel.MouseEnter
        MessageBox.Show("Well Done")
        Me.Close()



    End Sub
    Private Sub Start()
        Dim StartPoint = Panel1.Location
        StartPoint.Offset(450, 450)
        Cursor.Position = PointToScreen(StartPoint)
    End Sub

    Private Sub Start(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label39.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        Start()
        Me.Hide()
        Form6.Show()

    End Sub
End Class
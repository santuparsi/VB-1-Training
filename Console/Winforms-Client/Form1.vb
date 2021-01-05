Imports My.MathLib
Public Class Form1
    Dim obj As New Convertor
    Private Sub CTD(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amt As Double = CDbl(t1.Text)
        Dim dollers As Double = obj.RTD(amt)
        'MessageBox.Show("Dollers: $" & dollers)
        t2.Text = "$" & String.Format("{0:F2}", dollers)

    End Sub

    Private Sub CTR(sender As Object, e As EventArgs) Handles Button2.Click
        Dim amt As Double = CDbl(t1.Text)
        Dim rupees As Double = obj.DTR(amt)
        'MessageBox.Show("Dollers: $" & dollers)
        t2.Text = "Re" & String.Format("{0:F2}", rupees)
    End Sub
End Class

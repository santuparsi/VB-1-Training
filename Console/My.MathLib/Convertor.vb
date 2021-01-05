Public Class Convertor
    Public Function RTD(amt As Double) As Double
        Dim exchngamt As Double
        exchngamt = amt / 73.4
        Return exchngamt
    End Function
    Public Function DTR(amt As Double) As Double
        Dim exchngamt As Double
        exchngamt = amt * 73.4
        Return exchngamt
    End Function
End Class

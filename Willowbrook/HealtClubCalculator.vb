Option Strict On

Public Class HealtClubCalculator

    Private _intBasicFee As Integer
    Public Const GOLF_FEE As Integer = 25
    Public Const TENNIS_FEE As Integer = 30
    Public Const RACQUETBALL_FEE As Integer = 20

    Public Property BasicFee As Integer
        Get
            Return _intBasicFee
        End Get
        Set(value As Integer)
            If value > 0 Then
                _intBasicFee = value
            Else
                _intBasicFee = 0
            End If
        End Set
    End Property

    Public Sub New()

        _intBasicFee = 0

    End Sub

    Public Function GetMonthlyDues() As Integer

        Dim intMonthlyDues As Integer



        Return intMonthlyDues

    End Function

End Class

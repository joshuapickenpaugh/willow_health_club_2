Option Strict On

Public Class HealtClubCalculator

    Private _intBasicFee As Integer
    Private _bolGolf As Boolean
    Private _bolTennis As Boolean
    Private _bolRacquetball As Boolean
    Private _intAdditionalCharges As Integer
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

    Public Property Golf As Boolean
        Get
            Return False
        End Get
        Set(value As Boolean)
            If value = True Then
                _bolGolf = True
            Else
                _bolGolf = False
            End If
        End Set
    End Property

    Public Property Tennis As Boolean
        Get
            Return False
        End Get
        Set(value As Boolean)
            If value = True Then
                _bolTennis = True
            Else
                _bolTennis = False
            End If
        End Set
    End Property

    Public Property Racquetball As Boolean
        Get
            Return False
        End Get
        Set(value As Boolean)
            If value = True Then
                _bolRacquetball = True
            Else
                _bolRacquetball = False
            End If
        End Set
    End Property

    Public Sub New()

        _intBasicFee = 0

    End Sub

    Public Function GetAdditionalCharges() As Integer

        If _bolGolf = True Then
            _intAdditionalCharges = GOLF_FEE
        End If

        If _bolTennis = True Then
            _intAdditionalCharges = _intAdditionalCharges + TENNIS_FEE
        End If

        If _bolRacquetball = True Then
            _intAdditionalCharges = _intAdditionalCharges + RACQUETBALL_FEE
        End If

        Return _intAdditionalCharges

    End Function

    Public Function GetMonthlyDues() As Integer

        Dim intMonthlyDues As Integer

        intMonthlyDues = _intBasicFee + _intAdditionalCharges

        Return intMonthlyDues

    End Function

End Class

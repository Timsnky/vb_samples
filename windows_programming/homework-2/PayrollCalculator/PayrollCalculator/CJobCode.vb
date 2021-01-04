'Name: Sultan Abuhaqab
'Date: 04/10/2020
'I affirm that this program was created by me. It Is solely my work and does not include any work done by anyone else.

Public Class CJobCode
    Private _strJobCode As String
    Private _intTotalEmployees As Integer
    Private _intTotalEmployeesWithBonus As Integer
    Private _dblTotalBonusPaid As Double
    Private _sngTotalScore As Double

    Public Sub New(strJobCode As String, dblTotalBonusPaid As Double, sngTotalScore As Single)
        _strJobCode = strJobCode
        _dblTotalBonusPaid = dblTotalBonusPaid
        _sngTotalScore = sngTotalScore
        _intTotalEmployees = 1
        If _dblTotalBonusPaid <> 0.0 Then
            _intTotalEmployeesWithBonus = 1
        Else
            _intTotalEmployeesWithBonus = 0
        End If
    End Sub

    Public ReadOnly Property JobCode() As String
        Get
            Return _strJobCode
        End Get
    End Property

    Public Property TotalEmployees() As Integer
        Get
            Return _intTotalEmployees
        End Get
        Set(intValue As Integer)
            _intTotalEmployees = intValue
        End Set
    End Property

    Public Property TotalEmployeesWithBonus() As Integer
        Get
            Return _intTotalEmployeesWithBonus
        End Get
        Set(intValue As Integer)
            _intTotalEmployeesWithBonus = intValue
        End Set
    End Property

    Public Property TotalBonusPaid() As Double
        Get
            Return _dblTotalBonusPaid
        End Get
        Set(dblValue As Double)
            _dblTotalBonusPaid = dblValue
        End Set
    End Property

    Public Property TotalScore() As Single
        Get
            Return _sngTotalScore
        End Get
        Set(sngValue As Single)
            _sngTotalScore = sngValue
        End Set
    End Property

    Public Function GetAverageScore() As Single
        Return _sngTotalScore / _intTotalEmployees
    End Function
End Class

Public Class CInstrument
    Private _strType As String
    Private _sngTotalCost As Single
    Private _intTotalCount As Integer

    Public Property Type As String
        Get
            Return _strType
        End Get
        Set(strVal As String)
            _strType = strVal
        End Set
    End Property
    Public Property TotalCost As Single
        Get
            Return _sngTotalCost
        End Get
        Set(sngVal As Single)
            _sngTotalCost = sngVal
        End Set
    End Property
    Public Property TotalCount As Integer
        Get
            Return _intTotalCount
        End Get
        Set(intVal As Integer)
            _intTotalCount = intVal
        End Set
    End Property
    Public Sub New(strInstType As String, sngCost As Single)
        _strType = strInstType
        _sngTotalCost = sngCost
        _intTotalCount = 1
    End Sub
End Class

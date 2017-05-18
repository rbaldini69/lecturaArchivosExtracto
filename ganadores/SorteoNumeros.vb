Public Class SorteoNumeros
    Public Unidad As Integer
    Public Decena As Integer
    Public Centena As Integer
    Public UnidadDeMil As Integer
    Public DecenaDeMil As Integer
    Sub New()

    End Sub
    Sub New(ByVal Uni As Integer)
        Me.Unidad = Uni
    End Sub
    Sub New(ByVal Uni As Integer, ByVal Dec As Integer)
        Me.Unidad = Uni
        Me.Decena = Dec
    End Sub
    Sub New(ByVal Uni As Integer, ByVal Dec As Integer, ByVal Cen As Integer)
        Me.Unidad = Uni
        Me.Decena = Dec
        Me.Centena = Cen
    End Sub
    Sub New(ByVal Uni As Integer, ByVal Dec As Integer, ByVal Cen As Integer, ByVal UMil As Integer)
        Me.Unidad = Uni
        Me.Decena = Dec
        Me.Centena = Cen
        Me.UnidadDeMil = UMil
    End Sub
    Sub New(ByVal Uni As Integer, ByVal Dec As Integer, ByVal Cen As Integer, ByVal UMil As Integer, ByVal DMil As Integer)
        Me.Unidad = Uni
        Me.Decena = Dec
        Me.Centena = Cen
        Me.UnidadDeMil = UMil
        Me.DecenaDeMil = DMil
    End Sub



End Class

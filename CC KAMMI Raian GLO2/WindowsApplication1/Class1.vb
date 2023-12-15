Public Class Medicament

    Public Idprod As String
    Public Nomprod As String
    Public prixprod As String
    Public quantitestock As String


    Public Function valider() As Boolean
        Dim state As Boolean = True

        If Not IsNumeric(Me.Idprod) Then
            state = False
        End If

        If IsNumeric(Me.Nomprod) Then
            state = False
        End If

        If Not IsNumeric(Me.prixprod) Then
            state = False

        End If

        If Not IsNumeric(Me.quantitestock) Then
            state = False
        End If

        Return state
    End Function
End Class

Imports System.Data.SqlClient
Public Class ado
Private cnx As SqlConnection
Private query As String

Public Sub New()

End Sub
Public Sub New(ByVal unSrv As String, ByVal uneBdd As String, ByVal unUser As String, ByVal unMdp As String)
    'Définition de la chaine de connexion
    Dim cnxChaine As String

    cnxChaine = "server=" & unSrv & ";user=" & unUser & ";password=" & unMdp & ";database=" & uneBdd
    Try
        cnx = New SqlConnection(cnxChaine)
    Catch ex As Exception

End Try

End Sub
Public Function getConnect() As SqlConnection
    'renvoi de la connection 
    Return cnx
End Function
Public Function etatConnect() As Boolean
    'test et renvoie l'état de la connexion  
    If cnx.State = ConnectionState.Open Then
            Return True
        Else
            Return False
    End If
End Function
Public Sub executNonQuery(ByVal uneRqt As String)
    'execution d'une requete qui ne renvoie pas de table ...
    Dim cmd As New SqlCommand(uneRqt, cnx)
    If etatConnect() = False Then
        cnx.Open()
    End If
    cmd.ExecuteReader()
    cnx.Close()
End Sub

Public Function getDataSet(ByVal uneRqt As String, ByVal unNom As String) As DataSet
    Dim ds As DataSet
    Dim da As SqlDataAdapter

    'on test que la connection est bien ouverte
    If cnx.State = ConnectionState.Closed Then
        cnx.Open()
    End If

    'initialisation du DataAdapter
    da = New SqlDataAdapter(uneRqt, Me.getConnect)
    'initialisation du dataSet
    ds = New DataSet(unNom)
    'affectation du da dans le Ds
    da.Fill(ds)
    'on retourn le dataset
    Return ds

End Function

Public Function executProcStockee(ByVal unNom As String, ByVal desParam As ArrayList)
    Dim cmd As SqlCommand

    'test de la connection 
    If cnx.State = ConnectionState.Closed Then
        cnx.Open()
    End If

    'définition de la sqlCommande
    cmd = New SqlCommand(unNom, Me.getConnect())

    'on parcour la liste des parametres et on les affecte a la sqlCommand
    For Each parametre As Object In desParam
        cmd.Parameters.Add(parametre)
    Next

    'on execute cette commande 
    cmd.ExecuteNonQuery()

End Function


End Class

Imports System.Data.SqlClient
Imports System.Web.Services

<System.Web.Services.WebService(Namespace := "http://tempuri.org/authentification/RecupInfoBdd")> _
Public Class RecupInfoBdd
    Inherits System.Web.Services.WebService
        Dim cnx As New ado("localhost", "rdv", "test", "test")


#Region " Code généré par le Concepteur des services Web "

    Public Sub New()
        MyBase.New()

        'Cet appel est requis par le Concepteur des services Web.
        InitializeComponent()

        'Ajoutez votre code d'initialisation après l'appel InitializeComponent()

    End Sub

    'Requis par le Concepteur des services Web
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur des services Web
    'Elle peut être modifiée en utilisant le Concepteur des services Web.  
    'Ne la modifiez pas en utilisant l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        'CODEGEN : cette procédure est requise par le Concepteur des services Web
        'Ne la modifiez pas en utilisant l'éditeur de code.
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#End Region

    <WebMethod()> Public Function getAllMed() As DataSet
        Dim query As String
        query = "select * from medecin"
        Return cnx.getDataSet(query, "medecin")
    End Function
    <WebMethod()> Public Function gelAllPat() As DataSet
        Dim query As String
        query = "select * from patient"
        Return cnx.getDataSet(query, "patient")
    End Function
    <WebMethod()> Public Function addRdv(ByVal uneRequete As String) As String
        Try
            cnx.executNonQuery(uneRequete)
            Return "Rendez vous enregistré"
        Catch ex As Exception
            Return "Un rendez vous est déja pris pour cette heure la"
    End Try
    End Function
    <WebMethod()> Public Function getAllRdvFix(ByVal uneDate As Date, ByVal unMed As String) As DataSet
    Dim query As String
        Try
            query = "select nompat , laDate from rdv , medecin , patient where medecin.nummed = rdv.nummed and patient.numpat = rdv.numpat and nommed='" & unMed & "' and day(laDate)=" & uneDate.Day & " and month(laDate)=" & uneDate.Month & " and year(laDate)=" & uneDate.Year & " order by laDate"
            Return cnx.getDataSet(query, "rdvfix")
       Catch ex As Exception

        End Try
    End Function

    <WebMethod()> Public Function enregistrerPatient(ByVal unNom As String, ByVal unPrenom As String, ByVal uneAd As String, ByVal unCp As String, ByVal uneVille As String, ByVal unTel As String, ByVal unMedTrait As String) As String
        Dim query As String
        query = "select nummed from medecin where nommed='" & unMedTrait & "'"


        Try
            Dim numMed As Integer
            numMed = cnx.getDataSet(query, "result").Tables(0).Rows(0)(0)
            query = "insert into patient (nompat, prenompat ,ad , cp , ville , tel , medecinTraitant) Values ('" & unNom & "' , '" & unPrenom & "' , '" & uneAd & "' , '" & unCp & "' , '" & uneVille & "' , '" & unTel & "' , " & numMed & ")"
            cnx.executNonQuery(query)
            Return "Patient enregistré"
        Catch ex As Exception
            Return query
End Try

    End Function
    <WebMethod()> Public Function enregistrerMedecin(ByVal unNom As String, ByVal unPrenom As String, ByVal uneAd As String, ByVal unCp As String, ByVal uneVille As String, ByVal unTel As String, ByVal uneSpe As String, ByVal unMobil As String, ByVal unMail As String, ByVal unPwd As String) As String
    Dim query As String
    Try
        query = "insert into medecin (nommed,prenommed,admed,cpmed,villemed,mailmed,mdp,specialite,mobile) VALUES ('" & unNom & "' , '" & unPrenom & "' , '" & uneAd & "' ,  '" & unCp & "' , '" & uneVille & "' , '" & unMail & "' , '" & unPwd & "', '" & uneSpe & "' , '" & unMobil & "')"
        cnx.executNonQuery(query)
        Return "Medecin enregistrer"
    Catch ex As Exception
        Return query
End Try
    End Function
        <WebMethod()> Public Function enregistrerSecretaire(ByVal unNom As String, ByVal unPrenom As String, ByVal uneAd As String, ByVal unCp As String, ByVal uneVille As String, ByVal unTel As String, ByVal unContrat As String, ByVal unMail As String, ByVal unPwd As String) As String

    Dim query As String
    Try
        query = "insert into secretaire (nomsec , prenomsec , mailsec , mdpsec , ad , ville , cp , contrat) VALUES ('" & unNom & "' , '" & unPrenom & "' , '" & unMail & "' , '" & unPwd & "' , '" & uneAd & "' , '" & uneVille & "' , '" & unCp & "' , '" & unContrat & "')"
        cnx.executNonQuery(query)
        Return "Secretaire enregistrée"
    Catch ex As Exception
        Return query
End Try
    End Function



End Class

Imports System.Web.Services
Imports System.Data.SqlClient


<System.Web.Services.WebService(Namespace:="http://tempuri.org/authentification/log")> _
Public Class Log
    Inherits System.Web.Services.WebService

    Dim query As String
    Dim cnx As ado



#Region " Code généré par le Concepteur des services Web "


    'Requis par le Concepteur des services Web
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur des services Web
    'Elle peut être modifiée en utilisant le Concepteur des services Web.  
    'Ne la modifiez pas en utilisant l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

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

    ' EXEMPLE DE SERVICE WEB
    ' L'exemple de service HelloWorld() retourne la chaîne Hello World.
    ' Pour générer, ne commentez pas les lignes suivantes, puis enregistrez et générez le projet.
    ' Pour tester ce service Web, assurez-vous que le fichier .asmx est la page de démarrage
    ' et appuyez sur F5.
    '
    '<WebMethod()> Public Function HelloWorld() As String
    '	HelloWorld = "Hello World"
    ' End Function

    Public Sub New()
        'Dim query As String
        'Dim unDs As DataSet

        InitializeComponent()

        Try
            cnx = New ado("localhost", "rdv", "test", "test")
        Catch ex As Exception


        End Try


    End Sub
    <WebMethod()> Public Function testLog(ByVal unMail As String, ByVal unPwd As String) As Boolean
        query = "select * from medecin where mailmed= '" & unMail & "' and mdp= '" & unPwd & "'"
        Try
            If cnx.getDataSet(query, "test").Tables(0).Rows.Count - 1 = 0 Then
                    Return True
                Else
                    query = "select * from secretaire where mailsec= '" & unMail & "' and mdpsec= '" & unPwd & "'"
                    If cnx.getDataSet(query, "test").Tables(0).Rows.Count - 1 = 0 Then
                            Return True
                        Else
                            Return False

                    End If
            End If
        Catch ex As Exception

    End Try

    End Function
    <WebMethod()> Public Function testType(ByVal unMail As String, ByVal unPwd As String) As String
        'web methode qui va permettre de définir si la personne qui se connect est un medecin ou une secraitaire
        Dim query As String
        query = "select * from medecin where mailmed= '" & unMail & "' and mdp= '" & unPwd & "'"
        If cnx.getDataSet(query, "test").Tables(0).Rows.Count = 1 Then
                Return "medecin"
            Else
                Return "secretaire"
        End If
    End Function
    <WebMethod()> Public Function getNomMed(ByVal unMail As String, ByVal unPwd As String) As String
        Dim query As String
        query = "select nommed from medecin where mailmed='" & unMail & "' and mdp = '" & unPwd & "'"
        Try
            Return Convert.ToString(cnx.getDataSet(query, "result").Tables(0).Rows(0).Item(0))
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

End Class

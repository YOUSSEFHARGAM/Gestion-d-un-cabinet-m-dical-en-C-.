Imports System.Web.Services

<System.Web.Services.WebService(Namespace := "http://tempuri.org/authentification/Horraire")> _
Public Class Horraire
    Inherits System.Web.Services.WebService

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

    ' EXEMPLE DE SERVICE WEB
    ' L'exemple de service HelloWorld() retourne la chaîne Hello World.
    ' Pour générer, ne commentez pas les lignes suivantes, puis enregistrez et générez le projet.
    ' Pour tester ce service Web, assurez-vous que le fichier .asmx est la page de démarrage
    ' et appuyez sur F5.
    '
    '<WebMethod()> Public Function HelloWorld() As String
    '	HelloWorld = "Hello World"
    ' End Function

End Class

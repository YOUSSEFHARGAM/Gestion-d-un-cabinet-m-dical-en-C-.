Imports System.Web
Imports System.Web.SessionState

Public Class Global
    Inherits System.Web.HttpApplication

#Region " Code généré par le Concepteur de composants "

    Public Sub New()
        MyBase.New()

        'Cet appel est requis par le Concepteur de composants.
        InitializeComponent()

        'Ajoutez une initialisation quelconque après l'appel InitializeComponent()

    End Sub

    'Requis par le Concepteur de composants
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur de composants
    'Elle peut être modifiée à l'aide du Concepteur de composants.  
    'Ne la modifiez pas en utilisant l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

#End Region

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se déclenche lorsque l'application est démarrée
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se déclenche lorsque la session est démarrée
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se déclenche au début de chaque demande
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se déclenche lors d'une tentative d'authentification de l'utilisation
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Se déclenche lorsqu'une erreur se produit
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se déclenche lorsque la session se termine
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se déclenche lorsque l'application se termine
    End Sub

End Class

Imports System.Net.Http.Headers
Imports Microsoft.Graph

Public Class MSGraphHelper
    Public ReadOnly Property MSALClient As New MSALClientHelper
    Private _graphServiceClient As GraphServiceClient
    Private Str_AccessToken As String

    Public Property AccessToken As String
        Get
            Return Str_AccessToken
        End Get
        Private Set(value As String)
            Str_AccessToken = value
        End Set
    End Property

    Public Sub New(mSALClient As MSALClientHelper)
        Me.MSALClient = mSALClient
    End Sub

    Public Async Function SignInAndInitializeGraphServiceClient() As Task(Of GraphServiceClient)
        Try
            AccessToken = Await MSALClient.SignInUserAndAcquireAccessToken(ScopesArray)
            Return Await InitializeGraphServiceClientAsync(AccessToken)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
    End Function

    Private Async Function InitializeGraphServiceClientAsync(token As String) As Task(Of GraphServiceClient)
        Try
            _graphServiceClient = New GraphServiceClient(MSGraphBaseUrl,
                New DelegateAuthenticationProvider(
                    Async Function(requestMessage)
                        requestMessage.Headers.Authorization = New AuthenticationHeaderValue("bearer", Await Task.FromResult(token))
                    End Function
                    )
                )

            Return Await Task.FromResult(_graphServiceClient)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
    End Function
End Class

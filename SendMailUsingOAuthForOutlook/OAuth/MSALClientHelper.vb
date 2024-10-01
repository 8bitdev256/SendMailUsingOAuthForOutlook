Imports Microsoft.Identity.Client
Imports Microsoft.Identity.Client.Extensions.Msal
Imports Microsoft.IdentityModel.Abstractions

Public Class MSALClientHelper
    Public Property PublicClientApplication As IPublicClientApplication
    Private PublicClientApplicationBuilder As PublicClientApplicationBuilder
    Public AuthResult As AuthenticationResult

    Public Sub New()
        InitializePublicClientApplicationBuilder()
    End Sub

    Private Sub InitializePublicClientApplicationBuilder()
        PublicClientApplicationBuilder = PublicClientApplicationBuilder.Create(ClientId).WithAuthority(String.Format(Authority, TenantId)).WithRedirectUri(String.Format(RedirectURI, ClientId)).WithLogging(New IdentityLogger(EventLogLevel.Warning), False).WithClientCapabilities(New String() {"cp1"})
    End Sub

    Public Async Function InitializePublicClientAppAsync() As Task(Of IAccount)
        PublicClientApplication = PublicClientApplicationBuilder.Build()

        Await AttachTokenCache()
        Return Await FetchSignedInUserFromCache().ConfigureAwait(False)
    End Function

    Private Async Function AttachTokenCache() As Task(Of IEnumerable(Of IAccount))
        Dim StorageProperties As StorageCreationProperties = New StorageCreationPropertiesBuilder(CacheFileName, CacheDir).Build()
        Dim MSALCacheHelperObj As MsalCacheHelper = Await MsalCacheHelper.CreateAsync(StorageProperties)
        MSALCacheHelperObj.RegisterCache(PublicClientApplication.UserTokenCache)

        Return Await PublicClientApplication.GetAccountsAsync().ConfigureAwait(False)
    End Function
    Private Async Function FetchSignedInUserFromCache() As Task(Of IAccount)
        Dim Accounts As IEnumerable(Of IAccount)

        Try
            Accounts = New List(Of IAccount)
            Accounts = Await PublicClientApplication.GetAccountsAsync().ConfigureAwait(False)

            If Accounts.Count() > 1 Then
                For Each Account As IAccount In Accounts
                    Await PublicClientApplication.RemoveAsync(Account)
                Next

                Return Nothing
            End If

            Return Accounts.SingleOrDefault()
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Async Function SignInUserAndAcquireAccessToken(scopes() As String) As Task(Of String)
        Dim ExistingUser As IAccount

        Try
            ExistingUser = Await FetchSignedInUserFromCache().ConfigureAwait(False)
            If Not IsNothing(ExistingUser) Then
                AuthResult = Await PublicClientApplication.AcquireTokenSilent(scopes, ExistingUser).ExecuteAsync().ConfigureAwait(False)
            Else
                AuthResult = Await SignInUserInteractivelyAsync(scopes)
            End If
        Catch ex As MsalUiRequiredException
            MessageBox.Show($"MsalUiRequiredException: {ex.Message}")
            Throw
        Catch msalEx As MsalException
            MessageBox.Show($"Error Acquiring Token:{Environment.NewLine}{msalEx}")
            Throw
        End Try

        Return AuthResult.AccessToken
    End Function

    Private Async Function SignInUserInteractivelyAsync(scopes() As String, Optional ExistingAccount As IAccount = Nothing) As Task(Of AuthenticationResult)
        Dim UserName As String = ""

        If Not IsNothing(ExistingAccount) Then
            If Not IsNothing(ExistingAccount.Username) Then
                UserName = ExistingAccount.Username
            End If
        End If

        Return Await PublicClientApplication.AcquireTokenInteractive(scopes).WithLoginHint(UserName).ExecuteAsync().ConfigureAwait(False)
    End Function
End Class

Public Module AzureADConfig
    Public Property Authority As String = "https://login.microsoftonline.com/{0}"
    Public Property ClientId As String = ""
    Public Property TenantId As String = ""
    Public Property RedirectURI As String = "ms-appx-web://microsoft.aad.brokerplugin/{0}"
    Public Property CacheFileName As String = "email_tokens_cache.txt"
    Public Property CacheDir As String = "C:/temp"
End Module

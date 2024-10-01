Public Module MSGraphApiConfig
    Public Property MSGraphBaseUrl As String = "https://graph.microsoft.com/v1.0"
    Public Property Scopes As String = "https://outlook.office.com/IMAP.AccessAsUser.All https://outlook.office.com/POP.AccessAsUser.All https://outlook.office.com/SMTP.Send"
    Public ReadOnly Property ScopesArray As String() = Scopes.Split(" ")
End Module

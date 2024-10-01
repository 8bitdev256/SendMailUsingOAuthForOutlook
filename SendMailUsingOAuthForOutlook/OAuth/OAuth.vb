Imports MimeKit
Imports MimeKit.Text
Imports MailKit.Net.Smtp
Imports MailKit.Security

Public Module OAuth
    Private ReadOnly MSALClientHelper As New MSALClientHelper()
    Private ReadOnly MSGraphHelper As New MSGraphHelper(MSALClientHelper)

    Public Async Function SendMailUsingOAuth2(Str_Smtp As String, Str_Port As String, Str_From As String, Str_User As String, Str_To As String, Str_Subject As String, Str_Msg As String) As Task
        Dim Str_AccessToken As String
        Str_AccessToken = Await GenerateAccessToken()

        Await SendMail(Str_AccessToken, Str_Smtp, Str_Port, Str_From, Str_User, Str_To, Str_Subject, Str_Msg)
    End Function

    Private Async Function GenerateAccessToken() As Task(Of String)
        Try
            Await MSALClientHelper.InitializePublicClientAppAsync()

            Await SignInTheUser()

            Return MSGraphHelper.AccessToken
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Async Function SignInTheUser() As Task
        Try
            Await MSGraphHelper.SignInAndInitializeGraphServiceClient()
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Async Function SendMail(Str_AccessToken As String, Str_Smtp As String, Str_Port As String, Str_From As String, Str_User As String, Str_To As String, Str_Subject As String, Str_Msg As String) As Task
        Try
            Dim email As New MimeMessage()
            Dim oauth2 As SaslMechanismOAuth2

            email.From.Add(New MailboxAddress(Str_User, Str_From))
            email.To.Add(New MailboxAddress("", Str_To))
            email.Subject = Str_Subject

            email.Body = New TextPart(TextFormat.Plain) With {
                .Text = Str_Msg
            }

            Dim smtp As New SmtpClient()
            smtp.Connect(Str_Smtp, Convert.ToInt32(Str_Port), SecureSocketOptions.StartTls)
            oauth2 = New SaslMechanismOAuth2(Str_From, Str_AccessToken)

            Await smtp.AuthenticateAsync(oauth2).ConfigureAwait(False)

            smtp.Send(email)
            smtp.Disconnect(True)

            MessageBox.Show("E-mail sent successfully!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
End Module

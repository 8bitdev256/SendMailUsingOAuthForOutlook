Public Class Form1
    Private Async Sub Btn_Send_Click(sender As Object, e As EventArgs) Handles Btn_Send.Click
        Try
            Await SendMailUsingOAuth2(Txt_SMTP.Text, Txt_Port.Text, Txt_From.Text, Txt_User.Text, Txt_To.Text, Txt_Subject.Text, Txt_Msg.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class

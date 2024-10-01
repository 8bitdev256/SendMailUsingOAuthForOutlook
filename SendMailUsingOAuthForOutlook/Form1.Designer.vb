<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_From = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_SMTP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Port = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_To = New System.Windows.Forms.TextBox()
        Me.Txt_User = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_Subject = New System.Windows.Forms.TextBox()
        Me.Txt_Msg = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_Send = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From"
        '
        'Txt_From
        '
        Me.Txt_From.Location = New System.Drawing.Point(44, 138)
        Me.Txt_From.Name = "Txt_From"
        Me.Txt_From.Size = New System.Drawing.Size(243, 20)
        Me.Txt_From.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SMTP Server"
        '
        'Txt_SMTP
        '
        Me.Txt_SMTP.Location = New System.Drawing.Point(44, 43)
        Me.Txt_SMTP.Name = "Txt_SMTP"
        Me.Txt_SMTP.Size = New System.Drawing.Size(196, 20)
        Me.Txt_SMTP.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(283, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Port"
        '
        'Txt_Port
        '
        Me.Txt_Port.Location = New System.Drawing.Point(286, 42)
        Me.Txt_Port.Name = "Txt_Port"
        Me.Txt_Port.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Port.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(310, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "To"
        '
        'Txt_To
        '
        Me.Txt_To.Location = New System.Drawing.Point(313, 137)
        Me.Txt_To.Name = "Txt_To"
        Me.Txt_To.Size = New System.Drawing.Size(212, 20)
        Me.Txt_To.TabIndex = 7
        '
        'Txt_User
        '
        Me.Txt_User.Location = New System.Drawing.Point(44, 89)
        Me.Txt_User.Name = "Txt_User"
        Me.Txt_User.Size = New System.Drawing.Size(196, 20)
        Me.Txt_User.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "User"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Subject"
        '
        'Txt_Subject
        '
        Me.Txt_Subject.Location = New System.Drawing.Point(44, 182)
        Me.Txt_Subject.Name = "Txt_Subject"
        Me.Txt_Subject.Size = New System.Drawing.Size(196, 20)
        Me.Txt_Subject.TabIndex = 11
        '
        'Txt_Msg
        '
        Me.Txt_Msg.Location = New System.Drawing.Point(44, 240)
        Me.Txt_Msg.Multiline = True
        Me.Txt_Msg.Name = "Txt_Msg"
        Me.Txt_Msg.Size = New System.Drawing.Size(342, 162)
        Me.Txt_Msg.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Message"
        '
        'Btn_Send
        '
        Me.Btn_Send.Location = New System.Drawing.Point(236, 415)
        Me.Btn_Send.Name = "Btn_Send"
        Me.Btn_Send.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Send.TabIndex = 14
        Me.Btn_Send.Text = "Send"
        Me.Btn_Send.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 450)
        Me.Controls.Add(Me.Btn_Send)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Txt_Msg)
        Me.Controls.Add(Me.Txt_Subject)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_User)
        Me.Controls.Add(Me.Txt_To)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_Port)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_SMTP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_From)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_From As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_SMTP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Port As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_To As TextBox
    Friend WithEvents Txt_User As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_Subject As TextBox
    Friend WithEvents Txt_Msg As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Btn_Send As Button
End Class

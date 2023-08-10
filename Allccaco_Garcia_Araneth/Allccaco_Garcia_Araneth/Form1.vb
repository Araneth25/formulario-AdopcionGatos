Public Class Form1
    Dim usuario As String
    Dim contrasenia As String
    Dim contrasenia2 As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btbLogin.Click
        usuario = txtUser.Text
        contrasenia = txtContrasenia.Text

        contrasenia2 = LCase(contrasenia)

        'EL USUARIO DEBE COLOCAR SU NOMBRE MINIMO DE 3 CARACTERES SI ES MENOS DE 2 NO PODRÁ ACCEDER
        'COLOCANDO LA CONTRASEÑA INDICADA TANTO EN EL FORMULARIO PODRÁ ACCEDER

        If Len(usuario) < 2 Or Len(usuario) = 0 And contrasenia2 = "catadop" Then
            lblCampoObligatorio.Visible = True
        Else
            If Len(usuario) >= 3 And contrasenia2 = "catadop" Then
                Form2.Show()
            Else
                MsgBox("NOMBRE CON MENOS DE 3 CARACTERES")
            End If

        End If


    End Sub

    Private Sub txtContrasenia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContrasenia.KeyDown
        contrasenia = txtContrasenia.Text
        usuario = txtUser.Text

        'CONTRASEÑA A MINUSCULA POR SI EL USUARIO ESCRIBE TANTO SE LO MUESTRA O CON MAYUSCULAS O MINUSCULAS
        'PODRÁ ACCEDER. SIN EMBARGO, SI ESCRIBE OTRA PALABRA QUE NO SEA LA INDICA NO LE DEJARÁ ENTRAR

        contrasenia2 = LCase(contrasenia)

        'DANDO EL USUARIO Y LA CONTRASEÑA CORRECTA PODRÁ PONER ENTER-INTRO Y ACCEDER AL SIGUIENTE FORMULARIO
        If Len(usuario) < 2 Then
            'MsgBox("NOMBRE CON MENOS DE 3 CARACTERES")
            lblCampoObligatorio.Visible = True
        Else
            If Len(usuario) >= 3 And contrasenia2 = "catadop" Then
                If e.KeyCode = 13 Then
                    Form2.Show()
                Else
                    MsgBox("Escribir la contraseña correctamente")
                End If
            End If

        End If

    End Sub

End Class

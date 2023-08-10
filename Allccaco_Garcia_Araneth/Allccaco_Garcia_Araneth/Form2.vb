Public Class Form2
    Dim nombre, apellido As String
    Dim direccion, ocupacion, comentarios, email, movil As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btbListo.Click
        nombre = txtNombre.Text
        apellido = txtApellidos.Text
        direccion = txtDireccion.Text
        ocupacion = txtOcupacion.Text
        email = txtEmail.Text
        movil = txtMovil.Text
        comentarios = txbComentar.Text

        'COLOCA MAYUSCULAS LA PRIMERA LETRA DE TODAS LAS CASILLAS CORRESPONDIENTES
        Dim cadena, cadena2 As String

        cadena = txtNombre.Text

        cadena2 = UCase(Mid(cadena, 1, 1))
        For i = 2 To Len(cadena)
            If Mid(cadena, i, 1) <> " " Then
                cadena2 = cadena2 & LCase(Mid(cadena, i, 1))
            Else
                i = i + 1
                cadena2 = cadena2 & " " & UCase(Mid(cadena, i, 1))
            End If
        Next

        txtNombre.Text = cadena2

        'APELLIDO
        Dim cadena3, cadena4 As String

        cadena3 = txtApellidos.Text

        cadena4 = UCase(Mid(cadena3, 1, 1))
        For i = 2 To Len(cadena3)
            If Mid(cadena3, i, 1) <> " " Then
                cadena4 = cadena4 & LCase(Mid(cadena3, i, 1))
            Else
                i = i + 1
                cadena4 = cadena4 & " " & UCase(Mid(cadena3, i, 1))
            End If
        Next

        txtApellidos.Text = cadena4

        'OCUPACION
        Dim cadena5, cadena6 As String

        cadena5 = txtOcupacion.Text

        cadena6 = UCase(Mid(cadena5, 1, 1))
        For i = 2 To Len(cadena5)
            If Mid(cadena5, i, 1) <> " " Then
                cadena6 = cadena6 & LCase(Mid(cadena5, i, 1))
            Else
                i = i + 1
                cadena6 = cadena6 & " " & UCase(Mid(cadena5, i, 1))
            End If
        Next

        txtOcupacion.Text = cadena6


        'DIRECCION
        Dim cadena7, cadena8 As String

        cadena7 = txtDireccion.Text

        cadena8 = UCase(Mid(cadena7, 1, 1))
        For i = 2 To Len(cadena7)
            If Mid(cadena7, i, 1) <> " " Then
                cadena8 = cadena8 & LCase(Mid(cadena7, i, 1))
            Else
                i = i + 1
                cadena8 = cadena8 & " " & UCase(Mid(cadena7, i, 1))
            End If
        Next

        txtDireccion.Text = cadena8


        'EL ADOPTANTE DEBE COMPLETAR EL FORMULARIO DEBIDAMENTE SIENDO HONESTO
        'EL NOMBRE DEBE DE TENER MINIMO 3 CARACTERES, ASI MISMO COMO APELLIDO, DIRECCIÓN Y OCUPACIÓN DEL ADOPTANTE
        'LOS NUMEROS TANTO DE TELEFONICO COMO MOVIL DEBE SER IGUAL A 9 DIGITOS NI MÁS NI MENOS

        If Len(nombre) < 2 And Len(apellido) < 2 And Len(direccion) < 2 And Len(ocupacion) < 2 And Len(movil) < 9 And Len(email) < 2 And Len(comentarios) = 0 Then
            MsgBox("Nombre/Apellidos con menos de 3 caracteres")
        Else
            If Len(nombre) >= 3 And Len(apellido) >= 3 And Len(direccion) >= 3 And Len(ocupacion) >= 3 And Len(movil) = 9 And Len(comentarios) > 10 And Len(email) > 10 And rbSI.Checked Then
                Form3.Show()

            Else
                If rbNO.Checked Then
                    MsgBox("LO LAMENTAMOS AL NO ESTAR DE ACUERDO TODOS LOS FAMILIARES, LA ADOPCION NO SE MANTENDRÁ EN CUENTA", vbInformation)
                    Form4.Show()
                Else
                    MsgBox("LAS OPCIONES QUE TE PUEDEN FALTAR SON LAS SIGUIENTES:

                          - Nombre/Apellidos con más de 3 caracteres
                          - Dirección/Ocupación
                          - Numero telefónico o de móvil
                              (Números de 9 digitos)
                          - Email con más de 10 caracteres
                          - MARCAR SI - NO 
                          - Comentar con más de 10 caracteres
                            
                       MUCHAS GRACIAS! ")

                    'Por si les falta un campo obligatorio les saldrá a parte del mensaje box
                    'Un label donde muestre el campo referente
                    lblCampoObligatorio.Visible = True
                    lblCampoObligatorio1.Visible = True
                    lblCampoObligatorio2.Visible = True
                    lblCampoObligatorio3.Visible = True
                    lblCampoObligatorio4.Visible = True
                    lblCampoObligatorio5.Visible = True
                    lblCampoObligatorio6.Visible = True
                    lblCampoObligatorio7.Visible = True
                End If
            End If
        End If

    End Sub

    Private Sub btbCerrar_Click(sender As Object, e As EventArgs) Handles btbCerrar.Click
        'SI EL USUARIO PINCHA EL BOTÓN DE CERRAR, SE CERRÁ EL FORMULARIO INDICADO
        Me.Close()

    End Sub

    Private Sub btbReset_Click(sender As Object, e As EventArgs) Handles btbReset.Click
        'SI EL USUARIO COLOCA RESET SE LIMPIARÁ TODAS LAS CASILLAS QUE HAYA RELLENADO
        txtNombre.Clear()
        txtApellidos.Clear()
        txtOcupacion.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtMovil.Clear()
        txtEmail.Clear()
        txbComentar.Clear()
        rbSI.Checked = False
        rbNO.Checked = False


        'TAMBIÉN EL USUARIO DEJARÁ DE VER LOS CAMPOS OBLIGATORIOS COMO UN NUEVO FORMULARIO
        lblCampoObligatorio.Visible = False
        lblCampoObligatorio1.Visible = False
        lblCampoObligatorio2.Visible = False
        lblCampoObligatorio3.Visible = False
        lblCampoObligatorio4.Visible = False
        lblCampoObligatorio5.Visible = False
        lblCampoObligatorio6.Visible = False
        lblCampoObligatorio7.Visible = False
    End Sub

    Private Sub txtMovil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMovil.KeyPress
        'EL USUARIO DEBE COLOCAR SI O SI EL TELEFONO DE MOVIL SÓLO CON NUMEROS NO LETRAS
        'ESO INCLUYE QUE SÓLO ESTÁ CON NUMERACIÓN
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo puedes digitar numeros")
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        'EL USUARIO DEBE COLOCAR EL NUMERO DE TELEFONO SÓLO CON NUMEROS NO LETRAS
        'SINO LE SALTARÁ EL MENSAJE DE QUE SOLO DEBE USAR DIGITOS NUMERICOS Y NO LETRAS O DE CARACTER
        'PARA ELLO EL CODIGO PRESENTA QUE SI USA A PESAR UN CARACTER LE SALDRÁ UN AVISO
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Sólo puedes digitar números")
        End If
    End Sub
End Class
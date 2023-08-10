Public Class Form3
    Private Sub btbListo_Click(sender As Object, e As EventArgs) Handles btbListo.Click

        'EL USUARIO DEBE SELECCIONAR SI O SI UN ELEMENTO O ITEM DE LA LISTA POR ELLO, SI NO MARCA UNO SALDRÁ
        'UN LABEL DONDE LE MENCIONARA QUE EL CAMPO ES OBLIGATORIO
        If ComboBox1.SelectedIndex > -1 And (cb1.Checked Or cb2.Checked Or cb3.Checked Or cb4.Checked Or cb5.Checked) Then
            ' Ha seleccionado el item ComboBox1
            Form5.Show()

        Else
            lblCampoObligatorio.Visible = True
            lblCampoObligatorio1.Visible = True
            ' No ha seleccionado nada
        End If


        'PRUEBA PARA LOS CHECKBOX
        ' If cb1.Checked Or cb2.Checked Or cb3.Checked Or cb4.Checked Or cb5.Checked Then
        'Form5.Show()
        'Else
        'lblCampoObligatorio.Visible = True
        'End If

    End Sub
End Class
Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ACTIVAR EL TIMER PARA QUE EN 5 SEGUNOS SE CIERRE EL FORMULARIO DADO QUE EL USUARIO HA COLOCADO NO
        Timer1.Enabled = True
        Timer1.Interval = 3000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'UNA VEZ QUE EL USUARIO HAYA MARCADO SUS PREFERENCIAS EN OBTENER UN GATITO SE CERRARÁN LAS VENTANAS
        Form1.Close()
        Form2.Close()
        Form3.Close()
        Timer1.Enabled = False

        Me.Close()
    End Sub
End Class
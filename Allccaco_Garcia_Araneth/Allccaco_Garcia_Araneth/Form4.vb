Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ACTIVAR EL TIMER PARA QUE EN 3 SEGUNOS SE CIERRE EL FORMULARIO DADO QUE EL USUARIO HA COLOCADO NO
        Timer1.Enabled = True
        Timer1.Interval = 3000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'SE CERRARAN LOS DEMAS FORMULARIOS
        Me.Close()
        Form2.Close()
        Form1.Close()
        Timer1.Enabled = False

    End Sub

End Class
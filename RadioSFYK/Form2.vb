Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = Form1.CenterForm(Me, Me.Location)
        FlatAlertBox1.Visible = True
        Internet()
    End Sub

    ' Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
    '     Form2.Show()
    ' End Sub

    ' Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
    '     Form2.Dispose()
    ' End Sub

    

    Private Sub Internet()
        'BLOQUEO EL FORMULARIO PARA EVITAR INCONVENIENTES CON EL ARRASTRE DEL MISMO DURANTE LA COMPROBACION 
        Me.Enabled = False
        'ESTABLESCO TODOS LOS VALORES DESDE EL COMIENZO. 
        ip.Text = "---.---.---.---"
        estadointernet.Text = "Getting..."
        estado.Text = "Status: Validating Internet connection..."
        'CREO LA VARIABLE DONDE ALMACENO EL TEXTO OBTENIDO DE LA WEB "www.msftncsi.com/ncsi.txt" DE MICROSOFT 
        Dim conectarncsi
        'SI SE PRODUCE UN ERROR A PARTIR DE ACA, POR EJEMPLO QUE NO HAYA INTERNET QUE CONTINUE y NO DE ERROR LA APLICACION... 
        On Error Resume Next
        'ALMACENO EN LA VARIABLE EL TEXTO OBTENIDO DE "www.msftncsi.com/ncsi.txt" 
        conectarncsi = New System.Net.WebClient().DownloadString("http://www.msftncsi.com/ncsi.txt")

        'SI EL TEXTO OBTENIDO DE LA WEB DE MICROSOFT ES IGUAL A "Microsoft NCSI" ENTONCES HAY INTERNET 
        If conectarncsi = "Microsoft NCSI" Then
            'Muestro que si hay internet en ESTADOINTERNET.text 
            estadointernet.Text = "Yes"
            'Color verde 
            FlatAlertBox1.Text = "You are connected..."
            FlatAlertBox1.kind = FlatAlertBox._Kind.Success
            FlatButton1.Visible = True
            estadointernet.ForeColor = Color.Green
            'Muestro que voy a obtener IP publica 
            estado.Text = "Status: Obtaining public IP ..."
            'creo variable ippublica 
            Dim ippublica
            'LEO DE MI WEB LA IP PUBLICA QUE DETECTA MI SERVIDOR "www.peopledise.tk/ip.php" 
            ippublica = New System.Net.WebClient().DownloadString("http://peopledise.tk/ip.php")
            'MUESTRO LA IP PUBLICA QUE ALMACENE EN LA VARIABLE EN IP.TEXT 
            ip.Text = ippublica
            'COLOR AZUL O PREFERIDO A GUSTO.... 
            ip.ForeColor = Color.Blue

        Else
            'SINO ES IGUAL NO HAY INTERNET 
            estadointernet.Text = "No"
            'color ROJo 
            FlatAlertBox1.Text = "Error Connecting"
            FlatAlertBox1.kind = FlatAlertBox._Kind.Error
            FlatButton2.Visible = True
            estadointernet.ForeColor = Color.Red
            'MUESTRO QUE NO SE OBTUVO LA IP 
            ip.Text = "---.---.---.---"
            'COLOR ROJO 
            ip.ForeColor = Color.Red

        End If
        'MUESTRO QUE TERMINE 
        estado.Text = "Status: Completed."
        'HABILITO EL FORMULARIO PARA QUE SE PUEDA CLIQUEAR, MOVER... 
        Me.Enabled = True
    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click
        Me.Close()
    End Sub
    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click
        End
    End Sub
End Class
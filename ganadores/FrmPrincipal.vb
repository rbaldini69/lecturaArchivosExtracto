
Imports System
Imports System.IO
Imports System.Windows.Forms
Imports System.Text

Public Class Form1
    Dim cantRegistros As Integer = 0
    Dim cantRegistros2 As Integer = 0
    'posicion
    Dim version As String                                       '1 a 2 
    Dim CodJuego As String                                       '3 a 4
    Dim NumeroDeSorteo As String                                       '5 a 9
    Dim CantidadDeSorteosJugados As String                                       '10a 11
    Dim proveedor As String                                       '12a 12
    Dim provincia As String                                       '13a 14
    Dim agencia As String                                       '15a 19
    Dim digitoVerificador As String                                       '20a 20
    Dim NumeroDeTerminal As String                                       '21a 28
    Dim FechaDeVenta As String                                       '29a36
    Dim HoraDeVenta As String                                       '37a 42
    Dim FechaCancelacion As String                                       '43a 50
    Dim HoraCancelacion As String                                       '52a 56
    Dim cantidadDePartes As String                                       '57a 58
    Dim numeroDeTicket As String                                       '59a 68
    Dim OrdinalDeApuesta As String                                       '69a 70
    Dim valorDeApuesta As String                                       '71a 80
    Dim tipoDeDocumento As String                                       '82a 89
    Dim reservado As String                                       '90a 90
    Dim valorTotalApuestas As Long = 0


    Dim ruta As String
    'Dim frmresul As New frmResultados()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'frmresul.Show()
        'frmresul.Location = New Point(1500, 600)
        'frmresul.WindowState = FormWindowState.Maximized
        'Me.txtUnidad.Focus()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt5Aciertos_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtDecena_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub txtCentena_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtUMil_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtDMil_TextChanged(sender As Object, e As EventArgs)
        'txtcMil.Focus()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtArchivo_Click(sender As Object, e As EventArgs) Handles txtArchivo.Click
        Dim ruta As String
        Dim Openf As New OpenFileDialog
        Dim registros As New ArrayList()
        'Dim vendido As String
        If Openf.ShowDialog() = DialogResult.OK Then
            ruta = Openf.FileName.ToString()



            'Call Button1_Click_2(e, sender)
            For Each Ctrl As Control In Me.gbxExtractos.Controls
                If TypeOf (Ctrl) Is TextBox Then
                    CType(Ctrl, TextBox).Clear()
                End If
            Next
            Dim lector As StreamReader = New StreamReader(ruta)
            Dim lector2 As StreamReader = New StreamReader(ruta)
            Dim linea As String
            Dim linea0 As String
            Do
                linea0 = lector.ReadLine()
                cantRegistros += 1


            Loop Until linea0 Is Nothing
            ProgressBar1.Maximum = cantRegistros
            '        Timer1.Enabled = True

            MsgBox("fin de lectura de archivo, cant. de registros: " & cantRegistros)
            lector.Close()

            Do
                linea = lector2.ReadLine()
                Me.valorDeApuesta = Mid(linea, 71, 8)
                cantRegistros2 += 1
                Dim auxvalor As Long
                Long.TryParse(valorDeApuesta, auxValor)
                valorTotalApuestas = valorTotalApuestas + auxvalor

                ProgressBar1.Value += 1
            Loop Until linea Is Nothing
            Me.txtValorApuesta.Text = Format(CDec(valorTotalApuestas), "C")


            lector2.Close()


        End If

    End Sub

    Private Sub txtUnidad_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        For Each Ctrl As Control In Me.gbxExtractos.Controls
            If TypeOf (Ctrl) Is TextBox Then
                CType(Ctrl, TextBox).Clear()
                CType(Ctrl, TextBox).ForeColor = Color.Black
                CType(Ctrl, TextBox).BackColor = Color.White
            End If
        Next
        For Each Ctrl As Control In Me.gbxExtractos.Controls
            If TypeOf (Ctrl) Is TextBox Then
                CType(Ctrl, TextBox).Clear()
            End If
        Next
    End Sub
    Private Sub txtDMil_TextChanged_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtUMil_TextChanged_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtCentena_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtDecena_TextChanged_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs)
    End Sub
    Private Sub txt(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtUnidad_Enter(sender As Object, e As EventArgs)
    End Sub
    Private Sub txtDecena_Enter(sender As Object, e As EventArgs)
    End Sub

    Private Sub txtCentena_Enter(sender As Object, e As EventArgs)
    End Sub

    Private Sub txtUMil_Enter(sender As Object, e As EventArgs)
    End Sub

    Private Sub txtDMil_Enter(sender As Object, e As EventArgs)
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtBillGanador_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtUnidad_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub txtDecena_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub txtCentena_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub txtUMil_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub txtDMil_KeyPress(sender As Object, e As KeyPressEventArgs)


    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs) Handles gbxExtractos.Enter

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value * 100 / cantRegistros
    End Sub
End Class

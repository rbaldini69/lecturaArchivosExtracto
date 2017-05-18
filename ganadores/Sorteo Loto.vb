
Imports System
Imports System.IO
Imports System.Windows.Forms
Imports System.Text

Public Class Form1
    Dim ruta As String
    Dim frmresul As New frmResultados()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmresul.Show()
        frmresul.Location = New Point(1500, 600)
        frmresul.WindowState = FormWindowState.Maximized
        Me.txtUnidad.Focus()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSorteado.TextChanged

        '      Dim ListaBilletes As New ArrayList()
        ruta = Me.lblRutaArchivo.Text

        If ruta <> "Archivo no seleccionado" Then
            Dim billete As String
            Dim CantGan1 As Integer
            Dim CantGan2 As Integer
            Dim CantGan3 As Integer
            Dim CantGan4 As Integer
            Dim CantGan5 As Integer
            Dim sr As StreamReader = New StreamReader(ruta) 'hacer funcionar boton archivo
            Dim ganador As String
            Dim vendidos As Integer
            Dim billeteGanador As String
            Dim ListaBilletes As New ArrayList()
            billeteGanador = "Sin Ganador"

            ganador = Me.txtSorteado.Text

            Dim posicion As Byte
            posicion = Len(ganador)
            Do
                billete = sr.ReadLine()
                If (Mid(billete, 19) = "V") Then
                    ListaBilletes.Add(billete)
                End If
            Loop Until billete Is Nothing
            vendidos = ListaBilletes.Count()
            sr.Close()
            Select Case posicion
                Case 1
                    For Each billete In ListaBilletes
                        If Mid(billete, 15, 1) = ganador Then
                            CantGan1 += 1
                            billeteGanador = Mid(billete, 11, 5)

                        End If
                    Next
                    If CantGan1 = 0 Then                                            'SIN GANADORES
                        Me.txt1Acierto.Text = "No hay gandores"                     'MENSAJE NO HAY GANADORES EN DIGITO ACTUAL
                        Me.txtUnidad.Focus()                                        'UNIDAD PERMANECE CON FOCO PARA INSERTAR NUEVO DIGITO
                        Me.txtUnidad.BackColor = System.Drawing.Color.Red()         'EL COLOR DE FONDO LLAMA LA ATENCION CON EL COLOR ROJO
                        Me.txtUnidad.ForeColor = Color.White                        'EL COLOR DE LETRA SE PONE BLANCO
                        frmresul.txtUnidad.Text = Me.txtUnidad.Text                 'MUESTRO EN PANATALLLA VIVO EL DIGITO SORTEADO
                        frmresul.txtUnidad.ForeColor = Color.Red()                  'EL COLOR DE LETRA DE PANTALLA SE PONE ROJO
                        frmresul.lblNumBilGdor.Text = "Extraer otra bolilla"        'TXTMENSAJE TOMA VALOR "EXTRAER BOLILLA" EN PANTALLA VIVO
                        frmresul.lblNumBilGdor.Visible = True                       'SE HACE VISIBLE MENSAJE 

                        Exit Sub
                    ElseIf CantGan1 = 1 Then                                        '
                        Me.txtBillGanador.Text = billeteGanador
                        Me.txt1Acierto.Text = CantGan1
                        Me.txtUnidad.BackColor = Color.Green()
                        Me.txtUnidad.ForeColor = Color.White
                        'frmresul.lblNumBilGdor.Text = billeteGanador.ToString()
                        lblBilleteGanador.Visible = True
                        'frmresul.lblBGanador.Visible = True
                        'frmresul.lblNumBilGdor.Visible = True
                        'frmresul.Timer1.Enabled = True
                        frmresul.txtUnidad.Text = ganador
                        frmresul.lblNumBilGdor.Visible = False
                        'frmresul.txtUnidad.Text = Me.txtUnidad.Text
                        frmresul.txtUnidad.ForeColor = Color.Black()
                        Me.txtDecena.Focus()

                    Else
                        Me.txt1Acierto.Text = CantGan1
                        Me.txtDecena.Focus()
                        Me.txtUnidad.BackColor = Color.Green()
                        Me.txtUnidad.ForeColor = Color.White
                        frmresul.txtUnidad.Text = ganador
                        frmresul.lblNumBilGdor.Visible = False
                        frmresul.txtUnidad.Text = Me.txtUnidad.Text
                        frmresul.txtUnidad.ForeColor = Color.Black()
                        ' Dim SorteoActualUnidad As New SorteoNumeros(ganador)
                        'Dim frm2 As New frmResultados()

                        'frmResult.txtUnidad.Text = ganador

                        'frm2.Show()
                    End If


                Case 2
                    For Each billete In ListaBilletes
                        If Mid(billete, 14, 2) = ganador Then
                            CantGan2 += 1
                            billeteGanador = Mid(billete, 11, 5)
                        End If
                    Next
                    If CantGan2 = 0 Then
                        Me.txt2Aciertos.Text = "No hay gandores"
                        Me.txtDecena.Focus()
                        Me.txtDecena.BackColor = System.Drawing.Color.Red()
                        Me.txtDecena.ForeColor = Color.White
                        frmresul.txtDecena.Text = Me.txtDecena.Text
                        frmresul.txtDecena.ForeColor = Color.Red()
                        frmresul.lblNumBilGdor.Text = "Extraer otra bolilla"
                        frmresul.lblNumBilGdor.Visible = True
                        Exit Sub
                    ElseIf CantGan2 = 1 Then

                        Me.txt2Aciertos.Text = CantGan2
                        Me.txtDecena.BackColor = Color.Green()
                        Me.txtDecena.ForeColor = Color.White
                        Me.txtBillGanador.Text = billeteGanador
                        lblBilleteGanador.Visible = True
                        frmresul.txtDecena.Text = Mid(ganador, 1, 1)
                        frmresul.lblNumBilGdor.Visible = False
                        frmresul.txtDecena.ForeColor = Color.Black()
                        'frmresul.lblNumBilGdor.Text = billeteGanador.ToString()
                        'frmresul.lblBGanador.Visible = True
                        'frmresul.lblNumBilGdor.Visible = True
                        'frmresul.Timer1.Enabled = True
                        Me.txtCentena.Focus()
                    Else
                        Me.txt2Aciertos.Text = CantGan2
                        Me.txtCentena.Focus()
                        Me.txtDecena.BackColor = System.Drawing.Color.Green()
                        Me.txtDecena.ForeColor = Color.White
                        frmresul.txtDecena.Text = Mid(ganador, 1, 1)
                        frmresul.lblNumBilGdor.Visible = False
                        frmresul.txtDecena.ForeColor = Color.Black()
                        'frmresul.lblBGanador.Visible = True
                    End If
                Case 3
                    For Each billete In ListaBilletes
                        If Mid(billete, 13, 3) = ganador Then
                            CantGan3 += 1
                            billeteGanador = Mid(billete, 11, 5)
                        End If
                    Next
                    If CantGan3 = 0 Then
                        Me.txt3Aciertos.Text = "No hay gandores"

                        Me.txtCentena.BackColor = System.Drawing.Color.Red()
                        Me.txtCentena.ForeColor = Color.White
                        frmresul.txtCentena.Text = Me.txtCentena.Text
                        frmresul.txtCentena.ForeColor = Color.Red()
                        frmresul.lblNumBilGdor.Text = "Extraer otra bolilla"
                        frmresul.lblNumBilGdor.Visible = True
                        Exit Sub
                    ElseIf CantGan3 = 1 Then
                        Me.txt3Aciertos.Text = CantGan3
                        Me.txtCentena.BackColor = Color.Green()
                        Me.txtCentena.ForeColor = Color.White
                        Me.txtBillGanador.Text = billeteGanador
                        Me.txtUMil.Focus()
                        lblBilleteGanador.Visible = True
                        frmresul.txtCentena.Text = Mid(ganador, 1, 1)
                        frmresul.lblNumBilGdor.Visible = False
                        frmresul.txtCentena.ForeColor = Color.Black()
                        'frmresul.lblBGanador.Visible = True
                        'frmresul.lblNumBilGdor.Text = billeteGanador.ToString()
                        'frmresul.Timer1.Enabled = True
                        'Me.txtUMil.Focus()
                    Else
                        Me.txt3Aciertos.Text = CantGan3
                        Me.txtUMil.Focus()
                        Me.txtCentena.BackColor = System.Drawing.Color.Green()
                        Me.txtCentena.ForeColor = Color.White
                        frmresul.txtCentena.Text = Mid(ganador, 1, 1)
                        frmresul.txtCentena.ForeColor = Color.Black()
                        'frmresul.lblBGanador.Visible = True
                    End If
                Case 4
                    For Each billete In ListaBilletes
                        If Mid(billete, 12, 4) = ganador Then
                            CantGan4 += 1
                            billeteGanador = Mid(billete, 11, 5)
                        End If
                    Next
                    If CantGan4 = 0 Then
                        Me.txt4Aciertos.Text = "No hay gandores"
                        Me.txtUMil.Focus()
                        Me.txtUMil.BackColor = System.Drawing.Color.Red()
                        Me.txtUMil.ForeColor = Color.White
                        frmresul.txtUnidadMil.Text = Me.txtUMil.Text
                        frmresul.txtUnidadMil.ForeColor = Color.Red()
                        frmresul.lblNumBilGdor.Text = "Extraer otra bolilla"
                        frmresul.lblNumBilGdor.Visible = True
                        Exit Sub
                    ElseIf CantGan4 = 1 Then
                        Me.txtBillGanador.Text = billeteGanador
                        Me.txt4Aciertos.Text = CantGan4
                        Me.txtUMil.BackColor = Color.Green()
                        Me.txtUMil.ForeColor = Color.White
                        lblBilleteGanador.Visible = True
                        frmresul.txtUnidadMil.Text = Mid(ganador, 1, 1)
                        frmresul.txtUnidadMil.ForeColor = Color.Black()
                        'frmresul.lblBGanador.Visible = True
                        'frmresul.lblNumBilGdor.Text = billeteGanador.ToString()
                        'frmresul.lblNumBilGdor.Visible = True
                        'frmresul.Timer1.Enabled = True
                        frmresul.lblNumBilGdor.Visible = False
                        Me.txtDMil.Focus()
                    Else
                        Me.txt4Aciertos.Text = CantGan4
                        Me.txtDMil.Focus()
                        Me.txtUMil.BackColor = System.Drawing.Color.Green()
                        Me.txtUMil.ForeColor = Color.White
                        frmresul.txtUnidadMil.Text = Mid(ganador, 1, 1)
                        frmresul.lblNumBilGdor.Visible = False
                        frmresul.txtUnidadMil.ForeColor = Color.Black()
                    End If
                Case 5
                    For Each billete In ListaBilletes
                        If Mid(billete, 11, 5) = ganador Then
                            CantGan5 += 1
                            billeteGanador = Mid(billete, 11, 5)
                        End If
                    Next
                    If CantGan5 = 0 Then
                        Me.txt5Aciertos.Text = "No hay gandores"
                        Me.txtDMil.Focus()
                        Me.txtDMil.BackColor = System.Drawing.Color.Red()
                        Me.txtDMil.ForeColor = Color.White
                        frmresul.txtDecenaMil.Text = Me.txtDMil.Text
                        frmresul.txtDecenaMil.ForeColor = Color.Red()
                        frmresul.lblNumBilGdor.Text = "Extraer otra bolilla"
                        frmresul.lblNumBilGdor.Visible = True

                        Exit Sub
                    ElseIf CantGan5 = 1 Then
                        Me.txt5Aciertos.Text = CantGan5
                        Me.txtDMil.BackColor = Color.Green()
                        Me.txtDMil.ForeColor = Color.White
                        Me.txtBillGanador.Text = billeteGanador
                        lblBilleteGanador.Visible = True
                        frmresul.txtDecenaMil.Text = Mid(ganador, 1, 1)
                        frmresul.lblBGanador.Visible = True
                        frmresul.lblNumBilGdor.Visible = True
                        frmresul.lblNumBilGdor.Text = ganador.ToString()
                        frmresul.lblNumBilGdor.Height = 630
                        frmresul.txtDecenaMil.ForeColor = Color.Black()

                        frmresul.lblNumBilGdor.TextAlign = ContentAlignment.TopCenter

                        frmresul.Timer1.Enabled = True
                    Else
                        Me.txt5Aciertos.Text = CantGan5
                        Me.txtDMil.ForeColor = Color.White
                        Me.txtDMil.BackColor = Color.Green
                        frmresul.txtDecenaMil.Text = Mid(ganador, 1, 1)
                        frmresul.txtDecenaMil.ForeColor = Color.Black()
                        'frmresul.lblBGanador.Visible = True

                    End If

            End Select
        Else
            MessageBox.Show("Debe seleccionar el archivo")

            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txt5Aciertos_TextChanged(sender As Object, e As EventArgs) Handles txt5Aciertos.TextChanged

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

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
        Dim CantidadBilletes As New ArrayList()
        'Dim vendido As String
        If Openf.ShowDialog() = DialogResult.OK Then
            ruta = Openf.FileName.ToString()

            Me.lblRutaArchivo.Text = ruta
            Me.txtUnidad.Focus()
            'Call Button1_Click_2(e, sender)
            For Each Ctrl As Control In Me.GroupBox2.Controls
                If TypeOf (Ctrl) Is TextBox Then
                    CType(Ctrl, TextBox).Clear()
                    CType(Ctrl, TextBox).ForeColor = Color.Black
                    CType(Ctrl, TextBox).BackColor = Color.White

                End If
            Next
            For Each Ctrl As Control In Me.GroupBox1.Controls
                If TypeOf (Ctrl) Is TextBox Then
                    CType(Ctrl, TextBox).Clear()

                End If
            Next
            For Each Ctrl As Control In Me.frmresul.Controls
                If TypeOf (Ctrl) Is TextBox Then
                    CType(Ctrl, TextBox).ForeColor = Color.Black()
                    CType(Ctrl, TextBox).Clear()

                End If
            Next
            '  Me.frmresul.txtUnidad.Clear()
            ' Me.frmresul.txtDecena.Clear()
            'Me.frmresul.txtCentena.Clear()
            'Me.frmresul.txtUnidadMil.Clear()
            'Me.frmresul.txtDecenaMil.Clear()
            Me.frmresul.lblBGanador.Visible = False

            Me.frmresul.lblNumBilGdor.Text = "Extraer Bolillas"
            frmresul.lblNumBilGdor.Visible = False
            frmresul.lblNumBilGdor.ForeColor = Color.Black
            frmresul.lblPremio.ForeColor = Color.Black
            frmresul.Timer1.Enabled = False
            Me.txtUnidad.Focus()
            Dim lector As StreamReader = New StreamReader(ruta)
            Dim vendido As String
            Do
                vendido = lector.ReadLine()
                If (Mid(vendido, 19) = "V") Then
                    CantidadBilletes.Add(vendido)
                End If
            Loop Until vendido Is Nothing
            Me.lblVendidos.Text = CantidadBilletes.Count & " Billetes vendidos"


        End If

    End Sub

    Private Sub txtUnidad_TextChanged(sender As Object, e As EventArgs) Handles txtUnidad.TextChanged
        ' txtDecena.Focus()
        txtSorteado.Text = Me.txtUnidad.Text
    End Sub
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        For Each Ctrl As Control In Me.GroupBox2.Controls
            If TypeOf (Ctrl) Is TextBox Then
                CType(Ctrl, TextBox).Clear()
                CType(Ctrl, TextBox).ForeColor = Color.Black
                CType(Ctrl, TextBox).BackColor = Color.White

            End If
        Next
        For Each Ctrl As Control In Me.GroupBox1.Controls
            If TypeOf (Ctrl) Is TextBox Then
                CType(Ctrl, TextBox).Clear()

            End If
        Next
        For Each Ctrl As Control In Me.frmresul.Controls
            If TypeOf (Ctrl) Is TextBox Then
                CType(Ctrl, TextBox).ForeColor = Color.Black()
                CType(Ctrl, TextBox).Clear()
            End If
        Next
        '       Me.frmresul.txtUnidad.Clear()
        '      Me.frmresul.txtDecena.Clear()
        '     Me.frmresul.txtCentena.Clear()
        '    Me.frmresul.txtUnidadMil.Clear()
        '   Me.frmresul.txtDecenaMil.Clear()
        Me.frmresul.lblBGanador.Visible = False
        frmresul.lblNumBilGdor.Visible = False
        Me.frmresul.lblNumBilGdor.Text = "Extraer Bolillas"
        frmresul.lblNumBilGdor.ForeColor = Color.Black
        frmresul.lblPremio.ForeColor = Color.Black
        frmresul.Timer1.Enabled = False
        Me.txtUnidad.Focus()
    End Sub
    Private Sub txtDMil_TextChanged_1(sender As Object, e As EventArgs) Handles txtDMil.TextChanged
        txtSorteado.Text = Me.txtDMil.Text & Me.txtUMil.Text & Me.txtCentena.Text & Me.txtDecena.Text & Me.txtUnidad.Text
    End Sub
    Private Sub txtUMil_TextChanged_1(sender As Object, e As EventArgs) Handles txtUMil.TextChanged
        txtSorteado.Text = Me.txtUMil.Text & Me.txtCentena.Text & Me.txtDecena.Text & Me.txtUnidad.Text
    End Sub
    Private Sub txtCentena_TextChanged_1(sender As Object, e As EventArgs) Handles txtCentena.TextChanged
        txtSorteado.Text = Me.txtCentena.Text & Me.txtDecena.Text & Me.txtUnidad.Text
    End Sub

    Private Sub txtDecena_TextChanged_1(sender As Object, e As EventArgs) Handles txtDecena.TextChanged
        txtSorteado.Text = Me.txtDecena.Text & Me.txtUnidad.Text
    End Sub
    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs)
    End Sub
    Private Sub txt(sender As Object, e As EventArgs) Handles txt5Aciertos.Enter

    End Sub
    Private Sub txtUnidad_Enter(sender As Object, e As EventArgs) Handles txtUnidad.Enter
    End Sub
    Private Sub txtDecena_Enter(sender As Object, e As EventArgs) Handles txtDecena.Enter
    End Sub

    Private Sub txtCentena_Enter(sender As Object, e As EventArgs) Handles txtCentena.Enter
    End Sub

    Private Sub txtUMil_Enter(sender As Object, e As EventArgs) Handles txtUMil.Enter
    End Sub

    Private Sub txtDMil_Enter(sender As Object, e As EventArgs) Handles txtDMil.Enter
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtBillGanador_TextChanged(sender As Object, e As EventArgs) Handles txtBillGanador.TextChanged

    End Sub
    Private Sub txtUnidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnidad.KeyPress
        If e.KeyChar = Chr(13) Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub txtDecena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDecena.KeyPress
        If e.KeyChar = Chr(13) Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub txtCentena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCentena.KeyPress
        If e.KeyChar = Chr(13) Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub txtUMil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUMil.KeyPress
        If e.KeyChar = Chr(13) Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub txtDMil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDMil.KeyPress
        If e.KeyChar = Chr(13) Then
            e.KeyChar = Chr(0)
        End If

    End Sub
End Class

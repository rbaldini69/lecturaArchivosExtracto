

Public Class frmResultados
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDecenaMil.TextChanged

    End Sub

    Private Sub txtUnidad_TextChanged(sender As Object, e As EventArgs) Handles txtUnidad.TextChanged

    End Sub

    Private Sub frmResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtDecena_TextChanged(sender As Object, e As EventArgs) Handles txtDecena.TextChanged

    End Sub

    Private Sub frmResultados_Resize(sender As Object, e As EventArgs) Handles Me.Resize


    End Sub

    Private Sub txtUnidadMil_TextChanged(sender As Object, e As EventArgs) Handles txtUnidadMil.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPremio.Click

    End Sub

    Private Sub lblBGanador_Click(sender As Object, e As EventArgs) Handles lblBGanador.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static c As Integer
        c = c + 1
        If c = 1 Then
            Me.lblNumBilGdor.ForeColor = Color.Black
            Me.lblBGanador.ForeColor = Color.White
            Me.lblPremio.ForeColor = Color.White
            Me.txtUnidad.ForeColor = Color.White()
            Me.txtDecena.ForeColor = Color.White()
            Me.txtCentena.ForeColor = Color.White()
            Me.txtUnidadMil.ForeColor = Color.White()
            Me.txtDecenaMil.ForeColor = Color.White()
        ElseIf c = 2 Then
            Me.lblNumBilGdor.ForeColor = Color.White
            Me.txtUnidad.ForeColor = Color.Black()
            Me.txtDecena.ForeColor = Color.Black()
            Me.txtCentena.ForeColor = Color.Black()
            Me.txtUnidadMil.ForeColor = Color.Black()
            Me.txtDecenaMil.ForeColor = Color.Black()

        ElseIf c = 3 Then
            Me.lblNumBilGdor.ForeColor = Color.Black
            Me.lblBGanador.ForeColor = Color.Black
            Me.lblPremio.ForeColor = Color.Black

        Else : c = 4
            c = 0

        End If

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblFraccionesVendidas.Click

    End Sub
End Class
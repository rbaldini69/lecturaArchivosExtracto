<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtSorteado = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblBilleteGanador = New System.Windows.Forms.Label()
        Me.txtBillGanador = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt1Acierto = New System.Windows.Forms.TextBox()
        Me.txt2Aciertos = New System.Windows.Forms.TextBox()
        Me.txt3Aciertos = New System.Windows.Forms.TextBox()
        Me.txt4Aciertos = New System.Windows.Forms.TextBox()
        Me.txt5Aciertos = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblVendidos = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblRutaArchivo = New System.Windows.Forms.Label()
        Me.txtDMil = New System.Windows.Forms.TextBox()
        Me.txtUMil = New System.Windows.Forms.TextBox()
        Me.txtCentena = New System.Windows.Forms.TextBox()
        Me.txtDecena = New System.Windows.Forms.TextBox()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.txtArchivo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSorteado
        '
        Me.txtSorteado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSorteado.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSorteado.Location = New System.Drawing.Point(511, 0)
        Me.txtSorteado.Name = "txtSorteado"
        Me.txtSorteado.Size = New System.Drawing.Size(100, 28)
        Me.txtSorteado.TabIndex = 0
        Me.txtSorteado.UseWaitCursor = True
        Me.txtSorteado.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblBilleteGanador)
        Me.GroupBox1.Controls.Add(Me.txtBillGanador)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt1Acierto)
        Me.GroupBox1.Controls.Add(Me.txt2Aciertos)
        Me.GroupBox1.Controls.Add(Me.txt3Aciertos)
        Me.GroupBox1.Controls.Add(Me.txt4Aciertos)
        Me.GroupBox1.Controls.Add(Me.txt5Aciertos)
        Me.GroupBox1.Controls.Add(Me.txtSorteado)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Purple
        Me.GroupBox1.Location = New System.Drawing.Point(34, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(748, 345)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aciertos"
        Me.GroupBox1.UseWaitCursor = True
        '
        'lblBilleteGanador
        '
        Me.lblBilleteGanador.AutoSize = True
        Me.lblBilleteGanador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.lblBilleteGanador.Location = New System.Drawing.Point(6, 147)
        Me.lblBilleteGanador.Name = "lblBilleteGanador"
        Me.lblBilleteGanador.Size = New System.Drawing.Size(298, 44)
        Me.lblBilleteGanador.TabIndex = 25
        Me.lblBilleteGanador.Text = "Billete Ganador"
        Me.lblBilleteGanador.UseWaitCursor = True
        Me.lblBilleteGanador.Visible = False
        '
        'txtBillGanador
        '
        Me.txtBillGanador.BackColor = System.Drawing.SystemColors.Menu
        Me.txtBillGanador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBillGanador.Location = New System.Drawing.Point(45, 194)
        Me.txtBillGanador.Name = "txtBillGanador"
        Me.txtBillGanador.Size = New System.Drawing.Size(214, 65)
        Me.txtBillGanador.TabIndex = 24
        Me.txtBillGanador.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label6.Location = New System.Drawing.Point(328, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 46)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "1 acierto"
        Me.Label6.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label5.Location = New System.Drawing.Point(328, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 46)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "2 aciertos"
        Me.Label5.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Location = New System.Drawing.Point(328, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 46)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "3 aciertos"
        Me.Label4.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Location = New System.Drawing.Point(328, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 46)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "4 aciertos"
        Me.Label3.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(328, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 46)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "5 aciertos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label2.UseWaitCursor = True
        '
        'txt1Acierto
        '
        Me.txt1Acierto.BackColor = System.Drawing.Color.Silver
        Me.txt1Acierto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt1Acierto.Enabled = False
        Me.txt1Acierto.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1Acierto.ForeColor = System.Drawing.Color.White
        Me.txt1Acierto.Location = New System.Drawing.Point(558, 285)
        Me.txt1Acierto.Name = "txt1Acierto"
        Me.txt1Acierto.Size = New System.Drawing.Size(111, 46)
        Me.txt1Acierto.TabIndex = 17
        Me.txt1Acierto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt1Acierto.UseWaitCursor = True
        '
        'txt2Aciertos
        '
        Me.txt2Aciertos.BackColor = System.Drawing.Color.Silver
        Me.txt2Aciertos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt2Aciertos.Enabled = False
        Me.txt2Aciertos.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2Aciertos.ForeColor = System.Drawing.Color.White
        Me.txt2Aciertos.Location = New System.Drawing.Point(558, 233)
        Me.txt2Aciertos.Name = "txt2Aciertos"
        Me.txt2Aciertos.Size = New System.Drawing.Size(111, 46)
        Me.txt2Aciertos.TabIndex = 16
        Me.txt2Aciertos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt2Aciertos.UseWaitCursor = True
        '
        'txt3Aciertos
        '
        Me.txt3Aciertos.BackColor = System.Drawing.Color.Silver
        Me.txt3Aciertos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt3Aciertos.Enabled = False
        Me.txt3Aciertos.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3Aciertos.ForeColor = System.Drawing.Color.White
        Me.txt3Aciertos.Location = New System.Drawing.Point(558, 182)
        Me.txt3Aciertos.Name = "txt3Aciertos"
        Me.txt3Aciertos.Size = New System.Drawing.Size(111, 46)
        Me.txt3Aciertos.TabIndex = 15
        Me.txt3Aciertos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt3Aciertos.UseWaitCursor = True
        '
        'txt4Aciertos
        '
        Me.txt4Aciertos.BackColor = System.Drawing.Color.Silver
        Me.txt4Aciertos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt4Aciertos.Enabled = False
        Me.txt4Aciertos.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4Aciertos.ForeColor = System.Drawing.Color.White
        Me.txt4Aciertos.Location = New System.Drawing.Point(558, 128)
        Me.txt4Aciertos.Name = "txt4Aciertos"
        Me.txt4Aciertos.Size = New System.Drawing.Size(111, 46)
        Me.txt4Aciertos.TabIndex = 14
        Me.txt4Aciertos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt4Aciertos.UseWaitCursor = True
        '
        'txt5Aciertos
        '
        Me.txt5Aciertos.BackColor = System.Drawing.Color.Silver
        Me.txt5Aciertos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt5Aciertos.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5Aciertos.ForeColor = System.Drawing.Color.White
        Me.txt5Aciertos.Location = New System.Drawing.Point(558, 74)
        Me.txt5Aciertos.Name = "txt5Aciertos"
        Me.txt5Aciertos.Size = New System.Drawing.Size(111, 46)
        Me.txt5Aciertos.TabIndex = 13
        Me.txt5Aciertos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt5Aciertos.UseWaitCursor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblVendidos)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.lblRutaArchivo)
        Me.GroupBox2.Controls.Add(Me.txtDMil)
        Me.GroupBox2.Controls.Add(Me.txtUMil)
        Me.GroupBox2.Controls.Add(Me.txtCentena)
        Me.GroupBox2.Controls.Add(Me.txtDecena)
        Me.GroupBox2.Controls.Add(Me.txtUnidad)
        Me.GroupBox2.Controls.Add(Me.txtArchivo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(34, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(748, 161)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'lblVendidos
        '
        Me.lblVendidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendidos.Location = New System.Drawing.Point(499, 45)
        Me.lblVendidos.Name = "lblVendidos"
        Me.lblVendidos.Size = New System.Drawing.Size(245, 25)
        Me.lblVendidos.TabIndex = 32
        Me.lblVendidos.Text = "Billetes Vendidos :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(31, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 51)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblRutaArchivo
        '
        Me.lblRutaArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRutaArchivo.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblRutaArchivo.Location = New System.Drawing.Point(127, 41)
        Me.lblRutaArchivo.Name = "lblRutaArchivo"
        Me.lblRutaArchivo.Size = New System.Drawing.Size(368, 29)
        Me.lblRutaArchivo.TabIndex = 30
        Me.lblRutaArchivo.Text = "Archivo no seleccionado"
        '
        'txtDMil
        '
        Me.txtDMil.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDMil.Location = New System.Drawing.Point(148, 86)
        Me.txtDMil.Multiline = True
        Me.txtDMil.Name = "txtDMil"
        Me.txtDMil.Size = New System.Drawing.Size(51, 51)
        Me.txtDMil.TabIndex = 28
        '
        'txtUMil
        '
        Me.txtUMil.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUMil.Location = New System.Drawing.Point(222, 86)
        Me.txtUMil.Multiline = True
        Me.txtUMil.Name = "txtUMil"
        Me.txtUMil.Size = New System.Drawing.Size(51, 51)
        Me.txtUMil.TabIndex = 27
        '
        'txtCentena
        '
        Me.txtCentena.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentena.Location = New System.Drawing.Point(298, 86)
        Me.txtCentena.Multiline = True
        Me.txtCentena.Name = "txtCentena"
        Me.txtCentena.Size = New System.Drawing.Size(51, 51)
        Me.txtCentena.TabIndex = 26
        '
        'txtDecena
        '
        Me.txtDecena.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecena.Location = New System.Drawing.Point(372, 86)
        Me.txtDecena.Multiline = True
        Me.txtDecena.Name = "txtDecena"
        Me.txtDecena.Size = New System.Drawing.Size(51, 51)
        Me.txtDecena.TabIndex = 25
        '
        'txtUnidad
        '
        Me.txtUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.Location = New System.Drawing.Point(444, 86)
        Me.txtUnidad.Multiline = True
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(51, 51)
        Me.txtUnidad.TabIndex = 24
        '
        'txtArchivo
        '
        Me.txtArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArchivo.Location = New System.Drawing.Point(31, 30)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(90, 51)
        Me.txtArchivo.TabIndex = 23
        Me.txtArchivo.Text = "Archivo"
        Me.txtArchivo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 528)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sorteo Loto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtSorteado As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt1Acierto As TextBox
    Friend WithEvents txt2Aciertos As TextBox
    Friend WithEvents txt3Aciertos As TextBox
    Friend WithEvents txt4Aciertos As TextBox
    Friend WithEvents txt5Aciertos As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblRutaArchivo As Label
    Friend WithEvents txtDMil As TextBox
    Friend WithEvents txtUMil As TextBox
    Friend WithEvents txtCentena As TextBox
    Friend WithEvents txtDecena As TextBox
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents txtArchivo As Button
    Friend WithEvents txtBillGanador As TextBox
    Friend WithEvents lblBilleteGanador As Label
    Friend WithEvents lblVendidos As Label
End Class

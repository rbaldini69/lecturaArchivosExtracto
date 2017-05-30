<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtArchivo = New System.Windows.Forms.Button()
        Me.gbxExtractos = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtCantidadApuestas = New System.Windows.Forms.TextBox()
        Me.txtRecaudado = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.gbxExtractos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 51)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtArchivo
        '
        Me.txtArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArchivo.Location = New System.Drawing.Point(12, 26)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(105, 51)
        Me.txtArchivo.TabIndex = 23
        Me.txtArchivo.Text = "Archivo"
        Me.txtArchivo.UseVisualStyleBackColor = True
        '
        'gbxExtractos
        '
        Me.gbxExtractos.Controls.Add(Me.Label6)
        Me.gbxExtractos.Controls.Add(Me.Label5)
        Me.gbxExtractos.Controls.Add(Me.Label4)
        Me.gbxExtractos.Controls.Add(Me.Label3)
        Me.gbxExtractos.Controls.Add(Me.Label2)
        Me.gbxExtractos.Controls.Add(Me.Label1)
        Me.gbxExtractos.Controls.Add(Me.TextBox5)
        Me.gbxExtractos.Controls.Add(Me.TextBox4)
        Me.gbxExtractos.Controls.Add(Me.TextBox3)
        Me.gbxExtractos.Controls.Add(Me.TextBox2)
        Me.gbxExtractos.Controls.Add(Me.txtCantidadApuestas)
        Me.gbxExtractos.Controls.Add(Me.txtRecaudado)
        Me.gbxExtractos.Location = New System.Drawing.Point(123, 26)
        Me.gbxExtractos.Name = "gbxExtractos"
        Me.gbxExtractos.Size = New System.Drawing.Size(603, 289)
        Me.gbxExtractos.TabIndex = 32
        Me.gbxExtractos.TabStop = False
        Me.gbxExtractos.Text = "Extracto Archivo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Cantidad de Apuestas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Total Recaudado"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(148, 220)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 38
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(148, 183)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 37
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(148, 145)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 36
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(148, 107)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 35
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCantidadApuestas
        '
        Me.txtCantidadApuestas.Location = New System.Drawing.Point(147, 69)
        Me.txtCantidadApuestas.Name = "txtCantidadApuestas"
        Me.txtCantidadApuestas.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadApuestas.TabIndex = 34
        Me.txtCantidadApuestas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRecaudado
        '
        Me.txtRecaudado.Location = New System.Drawing.Point(147, 31)
        Me.txtRecaudado.Name = "txtRecaudado"
        Me.txtRecaudado.Size = New System.Drawing.Size(100, 20)
        Me.txtRecaudado.TabIndex = 33
        Me.txtRecaudado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Coral
        Me.ProgressBar1.Location = New System.Drawing.Point(123, 339)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(602, 28)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 33
        '
        'Timer1
        '
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnCancelar.Location = New System.Drawing.Point(12, 167)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 51)
        Me.btnCancelar.TabIndex = 35
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 528)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.gbxExtractos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtArchivo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sorteo Loto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbxExtractos.ResumeLayout(False)
        Me.gbxExtractos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents txtArchivo As Button
    Friend WithEvents gbxExtractos As GroupBox
    Friend WithEvents txtRecaudado As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtCantidadApuestas As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnCancelar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class

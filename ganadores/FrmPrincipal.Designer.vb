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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtArchivo = New System.Windows.Forms.Button()
        Me.gbxExtractos = New System.Windows.Forms.GroupBox()
        Me.txtValorApuesta = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbxExtractos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(27, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 51)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtArchivo
        '
        Me.txtArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArchivo.Location = New System.Drawing.Point(27, 26)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(90, 51)
        Me.txtArchivo.TabIndex = 23
        Me.txtArchivo.Text = "Archivo"
        Me.txtArchivo.UseVisualStyleBackColor = True
        '
        'gbxExtractos
        '
        Me.gbxExtractos.Controls.Add(Me.txtValorApuesta)
        Me.gbxExtractos.Location = New System.Drawing.Point(123, 26)
        Me.gbxExtractos.Name = "gbxExtractos"
        Me.gbxExtractos.Size = New System.Drawing.Size(603, 289)
        Me.gbxExtractos.TabIndex = 32
        Me.gbxExtractos.TabStop = False
        Me.gbxExtractos.Text = "Extracto Archivo"
        '
        'txtValorApuesta
        '
        Me.txtValorApuesta.Location = New System.Drawing.Point(147, 31)
        Me.txtValorApuesta.Name = "txtValorApuesta"
        Me.txtValorApuesta.Size = New System.Drawing.Size(100, 20)
        Me.txtValorApuesta.TabIndex = 33
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(123, 339)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(602, 28)
        Me.ProgressBar1.TabIndex = 33
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 528)
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
    Friend WithEvents txtValorApuesta As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
End Class

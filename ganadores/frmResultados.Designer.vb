<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResultados))
        Me.txtDecenaMil = New System.Windows.Forms.TextBox()
        Me.txtUnidadMil = New System.Windows.Forms.TextBox()
        Me.txtCentena = New System.Windows.Forms.TextBox()
        Me.txtDecena = New System.Windows.Forms.TextBox()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.lblPremio = New System.Windows.Forms.Label()
        Me.lblBGanador = New System.Windows.Forms.Label()
        Me.lblNumBilGdor = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblFraccionesVendidas = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDecenaMil
        '
        Me.txtDecenaMil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDecenaMil.Font = New System.Drawing.Font("Microsoft Sans Serif", 68.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecenaMil.Location = New System.Drawing.Point(107, 273)
        Me.txtDecenaMil.Name = "txtDecenaMil"
        Me.txtDecenaMil.Size = New System.Drawing.Size(100, 103)
        Me.txtDecenaMil.TabIndex = 0
        Me.txtDecenaMil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUnidadMil
        '
        Me.txtUnidadMil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUnidadMil.Font = New System.Drawing.Font("Microsoft Sans Serif", 68.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidadMil.Location = New System.Drawing.Point(360, 273)
        Me.txtUnidadMil.Name = "txtUnidadMil"
        Me.txtUnidadMil.Size = New System.Drawing.Size(100, 103)
        Me.txtUnidadMil.TabIndex = 1
        Me.txtUnidadMil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCentena
        '
        Me.txtCentena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCentena.Font = New System.Drawing.Font("Microsoft Sans Serif", 68.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentena.Location = New System.Drawing.Point(611, 273)
        Me.txtCentena.Name = "txtCentena"
        Me.txtCentena.Size = New System.Drawing.Size(100, 103)
        Me.txtCentena.TabIndex = 2
        Me.txtCentena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDecena
        '
        Me.txtDecena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDecena.Font = New System.Drawing.Font("Microsoft Sans Serif", 68.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecena.Location = New System.Drawing.Point(862, 273)
        Me.txtDecena.Name = "txtDecena"
        Me.txtDecena.Size = New System.Drawing.Size(100, 103)
        Me.txtDecena.TabIndex = 3
        Me.txtDecena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUnidad
        '
        Me.txtUnidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 68.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.Location = New System.Drawing.Point(1114, 273)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(100, 103)
        Me.txtUnidad.TabIndex = 4
        Me.txtUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPremio
        '
        Me.lblPremio.AutoSize = True
        Me.lblPremio.BackColor = System.Drawing.Color.Transparent
        Me.lblPremio.Font = New System.Drawing.Font("Microsoft Sans Serif", 65.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremio.Location = New System.Drawing.Point(12, 457)
        Me.lblPremio.Name = "lblPremio"
        Me.lblPremio.Size = New System.Drawing.Size(497, 98)
        Me.lblPremio.TabIndex = 6
        Me.lblPremio.Text = "$ 9.000.000"
        Me.lblPremio.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBGanador
        '
        Me.lblBGanador.AutoSize = True
        Me.lblBGanador.BackColor = System.Drawing.Color.Transparent
        Me.lblBGanador.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBGanador.Location = New System.Drawing.Point(823, 430)
        Me.lblBGanador.Name = "lblBGanador"
        Me.lblBGanador.Size = New System.Drawing.Size(276, 31)
        Me.lblBGanador.TabIndex = 7
        Me.lblBGanador.Text = "BILLETE GANADOR!"
        Me.lblBGanador.Visible = False
        '
        'lblNumBilGdor
        '
        Me.lblNumBilGdor.BackColor = System.Drawing.Color.Transparent
        Me.lblNumBilGdor.Font = New System.Drawing.Font("Microsoft Sans Serif", 55.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumBilGdor.Location = New System.Drawing.Point(636, 461)
        Me.lblNumBilGdor.Name = "lblNumBilGdor"
        Me.lblNumBilGdor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNumBilGdor.Size = New System.Drawing.Size(640, 85)
        Me.lblNumBilGdor.TabIndex = 8
        Me.lblNumBilGdor.Text = "Extraer otra bolilla"
        Me.lblNumBilGdor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNumBilGdor.Visible = False
        '
        'Timer1
        '
        '
        'lblFraccionesVendidas
        '
        Me.lblFraccionesVendidas.AutoSize = True
        Me.lblFraccionesVendidas.BackColor = System.Drawing.Color.Transparent
        Me.lblFraccionesVendidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraccionesVendidas.ForeColor = System.Drawing.Color.Black
        Me.lblFraccionesVendidas.Location = New System.Drawing.Point(88, 559)
        Me.lblFraccionesVendidas.Name = "lblFraccionesVendidas"
        Me.lblFraccionesVendidas.Size = New System.Drawing.Size(211, 25)
        Me.lblFraccionesVendidas.TabIndex = 9
        Me.lblFraccionesVendidas.Text = "Fracciones vendidas"
        '
        'frmResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ganadores.My.Resources.Resources.plasmas_escrutinio_033
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1261, 715)
        Me.Controls.Add(Me.lblFraccionesVendidas)
        Me.Controls.Add(Me.lblNumBilGdor)
        Me.Controls.Add(Me.lblBGanador)
        Me.Controls.Add(Me.lblPremio)
        Me.Controls.Add(Me.txtUnidad)
        Me.Controls.Add(Me.txtDecena)
        Me.Controls.Add(Me.txtCentena)
        Me.Controls.Add(Me.txtUnidadMil)
        Me.Controls.Add(Me.txtDecenaMil)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResultados"
        Me.Text = "Sorteo Bingo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDecenaMil As TextBox
    Friend WithEvents txtUnidadMil As TextBox
    Friend WithEvents txtCentena As TextBox
    Friend WithEvents txtDecena As TextBox
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents lblPremio As Label
    Friend WithEvents lblBGanador As Label
    Friend WithEvents lblNumBilGdor As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblFraccionesVendidas As Label
End Class

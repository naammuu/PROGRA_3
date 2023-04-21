<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoluciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.txtmanoo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTecnico = New System.Windows.Forms.TextBox()
        Me.txtcausa = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtfechas = New System.Windows.Forms.TextBox()
        Me.txtsolucion = New System.Windows.Forms.TextBox()
        Me.txthoras = New System.Windows.Forms.TextBox()
        Me.txtcostore = New System.Windows.Forms.TextBox()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackgroundImage = Global.PROYECTO.My.Resources.Resources.Imagen_de_WhatsApp_2023_04_19_a_las_21_011
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnIngresar)
        Me.Panel2.Controls.Add(Me.btnmodificar)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtmanoo)
        Me.Panel2.Controls.Add(Me.btnVolver)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtcausa)
        Me.Panel2.Controls.Add(Me.txtTecnico)
        Me.Panel2.Controls.Add(Me.txtstatus)
        Me.Panel2.Controls.Add(Me.txtcostore)
        Me.Panel2.Controls.Add(Me.txthoras)
        Me.Panel2.Controls.Add(Me.txtsolucion)
        Me.Panel2.Controls.Add(Me.txtfechas)
        Me.Panel2.Controls.Add(Me.txttotal)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(30, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(721, 379)
        Me.Panel2.TabIndex = 0
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.Location = New System.Drawing.Point(566, 129)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(124, 34)
        Me.btnmodificar.TabIndex = 49
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'txtmanoo
        '
        Me.txtmanoo.Location = New System.Drawing.Point(134, 280)
        Me.txtmanoo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmanoo.Name = "txtmanoo"
        Me.txtmanoo.Size = New System.Drawing.Size(285, 20)
        Me.txtmanoo.TabIndex = 48
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(23, 280)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 20)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Manoobra :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(23, 337)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 20)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Total :"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(98, 339)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(321, 20)
        Me.txttotal.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(23, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 20)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Tecnico :"
        '
        'txtTecnico
        '
        Me.txtTecnico.Location = New System.Drawing.Point(122, 20)
        Me.txtTecnico.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTecnico.Name = "txtTecnico"
        Me.txtTecnico.Size = New System.Drawing.Size(297, 20)
        Me.txtTecnico.TabIndex = 37
        '
        'txtcausa
        '
        Me.txtcausa.Location = New System.Drawing.Point(122, 50)
        Me.txtcausa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcausa.Name = "txtcausa"
        Me.txtcausa.Size = New System.Drawing.Size(297, 20)
        Me.txtcausa.TabIndex = 38
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(566, 73)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(124, 34)
        Me.btnIngresar.TabIndex = 44
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(566, 188)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(124, 34)
        Me.btnVolver.TabIndex = 29
        Me.btnVolver.Text = "Volver a menu"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'txtfechas
        '
        Me.txtfechas.Location = New System.Drawing.Point(122, 87)
        Me.txtfechas.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfechas.Name = "txtfechas"
        Me.txtfechas.Size = New System.Drawing.Size(297, 20)
        Me.txtfechas.TabIndex = 39
        '
        'txtsolucion
        '
        Me.txtsolucion.Location = New System.Drawing.Point(127, 129)
        Me.txtsolucion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtsolucion.Name = "txtsolucion"
        Me.txtsolucion.Size = New System.Drawing.Size(292, 20)
        Me.txtsolucion.TabIndex = 40
        '
        'txthoras
        '
        Me.txthoras.Location = New System.Drawing.Point(127, 160)
        Me.txthoras.Margin = New System.Windows.Forms.Padding(2)
        Me.txthoras.Name = "txthoras"
        Me.txthoras.Size = New System.Drawing.Size(292, 20)
        Me.txthoras.TabIndex = 41
        '
        'txtcostore
        '
        Me.txtcostore.Location = New System.Drawing.Point(213, 196)
        Me.txtcostore.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcostore.Name = "txtcostore"
        Me.txtcostore.Size = New System.Drawing.Size(206, 20)
        Me.txtcostore.TabIndex = 43
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(184, 238)
        Me.txtstatus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(235, 20)
        Me.txtstatus.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(23, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 20)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Causa :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(23, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 20)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "FechaS :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(23, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 20)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Solucion :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(23, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 20)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Horas :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(23, 194)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(167, 20)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Costo de repuesto :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(23, 236)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 20)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Nuevo Status :"
        '
        'frmSoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSoluciones"
        Me.Text = "frmSoluciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtmanoo As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcausa As TextBox
    Friend WithEvents txtTecnico As TextBox
    Friend WithEvents txtstatus As TextBox
    Friend WithEvents txtcostore As TextBox
    Friend WithEvents txthoras As TextBox
    Friend WithEvents txtsolucion As TextBox
    Friend WithEvents txtfechas As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
End Class

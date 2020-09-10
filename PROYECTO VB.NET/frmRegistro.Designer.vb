<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistro
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistro))
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.cmdRegistro = New System.Windows.Forms.Button()
        Me.lblENombre = New System.Windows.Forms.Label()
        Me.imgOjo = New System.Windows.Forms.PictureBox()
        Me.lstUsuario = New System.Windows.Forms.ListBox()
        Me.lstContraseña = New System.Windows.Forms.ListBox()
        Me.lblEDNI = New System.Windows.Forms.Label()
        Me.lblECorreo = New System.Windows.Forms.Label()
        Me.lblEUsuario = New System.Windows.Forms.Label()
        Me.lblEContraseña = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.imgOjo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(27, 28)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(92, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Apellido y Nombre"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(27, 64)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(26, 13)
        Me.lblDNI.TabIndex = 1
        Me.lblDNI.Text = "DNI"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(27, 98)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreo.TabIndex = 2
        Me.lblCorreo.Text = "Correo"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(27, 135)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Usuario"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(27, 173)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(61, 13)
        Me.lblContraseña.TabIndex = 4
        Me.lblContraseña.Text = "Contraseña"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(133, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 5
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(133, 61)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 6
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(133, 95)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(100, 20)
        Me.txtCorreo.TabIndex = 7
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(133, 132)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 8
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(133, 170)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(100, 20)
        Me.txtContraseña.TabIndex = 9
        '
        'cmdRegistro
        '
        Me.cmdRegistro.Location = New System.Drawing.Point(71, 248)
        Me.cmdRegistro.Name = "cmdRegistro"
        Me.cmdRegistro.Size = New System.Drawing.Size(109, 31)
        Me.cmdRegistro.TabIndex = 10
        Me.cmdRegistro.Text = "Registrarse"
        Me.cmdRegistro.UseVisualStyleBackColor = True
        '
        'lblENombre
        '
        Me.lblENombre.AutoSize = True
        Me.lblENombre.Location = New System.Drawing.Point(27, 201)
        Me.lblENombre.Name = "lblENombre"
        Me.lblENombre.Size = New System.Drawing.Size(51, 13)
        Me.lblENombre.TabIndex = 11
        Me.lblENombre.Text = "ENombre"
        '
        'imgOjo
        '
        Me.imgOjo.Image = CType(resources.GetObject("imgOjo.Image"), System.Drawing.Image)
        Me.imgOjo.Location = New System.Drawing.Point(249, 164)
        Me.imgOjo.Name = "imgOjo"
        Me.imgOjo.Size = New System.Drawing.Size(38, 32)
        Me.imgOjo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgOjo.TabIndex = 12
        Me.imgOjo.TabStop = False
        '
        'lstUsuario
        '
        Me.lstUsuario.FormattingEnabled = True
        Me.lstUsuario.Location = New System.Drawing.Point(340, 46)
        Me.lstUsuario.Name = "lstUsuario"
        Me.lstUsuario.Size = New System.Drawing.Size(120, 186)
        Me.lstUsuario.TabIndex = 13
        '
        'lstContraseña
        '
        Me.lstContraseña.FormattingEnabled = True
        Me.lstContraseña.Location = New System.Drawing.Point(466, 46)
        Me.lstContraseña.Name = "lstContraseña"
        Me.lstContraseña.Size = New System.Drawing.Size(120, 186)
        Me.lstContraseña.TabIndex = 14
        '
        'lblEDNI
        '
        Me.lblEDNI.AutoSize = True
        Me.lblEDNI.Location = New System.Drawing.Point(27, 214)
        Me.lblEDNI.Name = "lblEDNI"
        Me.lblEDNI.Size = New System.Drawing.Size(33, 13)
        Me.lblEDNI.TabIndex = 15
        Me.lblEDNI.Text = "EDNI"
        '
        'lblECorreo
        '
        Me.lblECorreo.AutoSize = True
        Me.lblECorreo.Location = New System.Drawing.Point(27, 227)
        Me.lblECorreo.Name = "lblECorreo"
        Me.lblECorreo.Size = New System.Drawing.Size(45, 13)
        Me.lblECorreo.TabIndex = 16
        Me.lblECorreo.Text = "ECorreo"
        '
        'lblEUsuario
        '
        Me.lblEUsuario.AutoSize = True
        Me.lblEUsuario.Location = New System.Drawing.Point(130, 201)
        Me.lblEUsuario.Name = "lblEUsuario"
        Me.lblEUsuario.Size = New System.Drawing.Size(50, 13)
        Me.lblEUsuario.TabIndex = 17
        Me.lblEUsuario.Text = "EUsuario"
        '
        'lblEContraseña
        '
        Me.lblEContraseña.AutoSize = True
        Me.lblEContraseña.Location = New System.Drawing.Point(130, 214)
        Me.lblEContraseña.Name = "lblEContraseña"
        Me.lblEContraseña.Size = New System.Drawing.Size(68, 13)
        Me.lblEContraseña.TabIndex = 18
        Me.lblEContraseña.Text = "EContraseña"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 304)
        Me.Controls.Add(Me.lblEContraseña)
        Me.Controls.Add(Me.lblEUsuario)
        Me.Controls.Add(Me.lblECorreo)
        Me.Controls.Add(Me.lblEDNI)
        Me.Controls.Add(Me.lstContraseña)
        Me.Controls.Add(Me.lstUsuario)
        Me.Controls.Add(Me.imgOjo)
        Me.Controls.Add(Me.lblENombre)
        Me.Controls.Add(Me.cmdRegistro)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "frmRegistro"
        Me.Text = "Registro"
        CType(Me.imgOjo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents cmdRegistro As System.Windows.Forms.Button
    Friend WithEvents lblENombre As System.Windows.Forms.Label
    Friend WithEvents imgOjo As System.Windows.Forms.PictureBox
    Friend WithEvents lstUsuario As System.Windows.Forms.ListBox
    Friend WithEvents lstContraseña As System.Windows.Forms.ListBox
    Friend WithEvents lblEDNI As System.Windows.Forms.Label
    Friend WithEvents lblECorreo As System.Windows.Forms.Label
    Friend WithEvents lblEUsuario As System.Windows.Forms.Label
    Friend WithEvents lblEContraseña As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class

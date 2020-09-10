Public Class frmLogin
    Private dato As String
    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click

        ErrorProvider1.Clear()
        lblError.Text = ""

        If txtUsuario.Text = "admin" And txtContraseña.Text = "admin" Then
            frmCompraVirtual.Show()
            ErrorProvider1.Clear()
        End If

        For i = 0 To frmRegistro.lstUsuario.Items.Count - 1
            If txtUsuario.Text = frmRegistro.lstUsuario.Items.Item(i) And txtContraseña.Text = frmRegistro.lstContraseña.Items.Item(i) Then
                lblError.Text = ""
                frmCompraVirtual.Show()
            Else
                If Not txtUsuario.Text <> frmRegistro.lstUsuario.Items.Item(i) And txtContraseña.Text <> frmRegistro.lstContraseña.Items.Item(i) Then
                    If txtUsuario.Text <> frmRegistro.lstUsuario.Items.Item(i) Then
                        If txtUsuario.Text = "" Then
                            lblError.Text = "Ingrese el Usuario"
                            ErrorProvider1.SetError(txtContraseña, "Campo Vacío")
                        Else
                            lblError.Text = "Usuario no registardo"
                            ErrorProvider1.SetError(txtUsuario, "Nombre de Usuario no registrado")
                        End If
                    End If
                    If txtContraseña.Text <> frmRegistro.lstContraseña.Items.Item(i) Then
                        If txtContraseña.Text = "" Then
                            lblError.Text = "Ingrese la Contraseña"
                            ErrorProvider1.SetError(txtContraseña, "Campo Vacío")
                        Else
                            lblError.Text = "Contraseña Incorrecta"
                            ErrorProvider1.SetError(txtContraseña, "Contraseña Incorrecta")
                        End If
                    End If
                Else
                    If txtUsuario.Text = "" And txtContraseña.Text = "" Then
                        lblError.Text = "Ingrese Usuario y Contraseña"
                        ErrorProvider1.SetError(txtUsuario, "Campo Vacío")
                        ErrorProvider1.SetError(txtContraseña, "Campo Vacío")
                    Else
                        lblError.Text = "Datos Inválidos"
                        ErrorProvider1.SetError(txtUsuario, "Nombre de Usuario no registrado")
                        ErrorProvider1.SetError(txtContraseña, "Contraseña Incorrecta")
                    End If
                End If
            End If
        Next

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'FileOpen(1, "datos.txt", OpenMode.Input)

        'While Not EOF(1)

        '    Input(1, dato)

        '    .Items.Add(dato)

        'End While

        'FileClose()



        'lblError.Text = ""
    End Sub

    Private Sub imgOjo_MouseDown(sender As Object, e As MouseEventArgs) Handles imgOjo.MouseDown
        txtContraseña.PasswordChar = ""
    End Sub

    Private Sub imgOjo_MouseUp(sender As Object, e As MouseEventArgs) Handles imgOjo.MouseUp
        txtContraseña.PasswordChar = "*"
    End Sub
End Class
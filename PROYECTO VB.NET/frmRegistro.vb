Imports System.Text.RegularExpressions
Public Class frmRegistro

    Private Sub cmdRegistro_Click(sender As Object, e As EventArgs) Handles cmdRegistro.Click

        Dim correo As String
        ErrorProvider1.Clear()
        correo = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"

        If txtNombre.Text = "" Then
            lblENombre.Text = "Ingrese su nombre"
            ErrorProvider1.SetError(txtNombre, "Ingrese su nombre")
        Else
            lblENombre.Text = ""
        End If

        If txtDNI.Text = "" Then
            lblEDNI.Text = "Ingrese su DNI"
            ErrorProvider1.SetError(txtDNI, "Ingrese su DNI")
        Else
            lblEDNI.Text = ""
        End If

        If txtCorreo.Text = "" Then
            lblECorreo.Text = "Ingrese su correo"
            ErrorProvider1.SetError(txtCorreo, "Ingrese su correo")
        Else
            lblECorreo.Text = ""
        End If

        If txtUsuario.Text = "" Then
            lblEUsuario.Text = "Ingrese su usuario"
            ErrorProvider1.SetError(txtUsuario, "Ingrese su usuario")
        Else
            lblEUsuario.Text = ""
        End If

        If txtContraseña.Text = "" Then
            lblEContraseña.Text = "Ingrese su contraseña"
            ErrorProvider1.SetError(txtContraseña, "Ingrese su contraseña")
        Else
            lblEContraseña.Text = ""
        End If

        If Not IsNumeric(txtDNI.Text) = True Then
            MsgBox("Ingrese correctamente su DNI")
            ErrorProvider1.SetError(txtDNI, "DNI Incorrecto")
            lblEDNI.Text = "DNI Incorrecto"
        End If

        If Not Regex.IsMatch(txtCorreo.Text, correo) Then
            lblECorreo.Text = "Formato Incorrecto de Correo"
            MsgBox("Ingrese correctamente su E-Mail")
            ErrorProvider1.SetError(txtCorreo, "Formato Incorrecto")
        End If

        If txtNombre.Text <> "" And txtDNI.Text <> "" And txtCorreo.Text <> "" And txtUsuario.Text <> "" And txtContraseña.Text <> "" Then
            If IsNumeric(txtDNI.Text) = True And Regex.IsMatch(txtCorreo.Text, correo) Then
                lstUsuario.Items.Add(txtUsuario.Text)
                lstContraseña.Items.Add(txtContraseña.Text)
                frmLogin.Show()
                txtNombre.Text = ""
                txtDNI.Text = ""
                txtCorreo.Text = ""
                txtUsuario.Text = ""
                txtContraseña.Text = ""
            End If
        End If

        FileOpen(1, "Datos.txt", OpenMode.Append)
        For i = 0 To lstUsuario.Items.Count - 1
            Write(1, lstUsuario.Items.Item(i))
            Write(1, lstContraseña.Items.Item(i))
        Next
        FileClose()

    End Sub

    Private Sub frmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmCompraVirtual.Show()
        lblENombre.Text = ""
        lblEDNI.Text = ""
        lblECorreo.Text = ""
        lblEUsuario.Text = ""
        lblEContraseña.Text = ""
    End Sub

    Private Sub imgOjo_MouseDown(sender As Object, e As MouseEventArgs) Handles imgOjo.MouseDown

        txtContraseña.PasswordChar = ""

    End Sub

    Private Sub imgOjo_MouseUp(sender As Object, e As MouseEventArgs) Handles imgOjo.MouseUp

        txtContraseña.PasswordChar = "*"

    End Sub
End Class

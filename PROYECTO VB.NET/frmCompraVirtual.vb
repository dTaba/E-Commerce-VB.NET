Public Class frmCompraVirtual
    Dim a As Integer
    Public Function Mostrar() As Action
        lblCel.Visible = True
        Rb1.Visible = True
        Rb2.Visible = True
        Rb3.Visible = True
        cmdComprar.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True

    End Function
    Private Sub S8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles S8ToolStripMenuItem.Click
        PictureBox2.ImageLocation = Image.FromFile("\S8.jpg")
        lblCel.Text = "Samsung Galaxy S8"
        Rb1.Text = "50.000$"
        Rb2.Text = Rb1.Text & "  +5%"
        Rb3.Text = Rb1.Text & "  +10%"
        Mostrar()

    End Sub

    Private Sub S9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles S9ToolStripMenuItem.Click
        PictureBox2.Image = System.Drawing.Image.FromFile("D:\Trabajos Visual Basic\PROYECTO VB.NET\Celulares Modelos\S8+.JPG")
        Rb1.Text = "60.000$"
        Rb2.Text = Rb1.Text & "  +5%"
        Rb3.Text = Rb1.Text & "  +10%"
        lblCel.Text = "Samsung Galaxy S8+"
        Mostrar()
    End Sub

    Private Sub GToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GToolStripMenuItem.Click
        PictureBox2.Image = System.Drawing.Image.FromFile("D:\Trabajos Visual Basic\PROYECTO VB.NET\Celulares Modelos\GalaxyAce.png")
        Rb1.Text = "2.500$"
        Rb2.Text = Rb1.Text & "  +5%"
        Rb3.Text = Rb1.Text & "  +10%"
        lblCel.Text = "Samsung Galaxy Ace"

        Mostrar()
    End Sub

    Private Sub GalaxyBeamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GalaxyBeamToolStripMenuItem.Click
        PictureBox2.Image = System.Drawing.Image.FromFile("D:\Trabajos Visual Basic\PROYECTO VB.NET\Celulares Modelos\GalaxyBeam.JPG")
        Rb1.Text = "5.000$"
        Rb2.Text = Rb1.Text & "  +5%"
        Rb3.Text = Rb1.Text & "  +10%"
        lblCel.Text = "Samsung Galaxy Beam"

        Mostrar()
    End Sub

    Private Sub X1045ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X1045ToolStripMenuItem.Click
        PictureBox2.Image = System.Drawing.Image.FromFile("D:\Trabajos Visual Basic\PROYECTO VB.NET\Celulares Modelos\Oneplus6.JPEG")
        Rb1.Text = "17.000$"
        Rb2.Text = Rb1.Text & "  +5%"
        Rb3.Text = Rb1.Text & "  +10%"
        lblCel.Text = "Oneplus 6"

        Mostrar()
    End Sub

    Private Sub TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TToolStripMenuItem.Click
        PictureBox2.Image = System.Drawing.Image.FromFile("D:\Trabajos Visual Basic\PROYECTO VB.NET\Celulares Modelos\Oneplus5t.JPG")
        Rb1.Text = "15.000$"
        Rb2.Text = Rb1.Text & "  +5%"
        Rb3.Text = Rb1.Text & "  +10%"
        lblCel.Text = "Oneplus 5T"

        Mostrar()
    End Sub

    Private Sub XdfxdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XdfxdToolStripMenuItem.Click
        PictureBox2.Image = System.Drawing.Image.FromFile("D:\Trabajos Visual Basic\PROYECTO VB.NET\Celulares Modelos\XiaomiRedmiNote6Pro.JPG")
        Rb1.Text = "14.000$"
        Rb2.Text = Rb1.Text & "  +5%"
        Rb3.Text = Rb1.Text & "  +10%"
        lblCel.Text = "Xiaomi Redmi Note 6 Pro"

        Mostrar()
    End Sub

    Private Sub Mi8ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Mi8ToolStripMenuItem1.Click
        PictureBox2.Image = System.Drawing.Image.FromFile("D:\Trabajos Visual Basic\PROYECTO VB.NET\Celulares Modelos\XiaomiMi8.JPG")
        Rb1.Text = "17.000$"
        Rb2.Text = Rb1.Text & "  +5%"
        Rb3.Text = Rb1.Text & "  +10%"
        lblCel.Text = "Xiaomi Mi 8"

        Mostrar()
    End Sub

    Private Sub Mi8ExplorerEditionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Mi8ExplorerEditionToolStripMenuItem.Click
        PictureBox2.Image = System.Drawing.Image.FromFile("D:\Trabajos Visual Basic\PROYECTO VB.NET\Celulares Modelos\XiaomiMi8ExplorerEdition.JPG")
        Rb1.Text = "20.000$"
        Rb2.Text = Rb1.Text & "  +5%"
        Rb3.Text = Rb1.Text & "  +10%"
        lblCel.Text = "Xiaomi Mi 8 Explorer Edition"

        Mostrar()
    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    a = a + 1
    '    If Label1.Text = "Samsung Galaxy S8" Then
    '        If a = 1 Then PictureBox1
    '    End If
    'End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton1.Click

    End Sub
End Class
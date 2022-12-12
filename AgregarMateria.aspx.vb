Public Class AgregarMateria
    Inherits System.Web.UI.Page


    Dim materia As New materia

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click


        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea guardar registro", 1, "Registro materia")
        If testmsg = 1 Then

            materia.nomMateria = txtMateria.Text
            materia.unidadesMateria = txtUv.Text



            materia.guardar()


            txtMateria.Text = ""
            txtUv.Text = ""



            Response.Redirect("Materia.aspx")
        Else

            txtMateria.Text = ""
            txtUv.Text = ""

        End If

    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        'Si damos clic en cancelar volvemos a listado Docentes
        Response.Redirect("Materia.aspx")

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
Public Class AgregarDocente
    Inherits System.Web.UI.Page


    Dim docente As New docente

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click


        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea guardar registro", 1, "Registro docente")
        If testmsg = 1 Then

            docente.nomDocente = txtNombre.Text
            docente.apeDocente = TxtApellido.Text
            docente.espDocente = TxtEspecialidad.Text
            docente.facDocente = TxtFacultad.Text



            docente.guardar()


            txtNombre.Text = ""
            TxtApellido.Text = ""
            TxtEspecialidad.Text = ""
            TxtFacultad.Text = ""



            Response.Redirect("Docente.aspx")
        Else

            txtNombre.Text = ""
            TxtApellido.Text = ""
            TxtEspecialidad.Text = ""
            TxtFacultad.Text = ""

        End If

    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        'Si damos clic en cancelar volvemos a listado Docentes
        Response.Redirect("Docente.aspx")

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class

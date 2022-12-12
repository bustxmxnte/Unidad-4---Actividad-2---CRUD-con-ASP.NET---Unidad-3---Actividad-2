Public Class EliminarMateria
    Inherits System.Web.UI.Page

    Dim materia As materia
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Comparamos el código pasado como parámetro
        materia.idMateria = Request.QueryString("materia")

        If Not Me.IsPostBack Then
            'llenado de DataTable con los datos de Alumno
            Dim dt As DataTable = materia.mostrarRegistro()


            For i = 0 To dt.Rows.Count - 1
                TxtId.Text = dt.Rows(i).Item("idmateria")
                txtMateria.Text = dt.Rows(i).Item("nombremateria")
                txtIdCarrera.Text = dt.Rows(i).Item("idcarrera")
                txtUv.Text = dt.Rows(i).Item("uv")

            Next

        End If
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        'variable para evaluar la respuesta del usuario
        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea eliminar registro", 1, "Eliminar materia")
        If testmsg = 1 Then

            'llamada metodo eliminar registro
            materia.eliminar()

            'Después de eliminar volvemos a listado Alumnos
            'Redireccionamos de nuevo a la página listado Alumnos
            Response.Redirect("Materia.aspx")
        Else
            'Redireccionamos de nuevo a la página listado Alumnos
            'Sin llamar el metodo eliminar
            Response.Redirect("Materia.aspx")
        End If
    End Sub
    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        'Si cancelamos volvemos a la página listado Alumnos
        Response.Redirect("Materia.aspx")

    End Sub

End Class
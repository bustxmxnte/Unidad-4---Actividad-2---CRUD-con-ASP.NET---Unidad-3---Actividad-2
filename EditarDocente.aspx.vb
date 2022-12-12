Public Class EditarDocente
    Inherits System.Web.UI.Page


    Dim docente As New docente

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        docente.idDocente = Request.QueryString("docente")

        If Not Me.IsPostBack Then

            Dim dt As DataTable = docente.mostrarRegistro()


            For i = 0 To dt.Rows.Count - 1
                TxtId.Text = dt.Rows(i).Item("iddocente")
                txtNombre.Text = dt.Rows(i).Item("nombre")
                TxtApellido.Text = dt.Rows(i).Item("apellido")
                TxtEspecialidad.Text = dt.Rows(i).Item("especialidad")
                TxtFacultad.Text = dt.Rows(i).Item("facultad")

            Next

        End If

    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click


        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea Actualizar registro", 1, "Actualizar docente")
        If testmsg = 1 Then
            'materia.ideAlumno = TxtId.Text
            docente.nomDocente = txtNombre.Text
            docente.apeDocente = TxtApellido.Text
            docente.espDocente = TxtEspecialidad.Text
            docente.facDocente = TxtFacultad.Text



            docente.editar()


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


        Response.Redirect("Docente.aspx")

    End Sub
End Class
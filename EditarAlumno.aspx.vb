Public Class EditarAlumno
    Inherits System.Web.UI.Page


    Dim alumno As New Alumno

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        alumno.idAlumno = Request.QueryString("Alumno")

        If Not Me.IsPostBack Then

            Dim dt As DataTable = alumno.mostrarRegistro()


            For i = 0 To dt.Rows.Count - 1
                TxtId.Text = dt.Rows(i).Item("idestudiante")
                txtNombre.Text = dt.Rows(i).Item("nombre")
                TxtApellido.Text = dt.Rows(i).Item("apellido")
                TxtCorreo.Text = dt.Rows(i).Item("correo")
                TxtTelefono.Text = dt.Rows(i).Item("telefono")
                TxtCodigo.Text = dt.Rows(i).Item("codigo")
            Next

        End If

    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click


        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea Actualizar registro", 1, "Actualizar Alumno")
        If testmsg = 1 Then
            'materia.ideAlumno = TxtId.Text
            alumno.nomAlumno = txtNombre.Text
            alumno.apeAlumno = TxtApellido.Text
            alumno.mailAlumno = TxtCorreo.Text
            alumno.telAlumno = TxtTelefono.Text
            alumno.codAlumno = TxtCodigo.Text


            alumno.editar()


            txtNombre.Text = ""
            TxtApellido.Text = ""
            TxtCorreo.Text = ""
            TxtTelefono.Text = ""
            TxtCodigo.Text = ""


            Response.Redirect("Alumno.aspx")
        Else

            txtNombre.Text = ""
            TxtApellido.Text = ""
            TxtCorreo.Text = ""
            TxtTelefono.Text = ""
            TxtCodigo.Text = ""
        End If
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click


        Response.Redirect("Alumno.aspx")

    End Sub
End Class
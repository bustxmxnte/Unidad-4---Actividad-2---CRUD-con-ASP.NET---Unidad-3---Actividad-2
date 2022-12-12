Public Class EditarMateria
    Inherits System.Web.UI.Page

    Dim materia As materia
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        materia.idMateria = Request.QueryString("materia")

        If Not Me.IsPostBack Then

            Dim dt As DataTable = materia.mostrarRegistro()


            For i = 0 To dt.Rows.Count - 1
                TxtId.Text = dt.Rows(i).Item("idmateria")
                txtMateria.Text = dt.Rows(i).Item("nombremateria")
                txtIdCarrera.Text = dt.Rows(i).Item("idcarrera")
                txtUv.Text = dt.Rows(i).Item("uv")


            Next

        End If

    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click


        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea Actualizar registro", 1, "Actualizar materia")
        If testmsg = 1 Then
            'materia.ideAlumno = TxtId.Text
            materia.nomMateria = txtMateria.Text
            materia.unidadesMateria = txtUv.Text



            materia.editar()


            txtMateria.Text = ""
            txtUv.Text = ""



            Response.Redirect("Materia.aspx")
        Else

            txtMateria.Text = ""
            txtUv.Text = ""

        End If
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click


        Response.Redirect("Materia.aspx")

    End Sub

End Class
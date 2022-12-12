﻿Public Class Alumno1

    Inherits System.Web.UI.Page

    'llamada de clase Alumno para usar sus métodos
    Dim alumno As New Alumno

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Me.IsPostBack Then

            ''llenado de DataTable para mostrar listado de estudiantes
            Dim dt As DataTable = alumno.listarRegistros()

            'Crear variable String para html
            Dim html As New StringBuilder()

            'Enlace para agregar nuevo Alumno

            '<a href = AgregarAlumno.aspx > Agregar</a>

            'Creando HTML para mostrar en forma tabla
            html.Append("<thead>")
            html.Append("<table class = 'table table-striped'>")

            'Encabezados de la tabla
            html.Append("<thead>")
            html.Append("<tr>")
            html.Append("<th>Id</th>")
            html.Append("<th>Nombre</th>")
            html.Append("<th>Apellido</th>")
            html.Append("<th>Correo</th>")
            html.Append("<th>Telefono</th>")
            html.Append("<th>Código</th>")
            html.Append("<th cols=3>Acciones</th>")
            html.Append("</tr>")
            html.Append("</thead>")

            html.Append("<tbody>")

            'Mostrar los datos en filas, segun cantidad de registros
            'en la tabla
            For i = 0 To dt.Rows.Count - 1

                Dim codigo As Integer = dt.Rows(i).Item("idestudiante")

                'Creamos una fila
                html.Append("<tr>")

                'Creamos las columnas y mostramos campos de tabla
                'Item recibe nombre de las columnas
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("idestudiante"))
                html.Append("</td>")
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("nombre"))
                html.Append("</td>")
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("apellido"))
                html.Append("</td>")
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("correo"))
                html.Append("</td>")
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("telefono"))
                html.Append("</td>")
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("codigo"))
                html.Append("</td>")

                'Columnas para Agregar, Editar,Eliminar
                html.Append("<td>")
                html.Append("<a href = 'EditarAlumno.aspx?Alumno=" & codigo & "' dt.Rows(i).Item('codigo') >Editar</a>")
                html.Append("</td>")
                html.Append("<td>")
                html.Append("<a href = 'EliminarAlumno.aspx?Alumno=" & codigo & "' dt.Rows(i).Item('codigo') >Eliminar</a>")
                html.Append("</td>")

                html.Append("</tr>")

            Next

            html.Append("<tbody>")

            'Finaliza la tabla
            html.Append("</table>")

            'Agregamos el código html en el contenedor placeholder
            estudiantes.Controls.Add(New Literal() With {
                .Text = html.ToString()
            })


        End If

    End Sub

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Response.Redirect("AgregarAlumno.aspx")

    End Sub
End Class
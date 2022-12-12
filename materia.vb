Public Class materia
    Dim c As New conexion

    Private Id As String
    Private codigoMateria As String
    Private nombreMateria As String
    Private id1 As String
    Private uvMateria As String

    Private pagina As materia

    'Metodos de la propiedad
    Public Property idMateria() As String
        Get
            Return Id

        End Get
        Set(value As String)
            Id = value
        End Set
    End Property

    Public Property nomMateria() As String
        Get
            Return nombreMateria

        End Get
        Set(value As String)
            nombreMateria = value
        End Set
    End Property
    Public Property idCarerra() As String
        Get
            Return id1

        End Get
        Set(value As String)
            id1 = value
        End Set
    End Property
    Public Property unidadesMateria() As String
        Get
            Return uvMateria

        End Get
        Set(value As String)
            uvMateria = value
        End Set
    End Property


    'Función para mostrar lista de materias
    Public Function listarRegistros() As DataTable
        'hace referencia a la instancia de la clase conexión
        c.strcon.Open()
        With c.cmd
            'cadena de conexión
            .Connection = c.strcon
            'consulta de la tabla materia
            .CommandText = "SELECT idmateria, nombremateria, idcarrera, uv FROM materia"
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt
    End Function


    'Método para editar, mostrar registro por Id
    'Para utilizar con otra clase, cambie el nombre de la tabla
    'Cambie los nombres de los campos que quiere mostrar en el formulario
    Public Function mostrarRegistro() As DataTable
        c.strcon.Open()
        With c.cmd
            .Connection = c.strcon

            'Parámetro que se pasa al dar clic en Editar o Eliminar.
            .CommandText = "SELECT idmateria, nombremateria, idcarrera, uv FROM materia where idmateria = '" & idMateria & "' "
            c.result = c.cmd.ExecuteNonQuery
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt
    End Function



    'Método para guardar
    Public Sub guardar()
        Try
            c.strcon.Open()
            With c.cmd
                .Connection = c.strcon
                .CommandText = "INSERT INTO materia values ('','" & idMateria & "','" & nombreMateria & "','" & idCarerra & "','" & unidadesMateria & "')"
                c.result = c.cmd.ExecuteNonQuery
            End With
            If c.result = 0 Then
                MsgBox("No se ha podido guardar", MsgBoxStyle.Critical)
            Else
                MsgBox("Registro guardado exitosamente", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            MsgBox("NO se ha podido guardar el registro", MsgBoxStyle.Critical)
        End Try
        c.strcon.Close()
    End Sub



    'Metodo para actualizr registros
    'Para utilizar con otra clase, cambie nombre de tabla y de los campos que se van actualizar
    Public Sub editar()
        Try
            c.strcon.Open()
            With c.cmd
                .Connection = c.strcon
                .CommandText = "UPDATE materia SET nombremateria ='" & nomMateria & "', uv = '" & unidadesMateria & "' WHERE idmateria = '" & idMateria & "' "

                'Estos dos campos no son editables, no es necesario actualizar
                'porque no pueden modificarse.
                'idestudiante ='" & idAlumno & "'
                'codigo = '" & codDocente & "'


                c.result = c.cmd.ExecuteNonQuery
            End With

            If c.result = 0 Then
                MsgBox("No se ha podido actualizar", MsgBoxStyle.Critical)
            Else
                MsgBox("Registro actualizado exitosamente", MsgBoxStyle.OkOnly)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        c.strcon.Close()
    End Sub

    'Función para eliminar estudiante seleccionado
    Public Sub eliminar()
        Try
            'hace referencia a la instancia de la clase conexión
            c.strcon.Open()
            With c.cmd
                'cadena de conexión
                .Connection = c.strcon
                'consulta de la tabla estudiante
                .CommandText = "DELETE FROM materia where idmateria = '" & idMateria & "' "
                c.result = c.cmd.ExecuteNonQuery
            End With

            If c.result = 0 Then
                MsgBox("No se ha podido eliminar", MsgBoxStyle.Critical)
            Else
                MsgBox("Registro eliminado exitosamente", MsgBoxStyle.OkOnly)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        c.strcon.Close()
    End Sub
End Class

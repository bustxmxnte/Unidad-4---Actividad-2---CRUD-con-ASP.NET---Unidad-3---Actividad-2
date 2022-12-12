Public Class docente
    'Instancia de la conexion
    Dim c As New conexion

    Private Id As String
    Private codigoDocente As String
    Private nombreDocente As String
    Private apellidoDocente As String
    Private especialidadDocente As String
    Private facultadDocente As String

    Private pagina As docente

    'Metodos de la propiedad
    Public Property idDocente() As String
        Get
            Return Id

        End Get
        Set(value As String)
            Id = value
        End Set
    End Property

    Public Property nomDocente() As String
        Get
            Return nombreDocente

        End Get
        Set(value As String)
            nombreDocente = value
        End Set
    End Property
    Public Property apeDocente() As String
        Get
            Return apellidoDocente

        End Get
        Set(value As String)
            apellidoDocente = value
        End Set
    End Property

    Public Property espDocente() As String
        Get
            Return especialidadDocente

        End Get
        Set(value As String)
            especialidadDocente = value
        End Set
    End Property

    Public Property facDocente() As String
        Get
            Return facultadDocente

        End Get
        Set(value As String)
            facultadDocente = value
        End Set
    End Property

    Public Property codDocente() As String
        Get
            Return codigoDocente

        End Get
        Set(value As String)
            codigoDocente = value
        End Set
    End Property

    'Función para mostrar lista de docentes
    Public Function listarRegistros() As DataTable
        'hace referencia a la instancia de la clase conexión
        c.strcon.Open()
        With c.cmd
            'cadena de conexión
            .Connection = c.strcon
            'consulta de la tabla docente
            .CommandText = "SELECT iddocente, nombre, apellido, especialidad, facultad FROM docente"
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
            .CommandText = "SELECT iddocente, nombre, apellido, especialidad, facultad FROM docente where iddocente = '" & idDocente & "' "
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
                .CommandText = "INSERT INTO estudiante values ('""','" & nomDocente & "','" & apeDocente & "','" & espDocente & "','" & facDocente & "','" & codDocente & "')"
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
                .CommandText = "UPDATE docente SET nombre ='" & nomDocente & "', apellido = '" & apeDocente & "', especialidad = '" & espDocente & "', facultad = '" & facDocente & "' WHERE iddocente = '" & idDocente & "' "

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
                .CommandText = "DELETE FROM docente where iddocente = '" & idDocente & "' "
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


    Public Function generarCodigo(ByVal nombre As String)

        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        valor1 = UCase(Left(nombre, 1))
        valor2 = Right(nombre, 2)
        numero = Int(Rnd() * 1000) + 65

        Return valor1 & numero & valor2

    End Function
End Class

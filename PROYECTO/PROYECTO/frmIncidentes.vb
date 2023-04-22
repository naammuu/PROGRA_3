Imports System.Data.SqlClient

Public Class frmIncidentes

    Dim Adaptadorincidentes As SqlDataAdapter
    Dim Dataincidentes As New DataSet
    Dim oFila As DataRow
    Dim i As Integer

    Sub metCOnexion()
        Dim conexionincidentes As SqlConnection = New SqlConnection()
        Dim strconexion As String = "data source=DESKTOP-8SFPDI4\SQLEXPRESS;
                       initial catalog=servicios;integrated security=true"
        conexionincidentes.ConnectionString = strconexion
        conexionincidentes.Open()
        '--------------------------
        'LLenamos el adaptador
        Adaptadorincidentes = New SqlDataAdapter("select * from incidentes", conexionincidentes)
        ' PAra ejecutar comendos sql
        Dim Command As SqlCommandBuilder = New SqlCommandBuilder(Adaptadorincidentes)
        'Creamos datset
        Dataincidentes = New DataSet
        'llenamos el data set
        Adaptadorincidentes.Fill(Dataincidentes, "incidentes")
        '--------------------------
        MessageBox.Show("Conexion exitosa!!!", " Conexion ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        conexionincidentes.Close()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim logOpcion As DialogResult
        logOpcion = MessageBox.Show("Desea volver al menú principal?", " Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If logOpcion = DialogResult.Yes Then
            Me.Hide()
            frmMenu.Show()
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Adaptadorincidentes.Fill(Dataincidentes, "incidentes")
        oFila = Dataincidentes.Tables("incidentes").NewRow()

        oFila("Tipo") = txttipo.Text
        oFila("Departamento") = txtdepartamento.Text
        oFila("Usuario") = txtusuario.Text
        oFila("Correo") = txtcorreo.Text
        oFila("Telefono") = txttelefono.Text
        oFila("fecha") = txtfecha.Text
        oFila("Descripcion") = txtdescripcion.Text
        oFila("Status") = "Pendiente"
        Dataincidentes.Tables("incidentes").Rows.Add(oFila)
        Adaptadorincidentes.Update(Dataincidentes, "incidentes")

        MessageBox.Show("Registros almacenados", "Guardar",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
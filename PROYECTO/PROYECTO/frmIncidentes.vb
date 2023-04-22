Imports System.Data.SqlClient

Public Class frmIncidentes

    Dim Adaptadorincidentes As SqlDataAdapter
    Dim Dataincidentes As New DataSet
    Dim oFila As DataRow
    Dim i As Integer

    Sub metCOnexion()
        Dim conexionincidentes As SqlConnection = New SqlConnection()
        Dim strconexion As String = "data source=DESKTOP-MPLP2PA\SQLEXPRESS;
                       initial catalog=servicios;integrated security=true"
        conexionincidentes.ConnectionString = strconexion
        conexionincidentes.Open()
        '--------------------------
        'LLenamos el adaptador
        Adaptadorincidentes = New SqlDataAdapter("select * from Incidentes", conexionincidentes)
        ' PAra ejecutar comendos sql
        Dim Command As SqlCommandBuilder = New SqlCommandBuilder(Adaptadorincidentes)
        'Creamos datset
        Dataincidentes = New DataSet
        'llenamos el data set
        Adaptadorincidentes.Fill(Dataincidentes, "Incidentes")
        '--------------------------
        'MessageBox.Show("Conexion exitosa!!!", " Conexion ", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        'Adaptadorincidentes.Fill(Dataincidentes, "incidentes")
        metCOnexion()
        oFila = Dataincidentes.Tables("Incidentes").NewRow()

        oFila("Tipo") = 1
        oFila("Departamento") = 1
        oFila("Usuario") = txtusuario.Text
        oFila("Correo") = txtcorreo.Text
        oFila("Telefono") = txttelefono.Text
        oFila("fecha") = Convert.ToDateTime(dtpFecha.Text)
        oFila("Descripcion") = txtdescripcion.Text
        oFila("Status") = "Pendiente"
        Dataincidentes.Tables("incidentes").Rows.Add(oFila)
        Adaptadorincidentes.Update(Dataincidentes, "Incidentes")

        MessageBox.Show("Registros almacenados", "Guardar",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
        Limpiar()
    End Sub

    Sub Limpiar()
        txtusuario.Clear()
        txtcorreo.Clear()
        txttelefono.Clear()
        txtdescripcion.Clear()
        dtpFecha.Value = Date.Now()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub
End Class
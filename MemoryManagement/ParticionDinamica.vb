Imports System.Text

Public Class ParticionDinamica

#Region " Fields "

    ' Administrador de Memoria en Ejecucion
    Private Ejecucion As Boolean = False

    ' Algoritmo de Asignación
    Private Algoritmo As AlgoritmoAsignacion

    ' Lista de Procesos 
    Private ListaProcesos As List(Of Proceso)

    ' Lista de Particiones
    Private ListaParticiones As List(Of Particion)

    ' Lista de Particiones Libres
    Private ParticionesLibres As List(Of Particion)

    ' Lista de Particiones Ocupadas
    Private ParticionesOcupadas As List(Of Particion)

#End Region

#Region " Subs & Functions"

    Public Sub Inicializar(_tamañoMemoria As Integer, _listaParticiones As List(Of Particion), _algoritmo As AlgoritmoAsignacion)

        ' Inicializando Particiones 
        ListaParticiones = _listaParticiones

        ' Inicializando Particiones Libres
        ParticionesLibres = New List(Of Particion)
        For Each p As Particion In _listaParticiones
            ParticionesLibres.Add(p)
        Next

        ' Inicializando Particiones Ocupadas
        ParticionesOcupadas = New List(Of Particion)

        ' Actualizando Etiqueta de Particiones
        Dim sbParticiones As StringBuilder = New StringBuilder()
        For Each p As Particion In _listaParticiones
            sbParticiones.Append(String.Format("P{0}: {1}kb | ", p.Numero, p.Tamaño))
        Next
        lblParticiones.Text = sbParticiones.ToString(0, sbParticiones.Length - 2)

        ' Actualizando Etiqueta de Tamaño de Memoria
        lblMemoria.Text = String.Format("Memoria Ram ~ {0}kb", _tamañoMemoria)

        ' Estableciendo algoritmo de asignacion
        Algoritmo = _algoritmo

        ' Actualizando Etiqueta de Algoritmo de Asignacion
        Select Case Algoritmo
            Case AlgoritmoAsignacion.PrimerAjuste
                lblAlgoritmo.Text = "Algoritmo de Asignación -> Primer Ajuste"
            Case AlgoritmoAsignacion.MejorAjuste
                lblAlgoritmo.Text = "Algoritmo de Asignación -> Mejor Ajuste"
        End Select

    End Sub

    Private Sub AsignarEspacio()

        ' Verificar si se esta ejecutando el administrador de memoria 
        If Not Ejecucion Then Exit Sub

        ' Verificar si existen procesos en la lista de procesos
        If ListaProcesos.Count > 0 Then

            ' Declarando Variables
            Dim index As Integer = -1
            Dim msj As String = String.Empty

            ' Recorrer cada proceso
            For Each proceso As Proceso In ListaProcesos

                ' Si el proceso no esta en espera pasar al siguiente
                If Not proceso.Estado = EstadoProceso.Espera Then
                    Continue For
                End If

                ' Buscando indice de particion libre 
                index = BuscarParticionLibre(proceso.Tamaño)

                ' Si se encontro particion index (>=) a cero
                If index >= 0 Then

                    ' Creando nueva particion
                    Dim ptOcupada As New Particion
                    With ptOcupada
                        .Direccion = ParticionesLibres.Item(index).Direccion
                        .Tamaño = ParticionesLibres.Item(index).Tamaño
                        .Proceso = proceso
                        .Estado = EstadoParticion.Ocupada
                    End With

                    ' Agregando a lista de particiones ocupadas
                    ParticionesOcupadas.Add(ptOcupada)

                    ' Eliminando de lista de particiones libres
                    ParticionesLibres.RemoveAt(index)

                    ' Cambiando el estado del proceso a Asignado 
                    ListaProcesos.Item(ListaProcesos.IndexOf(proceso)).Estado = EstadoProceso.Asignado

                    ' Mostrando mensaje en registro (log)
                    msj = String.Format("El proceso {0} de tamaño {1}kb ha sido asignado a la partición de memoria con dirección {2}", proceso.Nombre, proceso.Tamaño, ptOcupada.Direccion)
                Else ' de lo contrario
                    msj = String.Format("El proceso {0} de tamaño {1}kb no ha podido ser asignado debido a memoria insuficiente.", proceso.Nombre, proceso.Tamaño)
                End If

                ' Mostrando fecha y hora en registro (log)
                txtSalida.AppendText(String.Format("[{0}]", Date.Now.ToString("dd/MM/yyyy hh:mm:ss tt")))
                txtSalida.AppendText(vbCrLf + msj + vbCrLf + vbCrLf)
            Next

            ' Actualizando controles
            ActualizarDgvParticiones()
            ActualizaDgvProcesos()
        Else
            ' Si no hay procesos en cola mostrar en registro
            txtSalida.AppendText(String.Format("[{0}]", Date.Now.ToString("dd/MM/yyyy hh: mm:ss tt")))
            txtSalida.AppendText(vbCrLf + "No hay procesos en cola." + vbCrLf + vbCrLf)
        End If

    End Sub

    Private Function BuscarParticionLibre(tamañoProceso As Integer) As Integer

        ' Declarando variable index 
        Dim index As Integer = -1

        ' Realizando ordenamiento algoritmo primer ajuste
        If Algoritmo = AlgoritmoAsignacion.PrimerAjuste Then
            ParticionesLibres.Sort(Function(x, y) x.Direccion.CompareTo(y.Direccion))
        End If

        ' Realizando ordenamiento algoritmo mejor ajuste
        If Algoritmo = AlgoritmoAsignacion.MejorAjuste Then
            ParticionesLibres.Sort(Function(x, y) x.Tamaño.CompareTo(y.Tamaño))
        End If

        ' Recorriendo cada particion 
        For Each particion As Particion In ParticionesLibres

            ' Si el tamaño del proceso es mayor al de la particion
            If tamañoProceso > particion.Tamaño Then Continue For

            ' Devolviendo el indice de la particion libre encontrada 
            index = ParticionesLibres.IndexOf(particion)
            Exit For

        Next

        ' Obteniendo tamaño particion encontrada
        Dim tamañoParticion As Integer = ParticionesLibres.Item(index).Tamaño

        ' Verificando si se requiere redimensionar y crear particiones
        If tamañoParticion > tamañoProceso Then

            ' Obteniendo direccion inicial particion encontrada
            Dim direccionParticion As Integer = ParticionesLibres.Item(index).Direccion

            ' Creando nueva particion
            Dim nuevaParticion As Particion = New Particion()
            With nuevaParticion
                .Direccion = direccionParticion + tamañoProceso
                .Tamaño = tamañoParticion - tamañoProceso
            End With

            ' Redimensionando particion encontrada
            ParticionesLibres.Item(index).Tamaño = tamañoProceso

            ' Insertando nueva particion despues de la particion encontrada
            ParticionesLibres.Insert(index + 1, nuevaParticion)

        End If

        ' Devolviendo indice encontrado
        Return index
    End Function

    Private Sub ActualizarDgvParticiones()

        ' Limpiar filas de control dgvParticiones
        dgvParticiones.Rows.Clear()

        ' Agregar particiones libres a control dgvParticiones
        For Each p As Particion In ParticionesLibres
            dgvParticiones.Rows.Add(New String() {p.Numero, p.Direccion, p.Tamaño, "-", "-", p.Estado.ToString})
        Next

        ' Agregar particiones ocupadas a control dgvParticiones
        For Each p As Particion In ParticionesOcupadas
            dgvParticiones.Rows.Add(New String() {p.Numero, p.Direccion, p.Tamaño, p.Proceso.Nombre, p.Proceso.Tamaño, p.Estado.ToString})
        Next

        ' Ordenar lista de particiones en control dgvParticiones
        dgvParticiones.Sort(dgvParticiones.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        Dim c As Integer = 1
        For Each row As DataGridViewRow In dgvParticiones.Rows
            row.Cells(0).Value = c
            c += 1
        Next

    End Sub

    Private Sub ActualizaDgvProcesos()
        dgvProcesos.Rows.Clear()
        For Each p As Proceso In ListaProcesos
            dgvProcesos.Rows.Add(New String() {p.Nombre, p.Tamaño, p.Estado.ToString})
        Next
    End Sub

#End Region

#Region " Windows Form Events "

    Private Sub ParticionFija_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Inicializando cola de procesos de prueba
        ListaProcesos = New List(Of Proceso)
        ListaProcesos.Add(New Proceso("J1", 10, EstadoProceso.Espera)) ' J1 ~ 10kb
        ListaProcesos.Add(New Proceso("J2", 20, EstadoProceso.Espera)) ' J2 ~ 20kb

        ' Actualizando DataGridView Particiones
        ActualizarDgvParticiones()

        ' Actualizando DataGridView Procesos
        ActualizaDgvProcesos()

    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Ejecucion = True
        btnEjecutar.Visible = False
        AsignarEspacio()
    End Sub

    Private Sub btnAgregarProceso_Click(sender As Object, e As EventArgs) Handles btnAgregarProceso.Click

        ' Declarando variables
        Dim tamañoProcesoStr As String = String.Empty
        Dim tamañoProceso As Integer = 0

        ' Obteniendo tamaño de proceso
        tamañoProcesoStr = InputBox("Ingrese tamaño de proceso...", "Nuevo Proceso", "")
        tamañoProceso = IIf(String.IsNullOrEmpty(tamañoProcesoStr), 0, CInt(tamañoProcesoStr))

        ' Verificando si el tamaño del proceso es mayor que cero
        If tamañoProceso > 0 Then

            ' Declarando e Inicializando nuevo proceso
            Dim nuevoProceso As Proceso
            nuevoProceso = New Proceso("J" + CStr(ListaProcesos.Count + 1), tamañoProceso, EstadoProceso.Espera)

            ' Agregando proceso a la lista de procesos
            ListaProcesos.Add(nuevoProceso)

            ' Realizando asignación 
            AsignarEspacio()

        Else ' de lo contrario
            MsgBox("El tamaño del proceso no puede estar vacio y debe ser mayor de cero.")
        End If

    End Sub

    Private Sub btnTerminarProceso_Click(sender As Object, e As EventArgs) Handles btnTerminarProceso.Click

        ' Verificando si se ha seleccionado un proceso 
        If dgvProcesos.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar un proceso...")
            Exit Sub
        End If

        ' Verificando si el proceso seleccionado esta asignado a alguna particion
        If Not dgvProcesos.SelectedRows(0).Cells(2).Value = "Asignado" Then
            MsgBox("Debe seleccionar un proceso que este asignado a alguna particion.")
            Exit Sub
        End If

        ' Declarando variables
        Dim nomProcSel As String = String.Empty
        Dim idxProcSel As Integer = -1
        Dim ptOcupada As Particion = Nothing

        ' Obteniendo nombre de proceso seleccionado
        nomProcSel = dgvProcesos.SelectedRows(0).Cells(0).Value

        ' Buscando particion donde fue asignado el proceso seleccionado
        For Each p As Particion In ParticionesOcupadas

            ' Verificando coincidencia para el nombre del proceso 
            If p.Proceso.Nombre = nomProcSel Then

                ' Asignando particion 
                ptOcupada = p

                ' Asignando indice proceso seleccionado
                idxProcSel = ListaProcesos.IndexOf(p.Proceso)

                ' Actualizando lista de procesos 
                ListaProcesos.Item(idxProcSel).Estado = EstadoProceso.Terminado

                ' Saliendo de bucle for
                Exit For

            End If
        Next

        ' Mostrando mensaje en registro (log)
        txtSalida.AppendText(String.Format("[{0}]", Date.Now.ToString("dd/MM/yyyy hh:mm:ss tt")))
        txtSalida.AppendText(vbCr + String.Format("El proceso {0} de tamaño {1}k ha sido terminado", ptOcupada.Proceso.Nombre, ptOcupada.Proceso.Tamaño))
        txtSalida.AppendText(vbCr + String.Format("La partición {0} con dirección {1} ha sido liberada.", ptOcupada.Numero, ptOcupada.Direccion))
        txtSalida.AppendText(vbCr + vbCr)


        ' Creando nueva particion libre
        Dim ptLibre As New Particion
        With ptLibre
            .Direccion = ptOcupada.Direccion
            .Tamaño = ptOcupada.Tamaño
            .Proceso = Nothing
            .Estado = EstadoParticion.Libre
        End With

        ' Eliminando particion de lista de particiones ocupadas
        ParticionesOcupadas.Remove(ptOcupada)

        ''''''''''''''''''''''''''''''''''
        '' Combinando particiones libres '
        ''''''''''''''''''''''''''''''''''

        ' Declarando Variables
        Dim ptLibreAnterior As Particion = Nothing
        Dim ptLibrePosterior As Particion = Nothing

        ' Buscando particion libre anterior
        For Each p As Particion In ParticionesLibres

            ' Verificando si la particion es adyacente
            If (p.Direccion + p.Tamaño) = ptLibre.Direccion Then

                ' Asignando particion 
                ptLibreAnterior = p

                ' Saliendo de bucle for
                Exit For

            End If
        Next

        ' Verificando si se encontro particion libre anterior 
        If ptLibreAnterior IsNot Nothing Then

            ' Redimensionando particion libre 
            ptLibre.Direccion = ptLibreAnterior.Direccion
            ptLibre.Tamaño = ptLibre.Tamaño + ptLibreAnterior.Tamaño

            ' Eliminando particion libre anterior
            ParticionesLibres.Remove(ptLibreAnterior)

        End If

        ' Buscando particion libre posterior
        For Each p As Particion In ParticionesLibres

            ' Verificando si la particion es adyacente
            If (ptLibre.Direccion + ptLibre.Tamaño) = p.Direccion Then

                ' Asignando particion 
                ptLibrePosterior = p

                ' Saliendo de bucle for
                Exit For

            End If
        Next

        ' Verificando si se encontro particion libre posterior
        If ptLibrePosterior IsNot Nothing Then

            ' Redimensionando particion libre 
            ptLibre.Tamaño = ptLibre.Tamaño + ptLibrePosterior.Tamaño

            ' Eliminando particion libre posterior
            ParticionesLibres.Remove(ptLibrePosterior)

        End If


        ' Agregando particion a lista de particiones libres
        ParticionesLibres.Add(ptLibre)


        ' Actualizando controles
        ActualizarDgvParticiones()

        ' Asignar Espacio
        AsignarEspacio()


    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

#End Region


End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParticionDinamicaCfg
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.rbMejorAjuste = New System.Windows.Forms.RadioButton()
        Me.rbPrimerAjuste = New System.Windows.Forms.RadioButton()
        Me.btnEliminarParticion = New System.Windows.Forms.Button()
        Me.btnAgregarParticion = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.dgvParticiones = New System.Windows.Forms.DataGridView()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tamaño = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nupTamaño = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvParticiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupTamaño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbMejorAjuste
        '
        Me.rbMejorAjuste.AutoSize = True
        Me.rbMejorAjuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbMejorAjuste.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMejorAjuste.Location = New System.Drawing.Point(204, 443)
        Me.rbMejorAjuste.Name = "rbMejorAjuste"
        Me.rbMejorAjuste.Size = New System.Drawing.Size(115, 25)
        Me.rbMejorAjuste.TabIndex = 30
        Me.rbMejorAjuste.Text = "Mejor Ajuste"
        Me.rbMejorAjuste.UseVisualStyleBackColor = True
        '
        'rbPrimerAjuste
        '
        Me.rbPrimerAjuste.AutoSize = True
        Me.rbPrimerAjuste.Checked = True
        Me.rbPrimerAjuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbPrimerAjuste.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPrimerAjuste.Location = New System.Drawing.Point(48, 443)
        Me.rbPrimerAjuste.Name = "rbPrimerAjuste"
        Me.rbPrimerAjuste.Size = New System.Drawing.Size(121, 25)
        Me.rbPrimerAjuste.TabIndex = 31
        Me.rbPrimerAjuste.TabStop = True
        Me.rbPrimerAjuste.Text = "Primer Ajuste"
        Me.rbPrimerAjuste.UseVisualStyleBackColor = True
        '
        'btnEliminarParticion
        '
        Me.btnEliminarParticion.FlatAppearance.BorderSize = 0
        Me.btnEliminarParticion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarParticion.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarParticion.ForeColor = System.Drawing.Color.Purple
        Me.btnEliminarParticion.Location = New System.Drawing.Point(316, 194)
        Me.btnEliminarParticion.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEliminarParticion.Name = "btnEliminarParticion"
        Me.btnEliminarParticion.Size = New System.Drawing.Size(25, 41)
        Me.btnEliminarParticion.TabIndex = 28
        Me.btnEliminarParticion.Text = "-"
        Me.btnEliminarParticion.UseVisualStyleBackColor = True
        '
        'btnAgregarParticion
        '
        Me.btnAgregarParticion.FlatAppearance.BorderSize = 0
        Me.btnAgregarParticion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarParticion.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarParticion.ForeColor = System.Drawing.Color.Purple
        Me.btnAgregarParticion.Location = New System.Drawing.Point(284, 194)
        Me.btnAgregarParticion.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgregarParticion.Name = "btnAgregarParticion"
        Me.btnAgregarParticion.Size = New System.Drawing.Size(25, 41)
        Me.btnAgregarParticion.TabIndex = 29
        Me.btnAgregarParticion.Text = "+"
        Me.btnAgregarParticion.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.Purple
        Me.btnCerrar.Location = New System.Drawing.Point(327, 9)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(32, 33)
        Me.btnCerrar.TabIndex = 27
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnIniciar
        '
        Me.btnIniciar.BackColor = System.Drawing.Color.Purple
        Me.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.ForeColor = System.Drawing.Color.White
        Me.btnIniciar.Location = New System.Drawing.Point(-2, 497)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(368, 47)
        Me.btnIniciar.TabIndex = 26
        Me.btnIniciar.Text = "INICIAR"
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'dgvParticiones
        '
        Me.dgvParticiones.AllowUserToAddRows = False
        Me.dgvParticiones.AllowUserToDeleteRows = False
        Me.dgvParticiones.AllowUserToResizeRows = False
        Me.dgvParticiones.BackgroundColor = System.Drawing.Color.White
        Me.dgvParticiones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvParticiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvParticiones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvParticiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParticiones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numero, Me.Tamaño})
        Me.dgvParticiones.Location = New System.Drawing.Point(24, 236)
        Me.dgvParticiones.Name = "dgvParticiones"
        Me.dgvParticiones.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvParticiones.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvParticiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParticiones.Size = New System.Drawing.Size(317, 136)
        Me.dgvParticiones.TabIndex = 25
        '
        'Numero
        '
        Me.Numero.HeaderText = "Numero"
        Me.Numero.Name = "Numero"
        Me.Numero.ReadOnly = True
        Me.Numero.Width = 157
        '
        'Tamaño
        '
        Me.Tamaño.HeaderText = "Tamaño"
        Me.Tamaño.Name = "Tamaño"
        Me.Tamaño.Width = 157
        '
        'nupTamaño
        '
        Me.nupTamaño.Font = New System.Drawing.Font("Segoe UI Light", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupTamaño.Location = New System.Drawing.Point(23, 124)
        Me.nupTamaño.Margin = New System.Windows.Forms.Padding(0)
        Me.nupTamaño.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nupTamaño.Name = "nupTamaño"
        Me.nupTamaño.Size = New System.Drawing.Size(318, 47)
        Me.nupTamaño.TabIndex = 24
        Me.nupTamaño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Purple
        Me.Label4.Location = New System.Drawing.Point(19, 393)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 30)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Algoritmo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Purple
        Me.Label3.Location = New System.Drawing.Point(19, 199)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 30)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Particiones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Purple
        Me.Label2.Location = New System.Drawing.Point(18, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 30)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Tamaño"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(17, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 37)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Partición Dinamica"
        '
        'ParticionDinamicaCfg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(365, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.rbMejorAjuste)
        Me.Controls.Add(Me.rbPrimerAjuste)
        Me.Controls.Add(Me.btnEliminarParticion)
        Me.Controls.Add(Me.btnAgregarParticion)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.dgvParticiones)
        Me.Controls.Add(Me.nupTamaño)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ParticionDinamicaCfg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvParticiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupTamaño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbMejorAjuste As RadioButton
    Friend WithEvents rbPrimerAjuste As RadioButton
    Friend WithEvents btnEliminarParticion As Button
    Friend WithEvents btnAgregarParticion As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnIniciar As Button
    Friend WithEvents dgvParticiones As DataGridView
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents Tamaño As DataGridViewTextBoxColumn
    Friend WithEvents nupTamaño As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

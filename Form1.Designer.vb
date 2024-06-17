<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblVector = New System.Windows.Forms.Label()
        Me.lblNuevoVector = New System.Windows.Forms.Label()
        Me.cmdEjecutar = New System.Windows.Forms.Button()
        Me.dtvVector = New System.Windows.Forms.DataGridView()
        Me.dtvNuevoVector = New System.Windows.Forms.DataGridView()
        CType(Me.dtvVector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtvNuevoVector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVector
        '
        Me.lblVector.AutoSize = True
        Me.lblVector.Location = New System.Drawing.Point(12, 3)
        Me.lblVector.Name = "lblVector"
        Me.lblVector.Size = New System.Drawing.Size(39, 13)
        Me.lblVector.TabIndex = 0
        Me.lblVector.Text = "Label1"
        '
        'lblNuevoVector
        '
        Me.lblNuevoVector.AutoSize = True
        Me.lblNuevoVector.Location = New System.Drawing.Point(12, 63)
        Me.lblNuevoVector.Name = "lblNuevoVector"
        Me.lblNuevoVector.Size = New System.Drawing.Size(39, 13)
        Me.lblNuevoVector.TabIndex = 1
        Me.lblNuevoVector.Text = "Label2"
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Location = New System.Drawing.Point(265, 129)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEjecutar.TabIndex = 2
        Me.cmdEjecutar.Text = "Ejecutar"
        Me.cmdEjecutar.UseVisualStyleBackColor = True
        '
        'dtvVector
        '
        Me.dtvVector.AllowUserToAddRows = False
        Me.dtvVector.AllowUserToDeleteRows = False
        Me.dtvVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvVector.ColumnHeadersVisible = False
        Me.dtvVector.Location = New System.Drawing.Point(15, 18)
        Me.dtvVector.Name = "dtvVector"
        Me.dtvVector.RowHeadersVisible = False
        Me.dtvVector.Size = New System.Drawing.Size(324, 25)
        Me.dtvVector.TabIndex = 3
        '
        'dtvNuevoVector
        '
        Me.dtvNuevoVector.AllowUserToAddRows = False
        Me.dtvNuevoVector.AllowUserToDeleteRows = False
        Me.dtvNuevoVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvNuevoVector.ColumnHeadersVisible = False
        Me.dtvNuevoVector.Location = New System.Drawing.Point(15, 79)
        Me.dtvNuevoVector.Name = "dtvNuevoVector"
        Me.dtvNuevoVector.ReadOnly = True
        Me.dtvNuevoVector.RowHeadersVisible = False
        Me.dtvNuevoVector.Size = New System.Drawing.Size(324, 25)
        Me.dtvNuevoVector.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtvNuevoVector)
        Me.Controls.Add(Me.dtvVector)
        Me.Controls.Add(Me.cmdEjecutar)
        Me.Controls.Add(Me.lblNuevoVector)
        Me.Controls.Add(Me.lblVector)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dtvVector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtvNuevoVector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVector As Label
    Friend WithEvents lblNuevoVector As Label
    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents dtvVector As DataGridView
    Friend WithEvents dtvNuevoVector As DataGridView
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Buttonmodifier = New System.Windows.Forms.Button()
        Me.Buttonsupp = New System.Windows.Forms.Button()
        Me.Buttonretour2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.Location = New System.Drawing.Point(53, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(445, 198)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Numéro du médicament"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nom du médicament"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Prix du médicament"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantité en stock"
        Me.Column4.Name = "Column4"
        '
        'Buttonmodifier
        '
        Me.Buttonmodifier.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Buttonmodifier.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonmodifier.ForeColor = System.Drawing.Color.DarkGreen
        Me.Buttonmodifier.Location = New System.Drawing.Point(53, 236)
        Me.Buttonmodifier.Name = "Buttonmodifier"
        Me.Buttonmodifier.Size = New System.Drawing.Size(75, 23)
        Me.Buttonmodifier.TabIndex = 1
        Me.Buttonmodifier.Text = "Modifier"
        Me.Buttonmodifier.UseVisualStyleBackColor = False
        '
        'Buttonsupp
        '
        Me.Buttonsupp.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Buttonsupp.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonsupp.ForeColor = System.Drawing.Color.DarkGreen
        Me.Buttonsupp.Location = New System.Drawing.Point(134, 236)
        Me.Buttonsupp.Name = "Buttonsupp"
        Me.Buttonsupp.Size = New System.Drawing.Size(75, 23)
        Me.Buttonsupp.TabIndex = 2
        Me.Buttonsupp.Text = "Supprimer"
        Me.Buttonsupp.UseVisualStyleBackColor = False
        '
        'Buttonretour2
        '
        Me.Buttonretour2.BackColor = System.Drawing.Color.DarkGreen
        Me.Buttonretour2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonretour2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Buttonretour2.Location = New System.Drawing.Point(422, 236)
        Me.Buttonretour2.Name = "Buttonretour2"
        Me.Buttonretour2.Size = New System.Drawing.Size(75, 23)
        Me.Buttonretour2.TabIndex = 3
        Me.Buttonretour2.Text = "Retour"
        Me.Buttonretour2.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 293)
        Me.Controls.Add(Me.Buttonretour2)
        Me.Controls.Add(Me.Buttonsupp)
        Me.Controls.Add(Me.Buttonmodifier)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Buttonmodifier As Button
    Friend WithEvents Buttonsupp As Button
    Friend WithEvents Buttonretour2 As Button
End Class

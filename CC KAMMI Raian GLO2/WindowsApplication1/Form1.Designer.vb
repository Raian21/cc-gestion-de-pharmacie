<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Buttonajout = New System.Windows.Forms.Button()
        Me.Buttonliste = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pharmacie Mandela"
        '
        'Buttonajout
        '
        Me.Buttonajout.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Buttonajout.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonajout.ForeColor = System.Drawing.Color.DarkGreen
        Me.Buttonajout.Location = New System.Drawing.Point(12, 177)
        Me.Buttonajout.Name = "Buttonajout"
        Me.Buttonajout.Size = New System.Drawing.Size(113, 58)
        Me.Buttonajout.TabIndex = 1
        Me.Buttonajout.Text = "Ajouter Medicaments"
        Me.Buttonajout.UseVisualStyleBackColor = False
        '
        'Buttonliste
        '
        Me.Buttonliste.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Buttonliste.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonliste.ForeColor = System.Drawing.Color.DarkGreen
        Me.Buttonliste.Location = New System.Drawing.Point(164, 177)
        Me.Buttonliste.Name = "Buttonliste"
        Me.Buttonliste.Size = New System.Drawing.Size(98, 58)
        Me.Buttonliste.TabIndex = 2
        Me.Buttonliste.Text = "Consulter les medicaments"
        Me.Buttonliste.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"Bienvenu à dans notre pharmacie", ""})
        Me.ListBox1.Location = New System.Drawing.Point(12, 76)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(250, 36)
        Me.ListBox1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Buttonliste)
        Me.Controls.Add(Me.Buttonajout)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Buttonajout As Button
    Friend WithEvents Buttonliste As Button
    Friend WithEvents ListBox1 As ListBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Labelnom = New System.Windows.Forms.Label()
        Me.Labelid = New System.Windows.Forms.Label()
        Me.Labelprix = New System.Windows.Forms.Label()
        Me.Labelqte = New System.Windows.Forms.Label()
        Me.Textnommedicament = New System.Windows.Forms.TextBox()
        Me.Textid = New System.Windows.Forms.TextBox()
        Me.Textprix = New System.Windows.Forms.TextBox()
        Me.Textqte = New System.Windows.Forms.TextBox()
        Me.Buttonvalider = New System.Windows.Forms.Button()
        Me.Buttonretour = New System.Windows.Forms.Button()
        Me.Buttonmodif = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(56, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ajouter des médicaments"
        '
        'Labelnom
        '
        Me.Labelnom.AutoSize = True
        Me.Labelnom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelnom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Labelnom.Location = New System.Drawing.Point(27, 79)
        Me.Labelnom.Name = "Labelnom"
        Me.Labelnom.Size = New System.Drawing.Size(125, 13)
        Me.Labelnom.TabIndex = 1
        Me.Labelnom.Text = "Nom du médicament:"
        '
        'Labelid
        '
        Me.Labelid.AutoSize = True
        Me.Labelid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelid.Location = New System.Drawing.Point(26, 129)
        Me.Labelid.Name = "Labelid"
        Me.Labelid.Size = New System.Drawing.Size(143, 13)
        Me.Labelid.TabIndex = 2
        Me.Labelid.Text = "Numéro du médicament:"
        '
        'Labelprix
        '
        Me.Labelprix.AutoSize = True
        Me.Labelprix.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelprix.Location = New System.Drawing.Point(27, 178)
        Me.Labelprix.Name = "Labelprix"
        Me.Labelprix.Size = New System.Drawing.Size(121, 13)
        Me.Labelprix.TabIndex = 3
        Me.Labelprix.Text = "Prix du médicament:"
        '
        'Labelqte
        '
        Me.Labelqte.AutoSize = True
        Me.Labelqte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelqte.Location = New System.Drawing.Point(27, 227)
        Me.Labelqte.Name = "Labelqte"
        Me.Labelqte.Size = New System.Drawing.Size(112, 13)
        Me.Labelqte.TabIndex = 4
        Me.Labelqte.Text = "Quantité en stock:"
        '
        'Textnommedicament
        '
        Me.Textnommedicament.Location = New System.Drawing.Point(26, 95)
        Me.Textnommedicament.Name = "Textnommedicament"
        Me.Textnommedicament.Size = New System.Drawing.Size(303, 20)
        Me.Textnommedicament.TabIndex = 5
        '
        'Textid
        '
        Me.Textid.Location = New System.Drawing.Point(26, 145)
        Me.Textid.Name = "Textid"
        Me.Textid.Size = New System.Drawing.Size(303, 20)
        Me.Textid.TabIndex = 6
        '
        'Textprix
        '
        Me.Textprix.Location = New System.Drawing.Point(26, 194)
        Me.Textprix.Name = "Textprix"
        Me.Textprix.Size = New System.Drawing.Size(303, 20)
        Me.Textprix.TabIndex = 7
        '
        'Textqte
        '
        Me.Textqte.Location = New System.Drawing.Point(26, 243)
        Me.Textqte.Name = "Textqte"
        Me.Textqte.Size = New System.Drawing.Size(303, 20)
        Me.Textqte.TabIndex = 8
        '
        'Buttonvalider
        '
        Me.Buttonvalider.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Buttonvalider.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonvalider.ForeColor = System.Drawing.Color.DarkGreen
        Me.Buttonvalider.Location = New System.Drawing.Point(26, 281)
        Me.Buttonvalider.Name = "Buttonvalider"
        Me.Buttonvalider.Size = New System.Drawing.Size(75, 23)
        Me.Buttonvalider.TabIndex = 9
        Me.Buttonvalider.Text = "Valider"
        Me.Buttonvalider.UseVisualStyleBackColor = False
        '
        'Buttonretour
        '
        Me.Buttonretour.BackColor = System.Drawing.Color.DarkGreen
        Me.Buttonretour.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonretour.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Buttonretour.Location = New System.Drawing.Point(254, 282)
        Me.Buttonretour.Name = "Buttonretour"
        Me.Buttonretour.Size = New System.Drawing.Size(75, 23)
        Me.Buttonretour.TabIndex = 10
        Me.Buttonretour.Text = "Retour"
        Me.Buttonretour.UseVisualStyleBackColor = False
        '
        'Buttonmodif
        '
        Me.Buttonmodif.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Buttonmodif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonmodif.ForeColor = System.Drawing.Color.DarkGreen
        Me.Buttonmodif.Location = New System.Drawing.Point(107, 281)
        Me.Buttonmodif.Name = "Buttonmodif"
        Me.Buttonmodif.Size = New System.Drawing.Size(75, 23)
        Me.Buttonmodif.TabIndex = 11
        Me.Buttonmodif.Text = "Modifier"
        Me.Buttonmodif.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(377, 368)
        Me.Controls.Add(Me.Buttonmodif)
        Me.Controls.Add(Me.Buttonretour)
        Me.Controls.Add(Me.Buttonvalider)
        Me.Controls.Add(Me.Textqte)
        Me.Controls.Add(Me.Textprix)
        Me.Controls.Add(Me.Textid)
        Me.Controls.Add(Me.Textnommedicament)
        Me.Controls.Add(Me.Labelqte)
        Me.Controls.Add(Me.Labelprix)
        Me.Controls.Add(Me.Labelid)
        Me.Controls.Add(Me.Labelnom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Labelnom As Label
    Friend WithEvents Labelid As Label
    Friend WithEvents Labelprix As Label
    Friend WithEvents Labelqte As Label
    Friend WithEvents Textnommedicament As TextBox
    Friend WithEvents Textid As TextBox
    Friend WithEvents Textprix As TextBox
    Friend WithEvents Textqte As TextBox
    Friend WithEvents Buttonvalider As Button
    Friend WithEvents Buttonretour As Button
    Friend WithEvents Buttonmodif As Button
End Class

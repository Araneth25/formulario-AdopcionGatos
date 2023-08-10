<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.cb4 = New System.Windows.Forms.CheckBox()
        Me.cb5 = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btbListo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCampoObligatorio = New System.Windows.Forms.Label()
        Me.lblCampoObligatorio1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Muthiara -Demo Version-", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Sienna
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(730, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dado que cumple las funciones. FELICIDADES!!"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(104, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ADOPTA A UNO DE NUESTROS PELUDITOS"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(291, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "¿Qué tamaño de gato prefieres?"
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.BackColor = System.Drawing.Color.Transparent
        Me.rb1.Location = New System.Drawing.Point(343, 135)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(83, 20)
        Me.rb1.TabIndex = 3
        Me.rb1.TabStop = True
        Me.rb1.Text = "Pequeño"
        Me.rb1.UseVisualStyleBackColor = False
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.BackColor = System.Drawing.Color.Transparent
        Me.rb2.Location = New System.Drawing.Point(432, 135)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(81, 20)
        Me.rb2.TabIndex = 4
        Me.rb2.TabStop = True
        Me.rb2.Text = "Mediano"
        Me.rb2.UseVisualStyleBackColor = False
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.BackColor = System.Drawing.Color.Transparent
        Me.rb3.Location = New System.Drawing.Point(530, 135)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(73, 20)
        Me.rb3.TabIndex = 5
        Me.rb3.TabStop = True
        Me.rb3.Text = "Grande"
        Me.rb3.UseVisualStyleBackColor = False
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.BackColor = System.Drawing.Color.Transparent
        Me.rb4.Location = New System.Drawing.Point(402, 161)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(152, 20)
        Me.rb4.TabIndex = 6
        Me.rb4.TabStop = True
        Me.rb4.Text = "Todos los anteriores"
        Me.rb4.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sexo del gatito"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Hembra", "Macho", "Sin preferencias"})
        Me.ComboBox1.Location = New System.Drawing.Point(285, 210)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(197, 24)
        Me.ComboBox1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(143, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(346, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "¿Qué tanta energía debe tener tu gatito?"
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.BackColor = System.Drawing.Color.Transparent
        Me.cb1.Location = New System.Drawing.Point(380, 318)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(68, 20)
        Me.cb1.TabIndex = 10
        Me.cb1.Text = "Quieto"
        Me.cb1.UseVisualStyleBackColor = False
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.BackColor = System.Drawing.Color.Transparent
        Me.cb2.Location = New System.Drawing.Point(497, 318)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(118, 20)
        Me.cb2.TabIndex = 11
        Me.cb2.Text = "Mucha energía"
        Me.cb2.UseVisualStyleBackColor = False
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.BackColor = System.Drawing.Color.Transparent
        Me.cb3.Location = New System.Drawing.Point(380, 359)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(62, 20)
        Me.cb3.TabIndex = 12
        Me.cb3.Text = "Vivaz"
        Me.cb3.UseVisualStyleBackColor = False
        '
        'cb4
        '
        Me.cb4.AutoSize = True
        Me.cb4.BackColor = System.Drawing.Color.Transparent
        Me.cb4.Location = New System.Drawing.Point(497, 359)
        Me.cb4.Name = "cb4"
        Me.cb4.Size = New System.Drawing.Size(92, 20)
        Me.cb4.TabIndex = 13
        Me.cb4.Text = "Moderado"
        Me.cb4.UseVisualStyleBackColor = False
        '
        'cb5
        '
        Me.cb5.AutoSize = True
        Me.cb5.BackColor = System.Drawing.Color.Transparent
        Me.cb5.Location = New System.Drawing.Point(380, 402)
        Me.cb5.Name = "cb5"
        Me.cb5.Size = New System.Drawing.Size(76, 20)
        Me.cb5.TabIndex = 14
        Me.cb5.Text = "Callado"
        Me.cb5.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Allccaco_Garcia_Araneth.My.Resources.Resources.logo21
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(462, 500)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(231, 222)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(232, 677)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(287, 29)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "UN MAULLIDO ACELERA EL CORAZÓN"
        '
        'btbListo
        '
        Me.btbListo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btbListo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbListo.Location = New System.Drawing.Point(273, 531)
        Me.btbListo.Name = "btbListo"
        Me.btbListo.Size = New System.Drawing.Size(138, 54)
        Me.btbListo.TabIndex = 17
        Me.btbListo.Text = "LISTO"
        Me.btbListo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(351, 706)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 29)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Nos contactaremos..!!"
        '
        'lblCampoObligatorio
        '
        Me.lblCampoObligatorio.BackColor = System.Drawing.Color.Transparent
        Me.lblCampoObligatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampoObligatorio.ForeColor = System.Drawing.Color.Maroon
        Me.lblCampoObligatorio.Location = New System.Drawing.Point(154, 298)
        Me.lblCampoObligatorio.Name = "lblCampoObligatorio"
        Me.lblCampoObligatorio.Size = New System.Drawing.Size(211, 23)
        Me.lblCampoObligatorio.TabIndex = 35
        Me.lblCampoObligatorio.Text = "Campo Obligatorio"
        Me.lblCampoObligatorio.Visible = False
        '
        'lblCampoObligatorio1
        '
        Me.lblCampoObligatorio1.BackColor = System.Drawing.Color.Transparent
        Me.lblCampoObligatorio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampoObligatorio1.ForeColor = System.Drawing.Color.Maroon
        Me.lblCampoObligatorio1.Location = New System.Drawing.Point(127, 237)
        Me.lblCampoObligatorio1.Name = "lblCampoObligatorio1"
        Me.lblCampoObligatorio1.Size = New System.Drawing.Size(211, 23)
        Me.lblCampoObligatorio1.TabIndex = 36
        Me.lblCampoObligatorio1.Text = "Campo Obligatorio"
        Me.lblCampoObligatorio1.Visible = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Allccaco_Garcia_Araneth.My.Resources.Resources.fondo31
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(685, 773)
        Me.Controls.Add(Me.lblCampoObligatorio1)
        Me.Controls.Add(Me.lblCampoObligatorio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btbListo)
        Me.Controls.Add(Me.cb5)
        Me.Controls.Add(Me.cb4)
        Me.Controls.Add(Me.cb3)
        Me.Controls.Add(Me.cb2)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rb4)
        Me.Controls.Add(Me.rb3)
        Me.Controls.Add(Me.rb2)
        Me.Controls.Add(Me.rb1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.Text = "Adoptando.."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents rb4 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents cb5 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btbListo As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCampoObligatorio As Label
    Friend WithEvents lblCampoObligatorio1 As Label
End Class

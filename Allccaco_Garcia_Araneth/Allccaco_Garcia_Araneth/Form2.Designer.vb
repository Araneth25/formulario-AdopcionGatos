<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblOcupacion = New System.Windows.Forms.Label()
        Me.txtOcupacion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblMovil = New System.Windows.Forms.Label()
        Me.txtMovil = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.nudEdad = New System.Windows.Forms.NumericUpDown()
        Me.rbSI = New System.Windows.Forms.RadioButton()
        Me.rbNO = New System.Windows.Forms.RadioButton()
        Me.btbReset = New System.Windows.Forms.Button()
        Me.btbCerrar = New System.Windows.Forms.Button()
        Me.btbListo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbComentar = New System.Windows.Forms.TextBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblCampoObligatorio = New System.Windows.Forms.Label()
        Me.lblCampoObligatorio1 = New System.Windows.Forms.Label()
        Me.lblCampoObligatorio2 = New System.Windows.Forms.Label()
        Me.lblCampoObligatorio3 = New System.Windows.Forms.Label()
        Me.lblCampoObligatorio4 = New System.Windows.Forms.Label()
        Me.lblCampoObligatorio5 = New System.Windows.Forms.Label()
        Me.lblCampoObligatorio6 = New System.Windows.Forms.Label()
        Me.lblCampoObligatorio7 = New System.Windows.Forms.Label()
        CType(Me.nudEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblNombre.Location = New System.Drawing.Point(164, 299)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(114, 29)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(298, 302)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(194, 22)
        Me.txtNombre.TabIndex = 2
        '
        'lblApellidos
        '
        Me.lblApellidos.BackColor = System.Drawing.Color.Transparent
        Me.lblApellidos.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblApellidos.Location = New System.Drawing.Point(509, 301)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(152, 25)
        Me.lblApellidos.TabIndex = 3
        Me.lblApellidos.Text = "Apellidos:"
        Me.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(656, 305)
        Me.txtApellidos.MaxLength = 20
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(279, 22)
        Me.txtApellidos.TabIndex = 4
        '
        'lblEdad
        '
        Me.lblEdad.BackColor = System.Drawing.Color.Transparent
        Me.lblEdad.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblEdad.Location = New System.Drawing.Point(201, 354)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(77, 32)
        Me.lblEdad.TabIndex = 5
        Me.lblEdad.Text = "Edad:"
        Me.lblEdad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOcupacion
        '
        Me.lblOcupacion.BackColor = System.Drawing.Color.Transparent
        Me.lblOcupacion.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOcupacion.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblOcupacion.Location = New System.Drawing.Point(415, 361)
        Me.lblOcupacion.Name = "lblOcupacion"
        Me.lblOcupacion.Size = New System.Drawing.Size(150, 27)
        Me.lblOcupacion.TabIndex = 7
        Me.lblOcupacion.Text = "Ocupación:"
        Me.lblOcupacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOcupacion
        '
        Me.txtOcupacion.Location = New System.Drawing.Point(571, 364)
        Me.txtOcupacion.MaxLength = 20
        Me.txtOcupacion.Name = "txtOcupacion"
        Me.txtOcupacion.Size = New System.Drawing.Size(368, 22)
        Me.txtOcupacion.TabIndex = 8
        '
        'lblDireccion
        '
        Me.lblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccion.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblDireccion.Location = New System.Drawing.Point(96, 414)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(140, 29)
        Me.lblDireccion.TabIndex = 9
        Me.lblDireccion.Text = "Dirección: "
        Me.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(229, 418)
        Me.txtDireccion.MaxLength = 30
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(381, 22)
        Me.txtDireccion.TabIndex = 10
        '
        'lblTelefono
        '
        Me.lblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblTelefono.Location = New System.Drawing.Point(168, 471)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(146, 30)
        Me.lblTelefono.TabIndex = 13
        Me.lblTelefono.Text = "Teléfono: "
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(307, 476)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(209, 22)
        Me.txtTelefono.TabIndex = 14
        '
        'lblMovil
        '
        Me.lblMovil.BackColor = System.Drawing.Color.Transparent
        Me.lblMovil.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovil.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblMovil.Location = New System.Drawing.Point(538, 463)
        Me.lblMovil.Name = "lblMovil"
        Me.lblMovil.Size = New System.Drawing.Size(104, 38)
        Me.lblMovil.TabIndex = 15
        Me.lblMovil.Text = "Móvil: "
        Me.lblMovil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMovil
        '
        Me.txtMovil.Location = New System.Drawing.Point(647, 471)
        Me.txtMovil.MaxLength = 9
        Me.txtMovil.Name = "txtMovil"
        Me.txtMovil.Size = New System.Drawing.Size(209, 22)
        Me.txtMovil.TabIndex = 16
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblEmail.Location = New System.Drawing.Point(201, 510)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(91, 35)
        Me.lblEmail.TabIndex = 17
        Me.lblEmail.Text = "Email: "
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(298, 517)
        Me.txtEmail.MaxLength = 45
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(605, 22)
        Me.txtEmail.TabIndex = 18
        '
        'lblPregunta
        '
        Me.lblPregunta.BackColor = System.Drawing.Color.Transparent
        Me.lblPregunta.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregunta.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblPregunta.Location = New System.Drawing.Point(31, 572)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(725, 59)
        Me.lblPregunta.TabIndex = 19
        Me.lblPregunta.Text = "¿Están todos los miembros de la familia de acuerdo en la adopción del gato? "
        '
        'nudEdad
        '
        Me.nudEdad.Location = New System.Drawing.Point(284, 361)
        Me.nudEdad.Maximum = New Decimal(New Integer() {70, 0, 0, 0})
        Me.nudEdad.Minimum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.nudEdad.Name = "nudEdad"
        Me.nudEdad.Size = New System.Drawing.Size(102, 22)
        Me.nudEdad.TabIndex = 6
        Me.nudEdad.Value = New Decimal(New Integer() {18, 0, 0, 0})
        '
        'rbSI
        '
        Me.rbSI.AutoSize = True
        Me.rbSI.BackColor = System.Drawing.Color.Transparent
        Me.rbSI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSI.Location = New System.Drawing.Point(808, 569)
        Me.rbSI.Name = "rbSI"
        Me.rbSI.Size = New System.Drawing.Size(45, 24)
        Me.rbSI.TabIndex = 20
        Me.rbSI.TabStop = True
        Me.rbSI.Text = "SI"
        Me.rbSI.UseVisualStyleBackColor = False
        '
        'rbNO
        '
        Me.rbNO.AutoSize = True
        Me.rbNO.BackColor = System.Drawing.Color.Transparent
        Me.rbNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNO.Location = New System.Drawing.Point(894, 569)
        Me.rbNO.Name = "rbNO"
        Me.rbNO.Size = New System.Drawing.Size(55, 24)
        Me.rbNO.TabIndex = 21
        Me.rbNO.TabStop = True
        Me.rbNO.Text = "NO"
        Me.rbNO.UseVisualStyleBackColor = False
        '
        'btbReset
        '
        Me.btbReset.BackColor = System.Drawing.Color.SaddleBrown
        Me.btbReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btbReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbReset.ForeColor = System.Drawing.Color.White
        Me.btbReset.Location = New System.Drawing.Point(504, 760)
        Me.btbReset.Name = "btbReset"
        Me.btbReset.Size = New System.Drawing.Size(117, 56)
        Me.btbReset.TabIndex = 24
        Me.btbReset.Text = "RESET"
        Me.btbReset.UseVisualStyleBackColor = False
        '
        'btbCerrar
        '
        Me.btbCerrar.BackColor = System.Drawing.Color.SaddleBrown
        Me.btbCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btbCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbCerrar.ForeColor = System.Drawing.Color.White
        Me.btbCerrar.Location = New System.Drawing.Point(225, 770)
        Me.btbCerrar.Name = "btbCerrar"
        Me.btbCerrar.Size = New System.Drawing.Size(100, 59)
        Me.btbCerrar.TabIndex = 25
        Me.btbCerrar.Text = "CERRAR"
        Me.btbCerrar.UseVisualStyleBackColor = False
        '
        'btbListo
        '
        Me.btbListo.BackColor = System.Drawing.Color.SaddleBrown
        Me.btbListo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btbListo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbListo.ForeColor = System.Drawing.Color.White
        Me.btbListo.Location = New System.Drawing.Point(814, 770)
        Me.btbListo.Name = "btbListo"
        Me.btbListo.Size = New System.Drawing.Size(100, 59)
        Me.btbListo.TabIndex = 26
        Me.btbListo.Text = "LISTO!"
        Me.btbListo.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Allccaco_Garcia_Araneth.My.Resources.Resources.logo21
        Me.PictureBox1.Location = New System.Drawing.Point(381, -47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 302)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label2.Location = New System.Drawing.Point(32, 631)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(495, 33)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Comentar, ¿por qué adoptarías un gatito?"
        '
        'txbComentar
        '
        Me.txbComentar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbComentar.Location = New System.Drawing.Point(533, 631)
        Me.txbComentar.MaxLength = 100
        Me.txbComentar.Multiline = True
        Me.txbComentar.Name = "txbComentar"
        Me.txbComentar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txbComentar.Size = New System.Drawing.Size(456, 113)
        Me.txbComentar.TabIndex = 23
        Me.txbComentar.WordWrap = False
        '
        'lblMunicipio
        '
        Me.lblMunicipio.BackColor = System.Drawing.Color.Transparent
        Me.lblMunicipio.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMunicipio.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblMunicipio.Location = New System.Drawing.Point(616, 417)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(138, 29)
        Me.lblMunicipio.TabIndex = 11
        Me.lblMunicipio.Text = "Municipio:"
        Me.lblMunicipio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"", "Ajalvir", "Alameda del Valle", "Alcalá de Henares", "Alcobendas", "Alcorcón", "Aldea del Fresno", "Algete", "Alpedrete", "Ambite", "Anchuelo", "Aranjuez", "Arganda del Rey", "Arroyomolinos", "Batres", "Becerril de la Sierra", "Belmonte de Tajo", "Berzosa del Lozoya", "Boadilla del Monte", "Braojos", "Brea de Tajo", "Brunete", "Buitrago del Lozoya", "Bustarviejo", "Cabanillas de la Sierra", "Cadalso de los Vidrios", "Camarma de Esteruelas", "Campo Real", "Canencia", "Carabaña", "Casarrubuelos", "Cenicientos", "Cerceda", "Cercedilla", "Cervera de Buitrago", "Chapinería", "Chinchón", "Ciempozuelos", "Cobeña", "Collado Mediano", "Collado Villalba", "Colmenar de Oreja", "Colmenar del Arroyo", "Colmenar Viejo", "Colmenarejo", "Corpa", "Coslada", "Cubas de la Sagra", "Daganzo de Arriba", "El Atazar", "El Berrueco", "El Boalo", "El Escorial", "El Molar (Madrid)", "El Vellón", "El Álamo (Madrid)", "Estremera", "Fresnedillas de la Oliva", "Fresno de Torote", "Fuenlabrada", "Fuente el Saz de Jarama", "Fuentidueña de Tajo", "Galapagar", "Garganta de los Montes", "Gargantilla del Lozoya y Pinilla de Buitrago", "Gascones", "Getafe", "Griñón", "Guadalix de la Sierra", "Guadarrama", "Horcajo de la Sierra-Aoslos", "Horcajuelo de la Sierra", "Hoyo de Manzanares", "Humanes de Madrid", "La Acebeda", "La Cabrera", "La Hiruela", "La Serna del Monte", "Las Rozas", "Leganés", "Loeches", "Los Molinos", "Los Santos de la Humosa", "Lozoya", "Lozoyuela-Navas-Sieteiglesias", "Madarcos", "Madrid", "Madrid (desambiguación)", "Majadahonda", "Manzanares el Real", "Meco", "Mejorada del Campo", "Miraflores de la Sierra", "Montejo de la Sierra", "Moraleja de Enmedio", "Moralzarzal", "Morata de Tajuña", "Móstoles", "Navacerrada", "Navalafuente", "Navalagamella", "Navalcarnero", "Navarredonda y San Mamés", "Navas del Rey", "Nuevo Baztán", "Olmeda de las Fuentes", "Orusco de Tajuña", "Paracuellos del Jarama", "Parla", "Patones", "Pedrezuela", "Pelayos de la Presa", "Perales de Tajuña", "Pezuela de las Torres", "Pinilla del Valle", "Pinto", "Piñuécar-Gandullas", "Pozuelo de Alarcón", "Pozuelo del Rey", "Prádena del Rincón", "Puebla de la Sierra", "Puentes Viejas", "Quijorna", "Rascafría", "Redueña", "Ribatejada", "Rivas-Vaciamadrid", "Robledillo de la Jara", "Robledo de Chavela", "Robregordo", "Rozas de Puerto Real", "San Agustín del Guadalix", "San Fernando de Henares", "San Lorenzo del Escorial", "San Martín de la Vega", "San Martín de Valdeiglesias", "San Sebastián de los Reyes", "Santa María de la Alameda", "Santorcaz", "Serranillos del Valle", "Seseña", "Sevilla La Nueva", "Somosierra", "Soto del Real", "Talamanca de Jarama", "Tielmes", "Titulcia", "Torrejón de Ardoz", "Torrejón de la Calzada", "Torrejón de Velasco", "Torrelaguna", "Torrelodones", "Torremocha de Jarama", "Torres de la Alameda", "Tres Cantos", "Valdaracete", "Valdeavero", "Valdelaguna", "Valdemanco", "Valdemaqueda", "Valdemorillo", "Valdemoro", "Valdeolmos-Alalpardo", "Valdepiélagos", "Valdetorres de Jarama", "Valdilecha", "Valverde de Alcalá", "Velilla de San Antonio", "Venturada", "Villa del Prado", "Villaconejos", "Villalbilla", "Villamanrique de Tajo", "Villamanta", "Villamantilla", "Villanueva de la Cañada", "Villanueva de Perales", "Villanueva del Pardillo", "Villar del Olmo", "Villarejo de Salvanés", "Villaviciosa de Odón", "Villavieja del Lozoya", "Zarzalejo"})
        Me.ComboBox1.Location = New System.Drawing.Point(749, 422)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(221, 24)
        Me.ComboBox1.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.Allccaco_Garcia_Araneth.My.Resources.Resources.titulo21
        Me.PictureBox2.Location = New System.Drawing.Point(12, 200)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1138, 78)
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'lblCampoObligatorio
        '
        Me.lblCampoObligatorio.BackColor = System.Drawing.Color.Transparent
        Me.lblCampoObligatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampoObligatorio.ForeColor = System.Drawing.Color.Maroon
        Me.lblCampoObligatorio.Location = New System.Drawing.Point(295, 330)
        Me.lblCampoObligatorio.Name = "lblCampoObligatorio"
        Me.lblCampoObligatorio.Size = New System.Drawing.Size(263, 23)
        Me.lblCampoObligatorio.TabIndex = 28
        Me.lblCampoObligatorio.Text = "Campo Obligatorio"
        Me.lblCampoObligatorio.Visible = False
        '
        'lblCampoObligatorio1
        '
        Me.lblCampoObligatorio1.BackColor = System.Drawing.Color.Transparent
        Me.lblCampoObligatorio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampoObligatorio1.ForeColor = System.Drawing.Color.Maroon
        Me.lblCampoObligatorio1.Location = New System.Drawing.Point(653, 330)
        Me.lblCampoObligatorio1.Name = "lblCampoObligatorio1"
        Me.lblCampoObligatorio1.Size = New System.Drawing.Size(263, 23)
        Me.lblCampoObligatorio1.TabIndex = 29
        Me.lblCampoObligatorio1.Text = "Campo Obligatorio"
        Me.lblCampoObligatorio1.Visible = False
        '
        'lblCampoObligatorio2
        '
        Me.lblCampoObligatorio2.BackColor = System.Drawing.Color.Transparent
        Me.lblCampoObligatorio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampoObligatorio2.ForeColor = System.Drawing.Color.Maroon
        Me.lblCampoObligatorio2.Location = New System.Drawing.Point(568, 389)
        Me.lblCampoObligatorio2.Name = "lblCampoObligatorio2"
        Me.lblCampoObligatorio2.Size = New System.Drawing.Size(263, 23)
        Me.lblCampoObligatorio2.TabIndex = 30
        Me.lblCampoObligatorio2.Text = "Campo Obligatorio"
        Me.lblCampoObligatorio2.Visible = False
        '
        'lblCampoObligatorio3
        '
        Me.lblCampoObligatorio3.BackColor = System.Drawing.Color.Transparent
        Me.lblCampoObligatorio3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampoObligatorio3.ForeColor = System.Drawing.Color.Maroon
        Me.lblCampoObligatorio3.Location = New System.Drawing.Point(226, 444)
        Me.lblCampoObligatorio3.Name = "lblCampoObligatorio3"
        Me.lblCampoObligatorio3.Size = New System.Drawing.Size(263, 23)
        Me.lblCampoObligatorio3.TabIndex = 31
        Me.lblCampoObligatorio3.Text = "Campo Obligatorio"
        Me.lblCampoObligatorio3.Visible = False
        '
        'lblCampoObligatorio4
        '
        Me.lblCampoObligatorio4.BackColor = System.Drawing.Color.Transparent
        Me.lblCampoObligatorio4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampoObligatorio4.ForeColor = System.Drawing.Color.Maroon
        Me.lblCampoObligatorio4.Location = New System.Drawing.Point(644, 496)
        Me.lblCampoObligatorio4.Name = "lblCampoObligatorio4"
        Me.lblCampoObligatorio4.Size = New System.Drawing.Size(263, 23)
        Me.lblCampoObligatorio4.TabIndex = 32
        Me.lblCampoObligatorio4.Text = "Campo Obligatorio"
        Me.lblCampoObligatorio4.Visible = False
        '
        'lblCampoObligatorio5
        '
        Me.lblCampoObligatorio5.BackColor = System.Drawing.Color.Transparent
        Me.lblCampoObligatorio5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampoObligatorio5.ForeColor = System.Drawing.Color.Maroon
        Me.lblCampoObligatorio5.Location = New System.Drawing.Point(295, 542)
        Me.lblCampoObligatorio5.Name = "lblCampoObligatorio5"
        Me.lblCampoObligatorio5.Size = New System.Drawing.Size(263, 23)
        Me.lblCampoObligatorio5.TabIndex = 33
        Me.lblCampoObligatorio5.Text = "Campo Obligatorio"
        Me.lblCampoObligatorio5.Visible = False
        '
        'lblCampoObligatorio6
        '
        Me.lblCampoObligatorio6.BackColor = System.Drawing.Color.Transparent
        Me.lblCampoObligatorio6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampoObligatorio6.ForeColor = System.Drawing.Color.Maroon
        Me.lblCampoObligatorio6.Location = New System.Drawing.Point(165, 594)
        Me.lblCampoObligatorio6.Name = "lblCampoObligatorio6"
        Me.lblCampoObligatorio6.Size = New System.Drawing.Size(263, 23)
        Me.lblCampoObligatorio6.TabIndex = 34
        Me.lblCampoObligatorio6.Text = "Campo Obligatorio"
        Me.lblCampoObligatorio6.Visible = False
        '
        'lblCampoObligatorio7
        '
        Me.lblCampoObligatorio7.BackColor = System.Drawing.Color.Transparent
        Me.lblCampoObligatorio7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampoObligatorio7.ForeColor = System.Drawing.Color.Maroon
        Me.lblCampoObligatorio7.Location = New System.Drawing.Point(53, 652)
        Me.lblCampoObligatorio7.Name = "lblCampoObligatorio7"
        Me.lblCampoObligatorio7.Size = New System.Drawing.Size(263, 23)
        Me.lblCampoObligatorio7.TabIndex = 35
        Me.lblCampoObligatorio7.Text = "Campo Obligatorio"
        Me.lblCampoObligatorio7.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Allccaco_Garcia_Araneth.My.Resources.Resources.fondo2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1074, 1055)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCampoObligatorio7)
        Me.Controls.Add(Me.lblCampoObligatorio6)
        Me.Controls.Add(Me.lblCampoObligatorio5)
        Me.Controls.Add(Me.lblCampoObligatorio4)
        Me.Controls.Add(Me.lblCampoObligatorio3)
        Me.Controls.Add(Me.lblCampoObligatorio2)
        Me.Controls.Add(Me.lblCampoObligatorio1)
        Me.Controls.Add(Me.lblCampoObligatorio)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblMunicipio)
        Me.Controls.Add(Me.txbComentar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btbCerrar)
        Me.Controls.Add(Me.btbReset)
        Me.Controls.Add(Me.btbListo)
        Me.Controls.Add(Me.rbNO)
        Me.Controls.Add(Me.rbSI)
        Me.Controls.Add(Me.nudEdad)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtMovil)
        Me.Controls.Add(Me.lblMovil)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.txtOcupacion)
        Me.Controls.Add(Me.lblOcupacion)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CatAdop Formulario"
        CType(Me.nudEdad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblApellidos As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblOcupacion As Label
    Friend WithEvents txtOcupacion As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblMovil As Label
    Friend WithEvents txtMovil As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPregunta As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents nudEdad As NumericUpDown
    Friend WithEvents rbSI As RadioButton
    Friend WithEvents rbNO As RadioButton
    Friend WithEvents btbListo As Button
    Friend WithEvents btbReset As Button
    Friend WithEvents btbCerrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txbComentar As TextBox
    Friend WithEvents lblMunicipio As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblCampoObligatorio As Label
    Friend WithEvents lblCampoObligatorio1 As Label
    Friend WithEvents lblCampoObligatorio2 As Label
    Friend WithEvents lblCampoObligatorio3 As Label
    Friend WithEvents lblCampoObligatorio4 As Label
    Friend WithEvents lblCampoObligatorio5 As Label
    Friend WithEvents lblCampoObligatorio6 As Label
    Friend WithEvents lblCampoObligatorio7 As Label
End Class

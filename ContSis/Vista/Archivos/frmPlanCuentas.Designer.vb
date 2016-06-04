<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlanCuentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnexport = New System.Windows.Forms.Button()
        Me.btnimport = New System.Windows.Forms.Button()
        Me.btnCnfImp = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbohaber = New System.Windows.Forms.ComboBox()
        Me.cbodebe = New System.Windows.Forms.ComboBox()
        Me.lblAmHaber = New System.Windows.Forms.Label()
        Me.lblAmDebe = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.txtalias = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcuenta = New System.Windows.Forms.TextBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbldebeini = New System.Windows.Forms.Label()
        Me.lblhaberini = New System.Windows.Forms.Label()
        Me.lbldebeene = New System.Windows.Forms.Label()
        Me.lblhaberene = New System.Windows.Forms.Label()
        Me.lblhabertotal = New System.Windows.Forms.Label()
        Me.lbldebefeb = New System.Windows.Forms.Label()
        Me.lbldebetotal = New System.Windows.Forms.Label()
        Me.lblhaberfeb = New System.Windows.Forms.Label()
        Me.lbldebeabr = New System.Windows.Forms.Label()
        Me.lblhabercier = New System.Windows.Forms.Label()
        Me.lbldebemar = New System.Windows.Forms.Label()
        Me.lbldebecier = New System.Windows.Forms.Label()
        Me.lbldebejun = New System.Windows.Forms.Label()
        Me.lblhaberabr = New System.Windows.Forms.Label()
        Me.lblhabermar = New System.Windows.Forms.Label()
        Me.lblhaberjun = New System.Windows.Forms.Label()
        Me.lbldebemay = New System.Windows.Forms.Label()
        Me.lblhaberdic = New System.Windows.Forms.Label()
        Me.lbldebejul = New System.Windows.Forms.Label()
        Me.lblhabermay = New System.Windows.Forms.Label()
        Me.lblhaberoct = New System.Windows.Forms.Label()
        Me.lblhaberjul = New System.Windows.Forms.Label()
        Me.lbldebedic = New System.Windows.Forms.Label()
        Me.lbldebesep = New System.Windows.Forms.Label()
        Me.lbldebeoct = New System.Windows.Forms.Label()
        Me.lbldebeago = New System.Windows.Forms.Label()
        Me.lblhabernov = New System.Windows.Forms.Label()
        Me.lbldebenov = New System.Windows.Forms.Label()
        Me.lblhaberago = New System.Windows.Forms.Label()
        Me.lblhabersep = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(555, 180)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(134, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 43
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"2 Digitos", "3 Digitos", "4 Digitos", "5 Digitos", "( 6 - 12 ) Digitos"})
        Me.ComboBox1.Location = New System.Drawing.Point(555, 14)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 21)
        Me.ComboBox1.TabIndex = 151
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnexport)
        Me.GroupBox3.Controls.Add(Me.btnimport)
        Me.GroupBox3.Controls.Add(Me.btnCnfImp)
        Me.GroupBox3.Location = New System.Drawing.Point(546, 42)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(159, 124)
        Me.GroupBox3.TabIndex = 150
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opcional Plan Contable - Excel"
        '
        'btnexport
        '
        Me.btnexport.Location = New System.Drawing.Point(46, 57)
        Me.btnexport.Name = "btnexport"
        Me.btnexport.Size = New System.Drawing.Size(75, 23)
        Me.btnexport.TabIndex = 53
        Me.btnexport.Text = "Exportar"
        Me.btnexport.UseVisualStyleBackColor = True
        '
        'btnimport
        '
        Me.btnimport.Location = New System.Drawing.Point(46, 28)
        Me.btnimport.Name = "btnimport"
        Me.btnimport.Size = New System.Drawing.Size(75, 23)
        Me.btnimport.TabIndex = 54
        Me.btnimport.Text = "Importar"
        Me.btnimport.UseVisualStyleBackColor = True
        '
        'btnCnfImp
        '
        Me.btnCnfImp.Location = New System.Drawing.Point(46, 95)
        Me.btnCnfImp.Name = "btnCnfImp"
        Me.btnCnfImp.Size = New System.Drawing.Size(75, 23)
        Me.btnCnfImp.TabIndex = 37
        Me.btnCnfImp.Text = "Confirmar"
        Me.btnCnfImp.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbohaber)
        Me.GroupBox2.Controls.Add(Me.cbodebe)
        Me.GroupBox2.Controls.Add(Me.lblAmHaber)
        Me.GroupBox2.Controls.Add(Me.lblAmDebe)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 161)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(524, 68)
        Me.GroupBox2.TabIndex = 149
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Destino"
        '
        'cbohaber
        '
        Me.cbohaber.FormattingEnabled = True
        Me.cbohaber.Location = New System.Drawing.Point(281, 19)
        Me.cbohaber.Name = "cbohaber"
        Me.cbohaber.Size = New System.Drawing.Size(81, 21)
        Me.cbohaber.TabIndex = 17
        '
        'cbodebe
        '
        Me.cbodebe.FormattingEnabled = True
        Me.cbodebe.Location = New System.Drawing.Point(24, 19)
        Me.cbodebe.Name = "cbodebe"
        Me.cbodebe.Size = New System.Drawing.Size(81, 21)
        Me.cbodebe.TabIndex = 17
        '
        'lblAmHaber
        '
        Me.lblAmHaber.AutoSize = True
        Me.lblAmHaber.Location = New System.Drawing.Point(278, 44)
        Me.lblAmHaber.Name = "lblAmHaber"
        Me.lblAmHaber.Size = New System.Drawing.Size(72, 13)
        Me.lblAmHaber.TabIndex = 16
        Me.lblAmHaber.Text = "Amarre Haber"
        '
        'lblAmDebe
        '
        Me.lblAmDebe.AutoSize = True
        Me.lblAmDebe.Location = New System.Drawing.Point(24, 44)
        Me.lblAmDebe.Name = "lblAmDebe"
        Me.lblAmDebe.Size = New System.Drawing.Size(69, 13)
        Me.lblAmDebe.TabIndex = 15
        Me.lblAmDebe.Text = "Amarre Debe"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(492, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 147
        Me.Label7.Text = "Digitos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Controls.Add(Me.txtalias)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcuenta)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 113)
        Me.GroupBox1.TabIndex = 146
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Principal"
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(186, 20)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(59, 23)
        Me.BtnSearch.TabIndex = 132
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'txtalias
        '
        Me.txtalias.Location = New System.Drawing.Point(99, 79)
        Me.txtalias.MaxLength = 25
        Me.txtalias.Name = "txtalias"
        Me.txtalias.Size = New System.Drawing.Size(158, 20)
        Me.txtalias.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre Corto"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(100, 53)
        Me.txtnombre.MaxLength = 150
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(408, 20)
        Me.txtnombre.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cuenta"
        '
        'txtcuenta
        '
        Me.txtcuenta.Location = New System.Drawing.Point(100, 22)
        Me.txtcuenta.MaxLength = 12
        Me.txtcuenta.Name = "txtcuenta"
        Me.txtcuenta.Size = New System.Drawing.Size(81, 20)
        Me.txtcuenta.TabIndex = 0
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(258, 12)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 142
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(177, 12)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 143
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(92, 12)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 144
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(7, 12)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 145
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbldebeini)
        Me.GroupBox4.Controls.Add(Me.lblhaberini)
        Me.GroupBox4.Controls.Add(Me.lbldebeene)
        Me.GroupBox4.Controls.Add(Me.lblhaberene)
        Me.GroupBox4.Controls.Add(Me.lblhabertotal)
        Me.GroupBox4.Controls.Add(Me.lbldebefeb)
        Me.GroupBox4.Controls.Add(Me.lbldebetotal)
        Me.GroupBox4.Controls.Add(Me.lblhaberfeb)
        Me.GroupBox4.Controls.Add(Me.lbldebeabr)
        Me.GroupBox4.Controls.Add(Me.lblhabercier)
        Me.GroupBox4.Controls.Add(Me.lbldebemar)
        Me.GroupBox4.Controls.Add(Me.lbldebecier)
        Me.GroupBox4.Controls.Add(Me.lbldebejun)
        Me.GroupBox4.Controls.Add(Me.lblhaberabr)
        Me.GroupBox4.Controls.Add(Me.lblhabermar)
        Me.GroupBox4.Controls.Add(Me.lblhaberjun)
        Me.GroupBox4.Controls.Add(Me.lbldebemay)
        Me.GroupBox4.Controls.Add(Me.lblhaberdic)
        Me.GroupBox4.Controls.Add(Me.lbldebejul)
        Me.GroupBox4.Controls.Add(Me.lblhabermay)
        Me.GroupBox4.Controls.Add(Me.lblhaberoct)
        Me.GroupBox4.Controls.Add(Me.lblhaberjul)
        Me.GroupBox4.Controls.Add(Me.lbldebedic)
        Me.GroupBox4.Controls.Add(Me.lbldebesep)
        Me.GroupBox4.Controls.Add(Me.lbldebeoct)
        Me.GroupBox4.Controls.Add(Me.lbldebeago)
        Me.GroupBox4.Controls.Add(Me.lblhabernov)
        Me.GroupBox4.Controls.Add(Me.lbldebenov)
        Me.GroupBox4.Controls.Add(Me.lblhaberago)
        Me.GroupBox4.Controls.Add(Me.lblhabersep)
        Me.GroupBox4.Location = New System.Drawing.Point(213, 273)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(318, 276)
        Me.GroupBox4.TabIndex = 177
        Me.GroupBox4.TabStop = False
        '
        'lbldebeini
        '
        Me.lbldebeini.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebeini.Location = New System.Drawing.Point(29, 8)
        Me.lbldebeini.Name = "lbldebeini"
        Me.lbldebeini.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldebeini.Size = New System.Drawing.Size(109, 17)
        Me.lbldebeini.TabIndex = 86
        Me.lbldebeini.Text = "0.00"
        Me.lbldebeini.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhaberini
        '
        Me.lblhaberini.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhaberini.Location = New System.Drawing.Point(188, 8)
        Me.lblhaberini.Name = "lblhaberini"
        Me.lblhaberini.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblhaberini.Size = New System.Drawing.Size(109, 17)
        Me.lblhaberini.TabIndex = 81
        Me.lblhaberini.Text = "0.00"
        Me.lblhaberini.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldebeene
        '
        Me.lbldebeene.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebeene.Location = New System.Drawing.Point(29, 25)
        Me.lbldebeene.Name = "lbldebeene"
        Me.lbldebeene.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldebeene.Size = New System.Drawing.Size(109, 17)
        Me.lbldebeene.TabIndex = 82
        Me.lbldebeene.Text = "0.00"
        Me.lbldebeene.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhaberene
        '
        Me.lblhaberene.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhaberene.Location = New System.Drawing.Point(188, 25)
        Me.lblhaberene.Name = "lblhaberene"
        Me.lblhaberene.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblhaberene.Size = New System.Drawing.Size(109, 17)
        Me.lblhaberene.TabIndex = 80
        Me.lblhaberene.Text = "0.00"
        Me.lblhaberene.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhabertotal
        '
        Me.lblhabertotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhabertotal.Location = New System.Drawing.Point(187, 247)
        Me.lblhabertotal.Name = "lblhabertotal"
        Me.lblhabertotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblhabertotal.Size = New System.Drawing.Size(109, 17)
        Me.lblhabertotal.TabIndex = 128
        Me.lblhabertotal.Text = "0.00"
        Me.lblhabertotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldebefeb
        '
        Me.lbldebefeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebefeb.Location = New System.Drawing.Point(29, 42)
        Me.lbldebefeb.Name = "lbldebefeb"
        Me.lbldebefeb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldebefeb.Size = New System.Drawing.Size(109, 17)
        Me.lbldebefeb.TabIndex = 102
        Me.lbldebefeb.Text = "0.00"
        Me.lbldebefeb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldebetotal
        '
        Me.lbldebetotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebetotal.Location = New System.Drawing.Point(28, 247)
        Me.lbldebetotal.Name = "lbldebetotal"
        Me.lbldebetotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldebetotal.Size = New System.Drawing.Size(109, 17)
        Me.lbldebetotal.TabIndex = 129
        Me.lbldebetotal.Text = "0.00"
        Me.lbldebetotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhaberfeb
        '
        Me.lblhaberfeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhaberfeb.Location = New System.Drawing.Point(188, 42)
        Me.lblhaberfeb.Name = "lblhaberfeb"
        Me.lblhaberfeb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblhaberfeb.Size = New System.Drawing.Size(109, 17)
        Me.lblhaberfeb.TabIndex = 98
        Me.lblhaberfeb.Text = "0.00"
        Me.lblhaberfeb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldebeabr
        '
        Me.lbldebeabr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebeabr.Location = New System.Drawing.Point(29, 76)
        Me.lbldebeabr.Name = "lbldebeabr"
        Me.lbldebeabr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldebeabr.Size = New System.Drawing.Size(109, 17)
        Me.lbldebeabr.TabIndex = 101
        Me.lbldebeabr.Text = "0.00"
        Me.lbldebeabr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhabercier
        '
        Me.lblhabercier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhabercier.Location = New System.Drawing.Point(188, 226)
        Me.lblhabercier.Name = "lblhabercier"
        Me.lblhabercier.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblhabercier.Size = New System.Drawing.Size(109, 17)
        Me.lblhabercier.TabIndex = 125
        Me.lblhabercier.Text = "0.00"
        Me.lblhabercier.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldebemar
        '
        Me.lbldebemar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebemar.Location = New System.Drawing.Point(29, 59)
        Me.lbldebemar.Name = "lbldebemar"
        Me.lbldebemar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldebemar.Size = New System.Drawing.Size(109, 17)
        Me.lbldebemar.TabIndex = 96
        Me.lbldebemar.Text = "0.00"
        Me.lbldebemar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldebecier
        '
        Me.lbldebecier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebecier.Location = New System.Drawing.Point(29, 226)
        Me.lbldebecier.Name = "lbldebecier"
        Me.lbldebecier.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldebecier.Size = New System.Drawing.Size(109, 17)
        Me.lbldebecier.TabIndex = 126
        Me.lbldebecier.Text = "0.00"
        Me.lbldebecier.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldebejun
        '
        Me.lbldebejun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebejun.Location = New System.Drawing.Point(29, 110)
        Me.lbldebejun.Name = "lbldebejun"
        Me.lbldebejun.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldebejun.Size = New System.Drawing.Size(109, 17)
        Me.lbldebejun.TabIndex = 100
        Me.lbldebejun.Text = "0.00"
        Me.lbldebejun.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhaberabr
        '
        Me.lblhaberabr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhaberabr.Location = New System.Drawing.Point(188, 76)
        Me.lblhaberabr.Name = "lblhaberabr"
        Me.lblhaberabr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblhaberabr.Size = New System.Drawing.Size(109, 17)
        Me.lblhaberabr.TabIndex = 99
        Me.lblhaberabr.Text = "0.00"
        Me.lblhaberabr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhabermar
        '
        Me.lblhabermar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhabermar.Location = New System.Drawing.Point(188, 59)
        Me.lblhabermar.Name = "lblhabermar"
        Me.lblhabermar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblhabermar.Size = New System.Drawing.Size(109, 17)
        Me.lblhabermar.TabIndex = 93
        Me.lblhabermar.Text = "0.00"
        Me.lblhabermar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhaberjun
        '
        Me.lblhaberjun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhaberjun.Location = New System.Drawing.Point(188, 110)
        Me.lblhaberjun.Name = "lblhaberjun"
        Me.lblhaberjun.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblhaberjun.Size = New System.Drawing.Size(109, 17)
        Me.lblhaberjun.TabIndex = 97
        Me.lblhaberjun.Text = "0.00"
        Me.lblhaberjun.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldebemay
        '
        Me.lbldebemay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebemay.Location = New System.Drawing.Point(29, 93)
        Me.lbldebemay.Name = "lbldebemay"
        Me.lbldebemay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldebemay.Size = New System.Drawing.Size(109, 17)
        Me.lbldebemay.TabIndex = 94
        Me.lbldebemay.Text = "0.00"
        Me.lbldebemay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhaberdic
        '
        Me.lblhaberdic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhaberdic.Location = New System.Drawing.Point(188, 210)
        Me.lblhaberdic.Name = "lblhaberdic"
        Me.lblhaberdic.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblhaberdic.Size = New System.Drawing.Size(109, 17)
        Me.lblhaberdic.TabIndex = 110
        Me.lblhaberdic.Text = "0.00"
        Me.lblhaberdic.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldebejul
        '
        Me.lbldebejul.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebejul.Location = New System.Drawing.Point(29, 127)
        Me.lbldebejul.Name = "lbldebejul"
        Me.lbldebejul.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldebejul.Size = New System.Drawing.Size(109, 17)
        Me.lbldebejul.TabIndex = 95
        Me.lbldebejul.Text = "0.00"
        Me.lbldebejul.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhabermay
        '
        Me.lblhabermay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhabermay.Location = New System.Drawing.Point(188, 93)
        Me.lblhabermay.Name = "lblhabermay"
        Me.lblhabermay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblhabermay.Size = New System.Drawing.Size(109, 17)
        Me.lblhabermay.TabIndex = 91
        Me.lblhabermay.Text = "0.00"
        Me.lblhabermay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhaberoct
        '
        Me.lblhaberoct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhaberoct.Location = New System.Drawing.Point(188, 176)
        Me.lblhaberoct.Name = "lblhaberoct"
        Me.lblhaberoct.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblhaberoct.Size = New System.Drawing.Size(109, 17)
        Me.lblhaberoct.TabIndex = 111
        Me.lblhaberoct.Text = "0.00"
        Me.lblhaberoct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhaberjul
        '
        Me.lblhaberjul.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhaberjul.Location = New System.Drawing.Point(188, 127)
        Me.lblhaberjul.Name = "lblhaberjul"
        Me.lblhaberjul.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblhaberjul.Size = New System.Drawing.Size(109, 17)
        Me.lblhaberjul.TabIndex = 92
        Me.lblhaberjul.Text = "0.00"
        Me.lblhaberjul.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldebedic
        '
        Me.lbldebedic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebedic.Location = New System.Drawing.Point(29, 210)
        Me.lbldebedic.Name = "lbldebedic"
        Me.lbldebedic.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldebedic.Size = New System.Drawing.Size(109, 17)
        Me.lbldebedic.TabIndex = 113
        Me.lbldebedic.Text = "0.00"
        Me.lbldebedic.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldebesep
        '
        Me.lbldebesep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebesep.Location = New System.Drawing.Point(29, 159)
        Me.lbldebesep.Name = "lbldebesep"
        Me.lbldebesep.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldebesep.Size = New System.Drawing.Size(109, 17)
        Me.lbldebesep.TabIndex = 119
        Me.lbldebesep.Text = "0.00"
        Me.lbldebesep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldebeoct
        '
        Me.lbldebeoct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebeoct.Location = New System.Drawing.Point(29, 176)
        Me.lbldebeoct.Name = "lbldebeoct"
        Me.lbldebeoct.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldebeoct.Size = New System.Drawing.Size(109, 17)
        Me.lbldebeoct.TabIndex = 114
        Me.lbldebeoct.Text = "0.00"
        Me.lbldebeoct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldebeago
        '
        Me.lbldebeago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebeago.Location = New System.Drawing.Point(29, 142)
        Me.lbldebeago.Name = "lbldebeago"
        Me.lbldebeago.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldebeago.Size = New System.Drawing.Size(109, 17)
        Me.lbldebeago.TabIndex = 115
        Me.lbldebeago.Text = "0.00"
        Me.lbldebeago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhabernov
        '
        Me.lblhabernov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhabernov.Location = New System.Drawing.Point(188, 193)
        Me.lblhabernov.Name = "lblhabernov"
        Me.lblhabernov.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblhabernov.Size = New System.Drawing.Size(109, 17)
        Me.lblhabernov.TabIndex = 116
        Me.lblhabernov.Text = "0.00"
        Me.lblhabernov.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldebenov
        '
        Me.lbldebenov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebenov.Location = New System.Drawing.Point(29, 193)
        Me.lbldebenov.Name = "lbldebenov"
        Me.lbldebenov.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldebenov.Size = New System.Drawing.Size(109, 17)
        Me.lbldebenov.TabIndex = 118
        Me.lbldebenov.Text = "0.00"
        Me.lbldebenov.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhaberago
        '
        Me.lblhaberago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhaberago.Location = New System.Drawing.Point(188, 142)
        Me.lblhaberago.Name = "lblhaberago"
        Me.lblhaberago.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblhaberago.Size = New System.Drawing.Size(109, 17)
        Me.lblhaberago.TabIndex = 112
        Me.lblhaberago.Text = "0.00"
        Me.lblhaberago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhabersep
        '
        Me.lblhabersep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhabersep.Location = New System.Drawing.Point(188, 159)
        Me.lblhabersep.Name = "lblhabersep"
        Me.lblhabersep.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblhabersep.Size = New System.Drawing.Size(109, 17)
        Me.lblhabersep.TabIndex = 117
        Me.lblhabersep.Text = "0.00"
        Me.lblhabersep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(69, 520)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(44, 16)
        Me.Label47.TabIndex = 176
        Me.Label47.Text = "Total"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(70, 499)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(44, 16)
        Me.Label44.TabIndex = 175
        Me.Label44.Text = "Cierre"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(70, 483)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(70, 16)
        Me.Label29.TabIndex = 170
        Me.Label29.Text = "Diciembre"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(70, 449)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(55, 16)
        Me.Label30.TabIndex = 171
        Me.Label30.Text = "Octubre"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(69, 415)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(51, 16)
        Me.Label31.TabIndex = 172
        Me.Label31.Text = "Agosto"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(70, 466)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(75, 16)
        Me.Label32.TabIndex = 173
        Me.Label32.Text = "Noviembre"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(70, 432)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(78, 16)
        Me.Label34.TabIndex = 174
        Me.Label34.Text = "Septiembre"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(70, 400)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(36, 16)
        Me.Label28.TabIndex = 164
        Me.Label28.Text = "Julio"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(70, 366)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 16)
        Me.Label22.TabIndex = 165
        Me.Label22.Text = "Mayo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(69, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 16)
        Me.Label11.TabIndex = 166
        Me.Label11.Text = "Marzo"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(70, 383)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(40, 16)
        Me.Label27.TabIndex = 168
        Me.Label27.Text = "Junio"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(70, 349)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 16)
        Me.Label21.TabIndex = 167
        Me.Label21.Text = "Abril"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(69, 315)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 169
        Me.Label12.Text = "Febrero"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(69, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 16)
        Me.Label10.TabIndex = 163
        Me.Label10.Text = "Enero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 162
        Me.Label5.Text = "Inicio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(474, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 160
        Me.Label6.Text = "Haber"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(313, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "Debe"
        '
        'Frm_PlanCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 575)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Frm_PlanCuentas"
        Me.Text = "Frm_PlanCuentas"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnexport As Button
    Friend WithEvents btnimport As Button
    Friend WithEvents btnCnfImp As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbohaber As ComboBox
    Friend WithEvents cbodebe As ComboBox
    Friend WithEvents lblAmHaber As Label
    Friend WithEvents lblAmDebe As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents txtalias As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcuenta As TextBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbldebeini As Label
    Friend WithEvents lblhaberini As Label
    Friend WithEvents lbldebeene As Label
    Friend WithEvents lblhaberene As Label
    Friend WithEvents lblhabertotal As Label
    Friend WithEvents lbldebefeb As Label
    Friend WithEvents lbldebetotal As Label
    Friend WithEvents lblhaberfeb As Label
    Friend WithEvents lbldebeabr As Label
    Friend WithEvents lblhabercier As Label
    Friend WithEvents lbldebemar As Label
    Friend WithEvents lbldebecier As Label
    Friend WithEvents lbldebejun As Label
    Friend WithEvents lblhaberabr As Label
    Friend WithEvents lblhabermar As Label
    Friend WithEvents lblhaberjun As Label
    Friend WithEvents lbldebemay As Label
    Friend WithEvents lblhaberdic As Label
    Friend WithEvents lbldebejul As Label
    Friend WithEvents lblhabermay As Label
    Friend WithEvents lblhaberoct As Label
    Friend WithEvents lblhaberjul As Label
    Friend WithEvents lbldebedic As Label
    Friend WithEvents lbldebesep As Label
    Friend WithEvents lbldebeoct As Label
    Friend WithEvents lbldebeago As Label
    Friend WithEvents lblhabernov As Label
    Friend WithEvents lbldebenov As Label
    Friend WithEvents lblhaberago As Label
    Friend WithEvents lblhabersep As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
End Class

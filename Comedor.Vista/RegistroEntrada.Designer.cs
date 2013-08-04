namespace Comedor.Vista
{
    partial class RegistroEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblapellido;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroEntrada));
            this.timer_seg = new System.Windows.Forms.Timer(this.components);
            this.timer_min = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.panel_global = new System.Windows.Forms.Panel();
            this.btnReserva = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btncantidad = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtapellido3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre3 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.txtapellido2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtfalta = new System.Windows.Forms.TextBox();
            this.txtregistrado = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblfalta = new System.Windows.Forms.Label();
            this.lblatendido = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.line = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pcbimagen1 = new System.Windows.Forms.PictureBox();
            this.lblarea = new System.Windows.Forms.Label();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtapellido1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtnombre1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvTurno = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            lblapellido = new System.Windows.Forms.Label();
            this.panel_global.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbimagen1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblapellido.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblapellido.Location = new System.Drawing.Point(18, 443);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new System.Drawing.Size(92, 21);
            lblapellido.TabIndex = 65;
            lblapellido.Text = "APELLIDO:";
            // 
            // timer_seg
            // 
            this.timer_seg.Interval = 1000;
            this.timer_seg.Tick += new System.EventHandler(this.timer_seg_Tick);
            // 
            // timer_min
            // 
            this.timer_min.Interval = 60000;
            this.timer_min.Tick += new System.EventHandler(this.timer_min_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHora.Location = new System.Drawing.Point(1003, -9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(229, 86);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "--:--:--";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI Symbol", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFecha.Location = new System.Drawing.Point(4, 10);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(148, 50);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "--/--/--";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTurno.Location = new System.Drawing.Point(290, 10);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(381, 45);
            this.lblTurno.TabIndex = 3;
            this.lblTurno.Text = "TURNO(--:--:-- ; --:--:--)";
            // 
            // panel_global
            // 
            this.panel_global.BackColor = System.Drawing.Color.Transparent;
            this.panel_global.Controls.Add(this.btnReserva);
            this.panel_global.Controls.Add(this.button3);
            this.panel_global.Controls.Add(this.btncantidad);
            this.panel_global.Controls.Add(this.panel4);
            this.panel_global.Controls.Add(this.panel3);
            this.panel_global.Controls.Add(this.panel1);
            this.panel_global.Controls.Add(this.panel2);
            this.panel_global.Location = new System.Drawing.Point(82, 100);
            this.panel_global.Name = "panel_global";
            this.panel_global.Size = new System.Drawing.Size(1104, 828);
            this.panel_global.TabIndex = 5;
            // 
            // btnReserva
            // 
            this.btnReserva.BackColor = System.Drawing.Color.White;
            this.btnReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReserva.Location = new System.Drawing.Point(741, 186);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(158, 64);
            this.btnReserva.TabIndex = 78;
            this.btnReserva.Text = "RESERVAS";
            this.btnReserva.UseVisualStyleBackColor = false;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(741, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 64);
            this.button3.TabIndex = 77;
            this.button3.Text = "CONTINUAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btncantidad
            // 
            this.btncantidad.BackColor = System.Drawing.Color.White;
            this.btncantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncantidad.Location = new System.Drawing.Point(741, 106);
            this.btncantidad.Name = "btncantidad";
            this.btncantidad.Size = new System.Drawing.Size(158, 64);
            this.btncantidad.TabIndex = 75;
            this.btncantidad.Text = "ATENCIONES";
            this.btncantidad.UseVisualStyleBackColor = false;
            this.btncantidad.Click += new System.EventHandler(this.btncantidad_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtapellido3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtnombre3);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(741, 628);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 166);
            this.panel4.TabIndex = 74;
            // 
            // txtapellido3
            // 
            this.txtapellido3.BackColor = System.Drawing.Color.White;
            this.txtapellido3.Enabled = false;
            this.txtapellido3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.txtapellido3.Location = new System.Drawing.Point(156, 99);
            this.txtapellido3.Name = "txtapellido3";
            this.txtapellido3.Size = new System.Drawing.Size(127, 22);
            this.txtapellido3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(153, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "NOMBRE:";
            // 
            // txtnombre3
            // 
            this.txtnombre3.BackColor = System.Drawing.Color.White;
            this.txtnombre3.Enabled = false;
            this.txtnombre3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.txtnombre3.Location = new System.Drawing.Point(151, 43);
            this.txtnombre3.Name = "txtnombre3";
            this.txtnombre3.Size = new System.Drawing.Size(127, 22);
            this.txtnombre3.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(10, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 147);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(153, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "APELLIDO:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtnombre2);
            this.panel3.Controls.Add(this.txtapellido2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(408, 628);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 166);
            this.panel3.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(148, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "APELLIDO:";
            // 
            // txtnombre2
            // 
            this.txtnombre2.BackColor = System.Drawing.Color.White;
            this.txtnombre2.Enabled = false;
            this.txtnombre2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.txtnombre2.Location = new System.Drawing.Point(151, 35);
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(127, 22);
            this.txtnombre2.TabIndex = 2;
            // 
            // txtapellido2
            // 
            this.txtapellido2.BackColor = System.Drawing.Color.White;
            this.txtapellido2.Enabled = false;
            this.txtapellido2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.txtapellido2.Location = new System.Drawing.Point(151, 85);
            this.txtapellido2.Name = "txtapellido2";
            this.txtapellido2.Size = new System.Drawing.Size(127, 22);
            this.txtapellido2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(148, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(10, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 147);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(66, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 506);
            this.panel1.TabIndex = 71;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvTurnos);
            this.panel7.Controls.Add(this.txttotal);
            this.panel7.Controls.Add(this.txtfalta);
            this.panel7.Controls.Add(this.txtregistrado);
            this.panel7.Controls.Add(this.lbltotal);
            this.panel7.Controls.Add(this.lblfalta);
            this.panel7.Controls.Add(this.lblatendido);
            this.panel7.Controls.Add(this.shapeContainer1);
            this.panel7.Location = new System.Drawing.Point(486, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(463, 475);
            this.panel7.TabIndex = 67;
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.BackgroundColor = System.Drawing.Color.White;
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTurnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTurnos.Location = new System.Drawing.Point(7, 328);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.Size = new System.Drawing.Size(435, 136);
            this.dgvTurnos.TabIndex = 7;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Segoe UI Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(214, 19);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(206, 84);
            this.txttotal.TabIndex = 5;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtfalta
            // 
            this.txtfalta.Font = new System.Drawing.Font("Segoe UI Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfalta.Location = new System.Drawing.Point(214, 238);
            this.txtfalta.Multiline = true;
            this.txtfalta.Name = "txtfalta";
            this.txtfalta.Size = new System.Drawing.Size(206, 84);
            this.txtfalta.TabIndex = 4;
            this.txtfalta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtregistrado
            // 
            this.txtregistrado.Font = new System.Drawing.Font("Segoe UI Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtregistrado.Location = new System.Drawing.Point(214, 120);
            this.txtregistrado.Multiline = true;
            this.txtregistrado.Name = "txtregistrado";
            this.txtregistrado.Size = new System.Drawing.Size(206, 84);
            this.txtregistrado.TabIndex = 3;
            this.txtregistrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(35, 43);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(173, 40);
            this.lbltotal.TabIndex = 2;
            this.lbltotal.Text = "CANTIDAD:";
            // 
            // lblfalta
            // 
            this.lblfalta.AutoSize = true;
            this.lblfalta.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfalta.Location = new System.Drawing.Point(75, 278);
            this.lblfalta.Name = "lblfalta";
            this.lblfalta.Size = new System.Drawing.Size(133, 40);
            this.lblfalta.TabIndex = 1;
            this.lblfalta.Text = "FALTAN:";
            // 
            // lblatendido
            // 
            this.lblatendido.AutoSize = true;
            this.lblatendido.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblatendido.Location = new System.Drawing.Point(19, 142);
            this.lblatendido.Name = "lblatendido";
            this.lblatendido.Size = new System.Drawing.Size(189, 40);
            this.lblatendido.TabIndex = 0;
            this.lblatendido.Text = "ATENDIDOS:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.line});
            this.shapeContainer1.Size = new System.Drawing.Size(463, 475);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // line
            // 
            this.line.Name = "line";
            this.line.X1 = 74;
            this.line.X2 = 436;
            this.line.Y1 = 223;
            this.line.Y2 = 223;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Viner Hand ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(16, 456);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 78);
            this.lblCodigo.TabIndex = 60;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pcbimagen1);
            this.panel5.Controls.Add(this.lblarea);
            this.panel5.Controls.Add(this.txtarea);
            this.panel5.Controls.Add(this.txtnombre);
            this.panel5.Controls.Add(this.lblnombre);
            this.panel5.Controls.Add(lblapellido);
            this.panel5.Controls.Add(this.txtapellido);
            this.panel5.Location = new System.Drawing.Point(11, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(458, 475);
            this.panel5.TabIndex = 66;
            // 
            // pcbimagen1
            // 
            this.pcbimagen1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pcbimagen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbimagen1.Image = ((System.Drawing.Image)(resources.GetObject("pcbimagen1.Image")));
            this.pcbimagen1.Location = new System.Drawing.Point(95, 19);
            this.pcbimagen1.Name = "pcbimagen1";
            this.pcbimagen1.Size = new System.Drawing.Size(280, 325);
            this.pcbimagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbimagen1.TabIndex = 31;
            this.pcbimagen1.TabStop = false;
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Bold);
            this.lblarea.Location = new System.Drawing.Point(40, 480);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(62, 20);
            this.lblarea.TabIndex = 67;
            this.lblarea.Text = "AREA:";
            // 
            // txtarea
            // 
            this.txtarea.BackColor = System.Drawing.Color.White;
            this.txtarea.Enabled = false;
            this.txtarea.Font = new System.Drawing.Font("Bradley Hand ITC", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtarea.Location = new System.Drawing.Point(111, 475);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(310, 31);
            this.txtarea.TabIndex = 66;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Bradley Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(111, 407);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(310, 31);
            this.txtnombre.TabIndex = 45;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblnombre.Location = new System.Drawing.Point(25, 409);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(85, 21);
            this.lblnombre.TabIndex = 61;
            this.lblnombre.Text = "NOMBRE:";
            // 
            // txtapellido
            // 
            this.txtapellido.BackColor = System.Drawing.Color.White;
            this.txtapellido.Enabled = false;
            this.txtapellido.Font = new System.Drawing.Font("Bradley Hand ITC", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtapellido.Location = new System.Drawing.Point(111, 441);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(310, 31);
            this.txtapellido.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtapellido1);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtnombre1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(66, 628);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 166);
            this.panel2.TabIndex = 70;
            // 
            // txtapellido1
            // 
            this.txtapellido1.BackColor = System.Drawing.Color.White;
            this.txtapellido1.Enabled = false;
            this.txtapellido1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.txtapellido1.Location = new System.Drawing.Point(151, 73);
            this.txtapellido1.Name = "txtapellido1";
            this.txtapellido1.Size = new System.Drawing.Size(127, 22);
            this.txtapellido1.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(148, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "APELLIDO:";
            // 
            // txtnombre1
            // 
            this.txtnombre1.BackColor = System.Drawing.Color.White;
            this.txtnombre1.Enabled = false;
            this.txtnombre1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre1.Location = new System.Drawing.Point(151, 30);
            this.txtnombre1.Name = "txtnombre1";
            this.txtnombre1.Size = new System.Drawing.Size(127, 22);
            this.txtnombre1.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(148, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "NOMBRE:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvTurno
            // 
            this.dgvTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurno.Location = new System.Drawing.Point(12, 287);
            this.dgvTurno.Name = "dgvTurno";
            this.dgvTurno.Size = new System.Drawing.Size(152, 150);
            this.dgvTurno.TabIndex = 68;
            this.dgvTurno.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTurno_MouseDoubleClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.lblHora);
            this.panel6.Controls.Add(this.lblFecha);
            this.panel6.Controls.Add(this.lblTurno);
            this.panel6.Location = new System.Drawing.Point(12, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1280, 77);
            this.panel6.TabIndex = 6;
            // 
            // RegistroEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Comedor.Vista.Properties.Resources.white_back;
            this.ClientSize = new System.Drawing.Size(1293, 922);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel_global);
            this.Controls.Add(this.dgvTurno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Verificacion_Load);
            this.panel_global.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbimagen1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_seg;
        private System.Windows.Forms.Timer timer_min;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Panel panel_global;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtapellido3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtapellido2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.PictureBox pcbimagen1;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtnombre1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtapellido1;
        private System.Windows.Forms.DataGridView dgvTurno;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btncantidad;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtfalta;
        private System.Windows.Forms.TextBox txtregistrado;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblfalta;
        private System.Windows.Forms.Label lblatendido;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape line;
        private System.Windows.Forms.DataGridView dgvTurnos;
    }
}
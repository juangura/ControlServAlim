namespace Comedor.Vista
{
    partial class Verificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verificacion));
            this.timer_seg = new System.Windows.Forms.Timer(this.components);
            this.timer_min = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.panel_global = new System.Windows.Forms.Panel();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtcodigo3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtapellido3 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtcodigo2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtapellido2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.pcbimagen1 = new System.Windows.Forms.PictureBox();
            this.txtcodigo_p = new System.Windows.Forms.TextBox();
            this.lblarea = new System.Windows.Forms.Label();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtgrupo = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtcodigo1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtnombre1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtapellido1 = new System.Windows.Forms.TextBox();
            this.dgvTurno = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel_global.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbimagen1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
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
            this.lblHora.Location = new System.Drawing.Point(991, -9);
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
            this.lblFecha.Location = new System.Drawing.Point(0, 10);
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
            this.lblTurno.Location = new System.Drawing.Point(254, 10);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(381, 45);
            this.lblTurno.TabIndex = 3;
            this.lblTurno.Text = "TURNO(--:--:-- ; --:--:--)";
            this.lblTurno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_global
            // 
            this.panel_global.BackColor = System.Drawing.Color.Transparent;
            this.panel_global.Controls.Add(this.txtcodigo);
            this.panel_global.Controls.Add(this.panel4);
            this.panel_global.Controls.Add(this.panel3);
            this.panel_global.Controls.Add(this.panel1);
            this.panel_global.Controls.Add(this.panel2);
            this.panel_global.Location = new System.Drawing.Point(76, 178);
            this.panel_global.Name = "panel_global";
            this.panel_global.Size = new System.Drawing.Size(1098, 647);
            this.panel_global.TabIndex = 5;
            this.panel_global.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_global_Paint);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Segoe UI Symbol", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(588, 279);
            this.txtcodigo.MaxLength = 3;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(162, 93);
            this.txtcodigo.TabIndex = 75;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress_1);
            this.txtcodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcodigo_KeyUp_1);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Location = new System.Drawing.Point(771, 433);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 180);
            this.panel4.TabIndex = 74;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.pictureBox3);
            this.panel8.Controls.Add(this.txtcodigo3);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.txtnombre3);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.txtapellido3);
            this.panel8.Location = new System.Drawing.Point(5, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(280, 167);
            this.panel8.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(10, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 147);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // txtcodigo3
            // 
            this.txtcodigo3.BackColor = System.Drawing.Color.White;
            this.txtcodigo3.Enabled = false;
            this.txtcodigo3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.txtcodigo3.Location = new System.Drawing.Point(211, 125);
            this.txtcodigo3.Name = "txtcodigo3";
            this.txtcodigo3.Size = new System.Drawing.Size(62, 22);
            this.txtcodigo3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(141, 23);
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
            this.txtnombre3.Location = new System.Drawing.Point(146, 39);
            this.txtnombre3.Name = "txtnombre3";
            this.txtnombre3.Size = new System.Drawing.Size(127, 22);
            this.txtnombre3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(157, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CODIGO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(143, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "APELLIDO:";
            // 
            // txtapellido3
            // 
            this.txtapellido3.BackColor = System.Drawing.Color.White;
            this.txtapellido3.Enabled = false;
            this.txtapellido3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.txtapellido3.Location = new System.Drawing.Point(146, 86);
            this.txtapellido3.Name = "txtapellido3";
            this.txtapellido3.Size = new System.Drawing.Size(127, 22);
            this.txtapellido3.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Location = new System.Drawing.Point(771, 232);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 180);
            this.panel3.TabIndex = 73;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.txtcodigo2);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.txtnombre2);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.txtapellido2);
            this.panel7.Location = new System.Drawing.Point(5, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(280, 167);
            this.panel7.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(10, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 147);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtcodigo2
            // 
            this.txtcodigo2.BackColor = System.Drawing.Color.White;
            this.txtcodigo2.Enabled = false;
            this.txtcodigo2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.txtcodigo2.Location = new System.Drawing.Point(211, 125);
            this.txtcodigo2.Name = "txtcodigo2";
            this.txtcodigo2.Size = new System.Drawing.Size(62, 22);
            this.txtcodigo2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(141, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE:";
            // 
            // txtnombre2
            // 
            this.txtnombre2.BackColor = System.Drawing.Color.White;
            this.txtnombre2.Enabled = false;
            this.txtnombre2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.txtnombre2.Location = new System.Drawing.Point(146, 39);
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(127, 22);
            this.txtnombre2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(158, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CODIGO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(143, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "APELLIDO:";
            // 
            // txtapellido2
            // 
            this.txtapellido2.BackColor = System.Drawing.Color.White;
            this.txtapellido2.Enabled = false;
            this.txtapellido2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.txtapellido2.Location = new System.Drawing.Point(146, 87);
            this.txtapellido2.Name = "txtapellido2";
            this.txtapellido2.Size = new System.Drawing.Size(127, 22);
            this.txtapellido2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(45, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 576);
            this.panel1.TabIndex = 71;
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
            this.panel5.Controls.Add(this.txtnombre);
            this.panel5.Controls.Add(this.pcbimagen1);
            this.panel5.Controls.Add(this.txtcodigo_p);
            this.panel5.Controls.Add(this.lblarea);
            this.panel5.Controls.Add(this.txtarea);
            this.panel5.Controls.Add(this.lblnombre);
            this.panel5.Controls.Add(this.lblapellido);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txtgrupo);
            this.panel5.Controls.Add(this.txtapellido);
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(462, 554);
            this.panel5.TabIndex = 66;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(111, 407);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(310, 33);
            this.txtnombre.TabIndex = 45;
            // 
            // pcbimagen1
            // 
            this.pcbimagen1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pcbimagen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbimagen1.Image = ((System.Drawing.Image)(resources.GetObject("pcbimagen1.Image")));
            this.pcbimagen1.Location = new System.Drawing.Point(95, 19);
            this.pcbimagen1.Name = "pcbimagen1";
            this.pcbimagen1.Size = new System.Drawing.Size(281, 328);
            this.pcbimagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbimagen1.TabIndex = 31;
            this.pcbimagen1.TabStop = false;
            this.pcbimagen1.Click += new System.EventHandler(this.pcbimagen1_Click);
            // 
            // txtcodigo_p
            // 
            this.txtcodigo_p.BackColor = System.Drawing.Color.White;
            this.txtcodigo_p.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcodigo_p.Enabled = false;
            this.txtcodigo_p.Font = new System.Drawing.Font("Segoe UI Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo_p.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtcodigo_p.Location = new System.Drawing.Point(180, 330);
            this.txtcodigo_p.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigo_p.Name = "txtcodigo_p";
            this.txtcodigo_p.ReadOnly = true;
            this.txtcodigo_p.Size = new System.Drawing.Size(179, 86);
            this.txtcodigo_p.TabIndex = 50;
            this.txtcodigo_p.Text = "000";
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarea.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblarea.Location = new System.Drawing.Point(51, 478);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(51, 21);
            this.lblarea.TabIndex = 67;
            this.lblarea.Text = "AREA:";
            // 
            // txtarea
            // 
            this.txtarea.BackColor = System.Drawing.Color.White;
            this.txtarea.Enabled = false;
            this.txtarea.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarea.Location = new System.Drawing.Point(111, 475);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(310, 33);
            this.txtarea.TabIndex = 66;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblnombre.Location = new System.Drawing.Point(27, 410);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(78, 21);
            this.lblnombre.TabIndex = 61;
            this.lblnombre.Text = "NOMBRE:";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblapellido.Location = new System.Drawing.Point(20, 444);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(83, 21);
            this.lblapellido.TabIndex = 65;
            this.lblapellido.Text = "APELLIDO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(36, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 62;
            this.label1.Text = "GRUPO:";
            // 
            // txtgrupo
            // 
            this.txtgrupo.BackColor = System.Drawing.Color.White;
            this.txtgrupo.Enabled = false;
            this.txtgrupo.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrupo.Location = new System.Drawing.Point(111, 510);
            this.txtgrupo.Name = "txtgrupo";
            this.txtgrupo.Size = new System.Drawing.Size(310, 33);
            this.txtgrupo.TabIndex = 63;
            // 
            // txtapellido
            // 
            this.txtapellido.BackColor = System.Drawing.Color.White;
            this.txtapellido.Enabled = false;
            this.txtapellido.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(111, 441);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(310, 33);
            this.txtapellido.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Location = new System.Drawing.Point(771, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 180);
            this.panel2.TabIndex = 70;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.pictureBox1);
            this.panel9.Controls.Add(this.txtcodigo1);
            this.panel9.Controls.Add(this.label15);
            this.panel9.Controls.Add(this.txtnombre1);
            this.panel9.Controls.Add(this.label17);
            this.panel9.Controls.Add(this.label16);
            this.panel9.Controls.Add(this.txtapellido1);
            this.panel9.Location = new System.Drawing.Point(5, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(280, 167);
            this.panel9.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtcodigo1
            // 
            this.txtcodigo1.BackColor = System.Drawing.Color.White;
            this.txtcodigo1.Enabled = false;
            this.txtcodigo1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.txtcodigo1.Location = new System.Drawing.Point(211, 125);
            this.txtcodigo1.Name = "txtcodigo1";
            this.txtcodigo1.Size = new System.Drawing.Size(62, 22);
            this.txtcodigo1.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(141, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "NOMBRE:";
            // 
            // txtnombre1
            // 
            this.txtnombre1.BackColor = System.Drawing.Color.White;
            this.txtnombre1.Enabled = false;
            this.txtnombre1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre1.Location = new System.Drawing.Point(146, 39);
            this.txtnombre1.Name = "txtnombre1";
            this.txtnombre1.Size = new System.Drawing.Size(127, 22);
            this.txtnombre1.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(159, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "CODIGO:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(143, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "APELLIDO:";
            // 
            // txtapellido1
            // 
            this.txtapellido1.BackColor = System.Drawing.Color.White;
            this.txtapellido1.Enabled = false;
            this.txtapellido1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.txtapellido1.Location = new System.Drawing.Point(146, 87);
            this.txtapellido1.Name = "txtapellido1";
            this.txtapellido1.Size = new System.Drawing.Size(127, 22);
            this.txtapellido1.TabIndex = 4;
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
            this.panel6.Size = new System.Drawing.Size(1288, 77);
            this.panel6.TabIndex = 6;
            // 
            // Verificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Comedor.Vista.Properties.Resources.white_back;
            this.ClientSize = new System.Drawing.Size(1293, 741);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel_global);
            this.Controls.Add(this.dgvTurno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Verificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Verificacion_Load);
            this.panel_global.ResumeLayout(false);
            this.panel_global.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbimagen1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
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
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtcodigo3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtapellido3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtcodigo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgrupo;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtcodigo1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtnombre1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtapellido1;
        private System.Windows.Forms.DataGridView dgvTurno;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtcodigo_p;
    }
}
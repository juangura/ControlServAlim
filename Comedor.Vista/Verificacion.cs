using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comedor.Modelo;
using Comedor.Control;
using System.Media;


namespace Comedor.Vista
{
    public partial class Verificacion : Form
    {

        #region varibles...
        List<mdlTurno> ListTurno = new List<mdlTurno>();
        List<mdlDia> ListDia = new List<mdlDia>();
        List<mdlTurno> ListTurnoActual = new List<mdlTurno>();
        List<mdlConsumidor> ListConsumidor = new List<mdlConsumidor>();
        List<mdlConsumidor> ListIngreso = new List<mdlConsumidor>();

        bool ok = false; //confimar el turno
        String idturno=""; //id general
        String idDia=""; //id general
        SoundPlayer player = new SoundPlayer("C:\\ServalimGit\\ControlServAlim\\alerta.wav");
        KeyPressEventArgs temp;
        bool cancel = false;
        #endregion

        public Verificacion()
        {
            InitializeComponent();
            txtcodigo.Focus();
        }
        
        #region metodos...

        private String Buscar_Dia()
        {
            //buscar el iddia en base al nombre del dia actual
            foreach(mdlDia dia in ListDia){
                if (dia.Nombre == DateTime.Now.ToString("dddd")) {
                    this.idDia = dia.IdDia;
                }
            }
            return idDia;
        }

        private void llenarturno() {
            ctrlturno cTurno = new ctrlturno();
            this.ListTurno = cTurno.BuscarTurno(Buscar_Dia());
        }
        
        private void Buscar_turno() {
            //buscar el turno actual...
            
            TimeSpan ts = DateTime.Now.TimeOfDay;

            foreach(mdlTurno turno in ListTurno ){

                if (ts >= turno.HoraInicio.TimeOfDay && ts <= turno.HoraFin.TimeOfDay)
                {

                    if (idturno != turno.IdTurno.ToString())
                    {
                        ok = false;
                    }
                    else
                    {
                        ok = true;
                        return;
                    }
                    mdlTurno turnoAc = new mdlTurno();
                    turnoAc.IdTurno = turno.IdTurno.ToString();
                    turnoAc.DesAlmCen = int.Parse(turno.DesAlmCen.ToString());
                    turnoAc.HoraInicio = turno.HoraInicio;
                    turnoAc.HoraFin = turno.HoraFin;
                    ListTurnoActual.Add(turnoAc);
                    return;
                }
                else
                {
                    ListTurnoActual.Clear();
                    ok = false;
                }
            }
        }

        private void restriccion(int estado, Panel panel, int tipo)
        {
           
            player.Stop();
            if (estado == 2) {
                panel.BackColor = Color.OrangeRed;
                player.Play();
                return;
            } 
            if (estado == 3)
            {
                panel.BackColor = Color.OrangeRed;
                if (tipo == 1) {
                    return;
                }
                player.Play();
                MessageBox.Show("Su Reserva fue cancelada");
                player.Stop();
                return;
            }
            if (estado == 4)
            {
                panel.BackColor = Color.Gold;
                return;
            }
            if (estado == 5)
            {
                panel.BackColor = Color.OrangeRed;
                if (tipo == 1)
                {
                    return;
                }
                player.Play();
              //  MessageBox.Show("Su grupo no tiene acceso a este turno...!!");
                //Acceso Denegado por no tener ningun acceso o Bloqueo
                Form1 form = new Form1();
                form.ShowDialog();
                player.Stop();
                return;
            }
            if (estado == 6) {
                panel.BackColor = Color.CornflowerBlue;
                return;
            }
            panel.BackColor = Color.LimeGreen;
            
        }

        private bool ConfimarTurno() 
        {
            Buscar_turno();

            if (ok) {
                
                return ok;
            }

            if (ListTurnoActual.Count() >= 1)
            {
                //si hay un solo turno
                if(ListTurnoActual.Count()==1){

                    llenar(ListTurnoActual[0].IdTurno,ListTurnoActual[0].DesAlmCen,ListTurnoActual[0].HoraInicio.ToString(),ListTurnoActual[0].HoraFin.ToString());
                    abilitado();
                    return ok=true;
                }

                //varios turnos;
                dgvTurno.Visible = true;
                dgvTurno.Rows.Clear();
                dgvTurno.Columns.Clear();
                ArreglaDataViewSalidas();

                foreach (mdlTurno item in ListTurnoActual)
                {
                    int n = dgvTurno.Rows.Add();
                    dgvTurno.Rows[n].Cells[0].Value = item.IdTurno;
                    dgvTurno.Rows[n].Cells[1].Value = item.DesAlmCen;
                    dgvTurno.Rows[n].Cells[2].Value = item.HoraInicio;
                    dgvTurno.Rows[n].Cells[3].Value = item.HoraFin;
                }
              //  return ok = true;
            }
            Espera();
            return ok;
        }

        private void llenar(String idturno, int DesAlmCen, String horaIncio, String horafin) {
            String nombre="";
            if(DesAlmCen==1){
                nombre="DESAYUNO";
            }
            if(DesAlmCen==2){
                nombre="ALMUERZO";
            }
            if(DesAlmCen==3){
                nombre="CENA";
            }
            lblTurno.Text = nombre + ": ( " + horaIncio.Remove(0, 11) + " --- " + horafin.Remove(0, 11) + ")";
            this.idturno = idturno;
        }

        void entrar()
        {
            ctrlConsumidor_Acceso ca = new ctrlConsumidor_Acceso();
            this.ListConsumidor = ca.Consumidor_Acceso(txtcodigo.Text, idturno, idDia);
            
            if (ListConsumidor == null)
            {
                txtcodigo.Text = "";
                return;
            }

            if (ListIngreso.Count != 0)
            {
                int cant = ListIngreso.Count - 1;
                int j = 0;
                for (int i = cant; i >= cant - 2; i--)
                {
                    if (i < 0)
                    {
                        j = -1;
                    }
                    else
                    {
                        j++;
                    }
                    if (j == 1)
                    {

                        txtnombre1.Text = ListIngreso[i].Persona.PrimerNombre +" "+ ListIngreso[i].Persona.SegundoNombre;
                        txtapellido1.Text = ListIngreso[i].Persona.Apellidos;
                        txtcodigo1.Text = ListIngreso[i].Persona.IdPersona;
                        pictureBox1.Image = Image.FromFile(ListIngreso[i].Persona.Foto);
                        restriccion(ListIngreso[i].Estado, panel2,1);
                    }
                    if (j == 2)
                    {
                        txtnombre2.Text = ListIngreso[i].Persona.PrimerNombre +" "+ ListIngreso[i].Persona.SegundoNombre;
                        txtapellido2.Text = ListIngreso[i].Persona.Apellidos;
                        txtcodigo2.Text = ListIngreso[i].Persona.IdPersona;
                        pictureBox2.Image = Image.FromFile(ListIngreso[i].Persona.Foto);
                        restriccion(ListIngreso[i].Estado, panel3,1);
                    }
                    if (j == 3)
                    {
                        txtnombre3.Text = ListIngreso[i].Persona.PrimerNombre +" "+ ListIngreso[i].Persona.SegundoNombre;
                        txtapellido3.Text = ListIngreso[i].Persona.Apellidos;
                        txtcodigo3.Text = ListIngreso[i].Persona.IdPersona;
                        pictureBox3.Image = Image.FromFile(ListIngreso[i].Persona.Foto);
                        restriccion(ListIngreso[i].Estado, panel4,1);
                    }
                }
            }

            if (ListIngreso.Count > 4)
            {

                ListIngreso.RemoveAt(0);
            }


            txtnombre.Text = ListConsumidor[0].Persona.PrimerNombre + " " + ListConsumidor[0].Persona.SegundoNombre;
            txtapellido.Text = ListConsumidor[0].Persona.Apellidos;
            txtarea.Text = ListConsumidor[0].Area.Nombre;
            txtgrupo.Text = ListConsumidor[0].Grupo.Nombre;
            pcbimagen1.Image = Image.FromFile("\\\\CONTROLALIMENTA\\" + ListConsumidor[0].Persona.Foto);
            restriccion(ListConsumidor[0].Estado,panel1,0);
            mdlConsumidor mc = new mdlConsumidor();

            mc.IdConsumidor = ListConsumidor[0].IdConsumidor;
            mc.Persona = new mdlPersona();
            mc.Persona.IdPersona = txtcodigo.Text;
            mc.Persona.PrimerNombre = ListConsumidor[0].Persona.PrimerNombre;
            mc.Persona.SegundoNombre = ListConsumidor[0].Persona.SegundoNombre;
            mc.Persona.Apellidos = ListConsumidor[0].Persona.Apellidos;
            mc.Persona.Foto = "\\\\CONTROLALIMENTA\\" + ListConsumidor[0].Persona.Foto;
            mc.Estado = ListConsumidor[0].Estado;
            mc.Area = new mdlArea();
            mc.Area.Nombre = ListConsumidor[0].Area.Nombre;
            mc.Grupo = new mdlGrupo();
            mc.Grupo.Nombre = ListConsumidor[0].Grupo.Nombre;
            mc.Reserva = new mdlReserva();
            mc.Reserva.IdReserva = ListConsumidor[0].Reserva.IdReserva;
            txtcodigo_p.Text = txtcodigo.Text;
            ListIngreso.Add(mc);
            txtcodigo.Text = "";

            
        }

        private void cancelar(Panel panel, String idconsumidor, String idturno, int estado, String idreserva, int tipo)
        {

            if (estado == 1 || estado==4)
            {
                if (MessageBox.Show("Desea cancelar esta entrada", "Cancelar Entrada", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ctrlConsumidor_Acceso ca = new ctrlConsumidor_Acceso();
                    ca.cancelar(idconsumidor, idturno, idreserva);
                    restriccion(6, panel, 0);
                    if (tipo == 1)
                    {
                        ListIngreso[ListIngreso.Count() - 2].Estado = 6;
                        return;
                    }
                    ListIngreso[ListIngreso.Count() - 1].Estado = 6;
                    
                }
            }

        }

        private void Espera()
        {
            dgvTurno.Visible = false;
            panel_global.Visible = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            txtcodigo.Visible = false; 
            lblTurno.Text = "TURNO (--:--:-- ; --:--:--)";
        }

        private void abilitado()
        {
            panel_global.Visible = true;
            panel1.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            txtcodigo.Visible = true;
          
        }

        #endregion

        #region eventos..

        private void Verificacion_Load(object sender, EventArgs e)
        {
            Espera();
            //llamar los dias...
            ctrlDia cDia = new ctrlDia();
            this.ListDia = cDia.Listar_Dia();

            //llamar los turnos del dia actual...
            llenarturno();
            ConfimarTurno();
            //iniciar el timer por segundo
            timer_seg.Start();
            timer_min.Start();
            
            
        }

        private void timer_seg_Tick(object sender, EventArgs e)
        {
            ConfimarTurno();
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToString("d");
        }

        private void timer_min_Tick(object sender, EventArgs e)
        {
            llenarturno();
            
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            temp = e;
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }
        }
      
        private void txtcodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (temp != null)
            {
                player.Stop();
                if (temp.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    // Lo que hará al presionarse Enter
                    entrar();

                }
            }
        }

        private void dgvTurno_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(dgvTurno.Rows[Convert.ToInt32(this.dgvTurno.CurrentRow.Index)].Cells[0].Value.ToString());
            int fila = Convert.ToInt32(this.dgvTurno.CurrentRow.Index);

            llenar(dgvTurno.Rows[fila].Cells[0].Value.ToString(), int.Parse(dgvTurno.Rows[fila].Cells[1].Value.ToString()), dgvTurno.Rows[fila].Cells[2].Value.ToString(), dgvTurno.Rows[fila].Cells[3].Value.ToString());
            dgvTurno.Visible = false;
            abilitado();
            ok = true;
        }

        private void pcbimagen1_Click(object sender, EventArgs e)
        {
            cancelar(panel1, ListConsumidor[0].IdConsumidor, idturno, ListConsumidor[0].Estado, ListConsumidor[0].Reserva.IdReserva,0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cancelar(panel2, ListIngreso[ListIngreso.Count() - 2].IdConsumidor, idturno, ListIngreso[ListIngreso.Count() - 2].Estado, ListIngreso[ListIngreso.Count() - 2].Reserva.IdReserva,1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cancelar(panel3, ListIngreso[ListIngreso.Count() - 3].IdConsumidor, idturno, ListIngreso[ListIngreso.Count() - 3].Estado, ListIngreso[ListIngreso.Count() - 3].Reserva.IdReserva,1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cancelar(panel4, ListIngreso[ListIngreso.Count() - 4].IdConsumidor, idturno, ListIngreso[ListIngreso.Count() - 4].Estado, ListIngreso[ListIngreso.Count() - 4].Reserva.IdReserva,1);
        }

        #endregion

        #region Modelo controles...

        private void ArreglaDataViewSalidas()
        {
            if (dgvTurno.Columns.Count > 1) return;
            dgvTurno.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgvTurno.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTurno.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvTurno.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTurno.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Idturno";
            column.DataPropertyName = "Idturno";
            column.Width = 110;
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            column.ReadOnly = true;
            dgvTurno.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "DesAlmCen";
            column.DataPropertyName = "DesAlmCen";
            column.Width = 150;
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            column.ReadOnly = true;
            dgvTurno.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "horaIncio";
            column.DataPropertyName = "HoraIncio";
            column.Width = 150;
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            column.ReadOnly = true;
            dgvTurno.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "HoraFin";
            column.DataPropertyName = "HoraFin";
            column.Width = 150;
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            column.ReadOnly = true;
            dgvTurno.Columns.Add(column);


            column = new DataGridViewTextBoxColumn();
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvTurno.Columns.Add(column);

            dgvTurno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTurno.MultiSelect = false;
            dgvTurno.AllowUserToResizeColumns = true;
            dgvTurno.AllowUserToResizeRows = false;
            dgvTurno.BorderStyle = BorderStyle.FixedSingle;
            dgvTurno.RowHeadersVisible = false;
            dgvTurno.AllowUserToAddRows = false;
            dgvTurno.AllowUserToDeleteRows = false;
            dgvTurno.AllowUserToOrderColumns = false;


        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel_global_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcodigo_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (temp != null)
            {
                player.Stop();
                if (temp.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    // Lo que hará al presionarse Enter
                    entrar();

                }
            }
        }

        private void txtcodigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            temp = e;
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }
        }

    
     }
}

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
    public partial class RegistroEntrada : Form
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
        SoundPlayer player = new SoundPlayer("C:/Comedor2.0/alerta.mp3");
        KeyPressEventArgs temp;
        bool cancel = false;
        int cont = 0;

        #endregion

        public RegistroEntrada()
        {
            InitializeComponent();
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
        
        private void Buscar_turno() {
            //buscar el turno actual...
            ctrlturno cTurno = new ctrlturno();
            this.ListTurno = cTurno.BuscarTurno(Buscar_Dia());
            TimeSpan ts = DateTime.Now.TimeOfDay;

            foreach(mdlTurno turno in ListTurno ){

                if (ts >= turno.HoraInicio.TimeOfDay && ts <= turno.HoraFin.TimeOfDay) {

                    if (idturno != turno.IdTurno.ToString())
                    {
                        ok = false;
                    }
                    else {
                        ok = true;
                        return;
                    }
                    mdlTurno turnoAc = new mdlTurno();
                    turnoAc.IdTurno = turno.IdTurno.ToString();
                    turnoAc.DesAlmCen = int.Parse(turno.DesAlmCen.ToString());
                    turnoAc.HoraInicio = turno.HoraInicio;
                    turnoAc.HoraFin = turno.HoraFin;
                    ListTurnoActual.Add(turnoAc);

                }
            }
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
                return ok = true;
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
            this.ListIngreso = ca.RegistroEntrada(idturno, DateTime.Now.ToString("d"));

            if (ListIngreso.Count != 0)
            {
                int cant = ListIngreso.Count - 1;
                int j = 0;
                for (int i = cant; i >= cant - 3; i--)
                {
                    if (i < 0)
                    {
                        j = -1;
                    }
                    else
                    {
                        j++;
                    }
                    if (j == 4)
                    {
                        txtnombre.Text = ListIngreso[i].Persona.PrimerNombre + " " + ListIngreso[i].Persona.SegundoNombre;
                        txtapellido.Text = ListIngreso[i].Persona.Apellidos;
                        pcbimagen1.Image = Image.FromFile("D://Comedor2.0//" + ListIngreso[i].Persona.Foto);
                    }
                    if (j == 3)
                    {

                        txtnombre1.Text = ListIngreso[i].Persona.PrimerNombre +" "+ ListIngreso[i].Persona.SegundoNombre;
                        txtapellido1.Text = ListIngreso[i].Persona.Apellidos;
                        pictureBox1.Image = Image.FromFile("D://Comedor2.0//" + ListIngreso[i].Persona.Foto);
                        
                    }
                    if (j == 2)
                    {
                        txtnombre2.Text = ListIngreso[i].Persona.PrimerNombre +" "+ ListIngreso[i].Persona.SegundoNombre;
                        txtapellido2.Text = ListIngreso[i].Persona.Apellidos;
                        pictureBox2.Image = Image.FromFile("D://Comedor2.0//"+ ListIngreso[i].Persona.Foto);
                        
                    }
                    if (j == 1)
                    {
                        txtnombre3.Text = ListIngreso[i].Persona.PrimerNombre +" "+ ListIngreso[i].Persona.SegundoNombre;
                        txtapellido3.Text = ListIngreso[i].Persona.Apellidos;
                        pictureBox3.Image = Image.FromFile("D://Comedor2.0//" + ListIngreso[i].Persona.Foto);
                        
                    }
                   
                }
            }

            if (ListIngreso.Count > 5)
            {

                ListIngreso.RemoveAt(0);
            }

        }

        private void Espera()
        {
            dgvTurno.Visible = false;
            panel_global.Visible = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void abilitado()
        {
            panel_global.Visible = true;
            panel1.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
          
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
            ConfimarTurno();
            //iniciar el timer por segundo
            timer_seg.Start();
            timer_min.Start();
            
        }

        private void timer_seg_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToString("d");
            cont++;
            contador(cont);
            entrar();
        }

        private void timer_min_Tick(object sender, EventArgs e)
        {
            ConfimarTurno();
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


        private void ArreglaDataView1()
        {
            if (dgvTurnos.Columns.Count > 1) return;
            dgvTurnos.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgvTurnos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTurnos.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvTurnos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTurnos.AutoGenerateColumns = false;


            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = "ID";
            column.DataPropertyName = "id";
            column.Width = 50;
            column.Visible = false;
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTurnos.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Hora Inc";
            column.DataPropertyName = "horainic";
            column.Width = 80;
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            column.ReadOnly = true;
            dgvTurnos.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Hora Fn";
            column.DataPropertyName = "horafn";
            column.Width = 160;
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            column.ReadOnly = true;
            dgvTurnos.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Cantidad";
            column.DataPropertyName = "cantidad";
            column.Width = 160;
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            column.ReadOnly = true;
            dgvTurnos.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column.ReadOnly = true;
            dgvTurnos.Columns.Add(column);

            dgvTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTurnos.MultiSelect = false;
            dgvTurnos.AllowUserToResizeColumns = true;
            dgvTurnos.AllowUserToResizeRows = false;
            dgvTurnos.BorderStyle = BorderStyle.FixedSingle;
            dgvTurnos.RowHeadersVisible = false;
            dgvTurnos.AllowUserToAddRows = false;
            dgvTurnos.AllowUserToDeleteRows = false;
            dgvTurnos.AllowUserToOrderColumns = false;


        }


        private void ListarTurnoEvent()
        {
            List<mdlTurno> ListTurnoEvento = new List<mdlTurno>();
            ctrlturno ctrlT = new ctrlturno();
            ListTurnoEvento= ctrlT.BuscarTurnoEvento(idDia, idturno);
            dgvTurnos.Columns.Clear();
            ArreglaDataView1();
            dgvTurnos.Rows.Clear();

            foreach (mdlTurno item in ListTurnoEvento)
            {
                int n = dgvTurnos.Rows.Add();
                dgvTurnos.Rows[n].Cells[0].Value = item.IdTurno;
                dgvTurnos.Rows[n].Cells[1].Value = item.HoraInicio;
                dgvTurnos.Rows[n].Cells[2].Value = item.HoraFin;
                ctrlConsumidor_Acceso ctrl = new ctrlConsumidor_Acceso();
                int total = ctrl.CantidadConsumidores(DateTime.Now.ToString("d"),item.IdTurno);
                dgvTurnos.Rows[n].Cells[3].Value = total.ToString(); //cantidad
            }
            dgvTurnos.RowHeadersVisible = false;
        }

        private void btncantidad_Click(object sender, EventArgs e)
        {
            txtregistrado.Visible = true;
            txtfalta.Visible = true;
            lblfalta.Visible = true;
            lblatendido.Visible = true;
            line.Visible = true;
            ctrlConsumidor_Acceso ctrl = new ctrlConsumidor_Acceso();
            int total=ctrl.CantidadConsumidores(DateTime.Now.ToString("d"),idturno);
            int registrado = ctrl.CantidadRegistroEntrada(idturno, DateTime.Now.ToString("d"));
            txtregistrado.Text=registrado.ToString();
            txtfalta.Text = (total - registrado).ToString();
            txttotal.Text = total.ToString();
            
            ubicacion(panel7, true);
            cont = 0;
        }

        public void ubicacion(Panel panel, bool visible)
        {
            panel5.Visible = false;
            panel7.Visible = false;
            if (visible)
            {
                panel.Visible = true;
                panel.Location = new Point(11, 10);
            }
        }

        public void contador(int n)
        {
            if (n == 60)
            {
                ubicacion(panel5, true);
            }
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            ListarTurnoEvent();
            ctrlConsumidor_Acceso ctrl = new ctrlConsumidor_Acceso();
            int total = ctrl.CantidadConsumidoresReserva(DateTime.Now.ToString("d"), idturno);
            txttotal.Text = total.ToString();
            txtregistrado.Visible = false;
            txtfalta.Visible = false;
            lblfalta.Visible = false;
            lblatendido.Visible = false;
            line.Visible = false;
            ubicacion(panel7, true);
            cont = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ubicacion(panel5, true);
        }

        

     }
}

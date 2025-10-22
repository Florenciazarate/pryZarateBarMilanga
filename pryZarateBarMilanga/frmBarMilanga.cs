using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryZarateBarMilanga
{
    public partial class frmBarMilanga : Form
    {
        public frmBarMilanga()
        {
            InitializeComponent();
        }
        float[,] matVentas = new float [5, 4];
        private void frmBarMilanga_Load(object sender, EventArgs e)
        {
            dgvVentas.Rows.Add("Julio");
            dgvVentas.Rows.Add("Esteban");
            dgvVentas.Rows.Add("Javier");
            dgvVentas.Rows.Add("Gonzalo");
            dgvVentas.Rows.Add("Alberto");

            dgvVentas.Rows[0].Cells[0].Style.BackColor = Color.AliceBlue;
            dgvVentas.Rows[1].Cells[0].Style.BackColor = Color.AliceBlue;
            dgvVentas.Rows[2].Cells[0].Style.BackColor = Color.AliceBlue;
            dgvVentas.Rows[3].Cells[0].Style.BackColor = Color.AliceBlue;
            dgvVentas.Rows[4].Cells[0].Style.BackColor = Color.AliceBlue;
        }

        private void btnValidarDatos_Click(object sender, EventArgs e)
        {
            for (int indiceFilas = 0; indiceFilas < dgvVentas.Rows.Count; indiceFilas++)
            {
                for (int indiceColumnas = 1; indiceColumnas < 5; indiceColumnas++)
                {
                    if (dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value != null)
                    {
                        object valorCelda= dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value;
                        if (float.TryParse (Convert.ToString (valorCelda), out float resultado))
                        {
                               dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value = "si";
                        }
                        else
                        {
                            dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value = "no";

                        }
                        
                    }
                    else
                    {
                        dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value = "no";

                    }
                }
        }
    }
    }
}

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
            btnMozoDelDia.Enabled = false;
            btnTotales.Enabled = false;
            dgvVentas.Columns[0].ReadOnly = true;
            dgvVentas.AllowUserToResizeColumns = false;
            dgvVentas.AllowUserToResizeRows = false;
        }

        float[,] matVentas = new float[5, 4];
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
            bool datosValidos = true;

            for (int fila = 0; fila < dgvVentas.Rows.Count; fila++)
            {
                for (int col = 1; col < dgvVentas.Columns.Count; col++)
                {
                    object valorCelda = dgvVentas.Rows[fila].Cells[col].Value;
                    if (valorCelda == null || !float.TryParse(valorCelda.ToString(), out float resultado))
                    {
                        datosValidos = false;
                        break;
                    }
                    else
                    {
                        matVentas[fila, col - 1] = resultado;
                    }
                }
            }
            if (!datosValidos)
            {
                MessageBox.Show("Rellene TODOS los campos solo con números. Revise los campos.",
                                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnMozoDelDia.Enabled = false;
                btnTotales.Enabled = false;
            }
            else
            {
                MessageBox.Show("Datos validados correctamente.",
                                "Validación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnMozoDelDia.Enabled = true;
                btnTotales.Enabled = true;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMozoDelDia_Click(object sender, EventArgs e)
        {
            float mayorVenta = -1;
            int indiceMozo = -1;
            string[] nombresMozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
            for (int fila = 0; fila < matVentas.GetLength(0); fila++)
            {
                float totalMozo = 0;
                for (int col = 0; col < matVentas.GetLength(1); col++)
                {
                    totalMozo += matVentas[fila, col];
                }
                if (totalMozo > mayorVenta)
                {
                    mayorVenta = totalMozo;
                    indiceMozo = fila;
                }
            }
            lblMozoDelDia.Text = $"Mozo del día: {nombresMozos[indiceMozo]} con ventas de ${mayorVenta}";
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            float[] totalesCategorias = new float[4]; // Comidas, Bebidas sin alcohol, Bebidas con alcohol, Postres
            float totalGeneral = 0;

            for (int fila = 0; fila < matVentas.GetLength(0); fila++)
            {
                for (int col = 0; col < matVentas.GetLength(1); col++)
                {
                    totalesCategorias[col] += matVentas[fila, col];
                    totalGeneral += matVentas[fila, col];
                }
            }
          lblTotales.Text = 
          $"Comidas: ${totalesCategorias[0]}\n" +
          $"Bebidas sin alcohol: ${totalesCategorias[1]}\n" +
          $"Bebidas con alcohol: ${totalesCategorias[2]}\n" +
          $"Postres: ${totalesCategorias[3]}\n" +
          $"Total general: ${totalGeneral}";
        }

    }
}

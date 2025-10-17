namespace pryZarateBarMilanga
{
    partial class frmBarMilanga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarMilanga));
            dgvVentas = new DataGridView();
            colComidas = new DataGridViewTextBoxColumn();
            colBebidasSinAlcohol = new DataGridViewTextBoxColumn();
            colBebidasConAlcohol = new DataGridViewTextBoxColumn();
            colPostres = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colComidas, colBebidasSinAlcohol, colBebidasConAlcohol, colPostres });
            dgvVentas.Location = new Point(32, 21);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(525, 226);
            dgvVentas.TabIndex = 0;
            // 
            // colComidas
            // 
            colComidas.HeaderText = "Comidas";
            colComidas.Name = "colComidas";
            // 
            // colBebidasSinAlcohol
            // 
            colBebidasSinAlcohol.HeaderText = "Bebidas sin alcohol";
            colBebidasSinAlcohol.Name = "colBebidasSinAlcohol";
            // 
            // colBebidasConAlcohol
            // 
            colBebidasConAlcohol.HeaderText = "Bebidas con alcohol";
            colBebidasConAlcohol.Name = "colBebidasConAlcohol";
            // 
            // colPostres
            // 
            colPostres.HeaderText = "Postres";
            colPostres.Name = "colPostres";
            // 
            // frmBarMilanga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 345);
            Controls.Add(dgvVentas);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBarMilanga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bar la milanga";
            Load += frmBarMilanga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVentas;
        private DataGridViewTextBoxColumn colComidas;
        private DataGridViewTextBoxColumn colBebidasSinAlcohol;
        private DataGridViewTextBoxColumn colBebidasConAlcohol;
        private DataGridViewTextBoxColumn colPostres;
    }
}
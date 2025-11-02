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
            colMozos = new DataGridViewTextBoxColumn();
            colComidas = new DataGridViewTextBoxColumn();
            colBebidasSinAlcohol = new DataGridViewTextBoxColumn();
            colBebidasConAlcohol = new DataGridViewTextBoxColumn();
            colPostres = new DataGridViewTextBoxColumn();
            btnValidarDatos = new Button();
            btnMozoDelDia = new Button();
            btnTotales = new Button();
            btnCerrar = new Button();
            lblMozoDelDia = new Label();
            lblTotales = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.BackgroundColor = Color.LightSlateGray;
            dgvVentas.BorderStyle = BorderStyle.None;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colMozos, colComidas, colBebidasSinAlcohol, colBebidasConAlcohol, colPostres });
            dgvVentas.Location = new Point(33, 42);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.Size = new Size(518, 204);
            dgvVentas.TabIndex = 0;
            // 
            // colMozos
            // 
            colMozos.HeaderText = "Mozos";
            colMozos.Name = "colMozos";
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
            // btnValidarDatos
            // 
            btnValidarDatos.Anchor = AnchorStyles.None;
            btnValidarDatos.BackColor = Color.SkyBlue;
            btnValidarDatos.FlatStyle = FlatStyle.Popup;
            btnValidarDatos.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnValidarDatos.Location = new Point(448, 252);
            btnValidarDatos.Name = "btnValidarDatos";
            btnValidarDatos.Size = new Size(103, 39);
            btnValidarDatos.TabIndex = 1;
            btnValidarDatos.Text = "Validar datos";
            btnValidarDatos.UseVisualStyleBackColor = false;
            btnValidarDatos.Click += btnValidarDatos_Click;
            // 
            // btnMozoDelDia
            // 
            btnMozoDelDia.Anchor = AnchorStyles.None;
            btnMozoDelDia.BackColor = Color.SkyBlue;
            btnMozoDelDia.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMozoDelDia.Location = new Point(34, 330);
            btnMozoDelDia.Name = "btnMozoDelDia";
            btnMozoDelDia.Size = new Size(103, 39);
            btnMozoDelDia.TabIndex = 2;
            btnMozoDelDia.Text = "Mozo del día";
            btnMozoDelDia.UseVisualStyleBackColor = false;
            btnMozoDelDia.Click += btnMozoDelDia_Click;
            // 
            // btnTotales
            // 
            btnTotales.Anchor = AnchorStyles.None;
            btnTotales.BackColor = Color.SkyBlue;
            btnTotales.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTotales.Location = new Point(34, 375);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(103, 39);
            btnTotales.TabIndex = 3;
            btnTotales.Text = "Totales";
            btnTotales.UseVisualStyleBackColor = false;
            btnTotales.Click += btnTotales_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.None;
            btnCerrar.BackColor = Color.SkyBlue;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(448, 455);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(103, 46);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblMozoDelDia
            // 
            lblMozoDelDia.AutoSize = true;
            lblMozoDelDia.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMozoDelDia.Location = new Point(143, 387);
            lblMozoDelDia.Name = "lblMozoDelDia";
            lblMozoDelDia.Size = new Size(0, 21);
            lblMozoDelDia.TabIndex = 5;
            // 
            // lblTotales
            // 
            lblTotales.AutoSize = true;
            lblTotales.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotales.Location = new Point(143, 362);
            lblTotales.Name = "lblTotales";
            lblTotales.Size = new Size(0, 21);
            lblTotales.TabIndex = 6;
            // 
            // frmBarMilanga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(613, 523);
            Controls.Add(lblTotales);
            Controls.Add(lblMozoDelDia);
            Controls.Add(btnCerrar);
            Controls.Add(btnTotales);
            Controls.Add(btnMozoDelDia);
            Controls.Add(btnValidarDatos);
            Controls.Add(dgvVentas);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBarMilanga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bar la milanga";
            Load += frmBarMilanga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private Button btnValidarDatos;
        private DataGridViewTextBoxColumn colMozos;
        private DataGridViewTextBoxColumn colComidas;
        private DataGridViewTextBoxColumn colBebidasSinAlcohol;
        private DataGridViewTextBoxColumn colBebidasConAlcohol;
        private DataGridViewTextBoxColumn colPostres;
        private Button btnMozoDelDia;
        private Button btnTotales;
        private Button btnCerrar;
        private Label lblMozoDelDia;
        private Label lblTotales;
    }
}
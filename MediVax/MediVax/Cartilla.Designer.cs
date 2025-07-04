namespace MediVax
{
    partial class Cartilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cartilla));
            menupanel = new Panel();
            btnReg = new Button();
            btncartilla = new Button();
            btnMenu = new Button();
            btnCampanas = new Button();
            btnRecomendaciones = new Button();
            panelTitulo = new Panel();
            lblTitulo = new Label();
            historialvac = new DataGridView();
            logo1 = new PictureBox();
            addvac = new Button();
            menupanel.SuspendLayout();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)historialvac).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo1).BeginInit();
            SuspendLayout();
            // 
            // menupanel
            // 
            menupanel.BackColor = Color.FromArgb(0, 119, 182);
            menupanel.Controls.Add(btnReg);
            menupanel.Controls.Add(btncartilla);
            menupanel.Controls.Add(btnMenu);
            menupanel.Controls.Add(btnCampanas);
            menupanel.Controls.Add(btnRecomendaciones);
            menupanel.Dock = DockStyle.Top;
            menupanel.Location = new Point(0, 0);
            menupanel.Name = "menupanel";
            menupanel.Size = new Size(1277, 100);
            menupanel.TabIndex = 1;
            // 
            // btnReg
            // 
            btnReg.AutoSize = true;
            btnReg.BackColor = Color.FromArgb(139, 191, 106);
            btnReg.FlatAppearance.BorderColor = Color.FromArgb(139, 191, 106);
            btnReg.FlatStyle = FlatStyle.Flat;
            btnReg.Font = new Font("Segoe UI", 12F);
            btnReg.ForeColor = SystemColors.ButtonHighlight;
            btnReg.Location = new Point(727, 27);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(164, 40);
            btnReg.TabIndex = 4;
            btnReg.Text = "Registrar Vacunas";
            btnReg.UseVisualStyleBackColor = false;
            // 
            // btncartilla
            // 
            btncartilla.AutoSize = true;
            btncartilla.BackColor = Color.FromArgb(139, 191, 106);
            btncartilla.FlatAppearance.BorderColor = Color.FromArgb(139, 191, 106);
            btncartilla.FlatStyle = FlatStyle.Flat;
            btncartilla.Font = new Font("Segoe UI", 12F);
            btncartilla.ForeColor = SystemColors.ButtonHighlight;
            btncartilla.Location = new Point(896, 27);
            btncartilla.Name = "btncartilla";
            btncartilla.Size = new Size(158, 40);
            btncartilla.TabIndex = 1;
            btncartilla.Text = "Cartilla";
            btncartilla.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            btnMenu.AutoSize = true;
            btnMenu.BackColor = Color.FromArgb(139, 191, 106);
            btnMenu.FlatAppearance.BorderColor = Color.FromArgb(139, 191, 106);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 12F);
            btnMenu.ForeColor = SystemColors.ButtonHighlight;
            btnMenu.Location = new Point(175, 27);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(175, 40);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menu Principal";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnCampanas
            // 
            btnCampanas.AutoSize = true;
            btnCampanas.BackColor = Color.FromArgb(139, 191, 106);
            btnCampanas.FlatAppearance.BorderColor = Color.FromArgb(139, 191, 106);
            btnCampanas.FlatStyle = FlatStyle.Flat;
            btnCampanas.Font = new Font("Segoe UI", 12F);
            btnCampanas.ForeColor = SystemColors.ButtonHighlight;
            btnCampanas.Location = new Point(536, 27);
            btnCampanas.Name = "btnCampanas";
            btnCampanas.Size = new Size(186, 40);
            btnCampanas.TabIndex = 3;
            btnCampanas.Text = "Proximas Campañas";
            btnCampanas.UseVisualStyleBackColor = false;
            // 
            // btnRecomendaciones
            // 
            btnRecomendaciones.AutoSize = true;
            btnRecomendaciones.BackColor = Color.FromArgb(139, 191, 106);
            btnRecomendaciones.FlatAppearance.BorderColor = Color.FromArgb(139, 191, 106);
            btnRecomendaciones.FlatStyle = FlatStyle.Flat;
            btnRecomendaciones.Font = new Font("Segoe UI", 12F);
            btnRecomendaciones.ForeColor = SystemColors.ButtonHighlight;
            btnRecomendaciones.Location = new Point(355, 27);
            btnRecomendaciones.Name = "btnRecomendaciones";
            btnRecomendaciones.Size = new Size(176, 40);
            btnRecomendaciones.TabIndex = 2;
            btnRecomendaciones.Text = "Recomendaciones";
            btnRecomendaciones.UseVisualStyleBackColor = false;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(139, 191, 106);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Location = new Point(395, 128);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(454, 100);
            panelTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonHighlight;
            lblTitulo.Location = new Point(7, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(446, 54);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Historial de Vacunacion";
            // 
            // historialvac
            // 
            historialvac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            historialvac.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            historialvac.BackgroundColor = SystemColors.ButtonFace;
            historialvac.BorderStyle = BorderStyle.Fixed3D;
            historialvac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historialvac.GridColor = SystemColors.MenuText;
            historialvac.Location = new Point(112, 281);
            historialvac.Name = "historialvac";
            historialvac.Size = new Size(1000, 267);
            historialvac.TabIndex = 3;
            historialvac.CellContentClick += historialvac_CellContentClick;
            // 
            // logo1
            // 
            logo1.Image = (Image)resources.GetObject("logo1.Image");
            logo1.Location = new Point(33, 106);
            logo1.Name = "logo1";
            logo1.Size = new Size(317, 169);
            logo1.SizeMode = PictureBoxSizeMode.Zoom;
            logo1.TabIndex = 4;
            logo1.TabStop = false;
            // 
            // addvac
            // 
            addvac.Location = new Point(503, 581);
            addvac.Name = "addvac";
            addvac.Size = new Size(199, 23);
            addvac.TabIndex = 1;
            addvac.Text = "agregar vacunas";
            addvac.UseVisualStyleBackColor = true;
            addvac.Click += addvac_Click;
            // 
            // Cartilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1277, 645);
            Controls.Add(addvac);
            Controls.Add(logo1);
            Controls.Add(historialvac);
            Controls.Add(panelTitulo);
            Controls.Add(menupanel);
            Name = "Cartilla";
            Text = "CartillaVacunacion";
            Load += Cartilla_Load;
            menupanel.ResumeLayout(false);
            menupanel.PerformLayout();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)historialvac).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menupanel;
        private Button btnReg;
        private Button btncartilla;
        private Button btnMenu;
        private Button btnCampanas;
        private Button btnRecomendaciones;
        private Panel panelTitulo;
        private Label lblTitulo;
        private DataGridView historialvac;
        private PictureBox logo1;
        private Button addvac;
    }
}
namespace MediVax
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnMenu = new Button();
            btncartilla = new Button();
            btnRecomendaciones = new Button();
            btnCampanas = new Button();
            btnReg = new Button();
            menupanel = new Panel();
            logomenu = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            menupanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logomenu).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.AutoSize = true;
            btnMenu.BackColor = Color.FromArgb(139, 191, 106);
            btnMenu.FlatAppearance.BorderColor = Color.FromArgb(139, 191, 106);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 12F);
            btnMenu.ForeColor = SystemColors.ButtonHighlight;
            btnMenu.Location = new Point(171, 27);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(175, 40);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menu Principal";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btncartilla
            // 
            btncartilla.AutoSize = true;
            btncartilla.BackColor = Color.FromArgb(139, 191, 106);
            btncartilla.FlatAppearance.BorderColor = Color.FromArgb(139, 191, 106);
            btncartilla.FlatStyle = FlatStyle.Flat;
            btncartilla.Font = new Font("Segoe UI", 12F);
            btncartilla.ForeColor = SystemColors.ButtonHighlight;
            btncartilla.Location = new Point(892, 27);
            btncartilla.Name = "btncartilla";
            btncartilla.Size = new Size(158, 40);
            btncartilla.TabIndex = 1;
            btncartilla.Text = "Cartilla";
            btncartilla.UseVisualStyleBackColor = false;
            btncartilla.Click += cartilla_Click;
            // 
            // btnRecomendaciones
            // 
            btnRecomendaciones.AutoSize = true;
            btnRecomendaciones.BackColor = Color.FromArgb(139, 191, 106);
            btnRecomendaciones.FlatAppearance.BorderColor = Color.FromArgb(139, 191, 106);
            btnRecomendaciones.FlatStyle = FlatStyle.Flat;
            btnRecomendaciones.Font = new Font("Segoe UI", 12F);
            btnRecomendaciones.ForeColor = SystemColors.ButtonHighlight;
            btnRecomendaciones.Location = new Point(351, 27);
            btnRecomendaciones.Name = "btnRecomendaciones";
            btnRecomendaciones.Size = new Size(176, 40);
            btnRecomendaciones.TabIndex = 2;
            btnRecomendaciones.Text = "Recomendaciones";
            btnRecomendaciones.UseVisualStyleBackColor = false;
            btnRecomendaciones.Click += btnRecomendaciones_Click;
            // 
            // btnCampanas
            // 
            btnCampanas.AutoSize = true;
            btnCampanas.BackColor = Color.FromArgb(139, 191, 106);
            btnCampanas.FlatAppearance.BorderColor = Color.FromArgb(139, 191, 106);
            btnCampanas.FlatStyle = FlatStyle.Flat;
            btnCampanas.Font = new Font("Segoe UI", 12F);
            btnCampanas.ForeColor = SystemColors.ButtonHighlight;
            btnCampanas.Location = new Point(532, 27);
            btnCampanas.Name = "btnCampanas";
            btnCampanas.Size = new Size(186, 40);
            btnCampanas.TabIndex = 3;
            btnCampanas.Text = "Proximas Campañas";
            btnCampanas.UseVisualStyleBackColor = false;
            btnCampanas.Click += button3_Click;
            // 
            // btnReg
            // 
            btnReg.AutoSize = true;
            btnReg.BackColor = Color.FromArgb(139, 191, 106);
            btnReg.FlatAppearance.BorderColor = Color.FromArgb(139, 191, 106);
            btnReg.FlatStyle = FlatStyle.Flat;
            btnReg.Font = new Font("Segoe UI", 12F);
            btnReg.ForeColor = SystemColors.ButtonHighlight;
            btnReg.Location = new Point(723, 27);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(164, 40);
            btnReg.TabIndex = 4;
            btnReg.Text = "Registrar Vacunas";
            btnReg.UseVisualStyleBackColor = false;
            btnReg.Click += button4_Click;
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
            menupanel.Size = new Size(1243, 100);
            menupanel.TabIndex = 0;
            // 
            // logomenu
            // 
            logomenu.Image = (Image)resources.GetObject("logomenu.Image");
            logomenu.Location = new Point(12, 125);
            logomenu.Margin = new Padding(3, 2, 3, 2);
            logomenu.Name = "logomenu";
            logomenu.Size = new Size(487, 262);
            logomenu.SizeMode = PictureBoxSizeMode.Zoom;
            logomenu.TabIndex = 5;
            logomenu.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, -23);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 6;
            label1.Text = "¿Quienes Somos?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(705, 165);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(31, 22);
            label3.Name = "label3";
            label3.Size = new Size(360, 149);
            label3.TabIndex = 8;
            label3.Text = resources.GetString("label3.Text");
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(532, 165);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 171);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(10, 7);
            label4.Name = "label4";
            label4.Size = new Size(360, 149);
            label4.TabIndex = 11;
            label4.Text = "Facilitar el acceso, control y seguimiento digital de esquemas de vacunación, promoviendo \r\nla salud preventiva en una plataforma segura e intuitiva.\r\n\r\n\r\n\r\n\r\n\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.Location = new Point(171, 423);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 10;
            label5.Text = "Mision";
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(360, 149);
            label6.TabIndex = 13;
            label6.Text = " Ser la aplicación líder en nuestra comunidad en digitalización de historiales de vacunación, \r\nreconocida por su innovación y su compromiso con la salud pública. \r\n\r\n\r\n";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label7.Location = new Point(1012, 423);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 12;
            label7.Text = "Objetivo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(637, 125);
            label8.Name = "label8";
            label8.Size = new Size(164, 25);
            label8.TabIndex = 14;
            label8.Text = "¿Quienes Somos?";
            // 
            // label9
            // 
            label9.AutoEllipsis = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(13, -10);
            label9.Name = "label9";
            label9.Size = new Size(360, 149);
            label9.TabIndex = 16;
            label9.Text = " Brindar a las personas una herramienta digital segura, intuitiva y confiable para el registro, \r\nseguimiento y gestión de sus vacunas, promoviendo la prevención de enfermedades. \r\n\r\n\r\n";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label10.Location = new Point(601, 423);
            label10.Name = "label10";
            label10.Size = new Size(64, 25);
            label10.TabIndex = 15;
            label10.Text = "Vision";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(183, 217, 189);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(28, 458);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 112);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(183, 217, 189);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(447, 458);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(392, 112);
            panel3.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(183, 217, 189);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(872, 458);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(360, 112);
            panel4.TabIndex = 17;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 645);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(logomenu);
            Controls.Add(menupanel);
            Name = "Menu";
            Text = "  ";
            menupanel.ResumeLayout(false);
            menupanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logomenu).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenu;
        private Button btncartilla;
        private Button btnRecomendaciones;
        private Button btnCampanas;
        private Button btnReg;
        private Panel menupanel;
        private PictureBox logomenu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}

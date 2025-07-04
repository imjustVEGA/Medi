namespace MediVax
{
    partial class VacReg
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
            lbltitle = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            txtnombre = new TextBox();
            txtdosis = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            txtprev = new TextBox();
            panel4 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            timepick = new DateTimePicker();
            btnexit = new Button();
            btnsave = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.BackColor = Color.FromArgb(139, 191, 106);
            lbltitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitle.Location = new Point(62, 15);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(227, 32);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "Registro de Vacunas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(139, 191, 106);
            panel1.Controls.Add(lbltitle);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(208, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 68);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 119, 182);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(160, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(119, 40);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(408, 167);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(219, 23);
            txtnombre.TabIndex = 2;
            // 
            // txtdosis
            // 
            txtdosis.Location = new Point(408, 232);
            txtdosis.Name = "txtdosis";
            txtdosis.Size = new Size(219, 23);
            txtdosis.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 119, 182);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(160, 215);
            panel3.Name = "panel3";
            panel3.Size = new Size(119, 40);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(26, 9);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 0;
            label2.Text = "Dosis";
            // 
            // txtprev
            // 
            txtprev.Location = new Point(408, 281);
            txtprev.Name = "txtprev";
            txtprev.Size = new Size(219, 23);
            txtprev.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 119, 182);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(160, 275);
            panel4.Name = "panel4";
            panel4.Size = new Size(119, 40);
            panel4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(26, 8);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 0;
            label3.Text = "Previene";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 119, 182);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(160, 333);
            panel5.Name = "panel5";
            panel5.Size = new Size(176, 40);
            panel5.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(26, 9);
            label4.Name = "label4";
            label4.Size = new Size(123, 21);
            label4.TabIndex = 0;
            label4.Text = "Fecha aplicada";
            // 
            // timepick
            // 
            timepick.Location = new Point(408, 342);
            timepick.Name = "timepick";
            timepick.Size = new Size(200, 23);
            timepick.TabIndex = 5;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(293, 401);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(75, 23);
            btnexit.TabIndex = 6;
            btnexit.Text = "Salir";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += this.btnexit_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(408, 401);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(75, 23);
            btnsave.TabIndex = 7;
            btnsave.Text = "Guardar";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // VacReg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsave);
            Controls.Add(btnexit);
            Controls.Add(timepick);
            Controls.Add(txtprev);
            Controls.Add(panel5);
            Controls.Add(txtdosis);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(txtnombre);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "VacReg";
            Text = "Registro de Vacunas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox txtnombre;
        private TextBox txtdosis;
        private Panel panel3;
        private Label label2;
        private TextBox txtprev;
        private Panel panel4;
        private Label label3;
        private Panel panel5;
        private Label label4;
        private DateTimePicker timepick;
        private Button btnexit;
        private Button btnsave;
    }
}
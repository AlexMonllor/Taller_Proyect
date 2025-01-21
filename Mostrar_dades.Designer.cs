namespace ExamenInterfaces
{
    partial class Mostrar_dades
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
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            Eliminar = new Button();
            Mostrar = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(Eliminar);
            panel1.Controls.Add(Mostrar);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(43, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(303, 28);
            comboBox1.TabIndex = 3;
            // 
            // Eliminar
            // 
            Eliminar.Location = new Point(508, 328);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(94, 29);
            Eliminar.TabIndex = 2;
            Eliminar.Text = "Eliminar dades";
            Eliminar.UseVisualStyleBackColor = true;
            Eliminar.Click += Eliminar_Click;
            // 
            // Mostrar
            // 
            Mostrar.Location = new Point(43, 186);
            Mostrar.Name = "Mostrar";
            Mostrar.Size = new Size(141, 29);
            Mostrar.TabIndex = 1;
            Mostrar.Text = "Mostrar dades";
            Mostrar.UseVisualStyleBackColor = true;
            Mostrar.Click += Mostrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(396, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            // 
            // Mostrar_dades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Mostrar_dades";
            Text = "Mostrar_dades";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Eliminar;
        private Button Mostrar;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
    }
}
namespace ExamenInterfaces
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            Registrar_dades = new ToolStripDropDownButton();
            registrarCotxeToolStripMenuItem = new ToolStripMenuItem();
            registrarClienteToolStripMenuItem = new ToolStripMenuItem();
            Mostar_dades = new ToolStripLabel();
            Eixir = new ToolStripLabel();
            pictureBox1 = new PictureBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { Registrar_dades, Mostar_dades, Eixir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // Registrar_dades
            // 
            Registrar_dades.DropDownItems.AddRange(new ToolStripItem[] { registrarCotxeToolStripMenuItem, registrarClienteToolStripMenuItem });
            Registrar_dades.Name = "Registrar_dades";
            Registrar_dades.Size = new Size(126, 24);
            Registrar_dades.Text = "Registrar dades";
            // 
            // registrarCotxeToolStripMenuItem
            // 
            registrarCotxeToolStripMenuItem.Name = "registrarCotxeToolStripMenuItem";
            registrarCotxeToolStripMenuItem.Size = new Size(224, 26);
            registrarCotxeToolStripMenuItem.Text = "Registrar cliente";
            registrarCotxeToolStripMenuItem.Click += registrarCotxeToolStripMenuItem_Click;
            // 
            // registrarClienteToolStripMenuItem
            // 
            registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            registrarClienteToolStripMenuItem.Size = new Size(224, 26);
            registrarClienteToolStripMenuItem.Text = "Registrar cotxe";
            registrarClienteToolStripMenuItem.Click += registrarClienteToolStripMenuItem_Click;
            // 
            // Mostar_dades
            // 
            Mostar_dades.Name = "Mostar_dades";
            Mostar_dades.Size = new Size(99, 24);
            Mostar_dades.Text = "Mostar dades";
            Mostar_dades.Click += Mostar_dades_Click;
            // 
            // Eixir
            // 
            Eixir.Name = "Eixir";
            Eixir.Size = new Size(37, 24);
            Eixir.Text = "Eixir";
            Eixir.Click += Eixir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 423);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private PictureBox pictureBox1;
        private ToolStripDropDownButton Registrar_dades;
        private ToolStripMenuItem registrarCotxeToolStripMenuItem;
        private ToolStripMenuItem registrarClienteToolStripMenuItem;
        private ToolStripLabel Mostar_dades;
        private ToolStripLabel Eixir;
    }
}

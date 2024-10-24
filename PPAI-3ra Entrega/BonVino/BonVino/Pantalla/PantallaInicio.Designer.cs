namespace BonVino
{
    partial class PantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            label1 = new Label();
            btnGenerarRaking = new Button();
            tituloInicio = new Label();
            imagenInicio = new PictureBox();
            button1 = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)imagenInicio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(23, 93);
            label1.Name = "label1";
            label1.Size = new Size(313, 42);
            label1.TabIndex = 0;
            label1.Text = "Seleccione una opcion:";
            // 
            // btnGenerarRaking
            // 
            btnGenerarRaking.Font = new Font("Arial Narrow", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGenerarRaking.Location = new Point(23, 149);
            btnGenerarRaking.Name = "btnGenerarRaking";
            btnGenerarRaking.Size = new Size(205, 52);
            btnGenerarRaking.TabIndex = 2;
            btnGenerarRaking.Text = "Generar raking de vinos";
            btnGenerarRaking.UseVisualStyleBackColor = true;
            btnGenerarRaking.Click += btnGenerarRaking_Click;
            // 
            // tituloInicio
            // 
            tituloInicio.AutoSize = true;
            tituloInicio.BackColor = Color.Transparent;
            tituloInicio.Font = new Font("Arial Black", 24F, FontStyle.Underline);
            tituloInicio.ForeColor = SystemColors.ControlLight;
            tituloInicio.Location = new Point(23, 12);
            tituloInicio.Name = "tituloInicio";
            tituloInicio.Size = new Size(422, 45);
            tituloInicio.TabIndex = 3;
            tituloInicio.Text = "¡Bienvenido a BonVino!";
            tituloInicio.Click += tituloInicio_Click;
            // 
            // imagenInicio
            // 
            imagenInicio.ImageLocation = "C:\\Users\\santi\\source\\BonVino\\BonVino\\Recursos\\imagenInicio.jpg";
            imagenInicio.Location = new Point(478, 12);
            imagenInicio.Name = "imagenInicio";
            imagenInicio.Size = new Size(297, 417);
            imagenInicio.SizeMode = PictureBoxSizeMode.Zoom;
            imagenInicio.TabIndex = 5;
            imagenInicio.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(23, 218);
            button1.Name = "button1";
            button1.Size = new Size(327, 52);
            button1.TabIndex = 6;
            button1.Text = "Importar actualización de vinos de bodega";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Arial Narrow", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(23, 395);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 43);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(tituloInicio);
            Controls.Add(imagenInicio);
            Controls.Add(btnSalir);
            Controls.Add(button1);
            Controls.Add(btnGenerarRaking);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio BonVino";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)imagenInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGenerarRaking;
        private Label tituloInicio;
        private PictureBox imagenInicio;
        private Button button1;
        private Button btnSalir;
    }
}

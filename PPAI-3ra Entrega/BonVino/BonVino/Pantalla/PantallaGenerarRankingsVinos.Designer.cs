namespace BonVino
{
    partial class PantallaGenerarRakings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaGenerarRakings));
            label1 = new Label();
            label2 = new Label();
            lblFechaDesde = new Label();
            lblFechaHasta = new Label();
            textoErrorPeriodoFechas = new Label();
            dateTimePickerFechaDesde = new DateTimePicker();
            dateTimePickerFechaHasta = new DateTimePicker();
            lblTipoReseña = new Label();
            tipoReseña = new ComboBox();
            lblFormasVisualizacion = new Label();
            formasVisualizacion = new ComboBox();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(622, 42);
            label1.TabIndex = 0;
            label1.Text = "Caracteristicas del raking de vinos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(112, 61);
            label2.Name = "label2";
            label2.Size = new Size(550, 25);
            label2.TabIndex = 1;
            label2.Text = "Ingrese un periodo de fechas válido a considerar en la reseñas";
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaDesde.ForeColor = SystemColors.Control;
            lblFechaDesde.Location = new Point(1, 105);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(127, 25);
            lblFechaDesde.TabIndex = 2;
            lblFechaDesde.Text = "Fecha desde:";
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaHasta.ForeColor = SystemColors.Control;
            lblFechaHasta.Location = new Point(399, 105);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(122, 25);
            lblFechaHasta.TabIndex = 7;
            lblFechaHasta.Text = "Fecha hasta:";
            // 
            // textoErrorPeriodoFechas
            // 
            textoErrorPeriodoFechas.AutoSize = true;
            textoErrorPeriodoFechas.Font = new Font("Arial Narrow", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textoErrorPeriodoFechas.Location = new Point(261, 135);
            textoErrorPeriodoFechas.Name = "textoErrorPeriodoFechas";
            textoErrorPeriodoFechas.Size = new Size(330, 23);
            textoErrorPeriodoFechas.TabIndex = 11;
            textoErrorPeriodoFechas.Text = "Error! Ingreso un periodo de fechas incorrecto";
            // 
            // dateTimePickerFechaDesde
            // 
            dateTimePickerFechaDesde.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerFechaDesde.Location = new Point(124, 105);
            dateTimePickerFechaDesde.Name = "dateTimePickerFechaDesde";
            dateTimePickerFechaDesde.Size = new Size(256, 25);
            dateTimePickerFechaDesde.TabIndex = 12;
            dateTimePickerFechaDesde.ValueChanged += dateTimePickerFechas_ValueChanged;
            // 
            // dateTimePickerFechaHasta
            // 
            dateTimePickerFechaHasta.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerFechaHasta.Location = new Point(518, 107);
            dateTimePickerFechaHasta.Name = "dateTimePickerFechaHasta";
            dateTimePickerFechaHasta.Size = new Size(256, 25);
            dateTimePickerFechaHasta.TabIndex = 13;
            dateTimePickerFechaHasta.ValueChanged += dateTimePickerFechas_ValueChanged;
            // 
            // lblTipoReseña
            // 
            lblTipoReseña.AutoSize = true;
            lblTipoReseña.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoReseña.Location = new Point(261, 171);
            lblTipoReseña.Name = "lblTipoReseña";
            lblTipoReseña.Size = new Size(316, 31);
            lblTipoReseña.TabIndex = 15;
            lblTipoReseña.Text = "Seleccione el tipo de reseña:";
            // 
            // tipoReseña
            // 
            tipoReseña.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tipoReseña.FormattingEnabled = true;
            tipoReseña.Items.AddRange(new object[] { "Normales", "De Somelier", "De Amigos" });
            tipoReseña.Location = new Point(300, 225);
            tipoReseña.Name = "tipoReseña";
            tipoReseña.Size = new Size(221, 28);
            tipoReseña.TabIndex = 16;
            tipoReseña.SelectedIndexChanged += tomarSeleccionTipoReseña;
            // 
            // lblFormasVisualizacion
            // 
            lblFormasVisualizacion.AutoSize = true;
            lblFormasVisualizacion.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormasVisualizacion.Location = new Point(162, 279);
            lblFormasVisualizacion.Name = "lblFormasVisualizacion";
            lblFormasVisualizacion.Size = new Size(529, 31);
            lblFormasVisualizacion.TabIndex = 19;
            lblFormasVisualizacion.Text = "Seleccione una forma de visualizacion del raking";
            // 
            // formasVisualizacion
            // 
            formasVisualizacion.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            formasVisualizacion.FormattingEnabled = true;
            formasVisualizacion.Items.AddRange(new object[] { "PDF", "Archivo Excel", "Pantalla" });
            formasVisualizacion.Location = new Point(300, 322);
            formasVisualizacion.Name = "formasVisualizacion";
            formasVisualizacion.Size = new Size(221, 28);
            formasVisualizacion.TabIndex = 20;
            formasVisualizacion.SelectedIndexChanged += tomarSeleccionTipoVisualizacion;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = SystemColors.ActiveCaptionText;
            btnConfirmar.Location = new Point(509, 405);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(279, 33);
            btnConfirmar.TabIndex = 21;
            btnConfirmar.Text = "Confirmar generacion reporte";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // PantallaGenerarRakings
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmar);
            Controls.Add(formasVisualizacion);
            Controls.Add(lblFormasVisualizacion);
            Controls.Add(tipoReseña);
            Controls.Add(lblTipoReseña);
            Controls.Add(dateTimePickerFechaHasta);
            Controls.Add(dateTimePickerFechaDesde);
            Controls.Add(lblFechaHasta);
            Controls.Add(lblFechaDesde);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textoErrorPeriodoFechas);
            Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "PantallaGenerarRakings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar Rakings de Vinos";
            Load += PantallaGenerarRankingsVinos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblFechaDesde;
        private Label lblFechaHasta;
        private Label textoErrorPeriodoFechas;
        private DateTimePicker dateTimePickerFechaDesde;
        private DateTimePicker dateTimePickerFechaHasta;
        private Label lblTipoReseña;
        private ComboBox tipoReseña;
        private Label lblFormasVisualizacion;
        private ComboBox formasVisualizacion;
        private Button btnConfirmar;
    }
}
namespace BonVino.Pantalla
{
    partial class InterfazExcel
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
            listaRanking = new DataGridView();
            nombreVino = new DataGridViewTextBoxColumn();
            calificacion = new DataGridViewTextBoxColumn();
            precioARS = new DataGridViewTextBoxColumn();
            nombreBodega = new DataGridViewTextBoxColumn();
            varietal = new DataGridViewTextBoxColumn();
            region = new DataGridViewTextBoxColumn();
            nombrePais = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)listaRanking).BeginInit();
            SuspendLayout();
            // 
            // listaRanking
            // 
            listaRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaRanking.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            listaRanking.BackgroundColor = SystemColors.Window;
            listaRanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaRanking.Columns.AddRange(new DataGridViewColumn[] { nombreVino, calificacion, precioARS, nombreBodega, varietal, region, nombrePais });
            listaRanking.Dock = DockStyle.Fill;
            listaRanking.Location = new Point(0, 0);
            listaRanking.Margin = new Padding(3, 2, 3, 2);
            listaRanking.Name = "listaRanking";
            listaRanking.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            listaRanking.Size = new Size(1045, 338);
            listaRanking.TabIndex = 0;
            // 
            // nombreVino
            // 
            nombreVino.HeaderText = "Nombre Vino";
            nombreVino.MinimumWidth = 6;
            nombreVino.Name = "nombreVino";
            // 
            // precio sugerido
            // 
            calificacion.HeaderText = "Precio sugerido";
            calificacion.MinimumWidth = 6;
            calificacion.Name = "precioARS";
            // 
            // nombreBodega
            // 
            precioARS.HeaderText = "Nombre Bodega";
            precioARS.MinimumWidth = 6;
            precioARS.Name = "nombreBodega";
            // 
            // nombreBodega
            // 
            nombreBodega.HeaderText = "Nombre Region";
            nombreBodega.MinimumWidth = 6;
            nombreBodega.Name = "nombreRegion";
            // 
            // nombrePais
            // 
            varietal.HeaderText = "Nombre Pais";
            varietal.MinimumWidth = 6;
            varietal.Name = "nombrePais";
            // 
            // promedio
            // 
            region.HeaderText = "Promedio";
            region.MinimumWidth = 6;
            region.Name = "promedio";
            // 
            // varietal
            // 
            nombrePais.HeaderText = "Descripcion Varietal";
            nombrePais.MinimumWidth = 6;
            nombrePais.Name = "varietal";
            // 
            // InterfazExcel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1045, 338);
            Controls.Add(listaRanking);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InterfazExcel";
            Text = "InterfazExcel";
            WindowState = FormWindowState.Maximized;
            Load += InterfazExcel_Load;
            ((System.ComponentModel.ISupportInitialize)listaRanking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView listaRanking;
        private DataGridViewTextBoxColumn nombreVino;
        private DataGridViewTextBoxColumn calificacion;
        private DataGridViewTextBoxColumn precioARS;
        private DataGridViewTextBoxColumn nombreBodega;
        private DataGridViewTextBoxColumn varietal;
        private DataGridViewTextBoxColumn region;
        private DataGridViewTextBoxColumn nombrePais;
    }
}
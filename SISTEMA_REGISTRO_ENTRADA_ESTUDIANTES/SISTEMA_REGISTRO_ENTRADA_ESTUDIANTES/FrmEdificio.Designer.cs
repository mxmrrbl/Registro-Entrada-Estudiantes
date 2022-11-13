namespace SISTEMA_REGISTRO_ENTRADA_ESTUDIANTES
{
    partial class FrmEdificio
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
            this.components = new System.ComponentModel.Container();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LbLSesion = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TblEdificio = new System.Windows.Forms.DataGridView();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RedondeadoForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.RedondeadoTabla = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MoverForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LblDatosE = new System.Windows.Forms.Label();
            this.BtnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblEdificio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.TopPanel.Controls.Add(this.LbLSesion);
            this.TopPanel.Controls.Add(this.pictureBox6);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(805, 44);
            this.TopPanel.TabIndex = 2;
            // 
            // LbLSesion
            // 
            this.LbLSesion.AutoSize = true;
            this.LbLSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbLSesion.Location = new System.Drawing.Point(12, 9);
            this.LbLSesion.Name = "LbLSesion";
            this.LbLSesion.Size = new System.Drawing.Size(246, 29);
            this.LbLSesion.TabIndex = 1;
            this.LbLSesion.Text = "GESTION EDIFICIOS";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SISTEMA_REGISTRO_ENTRADA_ESTUDIANTES.Properties.Resources.baseline_clear_white_48dp;
            this.pictureBox6.Location = new System.Drawing.Point(761, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 39);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TblEdificio);
            this.panel1.Controls.Add(this.TxtBuscar);
            this.panel1.Controls.Add(this.pictureBox12);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 392);
            this.panel1.TabIndex = 3;
            // 
            // TblEdificio
            // 
            this.TblEdificio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TblEdificio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TblEdificio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.TblEdificio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TblEdificio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblEdificio.Location = new System.Drawing.Point(51, 85);
            this.TblEdificio.Name = "TblEdificio";
            this.TblEdificio.RowHeadersWidth = 51;
            this.TblEdificio.RowTemplate.Height = 24;
            this.TblEdificio.Size = new System.Drawing.Size(331, 254);
            this.TblEdificio.TabIndex = 13;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(99, 35);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(193, 23);
            this.TxtBuscar.TabIndex = 12;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.White;
            this.pictureBox12.Image = global::SISTEMA_REGISTRO_ENTRADA_ESTUDIANTES.Properties.Resources.baseline_search_black_48dp;
            this.pictureBox12.Location = new System.Drawing.Point(57, 28);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(37, 35);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = global::SISTEMA_REGISTRO_ENTRADA_ESTUDIANTES.Properties.Resources.Imagen3;
            this.pictureBox7.Location = new System.Drawing.Point(51, 27);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(251, 52);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(550, 161);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(223, 23);
            this.TxtNombre.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(458, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre";
            // 
            // RedondeadoForm
            // 
            this.RedondeadoForm.ElipseRadius = 20;
            this.RedondeadoForm.TargetControl = this;
            // 
            // RedondeadoTabla
            // 
            this.RedondeadoTabla.ElipseRadius = 20;
            this.RedondeadoTabla.TargetControl = this.TblEdificio;
            // 
            // MoverForm
            // 
            this.MoverForm.Fixed = true;
            this.MoverForm.Horizontal = true;
            this.MoverForm.TargetControl = this.TopPanel;
            this.MoverForm.Vertical = true;
            // 
            // LblDatosE
            // 
            this.LblDatosE.AutoSize = true;
            this.LblDatosE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.LblDatosE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatosE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblDatosE.Location = new System.Drawing.Point(458, 71);
            this.LblDatosE.Name = "LblDatosE";
            this.LblDatosE.Size = new System.Drawing.Size(199, 29);
            this.LblDatosE.TabIndex = 24;
            this.LblDatosE.Text = "Datos del edificio";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.BtnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.BorderRadius = 7;
            this.BtnEliminar.ButtonText = "Eliminar";
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Iconimage = global::SISTEMA_REGISTRO_ENTRADA_ESTUDIANTES.Properties.Resources.baseline_delete_white_48dp;
            this.BtnEliminar.Iconimage_right = null;
            this.BtnEliminar.Iconimage_right_Selected = null;
            this.BtnEliminar.Iconimage_Selected = null;
            this.BtnEliminar.IconMarginLeft = 0;
            this.BtnEliminar.IconMarginRight = 0;
            this.BtnEliminar.IconRightVisible = true;
            this.BtnEliminar.IconRightZoom = 0D;
            this.BtnEliminar.IconVisible = true;
            this.BtnEliminar.IconZoom = 90D;
            this.BtnEliminar.IsTab = false;
            this.BtnEliminar.Location = new System.Drawing.Point(639, 313);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Normalcolor = System.Drawing.Color.Crimson;
            this.BtnEliminar.OnHovercolor = System.Drawing.Color.Crimson;
            this.BtnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEliminar.selected = false;
            this.BtnEliminar.Size = new System.Drawing.Size(147, 59);
            this.BtnEliminar.TabIndex = 17;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEliminar.Textcolor = System.Drawing.Color.White;
            this.BtnEliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(112)))));
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNuevo.BorderRadius = 7;
            this.BtnNuevo.ButtonText = "Nuevo";
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.DisabledColor = System.Drawing.Color.Gray;
            this.BtnNuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnNuevo.Iconimage = global::SISTEMA_REGISTRO_ENTRADA_ESTUDIANTES.Properties.Resources.baseline_refresh_white_48dp;
            this.BtnNuevo.Iconimage_right = null;
            this.BtnNuevo.Iconimage_right_Selected = null;
            this.BtnNuevo.Iconimage_Selected = null;
            this.BtnNuevo.IconMarginLeft = 0;
            this.BtnNuevo.IconMarginRight = 0;
            this.BtnNuevo.IconRightVisible = true;
            this.BtnNuevo.IconRightZoom = 0D;
            this.BtnNuevo.IconVisible = true;
            this.BtnNuevo.IconZoom = 90D;
            this.BtnNuevo.IsTab = false;
            this.BtnNuevo.Location = new System.Drawing.Point(463, 230);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(112)))));
            this.BtnNuevo.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.BtnNuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnNuevo.selected = false;
            this.BtnNuevo.Size = new System.Drawing.Size(147, 59);
            this.BtnNuevo.TabIndex = 14;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNuevo.Textcolor = System.Drawing.Color.White;
            this.BtnNuevo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(112)))));
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.BorderRadius = 7;
            this.BtnEditar.ButtonText = "Editar";
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnEditar.Iconimage = global::SISTEMA_REGISTRO_ENTRADA_ESTUDIANTES.Properties.Resources.baseline_edit_white_48dp;
            this.BtnEditar.Iconimage_right = null;
            this.BtnEditar.Iconimage_right_Selected = null;
            this.BtnEditar.Iconimage_Selected = null;
            this.BtnEditar.IconMarginLeft = 0;
            this.BtnEditar.IconMarginRight = 0;
            this.BtnEditar.IconRightVisible = true;
            this.BtnEditar.IconRightZoom = 0D;
            this.BtnEditar.IconVisible = true;
            this.BtnEditar.IconZoom = 90D;
            this.BtnEditar.IsTab = false;
            this.BtnEditar.Location = new System.Drawing.Point(463, 313);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(112)))));
            this.BtnEditar.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.BtnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnEditar.selected = false;
            this.BtnEditar.Size = new System.Drawing.Size(147, 59);
            this.BtnEditar.TabIndex = 16;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEditar.Textcolor = System.Drawing.Color.White;
            this.BtnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(112)))));
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardar.BorderRadius = 7;
            this.BtnGuardar.ButtonText = "Guardar";
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Iconimage = global::SISTEMA_REGISTRO_ENTRADA_ESTUDIANTES.Properties.Resources.baseline_save_white_48dp;
            this.BtnGuardar.Iconimage_right = null;
            this.BtnGuardar.Iconimage_right_Selected = null;
            this.BtnGuardar.Iconimage_Selected = null;
            this.BtnGuardar.IconMarginLeft = 0;
            this.BtnGuardar.IconMarginRight = 0;
            this.BtnGuardar.IconRightVisible = true;
            this.BtnGuardar.IconRightZoom = 0D;
            this.BtnGuardar.IconVisible = true;
            this.BtnGuardar.IconZoom = 90D;
            this.BtnGuardar.IsTab = false;
            this.BtnGuardar.Location = new System.Drawing.Point(639, 230);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(112)))));
            this.BtnGuardar.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.BtnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGuardar.selected = false;
            this.BtnGuardar.Size = new System.Drawing.Size(147, 59);
            this.BtnGuardar.TabIndex = 15;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnGuardar.Textcolor = System.Drawing.Color.White;
            this.BtnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.pictureBox3.Image = global::SISTEMA_REGISTRO_ENTRADA_ESTUDIANTES.Properties.Resources.Imagen3;
            this.pictureBox3.Location = new System.Drawing.Point(545, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(241, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(422, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 392);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEdificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 436);
            this.Controls.Add(this.LblDatosE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEdificio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEdificio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEdificio_FormClosed);
            this.Load += new System.EventHandler(this.FrmEdificio_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblEdificio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label LbLSesion;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.DataGridView TblEdificio;
        private Bunifu.Framework.UI.BunifuFlatButton BtnNuevo;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnEliminar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse RedondeadoForm;
        private Bunifu.Framework.UI.BunifuElipse RedondeadoTabla;
        private Bunifu.Framework.UI.BunifuDragControl MoverForm;
        private System.Windows.Forms.Label LblDatosE;
    }
}
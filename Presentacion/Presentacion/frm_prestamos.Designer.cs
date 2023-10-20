namespace Presentacion
{
    partial class frm_prestamos
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
            this.txt_id = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_nombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_codigo_implemento = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_descripcion = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_existencia = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_nombre_implemento = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_cantidad_prestamo = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_prestamo = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancelar = new MaterialSkin.Controls.MaterialButton();
            this.txt_observaciones = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btn_agregar = new MaterialSkin.Controls.MaterialButton();
            this.dtg_prestamo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_prestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.AnimateReadOnly = false;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Depth = 0;
            this.txt_id.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_id.Hint = "Identificación del la persona";
            this.txt_id.LeadingIcon = null;
            this.txt_id.Location = new System.Drawing.Point(13, 13);
            this.txt_id.MaxLength = 50;
            this.txt_id.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(286, 50);
            this.txt_id.TabIndex = 0;
            this.txt_id.Text = "";
            this.txt_id.TrailingIcon = null;
            // 
            // txt_nombre
            // 
            this.txt_nombre.AnimateReadOnly = false;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Depth = 0;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nombre.Hint = "Nombres persona";
            this.txt_nombre.LeadingIcon = null;
            this.txt_nombre.Location = new System.Drawing.Point(315, 13);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nombre.Multiline = false;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(464, 50);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.Text = "";
            this.txt_nombre.TrailingIcon = null;
            // 
            // txt_codigo_implemento
            // 
            this.txt_codigo_implemento.AnimateReadOnly = false;
            this.txt_codigo_implemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo_implemento.Depth = 0;
            this.txt_codigo_implemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_codigo_implemento.Hint = "Codigo del implemento";
            this.txt_codigo_implemento.LeadingIcon = null;
            this.txt_codigo_implemento.Location = new System.Drawing.Point(12, 79);
            this.txt_codigo_implemento.MaxLength = 50;
            this.txt_codigo_implemento.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_codigo_implemento.Multiline = false;
            this.txt_codigo_implemento.Name = "txt_codigo_implemento";
            this.txt_codigo_implemento.Size = new System.Drawing.Size(286, 50);
            this.txt_codigo_implemento.TabIndex = 2;
            this.txt_codigo_implemento.Text = "";
            this.txt_codigo_implemento.TrailingIcon = null;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.AnimateReadOnly = false;
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descripcion.Depth = 0;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_descripcion.Hint = "Descripción";
            this.txt_descripcion.LeadingIcon = null;
            this.txt_descripcion.Location = new System.Drawing.Point(315, 79);
            this.txt_descripcion.MaxLength = 50;
            this.txt_descripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_descripcion.Multiline = false;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(464, 50);
            this.txt_descripcion.TabIndex = 3;
            this.txt_descripcion.Text = "";
            this.txt_descripcion.TrailingIcon = null;
            // 
            // txt_existencia
            // 
            this.txt_existencia.AnimateReadOnly = false;
            this.txt_existencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_existencia.Depth = 0;
            this.txt_existencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_existencia.Hint = "Existencias";
            this.txt_existencia.LeadingIcon = null;
            this.txt_existencia.Location = new System.Drawing.Point(12, 144);
            this.txt_existencia.MaxLength = 50;
            this.txt_existencia.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_existencia.Multiline = false;
            this.txt_existencia.Name = "txt_existencia";
            this.txt_existencia.ReadOnly = true;
            this.txt_existencia.Size = new System.Drawing.Size(286, 50);
            this.txt_existencia.TabIndex = 4;
            this.txt_existencia.Text = "";
            this.txt_existencia.TrailingIcon = null;
            // 
            // txt_nombre_implemento
            // 
            this.txt_nombre_implemento.AnimateReadOnly = false;
            this.txt_nombre_implemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre_implemento.Depth = 0;
            this.txt_nombre_implemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nombre_implemento.Hint = "Nombre implemento";
            this.txt_nombre_implemento.LeadingIcon = null;
            this.txt_nombre_implemento.Location = new System.Drawing.Point(315, 144);
            this.txt_nombre_implemento.MaxLength = 50;
            this.txt_nombre_implemento.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nombre_implemento.Multiline = false;
            this.txt_nombre_implemento.Name = "txt_nombre_implemento";
            this.txt_nombre_implemento.ReadOnly = true;
            this.txt_nombre_implemento.Size = new System.Drawing.Size(464, 50);
            this.txt_nombre_implemento.TabIndex = 5;
            this.txt_nombre_implemento.Text = "";
            this.txt_nombre_implemento.TrailingIcon = null;
            // 
            // txt_cantidad_prestamo
            // 
            this.txt_cantidad_prestamo.AnimateReadOnly = false;
            this.txt_cantidad_prestamo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantidad_prestamo.Depth = 0;
            this.txt_cantidad_prestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_cantidad_prestamo.Hint = "Cantidad a prestar";
            this.txt_cantidad_prestamo.LeadingIcon = null;
            this.txt_cantidad_prestamo.Location = new System.Drawing.Point(12, 210);
            this.txt_cantidad_prestamo.MaxLength = 50;
            this.txt_cantidad_prestamo.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_cantidad_prestamo.Multiline = false;
            this.txt_cantidad_prestamo.Name = "txt_cantidad_prestamo";
            this.txt_cantidad_prestamo.Size = new System.Drawing.Size(286, 50);
            this.txt_cantidad_prestamo.TabIndex = 6;
            this.txt_cantidad_prestamo.Text = "";
            this.txt_cantidad_prestamo.TrailingIcon = null;
            // 
            // btn_prestamo
            // 
            this.btn_prestamo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_prestamo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_prestamo.Depth = 0;
            this.btn_prestamo.HighEmphasis = true;
            this.btn_prestamo.Icon = null;
            this.btn_prestamo.Location = new System.Drawing.Point(13, 279);
            this.btn_prestamo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_prestamo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_prestamo.Name = "btn_prestamo";
            this.btn_prestamo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_prestamo.Size = new System.Drawing.Size(85, 36);
            this.btn_prestamo.TabIndex = 7;
            this.btn_prestamo.Text = "Prestar";
            this.btn_prestamo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_prestamo.UseAccentColor = false;
            this.btn_prestamo.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancelar.Depth = 0;
            this.btn_cancelar.HighEmphasis = true;
            this.btn_cancelar.Icon = null;
            this.btn_cancelar.Location = new System.Drawing.Point(121, 279);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancelar.Size = new System.Drawing.Size(96, 36);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancelar.UseAccentColor = false;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.AllowDrop = true;
            this.txt_observaciones.AnimateReadOnly = false;
            this.txt_observaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_observaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_observaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_observaciones.Depth = 0;
            this.txt_observaciones.HideSelection = true;
            this.txt_observaciones.Hint = "Observaciones";
            this.txt_observaciones.Location = new System.Drawing.Point(315, 210);
            this.txt_observaciones.MaxLength = 32767;
            this.txt_observaciones.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.PasswordChar = '\0';
            this.txt_observaciones.ReadOnly = false;
            this.txt_observaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_observaciones.SelectedText = "";
            this.txt_observaciones.SelectionLength = 0;
            this.txt_observaciones.SelectionStart = 0;
            this.txt_observaciones.ShortcutsEnabled = true;
            this.txt_observaciones.Size = new System.Drawing.Size(464, 105);
            this.txt_observaciones.TabIndex = 9;
            this.txt_observaciones.TabStop = false;
            this.txt_observaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_observaciones.UseSystemPasswordChar = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_agregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_agregar.Depth = 0;
            this.btn_agregar.HighEmphasis = true;
            this.btn_agregar.Icon = null;
            this.btn_agregar.Location = new System.Drawing.Point(235, 279);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_agregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_agregar.Size = new System.Drawing.Size(64, 36);
            this.btn_agregar.TabIndex = 10;
            this.btn_agregar.Text = "+";
            this.btn_agregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_agregar.UseAccentColor = false;
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // dtg_prestamo
            // 
            this.dtg_prestamo.AllowUserToAddRows = false;
            this.dtg_prestamo.AllowUserToDeleteRows = false;
            this.dtg_prestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_prestamo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtg_prestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_prestamo.Location = new System.Drawing.Point(13, 337);
            this.dtg_prestamo.Name = "dtg_prestamo";
            this.dtg_prestamo.ReadOnly = true;
            this.dtg_prestamo.Size = new System.Drawing.Size(766, 172);
            this.dtg_prestamo.TabIndex = 11;
            // 
            // frm_prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.dtg_prestamo);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_observaciones);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_prestamo);
            this.Controls.Add(this.txt_cantidad_prestamo);
            this.Controls.Add(this.txt_nombre_implemento);
            this.Controls.Add(this.txt_existencia);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_codigo_implemento);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Name = "frm_prestamos";
            this.Text = "Prestamos";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_prestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_id;
        private MaterialSkin.Controls.MaterialTextBox txt_nombre;
        private MaterialSkin.Controls.MaterialTextBox txt_codigo_implemento;
        private MaterialSkin.Controls.MaterialTextBox txt_descripcion;
        private MaterialSkin.Controls.MaterialTextBox txt_existencia;
        private MaterialSkin.Controls.MaterialTextBox txt_nombre_implemento;
        private MaterialSkin.Controls.MaterialTextBox txt_cantidad_prestamo;
        private MaterialSkin.Controls.MaterialButton btn_prestamo;
        private MaterialSkin.Controls.MaterialButton btn_cancelar;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_observaciones;
        private MaterialSkin.Controls.MaterialButton btn_agregar;
        private System.Windows.Forms.DataGridView dtg_prestamo;
    }
}
namespace Presentacion
{
    partial class frm_ModuloUsuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_id = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_p_nombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_s_nombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_p_apellido = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_contacto = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_correo = new MaterialSkin.Controls.MaterialTextBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_direccion = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_actualizar = new MaterialSkin.Controls.MaterialButton();
            this.btn_guardar = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancelar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.AnimateReadOnly = false;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Depth = 0;
            this.txt_id.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_id.Hint = "Identificación";
            this.txt_id.LeadingIcon = null;
            this.txt_id.Location = new System.Drawing.Point(12, 12);
            this.txt_id.MaxLength = 50;
            this.txt_id.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(220, 50);
            this.txt_id.TabIndex = 0;
            this.txt_id.Text = "";
            this.txt_id.TrailingIcon = null;
            // 
            // txt_p_nombre
            // 
            this.txt_p_nombre.AnimateReadOnly = false;
            this.txt_p_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_p_nombre.Depth = 0;
            this.txt_p_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_p_nombre.Hint = "Primer Nombre";
            this.txt_p_nombre.LeadingIcon = null;
            this.txt_p_nombre.Location = new System.Drawing.Point(249, 11);
            this.txt_p_nombre.MaxLength = 50;
            this.txt_p_nombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_p_nombre.Multiline = false;
            this.txt_p_nombre.Name = "txt_p_nombre";
            this.txt_p_nombre.Size = new System.Drawing.Size(235, 50);
            this.txt_p_nombre.TabIndex = 1;
            this.txt_p_nombre.Text = "";
            this.txt_p_nombre.TrailingIcon = null;
            this.txt_p_nombre.TextChanged += new System.EventHandler(this.txt_p_nombre_TextChanged);
            // 
            // txt_s_nombre
            // 
            this.txt_s_nombre.AnimateReadOnly = false;
            this.txt_s_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_s_nombre.Depth = 0;
            this.txt_s_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_s_nombre.Hint = "Segundo Nombre";
            this.txt_s_nombre.LeadingIcon = null;
            this.txt_s_nombre.Location = new System.Drawing.Point(499, 11);
            this.txt_s_nombre.MaxLength = 50;
            this.txt_s_nombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_s_nombre.Multiline = false;
            this.txt_s_nombre.Name = "txt_s_nombre";
            this.txt_s_nombre.Size = new System.Drawing.Size(226, 50);
            this.txt_s_nombre.TabIndex = 2;
            this.txt_s_nombre.Text = "";
            this.txt_s_nombre.TrailingIcon = null;
            this.txt_s_nombre.TextChanged += new System.EventHandler(this.txt_s_nombre_TextChanged);
            // 
            // txt_p_apellido
            // 
            this.txt_p_apellido.AnimateReadOnly = false;
            this.txt_p_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_p_apellido.Depth = 0;
            this.txt_p_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_p_apellido.Hint = "Primer Apellido";
            this.txt_p_apellido.LeadingIcon = null;
            this.txt_p_apellido.Location = new System.Drawing.Point(12, 83);
            this.txt_p_apellido.MaxLength = 50;
            this.txt_p_apellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_p_apellido.Multiline = false;
            this.txt_p_apellido.Name = "txt_p_apellido";
            this.txt_p_apellido.Size = new System.Drawing.Size(220, 50);
            this.txt_p_apellido.TabIndex = 3;
            this.txt_p_apellido.Text = "";
            this.txt_p_apellido.TrailingIcon = null;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Segundo Apellido";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(249, 83);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(235, 50);
            this.materialTextBox1.TabIndex = 4;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // txt_contacto
            // 
            this.txt_contacto.AnimateReadOnly = false;
            this.txt_contacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contacto.Depth = 0;
            this.txt_contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_contacto.Hint = "Contacto";
            this.txt_contacto.LeadingIcon = null;
            this.txt_contacto.Location = new System.Drawing.Point(499, 83);
            this.txt_contacto.MaxLength = 50;
            this.txt_contacto.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_contacto.Multiline = false;
            this.txt_contacto.Name = "txt_contacto";
            this.txt_contacto.Size = new System.Drawing.Size(226, 50);
            this.txt_contacto.TabIndex = 5;
            this.txt_contacto.Text = "";
            this.txt_contacto.TrailingIcon = null;
            // 
            // txt_correo
            // 
            this.txt_correo.AnimateReadOnly = false;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Depth = 0;
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_correo.Hint = "Correo";
            this.txt_correo.LeadingIcon = null;
            this.txt_correo.Location = new System.Drawing.Point(12, 158);
            this.txt_correo.MaxLength = 50;
            this.txt_correo.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_correo.Multiline = false;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(472, 50);
            this.txt_correo.TabIndex = 6;
            this.txt_correo.Text = "";
            this.txt_correo.TrailingIcon = null;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.materialComboBox1.Location = new System.Drawing.Point(499, 159);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(226, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 7;
            // 
            // txt_direccion
            // 
            this.txt_direccion.AnimateReadOnly = false;
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_direccion.Depth = 0;
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_direccion.Hint = "Dirección";
            this.txt_direccion.LeadingIcon = null;
            this.txt_direccion.Location = new System.Drawing.Point(12, 229);
            this.txt_direccion.MaxLength = 50;
            this.txt_direccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_direccion.Multiline = false;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(713, 50);
            this.txt_direccion.TabIndex = 8;
            this.txt_direccion.Text = "";
            this.txt_direccion.TrailingIcon = null;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_actualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_actualizar.Depth = 0;
            this.btn_actualizar.HighEmphasis = true;
            this.btn_actualizar.Icon = null;
            this.btn_actualizar.Location = new System.Drawing.Point(384, 309);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_actualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_actualizar.Size = new System.Drawing.Size(109, 36);
            this.btn_actualizar.TabIndex = 9;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_actualizar.UseAccentColor = false;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_guardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_guardar.Depth = 0;
            this.btn_guardar.HighEmphasis = true;
            this.btn_guardar.Icon = null;
            this.btn_guardar.Location = new System.Drawing.Point(517, 309);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_guardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_guardar.Size = new System.Drawing.Size(88, 36);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_guardar.UseAccentColor = false;
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancelar.Depth = 0;
            this.btn_cancelar.HighEmphasis = true;
            this.btn_cancelar.Icon = null;
            this.btn_cancelar.Location = new System.Drawing.Point(629, 309);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancelar.Size = new System.Drawing.Size(96, 36);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancelar.UseAccentColor = false;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // frm_ModuloUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 371);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_contacto);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.txt_p_apellido);
            this.Controls.Add(this.txt_s_nombre);
            this.Controls.Add(this.txt_p_nombre);
            this.Controls.Add(this.txt_id);
            this.Name = "frm_ModuloUsuarios";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_id;
        private MaterialSkin.Controls.MaterialTextBox txt_p_nombre;
        private MaterialSkin.Controls.MaterialTextBox txt_s_nombre;
        private MaterialSkin.Controls.MaterialTextBox txt_p_apellido;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox txt_contacto;
        private MaterialSkin.Controls.MaterialTextBox txt_correo;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialTextBox txt_direccion;
        private MaterialSkin.Controls.MaterialButton btn_actualizar;
        private MaterialSkin.Controls.MaterialButton btn_guardar;
        private MaterialSkin.Controls.MaterialButton btn_cancelar;
    }
}


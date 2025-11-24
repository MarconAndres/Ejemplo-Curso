namespace Ejemplo1
{
    partial class Form1
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
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.texteNombre = new System.Windows.Forms.TextBox();
            this.lvElementos = new System.Windows.Forms.ListView();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFechaNac = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNac = new System.Windows.Forms.DateTimePicker();
            this.checkBoxChocolate = new System.Windows.Forms.CheckBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.comboBoxColorFav = new System.Windows.Forms.ComboBox();
            this.labelNumeroFav = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonVerPerfil = new System.Windows.Forms.Button();
            this.groupBoxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAgregar.Location = new System.Drawing.Point(25, 609);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 8;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // texteNombre
            // 
            this.texteNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texteNombre.Location = new System.Drawing.Point(125, 52);
            this.texteNombre.Name = "texteNombre";
            this.texteNombre.Size = new System.Drawing.Size(305, 20);
            this.texteNombre.TabIndex = 0;
            // 
            // lvElementos
            // 
            this.lvElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvElementos.HideSelection = false;
            this.lvElementos.Location = new System.Drawing.Point(49, 342);
            this.lvElementos.Name = "lvElementos";
            this.lvElementos.Size = new System.Drawing.Size(488, 246);
            this.lvElementos.TabIndex = 7;
            this.lvElementos.UseCompatibleStateImageBehavior = false;
            this.lvElementos.View = System.Windows.Forms.View.List;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(68, 55);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelFechaNac
            // 
            this.labelFechaNac.AutoSize = true;
            this.labelFechaNac.Location = new System.Drawing.Point(6, 88);
            this.labelFechaNac.Name = "labelFechaNac";
            this.labelFechaNac.Size = new System.Drawing.Size(109, 13);
            this.labelFechaNac.TabIndex = 10;
            this.labelFechaNac.Text = "Fecha de nacimiento:";
            // 
            // dateTimePickerFechaNac
            // 
            this.dateTimePickerFechaNac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFechaNac.Location = new System.Drawing.Point(125, 88);
            this.dateTimePickerFechaNac.Name = "dateTimePickerFechaNac";
            this.dateTimePickerFechaNac.Size = new System.Drawing.Size(305, 20);
            this.dateTimePickerFechaNac.TabIndex = 1;
            // 
            // checkBoxChocolate
            // 
            this.checkBoxChocolate.AutoSize = true;
            this.checkBoxChocolate.Location = new System.Drawing.Point(125, 114);
            this.checkBoxChocolate.Name = "checkBoxChocolate";
            this.checkBoxChocolate.Size = new System.Drawing.Size(136, 17);
            this.checkBoxChocolate.TabIndex = 2;
            this.checkBoxChocolate.Text = "Te gusta el Chocolate?";
            this.checkBoxChocolate.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(209, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(198, 31);
            this.labelTitulo.TabIndex = 7;
            this.labelTitulo.Text = "Perfil Persona";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Wizzard";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(107, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Muggle";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(198, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Squibs";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxTipo.Controls.Add(this.radioButton1);
            this.groupBoxTipo.Controls.Add(this.radioButton3);
            this.groupBoxTipo.Controls.Add(this.radioButton2);
            this.groupBoxTipo.Location = new System.Drawing.Point(61, 137);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(289, 48);
            this.groupBoxTipo.TabIndex = 3;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Tipo";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(12, 205);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(75, 13);
            this.labelColor.TabIndex = 11;
            this.labelColor.Text = "Color Favorito:";
            // 
            // comboBoxColorFav
            // 
            this.comboBoxColorFav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxColorFav.FormattingEnabled = true;
            this.comboBoxColorFav.Location = new System.Drawing.Point(116, 202);
            this.comboBoxColorFav.Name = "comboBoxColorFav";
            this.comboBoxColorFav.Size = new System.Drawing.Size(226, 21);
            this.comboBoxColorFav.TabIndex = 4;
            // 
            // labelNumeroFav
            // 
            this.labelNumeroFav.AutoSize = true;
            this.labelNumeroFav.Location = new System.Drawing.Point(12, 241);
            this.labelNumeroFav.Name = "labelNumeroFav";
            this.labelNumeroFav.Size = new System.Drawing.Size(88, 13);
            this.labelNumeroFav.TabIndex = 12;
            this.labelNumeroFav.Text = "Numero Favorito:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(116, 241);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(225, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // buttonVerPerfil
            // 
            this.buttonVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonVerPerfil.Location = new System.Drawing.Point(15, 282);
            this.buttonVerPerfil.Name = "buttonVerPerfil";
            this.buttonVerPerfil.Size = new System.Drawing.Size(75, 23);
            this.buttonVerPerfil.TabIndex = 6;
            this.buttonVerPerfil.Text = "Ver Perfil";
            this.buttonVerPerfil.UseVisualStyleBackColor = true;
            this.buttonVerPerfil.Click += new System.EventHandler(this.buttonVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(593, 712);
            this.Controls.Add(this.buttonVerPerfil);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelNumeroFav);
            this.Controls.Add(this.comboBoxColorFav);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.checkBoxChocolate);
            this.Controls.Add(this.dateTimePickerFechaNac);
            this.Controls.Add(this.labelFechaNac);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.lvElementos);
            this.Controls.Add(this.texteNombre);
            this.Controls.Add(this.buttonAgregar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(883, 751);
            this.MinimumSize = new System.Drawing.Size(504, 671);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox texteNombre;
        private System.Windows.Forms.ListView lvElementos;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelFechaNac;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNac;
        private System.Windows.Forms.CheckBox checkBoxChocolate;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox comboBoxColorFav;
        private System.Windows.Forms.Label labelNumeroFav;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonVerPerfil;
    }
}


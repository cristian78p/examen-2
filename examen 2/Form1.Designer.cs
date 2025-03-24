namespace examen_2
{
    partial class Form1
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
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCuentas = new System.Windows.Forms.Label();
            this.txtCuentas = new System.Windows.Forms.TextBox();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.bttnEditar = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Corporativo",
            "Individual"});
            this.comboBoxTipo.Location = new System.Drawing.Point(34, 130);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(217, 21);
            this.comboBoxTipo.TabIndex = 0;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(34, 183);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(34, 237);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(217, 20);
            this.txtIdentificacion.TabIndex = 2;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(34, 292);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(217, 20);
            this.txtSaldo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Identificacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Saldo";
            // 
            // labelCuentas
            // 
            this.labelCuentas.AutoSize = true;
            this.labelCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuentas.Location = new System.Drawing.Point(31, 331);
            this.labelCuentas.Name = "labelCuentas";
            this.labelCuentas.Size = new System.Drawing.Size(99, 13);
            this.labelCuentas.TabIndex = 11;
            this.labelCuentas.Text = "Cuentas Activas";
            this.labelCuentas.Visible = false;
            // 
            // txtCuentas
            // 
            this.txtCuentas.Location = new System.Drawing.Point(34, 347);
            this.txtCuentas.Name = "txtCuentas";
            this.txtCuentas.Size = new System.Drawing.Size(217, 20);
            this.txtCuentas.TabIndex = 10;
            this.txtCuentas.Visible = false;
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.Location = new System.Drawing.Point(34, 393);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(126, 28);
            this.bttnAgregar.TabIndex = 12;
            this.bttnAgregar.Text = "Agregar";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(300, 44);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(315, 452);
            this.dgvClientes.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Lista de clientes";
            // 
            // bttnEditar
            // 
            this.bttnEditar.Location = new System.Drawing.Point(300, 519);
            this.bttnEditar.Name = "bttnEditar";
            this.bttnEditar.Size = new System.Drawing.Size(126, 28);
            this.bttnEditar.TabIndex = 15;
            this.bttnEditar.Text = "Editar";
            this.bttnEditar.UseVisualStyleBackColor = true;
            this.bttnEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.Location = new System.Drawing.Point(489, 519);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(126, 28);
            this.bttnEliminar.TabIndex = 16;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 572);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnEditar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.labelCuentas);
            this.Controls.Add(this.txtCuentas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.comboBoxTipo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCuentas;
        private System.Windows.Forms.TextBox txtCuentas;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttnEditar;
        private System.Windows.Forms.Button bttnEliminar;
    }
}


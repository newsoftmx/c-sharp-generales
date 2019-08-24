namespace invocacionWSVB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckbEstatus = new System.Windows.Forms.CheckBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.btnGuardarSP = new System.Windows.Forms.Button();
            this.btnGuardarNormal = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnActualizarNormal = new System.Windows.Forms.Button();
            this.btnBuscarTodosNormal = new System.Windows.Forms.Button();
            this.btnEliminarNormal = new System.Windows.Forms.Button();
            this.btnBuscarIDNormal = new System.Windows.Forms.Button();
            this.btnActualizarSP = new System.Windows.Forms.Button();
            this.btnBuscarTodosSP = new System.Windows.Forms.Button();
            this.btnEliminarSP = new System.Windows.Forms.Button();
            this.btnBuscarIDSP = new System.Windows.Forms.Button();
            this.dgvDeportistas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeportistas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(172, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Apellido Paterno";
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.Location = new System.Drawing.Point(172, 60);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(175, 20);
            this.txtApePaterno.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Apellido Materno";
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.Location = new System.Drawing.Point(172, 105);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(175, 20);
            this.txtApeMaterno.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(115, 147);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(175, 20);
            this.txtEdad.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nivel";
            // 
            // ckbEstatus
            // 
            this.ckbEstatus.AutoSize = true;
            this.ckbEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEstatus.Location = new System.Drawing.Point(53, 185);
            this.ckbEstatus.Name = "ckbEstatus";
            this.ckbEstatus.Size = new System.Drawing.Size(90, 24);
            this.ckbEstatus.TabIndex = 17;
            this.ckbEstatus.Text = "Estatus";
            this.ckbEstatus.UseVisualStyleBackColor = true;
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Items.AddRange(new object[] {
            "Estandar",
            "Medio",
            "Profesional",
            "Experto"});
            this.cmbNivel.Location = new System.Drawing.Point(115, 229);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(121, 21);
            this.cmbNivel.TabIndex = 18;
            // 
            // btnGuardarSP
            // 
            this.btnGuardarSP.Location = new System.Drawing.Point(12, 267);
            this.btnGuardarSP.Name = "btnGuardarSP";
            this.btnGuardarSP.Size = new System.Drawing.Size(112, 29);
            this.btnGuardarSP.TabIndex = 19;
            this.btnGuardarSP.Text = "Guardar SP";
            this.btnGuardarSP.UseVisualStyleBackColor = true;
            this.btnGuardarSP.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnGuardarNormal
            // 
            this.btnGuardarNormal.Location = new System.Drawing.Point(252, 267);
            this.btnGuardarNormal.Name = "btnGuardarNormal";
            this.btnGuardarNormal.Size = new System.Drawing.Size(102, 29);
            this.btnGuardarNormal.TabIndex = 20;
            this.btnGuardarNormal.Text = "Guardar Normal";
            this.btnGuardarNormal.UseVisualStyleBackColor = true;
            this.btnGuardarNormal.Click += new System.EventHandler(this.btnGuardarNormal_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(382, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 21;
            // 
            // btnActualizarNormal
            // 
            this.btnActualizarNormal.Location = new System.Drawing.Point(322, 374);
            this.btnActualizarNormal.Name = "btnActualizarNormal";
            this.btnActualizarNormal.Size = new System.Drawing.Size(109, 23);
            this.btnActualizarNormal.TabIndex = 22;
            this.btnActualizarNormal.Text = "Actualizar Normal";
            this.btnActualizarNormal.UseVisualStyleBackColor = true;
            this.btnActualizarNormal.Click += new System.EventHandler(this.btnActualizarNormal_Click);
            // 
            // btnBuscarTodosNormal
            // 
            this.btnBuscarTodosNormal.Location = new System.Drawing.Point(373, 321);
            this.btnBuscarTodosNormal.Name = "btnBuscarTodosNormal";
            this.btnBuscarTodosNormal.Size = new System.Drawing.Size(117, 23);
            this.btnBuscarTodosNormal.TabIndex = 23;
            this.btnBuscarTodosNormal.Text = "Buscar Todos Normal";
            this.btnBuscarTodosNormal.UseVisualStyleBackColor = true;
            this.btnBuscarTodosNormal.Click += new System.EventHandler(this.btnBuscarTodosNormal_Click);
            // 
            // btnEliminarNormal
            // 
            this.btnEliminarNormal.Location = new System.Drawing.Point(252, 321);
            this.btnEliminarNormal.Name = "btnEliminarNormal";
            this.btnEliminarNormal.Size = new System.Drawing.Size(95, 23);
            this.btnEliminarNormal.TabIndex = 24;
            this.btnEliminarNormal.Text = "Eliminar Normal";
            this.btnEliminarNormal.UseVisualStyleBackColor = true;
            this.btnEliminarNormal.Click += new System.EventHandler(this.btnEliminarNormal_Click);
            // 
            // btnBuscarIDNormal
            // 
            this.btnBuscarIDNormal.Location = new System.Drawing.Point(373, 273);
            this.btnBuscarIDNormal.Name = "btnBuscarIDNormal";
            this.btnBuscarIDNormal.Size = new System.Drawing.Size(117, 23);
            this.btnBuscarIDNormal.TabIndex = 25;
            this.btnBuscarIDNormal.Text = "Buscar ID Normal";
            this.btnBuscarIDNormal.UseVisualStyleBackColor = true;
            this.btnBuscarIDNormal.Click += new System.EventHandler(this.btnBuscarIDNormal_Click);
            // 
            // btnActualizarSP
            // 
            this.btnActualizarSP.Location = new System.Drawing.Point(86, 374);
            this.btnActualizarSP.Name = "btnActualizarSP";
            this.btnActualizarSP.Size = new System.Drawing.Size(84, 23);
            this.btnActualizarSP.TabIndex = 26;
            this.btnActualizarSP.Text = "Actualizar SP";
            this.btnActualizarSP.UseVisualStyleBackColor = true;
            this.btnActualizarSP.Click += new System.EventHandler(this.btnActualizarSP_Click);
            // 
            // btnBuscarTodosSP
            // 
            this.btnBuscarTodosSP.Location = new System.Drawing.Point(132, 321);
            this.btnBuscarTodosSP.Name = "btnBuscarTodosSP";
            this.btnBuscarTodosSP.Size = new System.Drawing.Size(104, 23);
            this.btnBuscarTodosSP.TabIndex = 27;
            this.btnBuscarTodosSP.Text = "Buscar Todos SP";
            this.btnBuscarTodosSP.UseVisualStyleBackColor = true;
            this.btnBuscarTodosSP.Click += new System.EventHandler(this.btnBuscarTodosSP_Click);
            // 
            // btnEliminarSP
            // 
            this.btnEliminarSP.Location = new System.Drawing.Point(21, 321);
            this.btnEliminarSP.Name = "btnEliminarSP";
            this.btnEliminarSP.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarSP.TabIndex = 28;
            this.btnEliminarSP.Text = "Eliminar SP";
            this.btnEliminarSP.UseVisualStyleBackColor = true;
            this.btnEliminarSP.Click += new System.EventHandler(this.btnEliminarSP_Click);
            // 
            // btnBuscarIDSP
            // 
            this.btnBuscarIDSP.Location = new System.Drawing.Point(142, 270);
            this.btnBuscarIDSP.Name = "btnBuscarIDSP";
            this.btnBuscarIDSP.Size = new System.Drawing.Size(94, 23);
            this.btnBuscarIDSP.TabIndex = 29;
            this.btnBuscarIDSP.Text = "Buscar ID SP";
            this.btnBuscarIDSP.UseVisualStyleBackColor = true;
            this.btnBuscarIDSP.Click += new System.EventHandler(this.btnBuscarIDSP_Click_1);
            // 
            // dgvDeportistas
            // 
            this.dgvDeportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeportistas.Location = new System.Drawing.Point(361, 60);
            this.dgvDeportistas.Name = "dgvDeportistas";
            this.dgvDeportistas.Size = new System.Drawing.Size(495, 198);
            this.dgvDeportistas.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 514);
            this.Controls.Add(this.dgvDeportistas);
            this.Controls.Add(this.btnBuscarIDSP);
            this.Controls.Add(this.btnEliminarSP);
            this.Controls.Add(this.btnBuscarTodosSP);
            this.Controls.Add(this.btnActualizarSP);
            this.Controls.Add(this.btnBuscarIDNormal);
            this.Controls.Add(this.btnEliminarNormal);
            this.Controls.Add(this.btnBuscarTodosNormal);
            this.Controls.Add(this.btnActualizarNormal);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnGuardarNormal);
            this.Controls.Add(this.btnGuardarSP);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.ckbEstatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApeMaterno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApePaterno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Actualizar Normal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeportistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckbEstatus;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Button btnGuardarSP;
        private System.Windows.Forms.Button btnGuardarNormal;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnActualizarNormal;
        private System.Windows.Forms.Button btnBuscarTodosNormal;
        private System.Windows.Forms.Button btnEliminarNormal;
        private System.Windows.Forms.Button btnBuscarIDNormal;
        private System.Windows.Forms.Button btnActualizarSP;
        private System.Windows.Forms.Button btnBuscarTodosSP;
        private System.Windows.Forms.Button btnEliminarSP;
        private System.Windows.Forms.Button btnBuscarIDSP;
        private System.Windows.Forms.DataGridView dgvDeportistas;
    }
}


namespace consumoWCF1
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
            this.dgvDeportistas = new System.Windows.Forms.DataGridView();
            this.btnBuscarIDSP = new System.Windows.Forms.Button();
            this.btnEliminarSP = new System.Windows.Forms.Button();
            this.btnBuscarTodosSP = new System.Windows.Forms.Button();
            this.btnActualizarSP = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnGuardarSP = new System.Windows.Forms.Button();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.ckbEstatus = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeportistas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeportistas
            // 
            this.dgvDeportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeportistas.Location = new System.Drawing.Point(359, 79);
            this.dgvDeportistas.Name = "dgvDeportistas";
            this.dgvDeportistas.Size = new System.Drawing.Size(495, 198);
            this.dgvDeportistas.TabIndex = 48;
            // 
            // btnBuscarIDSP
            // 
            this.btnBuscarIDSP.Location = new System.Drawing.Point(140, 289);
            this.btnBuscarIDSP.Name = "btnBuscarIDSP";
            this.btnBuscarIDSP.Size = new System.Drawing.Size(94, 23);
            this.btnBuscarIDSP.TabIndex = 47;
            this.btnBuscarIDSP.Text = "Buscar ID ";
            this.btnBuscarIDSP.UseVisualStyleBackColor = true;
            this.btnBuscarIDSP.Click += new System.EventHandler(this.btnBuscarIDSP_Click);
            // 
            // btnEliminarSP
            // 
            this.btnEliminarSP.Location = new System.Drawing.Point(19, 340);
            this.btnEliminarSP.Name = "btnEliminarSP";
            this.btnEliminarSP.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarSP.TabIndex = 46;
            this.btnEliminarSP.Text = "Eliminar ";
            this.btnEliminarSP.UseVisualStyleBackColor = true;
            // 
            // btnBuscarTodosSP
            // 
            this.btnBuscarTodosSP.Location = new System.Drawing.Point(130, 340);
            this.btnBuscarTodosSP.Name = "btnBuscarTodosSP";
            this.btnBuscarTodosSP.Size = new System.Drawing.Size(104, 23);
            this.btnBuscarTodosSP.TabIndex = 45;
            this.btnBuscarTodosSP.Text = "Buscar Todos ";
            this.btnBuscarTodosSP.UseVisualStyleBackColor = true;
            this.btnBuscarTodosSP.Click += new System.EventHandler(this.btnBuscarTodosSP_Click);
            // 
            // btnActualizarSP
            // 
            this.btnActualizarSP.Location = new System.Drawing.Point(84, 393);
            this.btnActualizarSP.Name = "btnActualizarSP";
            this.btnActualizarSP.Size = new System.Drawing.Size(84, 23);
            this.btnActualizarSP.TabIndex = 44;
            this.btnActualizarSP.Text = "Actualizar ";
            this.btnActualizarSP.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(380, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 43;
            // 
            // btnGuardarSP
            // 
            this.btnGuardarSP.Location = new System.Drawing.Point(10, 286);
            this.btnGuardarSP.Name = "btnGuardarSP";
            this.btnGuardarSP.Size = new System.Drawing.Size(112, 29);
            this.btnGuardarSP.TabIndex = 42;
            this.btnGuardarSP.Text = "Guardar ";
            this.btnGuardarSP.UseVisualStyleBackColor = true;
            this.btnGuardarSP.Click += new System.EventHandler(this.btnGuardarSP_Click);
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Items.AddRange(new object[] {
            "Estandar",
            "Medio",
            "Profesional",
            "Experto"});
            this.cmbNivel.Location = new System.Drawing.Point(113, 248);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(121, 21);
            this.cmbNivel.TabIndex = 41;
            // 
            // ckbEstatus
            // 
            this.ckbEstatus.AutoSize = true;
            this.ckbEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEstatus.Location = new System.Drawing.Point(51, 204);
            this.ckbEstatus.Name = "ckbEstatus";
            this.ckbEstatus.Size = new System.Drawing.Size(90, 24);
            this.ckbEstatus.TabIndex = 40;
            this.ckbEstatus.Text = "Estatus";
            this.ckbEstatus.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "Nivel";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(113, 166);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(175, 20);
            this.txtEdad.TabIndex = 38;
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.Location = new System.Drawing.Point(170, 124);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(175, 20);
            this.txtApeMaterno.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Apellido Materno";
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.Location = new System.Drawing.Point(170, 79);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(175, 20);
            this.txtApePaterno.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Apellido Paterno";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(170, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 20);
            this.txtNombre.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 430);
            this.Controls.Add(this.dgvDeportistas);
            this.Controls.Add(this.btnBuscarIDSP);
            this.Controls.Add(this.btnEliminarSP);
            this.Controls.Add(this.btnBuscarTodosSP);
            this.Controls.Add(this.btnActualizarSP);
            this.Controls.Add(this.txtID);
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
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeportistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeportistas;
        private System.Windows.Forms.Button btnBuscarIDSP;
        private System.Windows.Forms.Button btnEliminarSP;
        private System.Windows.Forms.Button btnBuscarTodosSP;
        private System.Windows.Forms.Button btnActualizarSP;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnGuardarSP;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.CheckBox ckbEstatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
    }
}


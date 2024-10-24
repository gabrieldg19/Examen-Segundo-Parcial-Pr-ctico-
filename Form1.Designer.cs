namespace Examen_Segundo_Parcial__Práctico_
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
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            listVehiculos = new ListBox();
            comboTipoVehiculo = new ComboBox();
            chkSidecar = new CheckBox();
            txtTipo = new TextBox();
            txtPuertas = new TextBox();
            txtAño = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(511, 106);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 31;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(430, 106);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(349, 106);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 29;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // listVehiculos
            // 
            listVehiculos.FormattingEnabled = true;
            listVehiculos.ItemHeight = 15;
            listVehiculos.Location = new Point(346, 135);
            listVehiculos.Name = "listVehiculos";
            listVehiculos.Size = new Size(321, 109);
            listVehiculos.TabIndex = 28;
            // 
            // comboTipoVehiculo
            // 
            comboTipoVehiculo.FormattingEnabled = true;
            comboTipoVehiculo.Items.AddRange(new object[] { "Automóvil", "Motocicleta", "Bicicleta" });
            comboTipoVehiculo.Location = new Point(446, 247);
            comboTipoVehiculo.Name = "comboTipoVehiculo";
            comboTipoVehiculo.Size = new Size(121, 23);
            comboTipoVehiculo.TabIndex = 27;
            // 
            // chkSidecar
            // 
            chkSidecar.AutoSize = true;
            chkSidecar.Location = new Point(673, 182);
            chkSidecar.Name = "chkSidecar";
            chkSidecar.Size = new Size(64, 19);
            chkSidecar.TabIndex = 26;
            chkSidecar.Text = "Sidecar";
            chkSidecar.UseVisualStyleBackColor = true;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(240, 247);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 25;
            // 
            // txtPuertas
            // 
            txtPuertas.Location = new Point(241, 216);
            txtPuertas.Name = "txtPuertas";
            txtPuertas.Size = new Size(100, 23);
            txtPuertas.TabIndex = 24;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(241, 178);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(100, 23);
            txtAño.TabIndex = 23;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(240, 147);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 22;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(240, 111);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(346, 253);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 20;
            label5.Text = "Tipo de Vehículo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 216);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 19;
            label4.Text = "Número de Puertas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 181);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 18;
            label3.Text = "Año";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 155);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 17;
            label2.Text = "Modelo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 119);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 16;
            label1.Text = "Marca";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(205, 247);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 32;
            label6.Text = "Tipo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(listVehiculos);
            Controls.Add(comboTipoVehiculo);
            Controls.Add(chkSidecar);
            Controls.Add(txtTipo);
            Controls.Add(txtPuertas);
            Controls.Add(txtAño);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnAgregar;
        private ListBox listVehiculos;
        private ComboBox comboTipoVehiculo;
        private CheckBox chkSidecar;
        private TextBox txtTipo;
        private TextBox txtPuertas;
        private TextBox txtAño;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
    }
}
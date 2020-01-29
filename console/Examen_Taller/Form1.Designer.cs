namespace Examen_Taller
{
    partial class titulo
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
            this.personales = new System.Windows.Forms.GroupBox();
            this.nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bancarios = new System.Windows.Forms.GroupBox();
            this.ejecucion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.saldo = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ejecutar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.edicion = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.sexo = new System.Windows.Forms.GroupBox();
            this.otro = new System.Windows.Forms.RadioButton();
            this.masculino = new System.Windows.Forms.RadioButton();
            this.femenino = new System.Windows.Forms.RadioButton();
            this.operacion = new System.Windows.Forms.GroupBox();
            this.consulta = new System.Windows.Forms.RadioButton();
            this.retiro = new System.Windows.Forms.RadioButton();
            this.deposito = new System.Windows.Forms.RadioButton();
            this.personales.SuspendLayout();
            this.bancarios.SuspendLayout();
            this.sexo.SuspendLayout();
            this.operacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // personales
            // 
            this.personales.Controls.Add(this.sexo);
            this.personales.Controls.Add(this.direccion);
            this.personales.Controls.Add(this.label1);
            this.personales.Controls.Add(this.nacimiento);
            this.personales.Controls.Add(this.label4);
            this.personales.Controls.Add(this.apellido);
            this.personales.Controls.Add(this.nombre);
            this.personales.Controls.Add(this.label3);
            this.personales.Controls.Add(this.label2);
            this.personales.Enabled = false;
            this.personales.Location = new System.Drawing.Point(12, 12);
            this.personales.Name = "personales";
            this.personales.Size = new System.Drawing.Size(610, 244);
            this.personales.TabIndex = 22;
            this.personales.TabStop = false;
            this.personales.Text = "Datos Personales";
            this.personales.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nacimiento
            // 
            this.nacimiento.Location = new System.Drawing.Point(182, 119);
            this.nacimiento.Name = "nacimiento";
            this.nacimiento.Size = new System.Drawing.Size(200, 20);
            this.nacimiento.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(109, 76);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 14;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(109, 39);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            // 
            // bancarios
            // 
            this.bancarios.Controls.Add(this.operacion);
            this.bancarios.Controls.Add(this.limpiar);
            this.bancarios.Controls.Add(this.ejecutar);
            this.bancarios.Controls.Add(this.ejecucion);
            this.bancarios.Controls.Add(this.label7);
            this.bancarios.Controls.Add(this.saldo);
            this.bancarios.Controls.Add(this.cantidad);
            this.bancarios.Controls.Add(this.label8);
            this.bancarios.Controls.Add(this.label9);
            this.bancarios.Enabled = false;
            this.bancarios.Location = new System.Drawing.Point(12, 262);
            this.bancarios.Name = "bancarios";
            this.bancarios.Size = new System.Drawing.Size(610, 247);
            this.bancarios.TabIndex = 23;
            this.bancarios.TabStop = false;
            this.bancarios.Text = "Datos Bancarios";
            // 
            // ejecucion
            // 
            this.ejecucion.Location = new System.Drawing.Point(192, 108);
            this.ejecucion.Name = "ejecucion";
            this.ejecucion.Size = new System.Drawing.Size(200, 20);
            this.ejecucion.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fecha de ejecucion";
            // 
            // saldo
            // 
            this.saldo.Location = new System.Drawing.Point(119, 65);
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            this.saldo.Size = new System.Drawing.Size(100, 20);
            this.saldo.TabIndex = 25;
            this.saldo.TextChanged += new System.EventHandler(this.saldo_TextChanged);
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(119, 28);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(100, 20);
            this.cantidad.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Saldo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Cantidad";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(450, 46);
            this.direccion.Multiline = true;
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(136, 178);
            this.direccion.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Direccion:";
            // 
            // ejecutar
            // 
            this.ejecutar.Location = new System.Drawing.Point(450, 24);
            this.ejecutar.Name = "ejecutar";
            this.ejecutar.Size = new System.Drawing.Size(75, 23);
            this.ejecutar.TabIndex = 32;
            this.ejecutar.Text = "Ejecutar";
            this.ejecutar.UseVisualStyleBackColor = true;
            this.ejecutar.Click += new System.EventHandler(this.ejecutar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(450, 76);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 33;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // edicion
            // 
            this.edicion.Location = new System.Drawing.Point(668, 41);
            this.edicion.Name = "edicion";
            this.edicion.Size = new System.Drawing.Size(75, 23);
            this.edicion.TabIndex = 24;
            this.edicion.Text = "Edicion";
            this.edicion.UseVisualStyleBackColor = true;
            this.edicion.Click += new System.EventHandler(this.edicion_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(668, 88);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 25;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // sexo
            // 
            this.sexo.Controls.Add(this.otro);
            this.sexo.Controls.Add(this.masculino);
            this.sexo.Controls.Add(this.femenino);
            this.sexo.Location = new System.Drawing.Point(59, 166);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(323, 71);
            this.sexo.TabIndex = 23;
            this.sexo.TabStop = false;
            this.sexo.Text = "Sexo";
            // 
            // otro
            // 
            this.otro.AutoSize = true;
            this.otro.Location = new System.Drawing.Point(245, 27);
            this.otro.Name = "otro";
            this.otro.Size = new System.Drawing.Size(45, 17);
            this.otro.TabIndex = 23;
            this.otro.Text = "Otro";
            this.otro.UseVisualStyleBackColor = true;
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.Checked = true;
            this.masculino.Location = new System.Drawing.Point(145, 27);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(73, 17);
            this.masculino.TabIndex = 22;
            this.masculino.TabStop = true;
            this.masculino.Text = "Masculino";
            this.masculino.UseVisualStyleBackColor = true;
            // 
            // femenino
            // 
            this.femenino.AutoSize = true;
            this.femenino.Location = new System.Drawing.Point(42, 27);
            this.femenino.Name = "femenino";
            this.femenino.Size = new System.Drawing.Size(71, 17);
            this.femenino.TabIndex = 21;
            this.femenino.Text = "Femenino";
            this.femenino.UseVisualStyleBackColor = true;
            // 
            // operacion
            // 
            this.operacion.Controls.Add(this.consulta);
            this.operacion.Controls.Add(this.retiro);
            this.operacion.Controls.Add(this.deposito);
            this.operacion.Location = new System.Drawing.Point(59, 154);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(323, 86);
            this.operacion.TabIndex = 34;
            this.operacion.TabStop = false;
            this.operacion.Text = "Operacion";
            // 
            // consulta
            // 
            this.consulta.AutoSize = true;
            this.consulta.Checked = true;
            this.consulta.Location = new System.Drawing.Point(230, 35);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(66, 17);
            this.consulta.TabIndex = 34;
            this.consulta.TabStop = true;
            this.consulta.Text = "Consulta";
            this.consulta.UseVisualStyleBackColor = true;
            // 
            // retiro
            // 
            this.retiro.AutoSize = true;
            this.retiro.Location = new System.Drawing.Point(130, 35);
            this.retiro.Name = "retiro";
            this.retiro.Size = new System.Drawing.Size(53, 17);
            this.retiro.TabIndex = 33;
            this.retiro.Text = "Retiro";
            this.retiro.UseVisualStyleBackColor = true;
            // 
            // deposito
            // 
            this.deposito.AutoSize = true;
            this.deposito.Location = new System.Drawing.Point(27, 35);
            this.deposito.Name = "deposito";
            this.deposito.Size = new System.Drawing.Size(67, 17);
            this.deposito.TabIndex = 32;
            this.deposito.Text = "Deposito";
            this.deposito.UseVisualStyleBackColor = true;
            // 
            // titulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.edicion);
            this.Controls.Add(this.bancarios);
            this.Controls.Add(this.personales);
            this.Name = "titulo";
            this.Text = "Servicios Financieros SA de CV";
            this.Load += new System.EventHandler(this.titulo_Load);
            this.personales.ResumeLayout(false);
            this.personales.PerformLayout();
            this.bancarios.ResumeLayout(false);
            this.bancarios.PerformLayout();
            this.sexo.ResumeLayout(false);
            this.sexo.PerformLayout();
            this.operacion.ResumeLayout(false);
            this.operacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox personales;
        private System.Windows.Forms.DateTimePicker nacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox bancarios;
        private System.Windows.Forms.DateTimePicker ejecucion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox saldo;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button ejecutar;
        private System.Windows.Forms.Button edicion;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.GroupBox sexo;
        private System.Windows.Forms.RadioButton otro;
        private System.Windows.Forms.RadioButton masculino;
        private System.Windows.Forms.RadioButton femenino;
        private System.Windows.Forms.GroupBox operacion;
        private System.Windows.Forms.RadioButton consulta;
        private System.Windows.Forms.RadioButton retiro;
        private System.Windows.Forms.RadioButton deposito;
    }
}


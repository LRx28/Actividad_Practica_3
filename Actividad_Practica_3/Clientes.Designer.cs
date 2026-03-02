namespace Actividad_Practica_3
{
    partial class Clientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            insertar_Gpb = new GroupBox();
            btn_Agregar = new Button();
            label5 = new Label();
            txt_Direccion = new TextBox();
            label4 = new Label();
            txt_Telefono = new TextBox();
            label2 = new Label();
            txt_Correo = new TextBox();
            label1 = new Label();
            txt_Nombre = new TextBox();
            Eliminar = new GroupBox();
            btn_Eliminar = new Button();
            txt_IdEliminar = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label10 = new Label();
            btn_Actualizar = new Button();
            txt_NombreActualizado = new TextBox();
            label6 = new Label();
            txt_DireccionActualizada = new TextBox();
            label7 = new Label();
            txt_TelefonoActualizado = new TextBox();
            label8 = new Label();
            txt_CorreoActualizado = new TextBox();
            label9 = new Label();
            txt_IDActualizado = new TextBox();
            groupBox2 = new GroupBox();
            btn_Cargar = new Button();
            dgv_Mostrar = new DataGridView();
            insertar_Gpb.SuspendLayout();
            Eliminar.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Mostrar).BeginInit();
            SuspendLayout();
            // 
            // insertar_Gpb
            // 
            insertar_Gpb.Controls.Add(btn_Agregar);
            insertar_Gpb.Controls.Add(label5);
            insertar_Gpb.Controls.Add(txt_Direccion);
            insertar_Gpb.Controls.Add(label4);
            insertar_Gpb.Controls.Add(txt_Telefono);
            insertar_Gpb.Controls.Add(label2);
            insertar_Gpb.Controls.Add(txt_Correo);
            insertar_Gpb.Controls.Add(label1);
            insertar_Gpb.Controls.Add(txt_Nombre);
            insertar_Gpb.Location = new Point(3, 12);
            insertar_Gpb.Name = "insertar_Gpb";
            insertar_Gpb.Size = new Size(447, 233);
            insertar_Gpb.TabIndex = 0;
            insertar_Gpb.TabStop = false;
            insertar_Gpb.Text = "Insertar";
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(144, 164);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(150, 45);
            btn_Agregar.TabIndex = 8;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 91);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 7;
            label5.Text = "Direccion";
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(227, 114);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(205, 27);
            txt_Direccion.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 31);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 5;
            label4.Text = "Telefono";
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(227, 54);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(205, 27);
            txt_Telefono.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 91);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 3;
            label2.Text = "Correo electronico";
            // 
            // txt_Correo
            // 
            txt_Correo.Location = new Point(9, 114);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.Size = new Size(201, 27);
            txt_Correo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 31);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(9, 54);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(182, 27);
            txt_Nombre.TabIndex = 0;
            // 
            // Eliminar
            // 
            Eliminar.Controls.Add(btn_Eliminar);
            Eliminar.Controls.Add(txt_IdEliminar);
            Eliminar.Controls.Add(label3);
            Eliminar.Location = new Point(456, 12);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(244, 233);
            Eliminar.TabIndex = 1;
            Eliminar.TabStop = false;
            Eliminar.Text = "Eliminar";
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(20, 105);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(182, 45);
            btn_Eliminar.TabIndex = 9;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // txt_IdEliminar
            // 
            txt_IdEliminar.Location = new Point(6, 54);
            txt_IdEliminar.Name = "txt_IdEliminar";
            txt_IdEliminar.Size = new Size(215, 27);
            txt_IdEliminar.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 31);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btn_Actualizar);
            groupBox1.Controls.Add(txt_NombreActualizado);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_DireccionActualizada);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txt_TelefonoActualizado);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txt_CorreoActualizado);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txt_IDActualizado);
            groupBox1.Location = new Point(706, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 233);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = " Actualizar";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(2, 94);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 10;
            label10.Text = "Nombre";
            // 
            // btn_Actualizar
            // 
            btn_Actualizar.Location = new Point(321, 168);
            btn_Actualizar.Name = "btn_Actualizar";
            btn_Actualizar.Size = new Size(150, 45);
            btn_Actualizar.TabIndex = 8;
            btn_Actualizar.Text = "Actualizar";
            btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // txt_NombreActualizado
            // 
            txt_NombreActualizado.Location = new Point(2, 117);
            txt_NombreActualizado.Name = "txt_NombreActualizado";
            txt_NombreActualizado.Size = new Size(201, 27);
            txt_NombreActualizado.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(227, 87);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 7;
            label6.Text = "Direccion";
            // 
            // txt_DireccionActualizada
            // 
            txt_DireccionActualizada.Location = new Point(225, 117);
            txt_DireccionActualizada.Name = "txt_DireccionActualizada";
            txt_DireccionActualizada.Size = new Size(219, 27);
            txt_DireccionActualizada.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(227, 27);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 5;
            label7.Text = "Telefono";
            // 
            // txt_TelefonoActualizado
            // 
            txt_TelefonoActualizado.Location = new Point(227, 50);
            txt_TelefonoActualizado.Name = "txt_TelefonoActualizado";
            txt_TelefonoActualizado.Size = new Size(217, 27);
            txt_TelefonoActualizado.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 154);
            label8.Name = "label8";
            label8.Size = new Size(132, 20);
            label8.TabIndex = 3;
            label8.Text = "Correo electronico";
            // 
            // txt_CorreoActualizado
            // 
            txt_CorreoActualizado.Location = new Point(9, 177);
            txt_CorreoActualizado.Name = "txt_CorreoActualizado";
            txt_CorreoActualizado.Size = new Size(285, 27);
            txt_CorreoActualizado.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 29);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 1;
            label9.Text = "ID";
            // 
            // txt_IDActualizado
            // 
            txt_IDActualizado.Location = new Point(6, 51);
            txt_IDActualizado.Name = "txt_IDActualizado";
            txt_IDActualizado.Size = new Size(197, 27);
            txt_IDActualizado.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Cargar);
            groupBox2.Controls.Add(dgv_Mostrar);
            groupBox2.Location = new Point(3, 265);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1191, 388);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mostrar";
            // 
            // btn_Cargar
            // 
            btn_Cargar.Location = new Point(296, 26);
            btn_Cargar.Name = "btn_Cargar";
            btn_Cargar.Size = new Size(508, 59);
            btn_Cargar.TabIndex = 9;
            btn_Cargar.Text = "Cargar";
            btn_Cargar.UseVisualStyleBackColor = true;
            btn_Cargar.Click += btn_Cargar_Click;
            // 
            // dgv_Mostrar
            // 
            dgv_Mostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Mostrar.Location = new Point(0, 117);
            dgv_Mostrar.Name = "dgv_Mostrar";
            dgv_Mostrar.RowHeadersWidth = 51;
            dgv_Mostrar.Size = new Size(1196, 271);
            dgv_Mostrar.TabIndex = 0;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 655);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Eliminar);
            Controls.Add(insertar_Gpb);
            Name = "Clientes";
            Text = "Clientes";
            insertar_Gpb.ResumeLayout(false);
            insertar_Gpb.PerformLayout();
            Eliminar.ResumeLayout(false);
            Eliminar.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Mostrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox insertar_Gpb;
        private TextBox txt_Nombre;
        private Label label1;
        private Label label2;
        private TextBox txt_Correo;
        private Button btn_Agregar;
        private Label label5;
        private TextBox txt_Direccion;
        private Label label4;
        private TextBox txt_Telefono;
        private GroupBox Eliminar;
        private Button btn_Eliminar;
        private TextBox txt_IdEliminar;
        private Label label3;
        private GroupBox groupBox1;
        private Button btn_Actualizar;
        private Label label6;
        private TextBox txt_DireccionActualizada;
        private Label label7;
        private TextBox txt_TelefonoActualizado;
        private Label label8;
        private TextBox txt_CorreoActualizado;
        private Label label9;
        private TextBox txt_IDActualizado;
        private Label label10;
        private TextBox txt_NombreActualizado;
        private GroupBox groupBox2;
        private Button btn_Cargar;
        private DataGridView dgv_Mostrar;
    }
}

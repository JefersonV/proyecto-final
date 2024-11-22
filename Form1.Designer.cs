namespace proyecto_final
{
    partial class Form1
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
            tabControl1 = new TabControl();
            no = new TabPage();
            idTarjeta = new TabPage();
            propietario = new TabPage();
            presente = new TabPage();
            horaEntrada = new TabPage();
            horaSalida = new TabPage();
            isManual = new TabPage();
            rechazados = new TabPage();
            label1 = new Label();
            button1 = new Button();
            abrirPuertaBtn = new Button();
            cerrarPuertaBtn = new Button();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(no);
            tabControl1.Controls.Add(idTarjeta);
            tabControl1.Controls.Add(propietario);
            tabControl1.Controls.Add(presente);
            tabControl1.Controls.Add(horaEntrada);
            tabControl1.Controls.Add(horaSalida);
            tabControl1.Controls.Add(isManual);
            tabControl1.Controls.Add(rechazados);
            tabControl1.Location = new Point(80, 95);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(880, 331);
            tabControl1.TabIndex = 0;
            // 
            // no
            // 
            no.Location = new Point(4, 29);
            no.Name = "no";
            no.Padding = new Padding(3);
            no.Size = new Size(872, 298);
            no.TabIndex = 0;
            no.Text = "#";
            no.UseVisualStyleBackColor = true;
            no.Click += tabPage1_Click;
            // 
            // idTarjeta
            // 
            idTarjeta.Location = new Point(4, 29);
            idTarjeta.Name = "idTarjeta";
            idTarjeta.Padding = new Padding(3);
            idTarjeta.Size = new Size(872, 298);
            idTarjeta.TabIndex = 1;
            idTarjeta.Text = "Id Tarjeta";
            idTarjeta.UseVisualStyleBackColor = true;
            // 
            // propietario
            // 
            propietario.Location = new Point(4, 29);
            propietario.Name = "propietario";
            propietario.Size = new Size(872, 298);
            propietario.TabIndex = 2;
            propietario.Text = "Propietario";
            propietario.UseVisualStyleBackColor = true;
            // 
            // presente
            // 
            presente.Location = new Point(4, 29);
            presente.Name = "presente";
            presente.Size = new Size(872, 298);
            presente.TabIndex = 5;
            presente.Text = "Presente";
            presente.UseVisualStyleBackColor = true;
            presente.Click += fecha_Click;
            // 
            // horaEntrada
            // 
            horaEntrada.Location = new Point(4, 29);
            horaEntrada.Name = "horaEntrada";
            horaEntrada.Padding = new Padding(3);
            horaEntrada.Size = new Size(872, 298);
            horaEntrada.TabIndex = 3;
            horaEntrada.Text = "Hora entrada";
            horaEntrada.UseVisualStyleBackColor = true;
            // 
            // horaSalida
            // 
            horaSalida.Location = new Point(4, 29);
            horaSalida.Name = "horaSalida";
            horaSalida.Padding = new Padding(3);
            horaSalida.Size = new Size(872, 298);
            horaSalida.TabIndex = 4;
            horaSalida.Text = "Hora Salida";
            horaSalida.UseVisualStyleBackColor = true;
            // 
            // isManual
            // 
            isManual.BackColor = Color.OrangeRed;
            isManual.Location = new Point(4, 29);
            isManual.Name = "isManual";
            isManual.RightToLeft = RightToLeft.Yes;
            isManual.Size = new Size(872, 298);
            isManual.TabIndex = 6;
            isManual.Text = "Manual";
            // 
            // rechazados
            // 
            rechazados.BackColor = Color.SkyBlue;
            rechazados.Location = new Point(4, 29);
            rechazados.Name = "rechazados";
            rechazados.Size = new Size(872, 298);
            rechazados.TabIndex = 7;
            rechazados.Text = "rechazados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(123, 28);
            label1.Name = "label1";
            label1.Size = new Size(183, 31);
            label1.TabIndex = 2;
            label1.Text = "Control Peatonal";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(614, 457);
            button1.Name = "button1";
            button1.Size = new Size(119, 51);
            button1.TabIndex = 1;
            button1.Text = "Imprimir Reporte";
            button1.UseVisualStyleBackColor = false;
            // 
            // abrirPuertaBtn
            // 
            abrirPuertaBtn.BackColor = SystemColors.Highlight;
            abrirPuertaBtn.ForeColor = SystemColors.ButtonFace;
            abrirPuertaBtn.Location = new Point(187, 457);
            abrirPuertaBtn.Name = "abrirPuertaBtn";
            abrirPuertaBtn.Size = new Size(119, 51);
            abrirPuertaBtn.TabIndex = 3;
            abrirPuertaBtn.Text = "Abrir puerta";
            abrirPuertaBtn.UseVisualStyleBackColor = false;
            abrirPuertaBtn.Click += button2_Click;
            // 
            // cerrarPuertaBtn
            // 
            cerrarPuertaBtn.BackColor = SystemColors.Highlight;
            cerrarPuertaBtn.ForeColor = SystemColors.ButtonFace;
            cerrarPuertaBtn.Location = new Point(374, 457);
            cerrarPuertaBtn.Name = "cerrarPuertaBtn";
            cerrarPuertaBtn.Size = new Size(119, 51);
            cerrarPuertaBtn.TabIndex = 4;
            cerrarPuertaBtn.Text = "Cerrar puerta";
            cerrarPuertaBtn.UseVisualStyleBackColor = false;
            cerrarPuertaBtn.Click += cerrrPuertaBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 540);
            Controls.Add(cerrarPuertaBtn);
            Controls.Add(abrirPuertaBtn);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage no;
        private TabPage idTarjeta;
        private TabPage propietario;
        private Label label1;
        private TabPage horaEntrada;
        private TabPage horaSalida;
        private TabPage presente;
        private Button button1;
        private Button abrirPuertaBtn;
        private TabPage isManual;
        private TabPage rechazados;
        private Button cerrarPuertaBtn;
    }
}

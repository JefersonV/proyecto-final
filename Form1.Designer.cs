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
            label1 = new Label();
            button1 = new Button();
            abrirPuertaBtn = new Button();
            cerrarPuertaBtn = new Button();
            dataGridView1 = new DataGridView();
            lbltest = new Label();
            btnUpdataData = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(76, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(775, 188);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbltest
            // 
            lbltest.AutoSize = true;
            lbltest.Location = new Point(123, 371);
            lbltest.Name = "lbltest";
            lbltest.Size = new Size(50, 20);
            lbltest.TabIndex = 6;
            lbltest.Text = "label2";
            lbltest.Click += lbltest_Click;
            // 
            // btnUpdataData
            // 
            btnUpdataData.Location = new Point(821, 457);
            btnUpdataData.Name = "btnUpdataData";
            btnUpdataData.Size = new Size(94, 29);
            btnUpdataData.TabIndex = 7;
            btnUpdataData.Text = "button2";
            btnUpdataData.UseVisualStyleBackColor = true;
            btnUpdataData.Click += btnUpdataData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 540);
            Controls.Add(btnUpdataData);
            Controls.Add(lbltest);
            Controls.Add(dataGridView1);
            Controls.Add(cerrarPuertaBtn);
            Controls.Add(abrirPuertaBtn);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button abrirPuertaBtn;
        private Button cerrarPuertaBtn;
        private DataGridView dataGridView1;
        private Label lbltest;
        private Button btnUpdataData;
    }
    partial class MainForm
    {
        private void InitializeComponent()
        {
            //this.SuspendLayout();
            // 
            // MainForm
            // 
            //this.ClientSize = new System.Drawing.Size(800, 450);
            //this.Name = "MainForm";
            //this.Text = "RFID Reader";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            //this.ResumeLayout(false);
        }
    }
}

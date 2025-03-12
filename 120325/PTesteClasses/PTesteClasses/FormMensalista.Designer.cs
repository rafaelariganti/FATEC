namespace PTesteClasses
{
    partial class FormMensalista
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(400, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(400, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(347, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(400, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(400, 184);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtMatricula
            // 
            this.txtMatricula.AutoSize = true;
            this.txtMatricula.Location = new System.Drawing.Point(181, 52);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(77, 20);
            this.txtMatricula.TabIndex = 4;
            this.txtMatricula.Text = "Matrícula:";
            this.txtMatricula.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Location = new System.Drawing.Point(181, 97);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(55, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.Text = "Nome:";
            this.txtNome.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.AutoSize = true;
            this.txtSalario.Location = new System.Drawing.Point(181, 142);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(117, 20);
            this.txtSalario.TabIndex = 6;
            this.txtSalario.Text = "Salário Mensal:";
            this.txtSalario.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtData
            // 
            this.txtData.AutoSize = true;
            this.txtData.Location = new System.Drawing.Point(181, 187);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(199, 20);
            this.txtData.TabIndex = 7;
            this.txtData.Text = "Data Entrada na Empresa:";
            this.txtData.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 100);
            this.button1.TabIndex = 8;
            this.button1.Text = "Instanciar Mensalista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 100);
            this.button2.TabIndex = 9;
            this.button2.Text = "Instanciar Mensalista passando parâmetros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FormMensalista";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label txtMatricula;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtSalario;
        private System.Windows.Forms.Label txtData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
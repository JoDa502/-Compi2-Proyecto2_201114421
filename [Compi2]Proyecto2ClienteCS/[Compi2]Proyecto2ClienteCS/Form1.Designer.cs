namespace _Compi2_Proyecto2ClienteCS
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
            this.buttonNuevaPestaña = new System.Windows.Forms.Button();
            this.tabResultados = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxResultados = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControlComandos = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonCerrarPestaña = new System.Windows.Forms.Button();
            this.tabResultados.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControlComandos.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNuevaPestaña
            // 
            this.buttonNuevaPestaña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevaPestaña.Location = new System.Drawing.Point(855, 56);
            this.buttonNuevaPestaña.Name = "buttonNuevaPestaña";
            this.buttonNuevaPestaña.Size = new System.Drawing.Size(95, 51);
            this.buttonNuevaPestaña.TabIndex = 1;
            this.buttonNuevaPestaña.Text = "Nueva Pesaña";
            this.buttonNuevaPestaña.UseVisualStyleBackColor = true;
            this.buttonNuevaPestaña.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabResultados
            // 
            this.tabResultados.Controls.Add(this.tabPage1);
            this.tabResultados.Controls.Add(this.tabPage2);
            this.tabResultados.Controls.Add(this.tabPage3);
            this.tabResultados.Location = new System.Drawing.Point(12, 229);
            this.tabResultados.Name = "tabResultados";
            this.tabResultados.SelectedIndex = 0;
            this.tabResultados.Size = new System.Drawing.Size(938, 240);
            this.tabResultados.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(930, 214);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tabla de Simbolos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxResultados);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(930, 214);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resultados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxResultados
            // 
            this.textBoxResultados.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBoxResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultados.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxResultados.Location = new System.Drawing.Point(0, 0);
            this.textBoxResultados.Multiline = true;
            this.textBoxResultados.Name = "textBoxResultados";
            this.textBoxResultados.Size = new System.Drawing.Size(930, 214);
            this.textBoxResultados.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(930, 214);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Errores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControlComandos
            // 
            this.tabControlComandos.Controls.Add(this.tabPage4);
            this.tabControlComandos.Location = new System.Drawing.Point(16, 34);
            this.tabControlComandos.Name = "tabControlComandos";
            this.tabControlComandos.SelectedIndex = 0;
            this.tabControlComandos.Size = new System.Drawing.Size(833, 189);
            this.tabControlComandos.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(825, 163);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Lineas de Comando 1 ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(825, 163);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pestañas de Comandos :::";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(855, 167);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(95, 48);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonCerrarPestaña
            // 
            this.buttonCerrarPestaña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarPestaña.Location = new System.Drawing.Point(855, 113);
            this.buttonCerrarPestaña.Name = "buttonCerrarPestaña";
            this.buttonCerrarPestaña.Size = new System.Drawing.Size(95, 48);
            this.buttonCerrarPestaña.TabIndex = 6;
            this.buttonCerrarPestaña.Text = "Cerrar Pesaña";
            this.buttonCerrarPestaña.UseVisualStyleBackColor = true;
            this.buttonCerrarPestaña.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 481);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonCerrarPestaña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControlComandos);
            this.Controls.Add(this.tabResultados);
            this.Controls.Add(this.buttonNuevaPestaña);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabResultados.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControlComandos.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNuevaPestaña;
        private System.Windows.Forms.TabControl tabResultados;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControlComandos;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonCerrarPestaña;
        private System.Windows.Forms.TextBox textBoxResultados;
    }
}


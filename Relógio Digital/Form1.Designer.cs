namespace Relógio_Digital
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minutos = new System.Windows.Forms.Button();
            this.segundos = new System.Windows.Forms.Button();
            this.horas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(110)))));
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 194);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(138, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(537, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(340, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // minutos
            // 
            this.minutos.BackColor = System.Drawing.Color.MistyRose;
            this.minutos.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutos.Location = new System.Drawing.Point(317, 53);
            this.minutos.Name = "minutos";
            this.minutos.Size = new System.Drawing.Size(155, 51);
            this.minutos.TabIndex = 6;
            this.minutos.Text = "Minutos";
            this.minutos.UseVisualStyleBackColor = false;
            this.minutos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Acerta_Relogio);
            // 
            // segundos
            // 
            this.segundos.BackColor = System.Drawing.Color.MistyRose;
            this.segundos.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundos.Location = new System.Drawing.Point(496, 53);
            this.segundos.Name = "segundos";
            this.segundos.Size = new System.Drawing.Size(155, 51);
            this.segundos.TabIndex = 5;
            this.segundos.Text = "Segundos";
            this.segundos.UseVisualStyleBackColor = false;
            this.segundos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Acerta_Relogio);
            // 
            // horas
            // 
            this.horas.BackColor = System.Drawing.Color.MistyRose;
            this.horas.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horas.Location = new System.Drawing.Point(138, 53);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(155, 51);
            this.horas.TabIndex = 4;
            this.horas.Text = "Horas";
            this.horas.UseVisualStyleBackColor = false;
            this.horas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Acerta_Relogio);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.minutos);
            this.Controls.Add(this.segundos);
            this.Controls.Add(this.horas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button minutos;
        private System.Windows.Forms.Button segundos;
        private System.Windows.Forms.Button horas;
    }
}


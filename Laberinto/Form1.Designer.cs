namespace Laberinto
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelPerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textPersonaje = new System.Windows.Forms.TextBox();
            this.botonEntrenar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textActual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.botonExplotar = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textNumEntr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.trackVel = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picturePersonaje = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCantEnt = new System.Windows.Forms.Label();
            this.textCantEnt = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackVel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePersonaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 602);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SelPerButton
            // 
            this.SelPerButton.Location = new System.Drawing.Point(688, 366);
            this.SelPerButton.Name = "SelPerButton";
            this.SelPerButton.Size = new System.Drawing.Size(227, 23);
            this.SelPerButton.TabIndex = 6;
            this.SelPerButton.Text = "Seleccionar Personaje";
            this.SelPerButton.UseVisualStyleBackColor = true;
            this.SelPerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(704, 140);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Personaje Seleccionado:";
            // 
            // textPersonaje
            // 
            this.textPersonaje.Enabled = false;
            this.textPersonaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPersonaje.Location = new System.Drawing.Point(708, 163);
            this.textPersonaje.Name = "textPersonaje";
            this.textPersonaje.Size = new System.Drawing.Size(180, 22);
            this.textPersonaje.TabIndex = 8;
            // 
            // botonEntrenar
            // 
            this.botonEntrenar.Location = new System.Drawing.Point(678, 633);
            this.botonEntrenar.Name = "botonEntrenar";
            this.botonEntrenar.Size = new System.Drawing.Size(75, 23);
            this.botonEntrenar.TabIndex = 11;
            this.botonEntrenar.Text = "Entrenar";
            this.botonEntrenar.UseVisualStyleBackColor = true;
            this.botonEntrenar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 642);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 642);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Final:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(84, 642);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 22);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(302, 642);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 22);
            this.textBox2.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(846, 685);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textActual
            // 
            this.textActual.Enabled = false;
            this.textActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textActual.Location = new System.Drawing.Point(528, 642);
            this.textActual.Name = "textActual";
            this.textActual.Size = new System.Drawing.Size(129, 22);
            this.textActual.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(461, 642);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Actual:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(840, 633);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Pausa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // botonExplotar
            // 
            this.botonExplotar.Location = new System.Drawing.Point(759, 633);
            this.botonExplotar.Name = "botonExplotar";
            this.botonExplotar.Size = new System.Drawing.Size(75, 23);
            this.botonExplotar.TabIndex = 26;
            this.botonExplotar.Text = "Explotar";
            this.botonExplotar.UseVisualStyleBackColor = true;
            this.botonExplotar.Click += new System.EventHandler(this.botonExplotar_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // textNumEntr
            // 
            this.textNumEntr.Enabled = false;
            this.textNumEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumEntr.Location = new System.Drawing.Point(836, 576);
            this.textNumEntr.Name = "textNumEntr";
            this.textNumEntr.Size = new System.Drawing.Size(52, 22);
            this.textNumEntr.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(685, 579);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "No. Entrenamiento:";
            // 
            // trackVel
            // 
            this.trackVel.LargeChange = 500;
            this.trackVel.Location = new System.Drawing.Point(688, 525);
            this.trackVel.Maximum = 1000;
            this.trackVel.Minimum = -999;
            this.trackVel.Name = "trackVel";
            this.trackVel.Size = new System.Drawing.Size(227, 45);
            this.trackVel.SmallChange = 100;
            this.trackVel.TabIndex = 31;
            this.trackVel.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackVel.Scroll += new System.EventHandler(this.trackVel_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Rapido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(880, 557);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Lento";
            // 
            // picturePersonaje
            // 
            this.picturePersonaje.Location = new System.Drawing.Point(706, 191);
            this.picturePersonaje.Name = "picturePersonaje";
            this.picturePersonaje.Size = new System.Drawing.Size(182, 157);
            this.picturePersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePersonaje.TabIndex = 34;
            this.picturePersonaje.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Laberinto.Properties.Resources.bnf;
            this.pictureBox1.Location = new System.Drawing.Point(688, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 100);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // labelCantEnt
            // 
            this.labelCantEnt.AutoSize = true;
            this.labelCantEnt.Location = new System.Drawing.Point(685, 413);
            this.labelCantEnt.Name = "labelCantEnt";
            this.labelCantEnt.Size = new System.Drawing.Size(143, 13);
            this.labelCantEnt.TabIndex = 35;
            this.labelCantEnt.Text = "Cantidad de Entrenamientos:";
            // 
            // textCantEnt
            // 
            this.textCantEnt.Location = new System.Drawing.Point(834, 410);
            this.textCantEnt.Name = "textCantEnt";
            this.textCantEnt.Size = new System.Drawing.Size(80, 20);
            this.textCantEnt.TabIndex = 36;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 720);
            this.Controls.Add(this.textCantEnt);
            this.Controls.Add(this.labelCantEnt);
            this.Controls.Add(this.picturePersonaje);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackVel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textNumEntr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonExplotar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textActual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonEntrenar);
            this.Controls.Add(this.textPersonaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelPerButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackVel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePersonaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SelPerButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textPersonaje;
        private System.Windows.Forms.Button botonEntrenar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textActual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button botonExplotar;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textNumEntr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackVel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picturePersonaje;
        private System.Windows.Forms.Label labelCantEnt;
        private System.Windows.Forms.TextBox textCantEnt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}


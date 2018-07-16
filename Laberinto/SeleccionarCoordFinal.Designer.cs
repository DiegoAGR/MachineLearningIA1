namespace Laberinto
{
    partial class SeleccionarCoordFinal
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
            this.comboI = new System.Windows.Forms.ComboBox();
            this.comboJ = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboI
            // 
            this.comboI.FormattingEnabled = true;
            this.comboI.Location = new System.Drawing.Point(12, 24);
            this.comboI.Name = "comboI";
            this.comboI.Size = new System.Drawing.Size(121, 21);
            this.comboI.TabIndex = 0;
            // 
            // comboJ
            // 
            this.comboJ.FormattingEnabled = true;
            this.comboJ.Location = new System.Drawing.Point(151, 24);
            this.comboJ.Name = "comboJ";
            this.comboJ.Size = new System.Drawing.Size(121, 21);
            this.comboJ.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SeleccionarCoordFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 69);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboJ);
            this.Controls.Add(this.comboI);
            this.Name = "SeleccionarCoordFinal";
            this.Text = "SeleccionarCoordFinal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboI;
        private System.Windows.Forms.ComboBox comboJ;
        private System.Windows.Forms.Button button1;
    }
}
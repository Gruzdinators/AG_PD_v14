namespace AG_PD_v14
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nosaukums = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.poga = new System.Windows.Forms.Button();
            this.tsumma = new System.Windows.Forms.TextBox();
            this.cena = new System.Windows.Forms.NumericUpDown();
            this.daudzums = new System.Windows.Forms.NumericUpDown();
            this.daudzums2 = new System.Windows.Forms.NumericUpDown();
            this.cena2 = new System.Windows.Forms.NumericUpDown();
            this.nosaukums2 = new System.Windows.Forms.TextBox();
            this.daudzums3 = new System.Windows.Forms.NumericUpDown();
            this.cena3 = new System.Windows.Forms.NumericUpDown();
            this.nosaukums3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tnauda = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daudzums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daudzums2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cena2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daudzums3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cena3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tnauda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preces nosaukums";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena (Eiro)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Daudzums";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nosaukums
            // 
            this.nosaukums.Location = new System.Drawing.Point(29, 56);
            this.nosaukums.Name = "nosaukums";
            this.nosaukums.Size = new System.Drawing.Size(171, 20);
            this.nosaukums.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(565, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kopējā summa:";
            // 
            // poga
            // 
            this.poga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poga.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.poga.Location = new System.Drawing.Point(29, 196);
            this.poga.Name = "poga";
            this.poga.Size = new System.Drawing.Size(498, 217);
            this.poga.TabIndex = 7;
            this.poga.Text = "Aprēķināt";
            this.poga.UseVisualStyleBackColor = true;
            this.poga.Click += new System.EventHandler(this.poga_Click);
            // 
            // tsumma
            // 
            this.tsumma.Location = new System.Drawing.Point(570, 248);
            this.tsumma.Name = "tsumma";
            this.tsumma.Size = new System.Drawing.Size(147, 20);
            this.tsumma.TabIndex = 8;
            // 
            // cena
            // 
            this.cena.Location = new System.Drawing.Point(242, 55);
            this.cena.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(107, 20);
            this.cena.TabIndex = 9;
            // 
            // daudzums
            // 
            this.daudzums.Location = new System.Drawing.Point(385, 56);
            this.daudzums.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.daudzums.Name = "daudzums";
            this.daudzums.Size = new System.Drawing.Size(107, 20);
            this.daudzums.TabIndex = 10;
            // 
            // daudzums2
            // 
            this.daudzums2.Location = new System.Drawing.Point(385, 82);
            this.daudzums2.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.daudzums2.Name = "daudzums2";
            this.daudzums2.Size = new System.Drawing.Size(107, 20);
            this.daudzums2.TabIndex = 13;
            // 
            // cena2
            // 
            this.cena2.Location = new System.Drawing.Point(242, 81);
            this.cena2.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.cena2.Name = "cena2";
            this.cena2.Size = new System.Drawing.Size(107, 20);
            this.cena2.TabIndex = 12;
            // 
            // nosaukums2
            // 
            this.nosaukums2.Location = new System.Drawing.Point(29, 82);
            this.nosaukums2.Name = "nosaukums2";
            this.nosaukums2.Size = new System.Drawing.Size(171, 20);
            this.nosaukums2.TabIndex = 11;
            // 
            // daudzums3
            // 
            this.daudzums3.Location = new System.Drawing.Point(385, 108);
            this.daudzums3.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.daudzums3.Name = "daudzums3";
            this.daudzums3.Size = new System.Drawing.Size(107, 20);
            this.daudzums3.TabIndex = 16;
            // 
            // cena3
            // 
            this.cena3.Location = new System.Drawing.Point(242, 107);
            this.cena3.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.cena3.Name = "cena3";
            this.cena3.Size = new System.Drawing.Size(107, 20);
            this.cena3.TabIndex = 15;
            // 
            // nosaukums3
            // 
            this.nosaukums3.Location = new System.Drawing.Point(29, 108);
            this.nosaukums3.Name = "nosaukums3";
            this.nosaukums3.Size = new System.Drawing.Size(171, 20);
            this.nosaukums3.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(534, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 44);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cik tev naudas?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tnauda
            // 
            this.tnauda.Location = new System.Drawing.Point(542, 81);
            this.tnauda.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.tnauda.Name = "tnauda";
            this.tnauda.Size = new System.Drawing.Size(246, 20);
            this.tnauda.TabIndex = 18;
            this.tnauda.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tnauda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.daudzums3);
            this.Controls.Add(this.cena3);
            this.Controls.Add(this.nosaukums3);
            this.Controls.Add(this.daudzums2);
            this.Controls.Add(this.cena2);
            this.Controls.Add(this.nosaukums2);
            this.Controls.Add(this.daudzums);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.tsumma);
            this.Controls.Add(this.poga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nosaukums);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daudzums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daudzums2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cena2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daudzums3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cena3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tnauda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nosaukums;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button poga;
        private System.Windows.Forms.TextBox tsumma;
        private System.Windows.Forms.NumericUpDown cena;
        private System.Windows.Forms.NumericUpDown daudzums;
        private System.Windows.Forms.NumericUpDown daudzums2;
        private System.Windows.Forms.NumericUpDown cena2;
        private System.Windows.Forms.TextBox nosaukums2;
        private System.Windows.Forms.NumericUpDown daudzums3;
        private System.Windows.Forms.NumericUpDown cena3;
        private System.Windows.Forms.TextBox nosaukums3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown tnauda;
    }
}


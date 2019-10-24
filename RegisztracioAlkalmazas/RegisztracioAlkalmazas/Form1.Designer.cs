namespace RegisztracioAlkalmazas
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
            this.nev_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fiu_radioButton = new System.Windows.Forms.RadioButton();
            this.lany_radioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hobbi_ListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ujhobbi_TextBox = new System.Windows.Forms.TextBox();
            this.hozzad_Button = new System.Windows.Forms.Button();
            this.mentes_Button = new System.Windows.Forms.Button();
            this.betoltes_Button = new System.Windows.Forms.Button();
            this.szuldatum_TextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // nev_TextBox
            // 
            this.nev_TextBox.Location = new System.Drawing.Point(154, 41);
            this.nev_TextBox.Name = "nev_TextBox";
            this.nev_TextBox.Size = new System.Drawing.Size(100, 20);
            this.nev_TextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nev:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Szul. datum:";
            // 
            // fiu_radioButton
            // 
            this.fiu_radioButton.AutoSize = true;
            this.fiu_radioButton.Location = new System.Drawing.Point(139, 120);
            this.fiu_radioButton.Name = "fiu_radioButton";
            this.fiu_radioButton.Size = new System.Drawing.Size(31, 17);
            this.fiu_radioButton.TabIndex = 3;
            this.fiu_radioButton.TabStop = true;
            this.fiu_radioButton.Text = "F";
            this.fiu_radioButton.UseVisualStyleBackColor = true;
            // 
            // lany_radioButton
            // 
            this.lany_radioButton.AutoSize = true;
            this.lany_radioButton.Location = new System.Drawing.Point(231, 120);
            this.lany_radioButton.Name = "lany_radioButton";
            this.lany_radioButton.Size = new System.Drawing.Size(33, 17);
            this.lany_radioButton.TabIndex = 4;
            this.lany_radioButton.TabStop = true;
            this.lany_radioButton.Text = "N";
            this.lany_radioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kedvenc hobbi:";
            // 
            // hobbi_ListBox
            // 
            this.hobbi_ListBox.FormattingEnabled = true;
            this.hobbi_ListBox.Location = new System.Drawing.Point(376, 55);
            this.hobbi_ListBox.Name = "hobbi_ListBox";
            this.hobbi_ListBox.Size = new System.Drawing.Size(120, 95);
            this.hobbi_ListBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Uj hobbi";
            // 
            // ujhobbi_TextBox
            // 
            this.ujhobbi_TextBox.Location = new System.Drawing.Point(396, 174);
            this.ujhobbi_TextBox.Name = "ujhobbi_TextBox";
            this.ujhobbi_TextBox.Size = new System.Drawing.Size(100, 20);
            this.ujhobbi_TextBox.TabIndex = 9;
            // 
            // hozzad_Button
            // 
            this.hozzad_Button.Location = new System.Drawing.Point(406, 232);
            this.hozzad_Button.Name = "hozzad_Button";
            this.hozzad_Button.Size = new System.Drawing.Size(75, 23);
            this.hozzad_Button.TabIndex = 10;
            this.hozzad_Button.Text = "Hozzaad";
            this.hozzad_Button.UseVisualStyleBackColor = true;
            this.hozzad_Button.Click += new System.EventHandler(this.Hozzad_Button_Click);
            // 
            // mentes_Button
            // 
            this.mentes_Button.Location = new System.Drawing.Point(315, 308);
            this.mentes_Button.Name = "mentes_Button";
            this.mentes_Button.Size = new System.Drawing.Size(75, 23);
            this.mentes_Button.TabIndex = 11;
            this.mentes_Button.Text = "Mentes";
            this.mentes_Button.UseVisualStyleBackColor = true;
            this.mentes_Button.Click += new System.EventHandler(this.Mentes_Button_Click);
            // 
            // betoltes_Button
            // 
            this.betoltes_Button.Location = new System.Drawing.Point(446, 308);
            this.betoltes_Button.Name = "betoltes_Button";
            this.betoltes_Button.Size = new System.Drawing.Size(75, 23);
            this.betoltes_Button.TabIndex = 12;
            this.betoltes_Button.Text = "Betoltes";
            this.betoltes_Button.UseVisualStyleBackColor = true;
            this.betoltes_Button.Click += new System.EventHandler(this.Betoltes_Button_Click);
            // 
            // szuldatum_TextBox
            // 
            this.szuldatum_TextBox.Location = new System.Drawing.Point(154, 80);
            this.szuldatum_TextBox.Name = "szuldatum_TextBox";
            this.szuldatum_TextBox.Size = new System.Drawing.Size(100, 20);
            this.szuldatum_TextBox.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "mentes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 345);
            this.Controls.Add(this.szuldatum_TextBox);
            this.Controls.Add(this.betoltes_Button);
            this.Controls.Add(this.mentes_Button);
            this.Controls.Add(this.hozzad_Button);
            this.Controls.Add(this.ujhobbi_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hobbi_ListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lany_radioButton);
            this.Controls.Add(this.fiu_radioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nev_TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nev_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton fiu_radioButton;
        private System.Windows.Forms.RadioButton lany_radioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox hobbi_ListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ujhobbi_TextBox;
        private System.Windows.Forms.Button hozzad_Button;
        private System.Windows.Forms.Button mentes_Button;
        private System.Windows.Forms.Button betoltes_Button;
        private System.Windows.Forms.TextBox szuldatum_TextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


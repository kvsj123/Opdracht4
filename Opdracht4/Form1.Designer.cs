namespace Opdracht4
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_titel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_informatie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_tijd = new System.Windows.Forms.DateTimePicker();
            this.CheckBox_tijd = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_rij = new System.Windows.Forms.TextBox();
            this.btn_toevoegen = new System.Windows.Forms.Button();
            this.btn_volgende = new System.Windows.Forms.Button();
            this.btn_verwijderen = new System.Windows.Forms.Button();
            this.btn_zetAchteraan = new System.Windows.Forms.Button();
            this.btn_tb = new System.Windows.Forms.Button();
            this.TextBox_toon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_mb = new System.Windows.Forms.Button();
            this.btn_beep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBox_titel
            // 
            this.TextBox_titel.Location = new System.Drawing.Point(100, 35);
            this.TextBox_titel.Name = "TextBox_titel";
            this.TextBox_titel.Size = new System.Drawing.Size(192, 23);
            this.TextBox_titel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informatie :";
            // 
            // TextBox_informatie
            // 
            this.TextBox_informatie.Location = new System.Drawing.Point(100, 68);
            this.TextBox_informatie.Multiline = true;
            this.TextBox_informatie.Name = "TextBox_informatie";
            this.TextBox_informatie.Size = new System.Drawing.Size(192, 130);
            this.TextBox_informatie.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tijd : ";
            // 
            // box_tijd
            // 
            this.box_tijd.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.box_tijd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.box_tijd.Location = new System.Drawing.Point(100, 208);
            this.box_tijd.Name = "box_tijd";
            this.box_tijd.Size = new System.Drawing.Size(200, 23);
            this.box_tijd.TabIndex = 5;
            // 
            // CheckBox_tijd
            // 
            this.CheckBox_tijd.AutoSize = true;
            this.CheckBox_tijd.Location = new System.Drawing.Point(100, 237);
            this.CheckBox_tijd.Name = "CheckBox_tijd";
            this.CheckBox_tijd.Size = new System.Drawing.Size(102, 19);
            this.CheckBox_tijd.TabIndex = 6;
            this.CheckBox_tijd.Text = "Tijd niet nodig";
            this.CheckBox_tijd.UseVisualStyleBackColor = true;
            this.CheckBox_tijd.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Foute Rij :";
            // 
            // TextBox_rij
            // 
            this.TextBox_rij.Enabled = false;
            this.TextBox_rij.Location = new System.Drawing.Point(100, 417);
            this.TextBox_rij.Name = "TextBox_rij";
            this.TextBox_rij.Size = new System.Drawing.Size(664, 23);
            this.TextBox_rij.TabIndex = 8;
            // 
            // btn_toevoegen
            // 
            this.btn_toevoegen.Location = new System.Drawing.Point(100, 276);
            this.btn_toevoegen.Name = "btn_toevoegen";
            this.btn_toevoegen.Size = new System.Drawing.Size(105, 23);
            this.btn_toevoegen.TabIndex = 9;
            this.btn_toevoegen.Text = "Taak Toevoegen";
            this.btn_toevoegen.UseVisualStyleBackColor = true;
            this.btn_toevoegen.Click += new System.EventHandler(this.btn_toevoegen_Click);
            // 
            // btn_volgende
            // 
            this.btn_volgende.Location = new System.Drawing.Point(100, 305);
            this.btn_volgende.Name = "btn_volgende";
            this.btn_volgende.Size = new System.Drawing.Size(105, 23);
            this.btn_volgende.TabIndex = 10;
            this.btn_volgende.Text = "Volgende taak";
            this.btn_volgende.UseVisualStyleBackColor = true;
            this.btn_volgende.Click += new System.EventHandler(this.btn_volgende_Click);
            // 
            // btn_verwijderen
            // 
            this.btn_verwijderen.Location = new System.Drawing.Point(100, 334);
            this.btn_verwijderen.Name = "btn_verwijderen";
            this.btn_verwijderen.Size = new System.Drawing.Size(105, 23);
            this.btn_verwijderen.TabIndex = 11;
            this.btn_verwijderen.Text = "Taak is afgewerkt";
            this.btn_verwijderen.UseVisualStyleBackColor = true;
            this.btn_verwijderen.Click += new System.EventHandler(this.btn_verwijderen_Click);
            // 
            // btn_zetAchteraan
            // 
            this.btn_zetAchteraan.Location = new System.Drawing.Point(100, 363);
            this.btn_zetAchteraan.Name = "btn_zetAchteraan";
            this.btn_zetAchteraan.Size = new System.Drawing.Size(105, 23);
            this.btn_zetAchteraan.TabIndex = 12;
            this.btn_zetAchteraan.Text = "Zet achteraan";
            this.btn_zetAchteraan.UseVisualStyleBackColor = true;
            this.btn_zetAchteraan.Click += new System.EventHandler(this.btn_zetAchteraan_Click);
            // 
            // btn_tb
            // 
            this.btn_tb.Location = new System.Drawing.Point(475, 311);
            this.btn_tb.Name = "btn_tb";
            this.btn_tb.Size = new System.Drawing.Size(134, 46);
            this.btn_tb.TabIndex = 13;
            this.btn_tb.Text = "TextBox-Modus";
            this.btn_tb.UseVisualStyleBackColor = true;
            this.btn_tb.Click += new System.EventHandler(this.btn_tb_Click);
            // 
            // TextBox_toon
            // 
            this.TextBox_toon.Location = new System.Drawing.Point(475, 38);
            this.TextBox_toon.Multiline = true;
            this.TextBox_toon.Name = "TextBox_toon";
            this.TextBox_toon.Size = new System.Drawing.Size(289, 261);
            this.TextBox_toon.TabIndex = 14;
            this.TextBox_toon.TextChanged += new System.EventHandler(this.TextBox_toon_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "In textbox afgebeeld";
            // 
            // btn_mb
            // 
            this.btn_mb.Location = new System.Drawing.Point(630, 311);
            this.btn_mb.Name = "btn_mb";
            this.btn_mb.Size = new System.Drawing.Size(134, 46);
            this.btn_mb.TabIndex = 16;
            this.btn_mb.Text = "MessageBox-Modus";
            this.btn_mb.UseVisualStyleBackColor = true;
            this.btn_mb.Click += new System.EventHandler(this.btn_mb_Click);
            // 
            // btn_beep
            // 
            this.btn_beep.Location = new System.Drawing.Point(475, 363);
            this.btn_beep.Name = "btn_beep";
            this.btn_beep.Size = new System.Drawing.Size(289, 45);
            this.btn_beep.TabIndex = 17;
            this.btn_beep.Text = "! Beep !";
            this.btn_beep.UseVisualStyleBackColor = true;
            this.btn_beep.Click += new System.EventHandler(this.btn_beep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_beep);
            this.Controls.Add(this.btn_mb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBox_toon);
            this.Controls.Add(this.btn_tb);
            this.Controls.Add(this.btn_zetAchteraan);
            this.Controls.Add(this.btn_verwijderen);
            this.Controls.Add(this.btn_volgende);
            this.Controls.Add(this.btn_toevoegen);
            this.Controls.Add(this.TextBox_rij);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CheckBox_tijd);
            this.Controls.Add(this.box_tijd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_informatie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_titel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TextBox_titel;
        private Label label2;
        private TextBox TextBox_informatie;
        private Label label3;
        private DateTimePicker box_tijd;
        private CheckBox CheckBox_tijd;
        private Label label4;
        private TextBox TextBox_rij;
        private Button btn_toevoegen;
        private Button btn_volgende;
        private Button btn_verwijderen;
        private Button btn_zetAchteraan;
        private Button btn_tb;
        private TextBox TextBox_toon;
        private Label label5;
        private Button btn_mb;
        private Button btn_beep;
    }
}
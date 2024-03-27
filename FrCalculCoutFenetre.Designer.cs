namespace Gestion_des_clients
{
    partial class FrCalculCoutFenetre
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
            Btn_Quitter = new Button();
            LB_Modele = new ListBox();
            LB_Tissue = new ListBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            TB_Largeur = new TextBox();
            TB_Hauteur = new TextBox();
            TB_Ampleur = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label9 = new Label();
            textBox7 = new TextBox();
            TB_Montant = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // Btn_Quitter
            // 
            Btn_Quitter.Location = new Point(461, 415);
            Btn_Quitter.Name = "Btn_Quitter";
            Btn_Quitter.Size = new Size(75, 23);
            Btn_Quitter.TabIndex = 12;
            Btn_Quitter.Text = "Quitter";
            Btn_Quitter.UseVisualStyleBackColor = true;
            Btn_Quitter.Click += Btn_Quitter_Click;
            // 
            // LB_Modele
            // 
            LB_Modele.FormattingEnabled = true;
            LB_Modele.ItemHeight = 15;
            LB_Modele.Location = new Point(304, 127);
            LB_Modele.Name = "LB_Modele";
            LB_Modele.Size = new Size(160, 199);
            LB_Modele.TabIndex = 13;
            // 
            // LB_Tissue
            // 
            LB_Tissue.FormattingEnabled = true;
            LB_Tissue.ItemHeight = 15;
            LB_Tissue.Location = new Point(63, 127);
            LB_Tissue.Name = "LB_Tissue";
            LB_Tissue.Size = new Size(176, 199);
            LB_Tissue.TabIndex = 14;
            LB_Tissue.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 109);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 15;
            label1.Text = "Tissue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 109);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 16;
            label2.Text = "Modele";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(275, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(436, 12);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 19;
            // 
            // TB_Largeur
            // 
            TB_Largeur.Location = new Point(111, 71);
            TB_Largeur.Name = "TB_Largeur";
            TB_Largeur.Size = new Size(100, 23);
            TB_Largeur.TabIndex = 20;
            TB_Largeur.KeyPress += TB_Largeur_KeyPress;
            // 
            // TB_Hauteur
            // 
            TB_Hauteur.Location = new Point(275, 71);
            TB_Hauteur.Name = "TB_Hauteur";
            TB_Hauteur.Size = new Size(100, 23);
            TB_Hauteur.TabIndex = 21;
            TB_Hauteur.KeyPress += TB_Hauteur_KeyPress;
            // 
            // TB_Ampleur
            // 
            TB_Ampleur.Location = new Point(433, 71);
            TB_Ampleur.Name = "TB_Ampleur";
            TB_Ampleur.Size = new Size(100, 23);
            TB_Ampleur.TabIndex = 22;
            TB_Ampleur.KeyPress += TB_Ampleur_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 74);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 23;
            label3.Text = "Lageur";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 74);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 24;
            label4.Text = "Hauteur";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(377, 74);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 25;
            label5.Text = "Ampleur";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 15);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 26;
            label6.Text = "Num client";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(195, 15);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 27;
            label7.Text = "Num fenêtre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(399, 15);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 28;
            label8.Text = "Date";
            // 
            // button1
            // 
            button1.Location = new Point(380, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 29;
            button1.Text = "Enregistrer";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(299, 413);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 30;
            button2.Text = "Calculer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(219, 413);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 31;
            button3.Text = "Quitter";
            button3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 398);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 32;
            label9.Text = "Pour test";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(12, 416);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 33;
            // 
            // TB_Montant
            // 
            TB_Montant.Location = new Point(433, 386);
            TB_Montant.Name = "TB_Montant";
            TB_Montant.Size = new Size(100, 23);
            TB_Montant.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(433, 368);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 34;
            label10.Text = "Montant devis";
            // 
            // FrCalculCoutFenetre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 448);
            Controls.Add(TB_Montant);
            Controls.Add(label10);
            Controls.Add(textBox7);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TB_Ampleur);
            Controls.Add(TB_Hauteur);
            Controls.Add(TB_Largeur);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LB_Tissue);
            Controls.Add(LB_Modele);
            Controls.Add(Btn_Quitter);
            Name = "FrCalculCoutFenetre";
            Text = "FrCalculCoutFenetre";
            Load += FrCalculCoutFenetre_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Quitter;
        private ListBox LB_Modele;
        private ListBox LB_Tissue;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox TB_Largeur;
        private TextBox TB_Hauteur;
        private TextBox TB_Ampleur;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label9;
        private TextBox textBox7;
        private TextBox TB_Montant;
        private Label label10;
    }
}
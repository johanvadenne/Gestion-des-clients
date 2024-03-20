namespace Gestion_des_clients
{
    partial class FrClient
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TB_NomClient = new TextBox();
            NUP_NumeroClient = new NumericUpDown();
            TB_PrenomClient = new TextBox();
            Btn_Nouveau = new Button();
            Btn_Modifier = new Button();
            Btn_Supprimer = new Button();
            Btn_Enregistrer = new Button();
            Btn_Quitter = new Button();
            LB_Client = new ListBox();
            ((System.ComponentModel.ISupportInitialize)NUP_NumeroClient).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 46);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Numéro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 83);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 123);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Prénom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 270);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Message";
            // 
            // TB_NomClient
            // 
            TB_NomClient.Location = new Point(102, 80);
            TB_NomClient.Name = "TB_NomClient";
            TB_NomClient.Size = new Size(167, 23);
            TB_NomClient.TabIndex = 4;
            // 
            // NUP_NumeroClient
            // 
            NUP_NumeroClient.Location = new Point(104, 44);
            NUP_NumeroClient.Name = "NUP_NumeroClient";
            NUP_NumeroClient.Size = new Size(53, 23);
            NUP_NumeroClient.TabIndex = 5;
            // 
            // TB_PrenomClient
            // 
            TB_PrenomClient.Location = new Point(102, 123);
            TB_PrenomClient.Name = "TB_PrenomClient";
            TB_PrenomClient.Size = new Size(167, 23);
            TB_PrenomClient.TabIndex = 6;
            // 
            // Btn_Nouveau
            // 
            Btn_Nouveau.Location = new Point(33, 231);
            Btn_Nouveau.Name = "Btn_Nouveau";
            Btn_Nouveau.Size = new Size(75, 23);
            Btn_Nouveau.TabIndex = 7;
            Btn_Nouveau.Text = "Nouveau";
            Btn_Nouveau.UseVisualStyleBackColor = true;
            Btn_Nouveau.Click += Btn_Nouveau_Click;
            // 
            // Btn_Modifier
            // 
            Btn_Modifier.Location = new Point(114, 231);
            Btn_Modifier.Name = "Btn_Modifier";
            Btn_Modifier.Size = new Size(75, 23);
            Btn_Modifier.TabIndex = 8;
            Btn_Modifier.Text = "Modifier";
            Btn_Modifier.UseVisualStyleBackColor = true;
            Btn_Modifier.Click += Btn_Modifier_Click;
            // 
            // Btn_Supprimer
            // 
            Btn_Supprimer.Location = new Point(276, 231);
            Btn_Supprimer.Name = "Btn_Supprimer";
            Btn_Supprimer.Size = new Size(75, 23);
            Btn_Supprimer.TabIndex = 10;
            Btn_Supprimer.Text = "Supprimer";
            Btn_Supprimer.UseVisualStyleBackColor = true;
            Btn_Supprimer.Click += Btn_Supprimer_Click;
            // 
            // Btn_Enregistrer
            // 
            Btn_Enregistrer.Location = new Point(195, 231);
            Btn_Enregistrer.Name = "Btn_Enregistrer";
            Btn_Enregistrer.Size = new Size(75, 23);
            Btn_Enregistrer.TabIndex = 9;
            Btn_Enregistrer.Text = "Enregistrer";
            Btn_Enregistrer.UseVisualStyleBackColor = true;
            Btn_Enregistrer.Click += Btn_Enregistrer_Click;
            // 
            // Btn_Quitter
            // 
            Btn_Quitter.Location = new Point(357, 231);
            Btn_Quitter.Name = "Btn_Quitter";
            Btn_Quitter.Size = new Size(75, 23);
            Btn_Quitter.TabIndex = 11;
            Btn_Quitter.Text = "Quitter";
            Btn_Quitter.UseVisualStyleBackColor = true;
            Btn_Quitter.Click += Btn_Quitter_Click;
            // 
            // LB_Client
            // 
            LB_Client.FormattingEnabled = true;
            LB_Client.ItemHeight = 15;
            LB_Client.Location = new Point(312, 44);
            LB_Client.Name = "LB_Client";
            LB_Client.Size = new Size(165, 169);
            LB_Client.TabIndex = 12;
            LB_Client.SelectedIndexChanged += LB_Client_SelectedIndexChanged;
            // 
            // FrClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 305);
            Controls.Add(LB_Client);
            Controls.Add(Btn_Quitter);
            Controls.Add(Btn_Supprimer);
            Controls.Add(Btn_Enregistrer);
            Controls.Add(Btn_Modifier);
            Controls.Add(Btn_Nouveau);
            Controls.Add(TB_PrenomClient);
            Controls.Add(NUP_NumeroClient);
            Controls.Add(TB_NomClient);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrClient";
            Text = "Gestion des clients";
            Load += FrClient_Load_1;
            ((System.ComponentModel.ISupportInitialize)NUP_NumeroClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TB_NomClient;
        private NumericUpDown NUP_NumeroClient;
        private TextBox TB_PrenomClient;
        private Button Btn_Nouveau;
        private Button Btn_Modifier;
        private Button Btn_Supprimer;
        private Button Btn_Enregistrer;
        private Button Btn_Quitter;
        private ListBox LB_Client;
    }
}

namespace Gestion_des_clients
{
    partial class FrFenetre
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
            CB_Client = new ComboBox();
            LB_Fenetre = new ListBox();
            L_Client = new Label();
            NUP_Hauteur = new NumericUpDown();
            NUP_Largeur = new NumericUpDown();
            L_Hauteur = new Label();
            L_Largeur = new Label();
            ((System.ComponentModel.ISupportInitialize)NUP_Hauteur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUP_Largeur).BeginInit();
            SuspendLayout();
            // 
            // CB_Client
            // 
            CB_Client.FormattingEnabled = true;
            CB_Client.Location = new Point(59, 31);
            CB_Client.Name = "CB_Client";
            CB_Client.Size = new Size(121, 23);
            CB_Client.TabIndex = 0;
            CB_Client.SelectedIndexChanged += CB_Client_SelectedIndexChanged;
            // 
            // LB_Fenetre
            // 
            LB_Fenetre.FormattingEnabled = true;
            LB_Fenetre.ItemHeight = 15;
            LB_Fenetre.Location = new Point(226, 31);
            LB_Fenetre.Name = "LB_Fenetre";
            LB_Fenetre.Size = new Size(203, 244);
            LB_Fenetre.TabIndex = 1;
            LB_Fenetre.SelectedIndexChanged += LB_Fenetre_SelectedIndexChanged;
            // 
            // L_Client
            // 
            L_Client.AutoSize = true;
            L_Client.Location = new Point(15, 34);
            L_Client.Name = "L_Client";
            L_Client.Size = new Size(38, 15);
            L_Client.TabIndex = 2;
            L_Client.Text = "Client";
            // 
            // NUP_Hauteur
            // 
            NUP_Hauteur.Location = new Point(59, 76);
            NUP_Hauteur.Name = "NUP_Hauteur";
            NUP_Hauteur.Size = new Size(53, 23);
            NUP_Hauteur.TabIndex = 6;
            // 
            // NUP_Largeur
            // 
            NUP_Largeur.Location = new Point(59, 120);
            NUP_Largeur.Name = "NUP_Largeur";
            NUP_Largeur.Size = new Size(53, 23);
            NUP_Largeur.TabIndex = 7;
            // 
            // L_Hauteur
            // 
            L_Hauteur.AutoSize = true;
            L_Hauteur.Location = new Point(3, 78);
            L_Hauteur.Name = "L_Hauteur";
            L_Hauteur.Size = new Size(50, 15);
            L_Hauteur.TabIndex = 8;
            L_Hauteur.Text = "Hauteur";
            // 
            // L_Largeur
            // 
            L_Largeur.AutoSize = true;
            L_Largeur.Location = new Point(3, 122);
            L_Largeur.Name = "L_Largeur";
            L_Largeur.Size = new Size(47, 15);
            L_Largeur.TabIndex = 9;
            L_Largeur.Text = "Largeur";
            // 
            // FrFenetre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 343);
            Controls.Add(L_Largeur);
            Controls.Add(L_Hauteur);
            Controls.Add(NUP_Largeur);
            Controls.Add(NUP_Hauteur);
            Controls.Add(L_Client);
            Controls.Add(LB_Fenetre);
            Controls.Add(CB_Client);
            Name = "FrFenetre";
            Text = "FrFenetre";
            Load += FrFenetre_Load;
            ((System.ComponentModel.ISupportInitialize)NUP_Hauteur).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUP_Largeur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CB_Client;
        private ListBox LB_Fenetre;
        private Label L_Client;
        private NumericUpDown NUP_Hauteur;
        private NumericUpDown NUP_Largeur;
        private Label L_Hauteur;
        private Label L_Largeur;
    }
}
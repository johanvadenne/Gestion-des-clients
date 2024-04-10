namespace Gestion_des_clients
{
    partial class GestionFenetre
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
            label1 = new Label();
            LB_Fenetre = new ListBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // CB_Client
            // 
            CB_Client.FormattingEnabled = true;
            CB_Client.Location = new Point(83, 23);
            CB_Client.Name = "CB_Client";
            CB_Client.Size = new Size(289, 23);
            CB_Client.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 26);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Client";
            // 
            // LB_Fenetre
            // 
            LB_Fenetre.FormattingEnabled = true;
            LB_Fenetre.ItemHeight = 15;
            LB_Fenetre.Location = new Point(83, 68);
            LB_Fenetre.Name = "LB_Fenetre";
            LB_Fenetre.Size = new Size(289, 169);
            LB_Fenetre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 68);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Fenetre";
            // 
            // button1
            // 
            button1.Location = new Point(404, 267);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // GestionFenetre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 302);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(LB_Fenetre);
            Controls.Add(label1);
            Controls.Add(CB_Client);
            Name = "GestionFenetre";
            Text = "GestionFenetre";
            Load += GestionFenetre_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CB_Client;
        private Label label1;
        private ListBox LB_Fenetre;
        private Label label2;
        private Button button1;
    }
}
﻿namespace GUI
{
    partial class AjouterClientStandard
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textId = new TextBox();
            textCA = new TextBox();
            textDateCreation = new TextBox();
            textQa = new TextBox();
            textDateAffec = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 44);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "IdClient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 77);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 0;
            label2.Text = "CA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 113);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 0;
            label3.Text = "DateCreation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 148);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 0;
            label4.Text = "Quantite";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 183);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 0;
            label5.Text = "DateAffectation";
            label5.Click += label4_Click;
            // 
            // textId
            // 
            textId.Location = new Point(150, 41);
            textId.Name = "textId";
            textId.Size = new Size(227, 27);
            textId.TabIndex = 1;
            // 
            // textCA
            // 
            textCA.Location = new Point(150, 74);
            textCA.Name = "textCA";
            textCA.Size = new Size(227, 27);
            textCA.TabIndex = 1;
            // 
            // textDateCreation
            // 
            textDateCreation.Location = new Point(150, 107);
            textDateCreation.Name = "textDateCreation";
            textDateCreation.Size = new Size(227, 27);
            textDateCreation.TabIndex = 1;
            // 
            // textQa
            // 
            textQa.Location = new Point(150, 141);
            textQa.Name = "textQa";
            textQa.Size = new Size(227, 27);
            textQa.TabIndex = 1;
            // 
            // textDateAffec
            // 
            textDateAffec.Location = new Point(150, 174);
            textDateAffec.Name = "textDateAffec";
            textDateAffec.Size = new Size(227, 27);
            textDateAffec.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(283, 244);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AjouterClientStandard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 296);
            Controls.Add(button1);
            Controls.Add(textDateAffec);
            Controls.Add(textQa);
            Controls.Add(textDateCreation);
            Controls.Add(textCA);
            Controls.Add(textId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AjouterClientStandard";
            Text = "AjouterClientStandard";
            Load += AjouterClientStandard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textId;
        private TextBox textCA;
        private TextBox textDateCreation;
        private TextBox textQa;
        private TextBox textDateAffec;
        private Button button1;
    }
}
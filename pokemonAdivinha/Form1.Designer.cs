﻿namespace pokemonAdivinha
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            palpite = new TextBox();
            adivinhar = new Button();
            LabelAcertou = new Label();
            LabelErrou = new Label();
            label4 = new Label();
            numeroTentativas = new Label();
            recarregar1 = new Button();
            label2 = new Label();
            numeroAcertos = new Label();
            Sair = new Button();
            label3 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(280, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 186);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 340);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 1;
            label1.Text = "Qual o nome desse Pokemon?";
            // 
            // palpite
            // 
            palpite.Location = new Point(301, 337);
            palpite.Name = "palpite";
            palpite.Size = new Size(207, 23);
            palpite.TabIndex = 2;
            // 
            // adivinhar
            // 
            adivinhar.Location = new Point(536, 330);
            adivinhar.Name = "adivinhar";
            adivinhar.Size = new Size(153, 35);
            adivinhar.TabIndex = 3;
            adivinhar.Text = "adivinhar";
            adivinhar.UseVisualStyleBackColor = true;
            adivinhar.Click += adivinhar_Click;
            // 
            // LabelAcertou
            // 
            LabelAcertou.AutoSize = true;
            LabelAcertou.Location = new Point(301, 391);
            LabelAcertou.Name = "LabelAcertou";
            LabelAcertou.Size = new Size(49, 15);
            LabelAcertou.TabIndex = 4;
            LabelAcertou.Text = "Acertou";
            LabelAcertou.Visible = false;
            // 
            // LabelErrou
            // 
            LabelErrou.AutoSize = true;
            LabelErrou.Location = new Point(404, 391);
            LabelErrou.Name = "LabelErrou";
            LabelErrou.Size = new Size(129, 15);
            LabelErrou.TabIndex = 5;
            LabelErrou.Text = "Errou,Tente novamente";
            LabelErrou.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(628, 107);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 6;
            label4.Text = "tentativas:";
            // 
            // numeroTentativas
            // 
            numeroTentativas.AutoSize = true;
            numeroTentativas.Location = new Point(721, 107);
            numeroTentativas.Name = "numeroTentativas";
            numeroTentativas.Size = new Size(38, 15);
            numeroTentativas.TabIndex = 7;
            numeroTentativas.Text = "label5";
            // 
            // recarregar1
            // 
            recarregar1.Location = new Point(12, 12);
            recarregar1.Name = "recarregar1";
            recarregar1.Size = new Size(144, 48);
            recarregar1.TabIndex = 8;
            recarregar1.Text = "Recarregar";
            recarregar1.UseVisualStyleBackColor = true;
            recarregar1.Visible = false;
            recarregar1.Click += recarregar1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(628, 45);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 9;
            label2.Text = "Acertos";
            // 
            // numeroAcertos
            // 
            numeroAcertos.AutoSize = true;
            numeroAcertos.Location = new Point(721, 45);
            numeroAcertos.Name = "numeroAcertos";
            numeroAcertos.Size = new Size(38, 15);
            numeroAcertos.TabIndex = 10;
            numeroAcertos.Text = "label3";
            // 
            // Sair
            // 
            Sair.Location = new Point(12, 403);
            Sair.Name = "Sair";
            Sair.Size = new Size(131, 35);
            Sair.TabIndex = 11;
            Sair.Text = "Sair";
            Sair.UseVisualStyleBackColor = true;
            Sair.Click += Sair_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(602, 152);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 12;
            label3.Text = "Taxa de acertos";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(721, 152);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 13;
            label5.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(Sair);
            Controls.Add(numeroAcertos);
            Controls.Add(label2);
            Controls.Add(recarregar1);
            Controls.Add(numeroTentativas);
            Controls.Add(label4);
            Controls.Add(LabelErrou);
            Controls.Add(LabelAcertou);
            Controls.Add(adivinhar);
            Controls.Add(palpite);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox palpite;
        private Button adivinhar;
        private Label LabelAcertou;
        private Label LabelErrou;
        private Label label4;
        private Label numeroTentativas;
        private Button recarregar1;
        private Label label2;
        private Label numeroAcertos;
        private Button Sair;
        private Label label3;
        private Label label5;
    }
}
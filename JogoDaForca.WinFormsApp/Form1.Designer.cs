namespace JogoDaForca.WinFormsApp
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
            label1 = new Label();
            lblLetra = new Label();
            txtPalpite = new TextBox();
            btnTentativa = new Button();
            lblPalavra = new Label();
            txtPalavraSecreta = new TextBox();
            btnComecar = new Button();
            imgForca = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgForca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(113, 46);
            label1.Name = "label1";
            label1.Size = new Size(228, 33);
            label1.TabIndex = 1;
            label1.Text = "Jogo Da Forca";
            // 
            // lblLetra
            // 
            lblLetra.AutoSize = true;
            lblLetra.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLetra.Location = new Point(22, 301);
            lblLetra.Name = "lblLetra";
            lblLetra.Size = new Size(132, 23);
            lblLetra.TabIndex = 2;
            lblLetra.Text = "Digite uma letra:";
            // 
            // txtPalpite
            // 
            txtPalpite.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPalpite.ForeColor = SystemColors.WindowText;
            txtPalpite.Location = new Point(160, 292);
            txtPalpite.MaxLength = 1;
            txtPalpite.Name = "txtPalpite";
            txtPalpite.Size = new Size(202, 33);
            txtPalpite.TabIndex = 3;
            txtPalpite.TextChanged += txtPalpite_TextChanged;
            // 
            // btnTentativa
            // 
            btnTentativa.Location = new Point(368, 289);
            btnTentativa.Name = "btnTentativa";
            btnTentativa.Size = new Size(75, 43);
            btnTentativa.TabIndex = 4;
            btnTentativa.Text = "Tentar";
            btnTentativa.UseVisualStyleBackColor = true;
            btnTentativa.Click += btnTentativa_Click;
            // 
            // lblPalavra
            // 
            lblPalavra.AutoSize = true;
            lblPalavra.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPalavra.Location = new Point(22, 234);
            lblPalavra.Name = "lblPalavra";
            lblPalavra.Size = new Size(131, 23);
            lblPalavra.TabIndex = 6;
            lblPalavra.Text = "Palavra secreta:";
            // 
            // txtPalavraSecreta
            // 
            txtPalavraSecreta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPalavraSecreta.Location = new Point(159, 225);
            txtPalavraSecreta.Name = "txtPalavraSecreta";
            txtPalavraSecreta.Size = new Size(203, 33);
            txtPalavraSecreta.TabIndex = 7;
            txtPalavraSecreta.TextChanged += txtPalavraSecreta_TextChanged;
            // 
            // btnComecar
            // 
            btnComecar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnComecar.Location = new Point(159, 115);
            btnComecar.Name = "btnComecar";
            btnComecar.Size = new Size(146, 53);
            btnComecar.TabIndex = 8;
            btnComecar.Text = "Começar";
            btnComecar.UseVisualStyleBackColor = true;
            btnComecar.Click += btnComecar_Click;
            // 
            // imgForca
            // 
            imgForca.Image = Properties.Resources._1;
            imgForca.Location = new Point(505, 46);
            imgForca.Name = "imgForca";
            imgForca.Size = new Size(259, 341);
            imgForca.SizeMode = PictureBoxSizeMode.Zoom;
            imgForca.TabIndex = 9;
            imgForca.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2;
            pictureBox1.Location = new Point(505, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._3;
            pictureBox2.Location = new Point(505, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(259, 341);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._4;
            pictureBox3.Location = new Point(505, 46);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(259, 341);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._5;
            pictureBox4.Location = new Point(505, 46);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(259, 341);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._6;
            pictureBox5.Location = new Point(505, 46);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(259, 341);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources._7;
            pictureBox6.Location = new Point(505, 46);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(259, 341);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources._8;
            pictureBox7.Location = new Point(505, 46);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(259, 341);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(imgForca);
            Controls.Add(btnComecar);
            Controls.Add(txtPalavraSecreta);
            Controls.Add(lblPalavra);
            Controls.Add(btnTentativa);
            Controls.Add(txtPalpite);
            Controls.Add(lblLetra);
            Controls.Add(label1);
            Name = "Form1";
            Text = "JogoDaForca";
            ((System.ComponentModel.ISupportInitialize)imgForca).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblLetra;
        private TextBox txtPalpite;
        private Button btnTentativa;
        private Label lblPalavra;
        private TextBox txtPalavraSecreta;
        private Button btnComecar;
        private PictureBox imgForca;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}
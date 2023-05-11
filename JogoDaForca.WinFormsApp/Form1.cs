namespace JogoDaForca.WinFormsApp
{
    public partial class Form1 : Form
    {
        Forca Forca = new Forca();
        public char palpite;
        public string[] escondido = new string[15];
        public string palavraSecreta;
        public bool NaoEncontrouLetra = true;
        public int erros = 0;
        public bool AindaNaoGanhou = false;

        public Form1()
        {
            InitializeComponent();
            lblLetra.Visible = false;
            lblPalavra.Visible = false;
            txtPalavraSecreta.Visible = false;
            txtPalpite.Visible = false;
            btnTentativa.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
        }

        private void txtPalpite_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            lblLetra.Visible = true;
            lblPalavra.Visible = true;
            txtPalavraSecreta.Visible = true;
            txtPalpite.Visible = true;
            btnTentativa.Visible = true;
            btnComecar.Visible = false;

            palavraSecreta = Forca.SortearPalavra();

            for (int i = 0; i < palavraSecreta.Length; i++)
            {
                escondido[i] = "_ ";
                txtPalavraSecreta.Text += escondido[i];
            }
        }

        private void txtPalavraSecreta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTentativa_Click(object sender, EventArgs e)
        {

            palpite = Convert.ToChar(txtPalpite.Text);


            for (int i = 0; i < palavraSecreta.Length; i++)
            {
                if (palpite == palavraSecreta[i])
                {
                    escondido[i] = palpite.ToString();
                    txtPalavraSecreta.Text += escondido[i];
                    NaoEncontrouLetra = false;
                }
            }

            if (NaoEncontrouLetra)
            {
                erros++;
            }

            if(erros == 1)
                pictureBox1.Visible = true;

            if (erros == 2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
                

            if (erros == 3)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
                

            if (erros == 4)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
                

            if (erros == 5)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
                

            if (erros == 6)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }
                

            if (erros == 7)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;

                MessageBox.Show("Você perdeu, tente novamente!");

                pictureBox7.Visible = false;
                btnComecar.Visible = true;
                lblLetra.Visible = false;
                lblPalavra.Visible = false;
                txtPalavraSecreta.Visible = false;
                txtPalpite.Visible = false;
                btnTentativa.Visible = false;
                erros = 0;

                for (int i = 0; i < palavraSecreta.Length; i++)
                {
                    escondido[i] = "_ ";
                    txtPalavraSecreta.Text += escondido[i];
                }
            }

            txtPalavraSecreta.Text = "";

            for (int i = 0; i < palavraSecreta.Length; i++)
            {
                txtPalavraSecreta.Text += escondido[i];
            }

            for(int i = 0; i < escondido.Length; i++)
            {
                if (escondido[i] == "_ ")
                    AindaNaoGanhou = true;
            }

            if(AindaNaoGanhou == false)
            {
                MessageBox.Show("Você ganhou, parabéns!");

                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                btnComecar.Visible = true;
                lblLetra.Visible = false;
                lblPalavra.Visible = false;
                txtPalavraSecreta.Visible = false;
                txtPalpite.Visible = false;
                btnTentativa.Visible = false;
                erros = 0;
                txtPalavraSecreta.Text = "";
            }

            txtPalpite.Text = "";
            NaoEncontrouLetra = true;
            AindaNaoGanhou = false;
        }
    }
}
using pokemonAdivinha.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form = System.Windows.Forms.Form;

namespace pokemonAdivinha
{
    public partial class Form1 : Form
    {
        public Pokemon pokemon = new Pokemon();
        ConectaApi conecta = new ConectaApi();
        public int tentativas = 3;
        public double acertos = 0;
        public double pokemonCarregados = 0;
        public double taxaDeAcertos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pokemon = conecta.recarregar();
            pictureBox1.LoadAsync(pokemon.sprites.front_default);
            numeroTentativas.Text = tentativas.ToString();
            numeroAcertos.Text = acertos.ToString();
            label5.Text = taxaDeAcertos.ToString() + "%";

        }

        private void adivinhar_Click(object sender, EventArgs e)
        {
            if (tentativas > 1)
            {
                if (palpite.Text == pokemon.species.name)
                {
                    LabelAcertou.Visible = true;
                    LabelErrou.Visible = false;
                    adivinhar.Visible = false;
                    recarregar1.Visible = true;
                    acertos++;
                    numeroAcertos.Text = acertos.ToString();



                }
                else
                {
                    tentativas--;
                    LabelErrou.Visible = true;
                    numeroTentativas.Text = tentativas.ToString();
                }

            }
            else
            {
                tentativas--;
                numeroTentativas.Text = tentativas.ToString();
                LabelErrou.Text = $"o nome do pokemon era {pokemon.species.name} Recarreque o jogo e tente de novo";
                recarregar1.Visible = true;
                adivinhar.Visible = false;


            }

        }

        private void recarregar1_Click(object sender, EventArgs e)
        {
            palpite.Text = "";
            LabelAcertou.Visible = false;
            LabelErrou.Visible = false;
            tentativas = 3;
            pokemon = conecta.recarregar();
            pictureBox1.LoadAsync(pokemon.sprites.front_default);
            numeroTentativas.Text = tentativas.ToString();
            adivinhar.Visible = true;
            LabelErrou.Text = "Errou,Tente novamente";
            LabelErrou.Visible = false;
            pokemonCarregados++;
            taxaDeAcertos = acertos / pokemonCarregados *100;
            label5.Text = taxaDeAcertos.ToString("##.##") + "%";
            

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

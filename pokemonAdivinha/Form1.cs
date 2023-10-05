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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pokemon = conecta.recarregar();
            pictureBox1.LoadAsync(pokemon.sprites.front_default);
            numeroTentativas.Text = tentativas.ToString();

        }

        private void adivinhar_Click(object sender, EventArgs e)
        {
            if (tentativas > 1)
            {
                if (palpite.Text == pokemon.name)
                {
                    LabelAcertou.Visible = true;
                    LabelErrou.Visible = false;
                    adivinhar.Visible = false;
                    recarregar1.Visible = true;

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
                LabelErrou.Text = $"o nome do pokemon era {pokemon.name} Recarreque o jogo e tente de novo";
                recarregar1.Visible = true;
                adivinhar .Visible = false;


            }

        }

        private void recarregar1_Click(object sender, EventArgs e)
        {
            tentativas = 3;
            pokemon = conecta.recarregar();
            pictureBox1.LoadAsync(pokemon.sprites.front_default);
            numeroTentativas.Text = tentativas.ToString();
            adivinhar.Visible = true;

        }
    }
}

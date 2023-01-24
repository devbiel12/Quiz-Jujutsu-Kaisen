using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gabriel_Araujo___Quiz
{
    public partial class Form2 : Form
    {
        public int contador = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                contador++;
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            label1.Text = "2. Qual é o shikigami mais poderoso de Megumi Fushiguro dentro de seu arsenal de invocações?";
            radioButton1.Text = "a) Elefante Max.";
            radioButton2.Text = "b) Jardim das Sombras Sobrepostas.";
            radioButton3.Text = "c) Mahoraga.";
            radioButton4.Text = "d) Cão Divino: Totalidade.";
            radioButton5.Text = "e) Nue.";

            this.BackgroundImage = Properties.Resources._2;
            pictureBox1.Image = Properties.Resources.megumi;

            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                contador++;
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            label1.Text = "3. Nobara Kugisaki possui em seu arsenal de jujutsu uma tecnica chamada Tomonari, em portugues Ressonancia. No que consiste essa tecnica?";
            radioButton1.Text = "a) Através de uma boneca de palha e parte da maldição, ela consegue causar danos na maldição toda vez que ferir a boneca de palha. ";
            radioButton2.Text = "b) Expande energia amaldiçoada em forma de um raio e causa grandes danos ao oponente.";
            radioButton3.Text = "c) Ela junto de uma arma se torna somente um, aumentando seu poder durante um tempo.";
            radioButton4.Text = "d) Localiza inimigos perto do feiticeiro jujutsu.";
            radioButton5.Text = "e) Faz tudo voltar 300 segundos antes e causa dano gigantesco na maldição oponente.";

            this.BackgroundImage = Properties.Resources._3;
            pictureBox1.Image = Properties.Resources.nobara;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                contador++;
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            label1.Text = "4. Qual dos nomes abaixo é o nome dado ao dominio inato de Satoru Gojo:";
            radioButton1.Text = "a) Tecnica Amaldiçoada: Azul.";
            radioButton2.Text = "b) Tecnica Amaldiçoada Reversa: Vermelho.";
            radioButton3.Text = "c) Vazio: Roxo.";
            radioButton4.Text = "d) Seis Olhos.";
            radioButton5.Text = "e) Void Ilimitado.";
            this.ForeColor = Color.White;

            this.BackgroundImage = Properties.Resources._4;
            pictureBox1.Image = Properties.Resources.gojo;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                contador++;
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            label1.Text = "5. Toge Inumaki possui um simbolo que representa seu clâ e sua tecnica almodiçoada. Qual é a descrição desse simbolo e qual tecnica amaldiçoada é utilizado por seu clã, respectivamente:";
            radioButton1.Text = "a) Olhos e Presas de Serpente, Fala Amaldiçoada.";
            radioButton2.Text = "b) Seis Olhos, Infinito.";
            radioButton3.Text = "c) Duas Faces, Santuario Malevólo.";
            radioButton4.Text = "d) Sombras Sobrepostas, Shikigamis.";
            radioButton5.Text = "e) Dominio Inato, Armas Amaldiçoadas.";

            this.BackgroundImage = Properties.Resources._5;
            pictureBox1.Image = Properties.Resources.inumaki;
            this.ForeColor = Color.Black;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = true;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                contador++;
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            label1.Text = "6. Maki Zenin é uma personagem que não consegue ver espiritos amaldiçoados sem seu oculos. Isso se deve a:";
            radioButton1.Text = "a) Ter nascido no clã Zenin.";
            radioButton2.Text = "b) Não saber usar sua energia amaldiçoada.";
            radioButton3.Text = "c) Não ter energia amaldiçoada, somente conseguindo imbuir em suas armas.";
            radioButton4.Text = "d) Não ter nascido com energia amaldiçoada em seu corpo. ";
            radioButton5.Text = "e) Por conta de um acidente que fez ela perder sua energia amaldiçoada pelo resto de sua vida.";

            this.BackgroundImage = Properties.Resources._6;
            pictureBox1.Image = Properties.Resources.maki;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false; 
            button6.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                contador++;
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            label1.Text = "7. O Panda, marionete feita pelo diretor da escola de feiticeiros de Tokyo, possui 3 almas em seu corpo, sendo elas:";
            radioButton1.Text = "a) Gorila, Gavião e Urso.";
            radioButton2.Text = "b) Panda, Triceratops e Gorila.";
            radioButton3.Text = "c) Chimpanzé, Galinha e Panda.";
            radioButton4.Text = "d) Formiga, Gorila e Panda.";
            radioButton5.Text = "e) Panda, Urso Polar e Urso Pardo.";

            this.BackgroundImage = Properties.Resources._7;
            pictureBox1.Image = Properties.Resources.panda;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = true;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                contador++;
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            label1.Text = "8. Yuta Okotsu era considerado um feiticeiro de que nivel quando começou na escola para feiticeiros de Tokyo?";
            radioButton1.Text = "a) Grau 1.";
            radioButton2.Text = "b) Grau 4.";
            radioButton3.Text = "c) Grau 3.";
            radioButton4.Text = "d) Grau Especial.";
            radioButton5.Text = "e) Grau 2.";

            this.BackgroundImage = Properties.Resources._8;
            pictureBox1.Image = Properties.Resources.yuta;
            this.ForeColor = Color.White;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = true;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                contador++;
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            label1.Text = "9. Sukuna, uma das maiores maldições vivas no universo de Jujutsu Kaisen, é conhecido como:";
            radioButton1.Text = "a) Rei dos Envenenamentos.";
            radioButton2.Text = "b) Maldição Suprema.";
            radioButton3.Text = "c) Duas Faces.";
            radioButton4.Text = "d) Veterano do Jujutsu.";
            radioButton5.Text = "e) Rei das Maldições.";

            this.BackgroundImage = Properties.Resources._9;
            pictureBox1.Image = Properties.Resources.sukuna;
            this.ForeColor = Color.White;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = true;
            button10.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                contador++;
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            label1.Text = "10. Para que a tecnica amaldiçoada de Todo funcione, é necessaria completar uma condição para que troque de lugar com alguém no campo de batalha. Qual é a condição correta:";
            radioButton1.Text = "a) Bater Palma.";
            radioButton2.Text = "b) Bater os Pés.";
            radioButton3.Text = "c) Liberar Energia.";
            radioButton4.Text = "d) Ter Uma Boa Quantidade De Energia.";
            radioButton5.Text = "e) Estar Em Uma Situação De Perigo Ao Usuário.";

            this.BackgroundImage = Properties.Resources._10;
            pictureBox1.Image = Properties.Resources.todo;
            this.ForeColor = Color.Black;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                contador++;
            }

            MessageBox.Show("Parabens por ter completado o quiz!!Sua pontuação foi " + contador + "/10");
  
            Application.Exit();
        }
    }
}

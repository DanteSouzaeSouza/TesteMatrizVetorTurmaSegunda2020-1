using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteMatrizVetorTurmaSegunda2020_1
{
    public partial class FrmVetorMatriz : Form
    {
        // declarando e inicializando um vetor
        // a lista inicializadora especifica o número de elementos
        // e o valor de cada elemento
        readonly int[] y = { 5, 8, 25, -32, 40 };

        //declara a variável nomes omitindo o tamanho da
        //variavel e utilizando uma lista inicializadora

        readonly string[,] nomes = { { "João", "Antonio" }, { "Maria", "Ana" } };


        // criado método sem retorno de valor que
        // limpa o estado dos componentes
        public void LimpaTela()
        {
            lstVetor.Items.Clear();
            lstMatriz.Items.Clear();
        }


        public FrmVetorMatriz()
        {
            InitializeComponent();
        }

        private void btnVetor_Click(object sender, EventArgs e)
        {
            // limpando o listbox
            LimpaTela();

            // percorrendo o vetor
            int j = 1;

            foreach (int i in y)
            {
                // adicionando os elementos do vetor à ListBox
                lstVetor.Items.Add("Elemento [" + j + "] = " + i);
                j++;
            }
        }
        private void btnVetorFor_Click(object sender, EventArgs e)
        {
            // limpando o listBox
            LimpaTela();

            // percorrendo os elementos do vetor
            for (int i = 0; i < y.Length; i++)
            {
                // adicionando os elementos à lista
                lstVetor.Items.Add("Elemento [" + (i + 1) + "] = " + y[i]);
            }
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            LimpaTela();

            for (int i = 0; i < 2; i++)   //percorre as linhas
            {
                for (int j = 0; j < 2; j++)  //percorre as colunas
                {
                    // Escrever os elementos na listbox
                    lstMatriz.Items.Add("Elemento [" + (i+1) +
                                        " , " + (j+1) + "] = " + nomes[i, j]);
                   
                }
            }
        }
    }
}

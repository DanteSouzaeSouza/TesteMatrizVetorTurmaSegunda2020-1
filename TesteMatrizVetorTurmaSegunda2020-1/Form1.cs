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


        public FrmVetorMatriz()
        {
            InitializeComponent();
        }

        private void btnVetor_Click(object sender, EventArgs e)
        {
            // limpando o listbox
            lstVetor.Items.Clear();
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
            lstVetor.Items.Clear();

            // percorrendo os elementos do vetor
            for (int i = 0; i < y.Length; i++)
            {
                // adicionando os elementos à lista
                lstVetor.Items.Add("Elemento [" + (i + 1) + "] = " + y[i]);
            }
        }
    }
}

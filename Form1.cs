using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDtarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Adicionar as colunas ao DataGrigView
            dgvTarefa.Columns.Add("colTarefa", "Tarefa");
            dgvTarefa.Columns.Add("colResponsavel", "Responsável");
            dgvTarefa.Columns.Add("colSetor", "Setor");
            dgvTarefa.Columns.Add("colData", "Data Limite");
            string[] setores = { "Administrativo", "Financeiro", "Suporte", "Atendimento", "Desenvolvimento" };
            //Adicionar os setores ao cmb:
            cmbSetor.Items.AddRange(setores);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Verificar se o campo está vazio:
            if (string.IsNullOrEmpty(txbNome.Text) && txbNome.Text.Length > 3)
            {
                MessageBox.Show("O nome da tarefa não pode ficar em branco",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txbRespon.Text) && txbRespon.Text.Length > 3) 
            {
                MessageBox.Show("O nome do responsável não pode ficar em branco",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbSetor.SelectedIndex == -1)
            {
                MessageBox.Show("O setor não pode ficar em branco",
                       "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpData.Value < DateTime.Today)
            {
                MessageBox.Show("Não é possivel adcionar tarefas passadas.",
                       "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tarefa = txbNome.Text;
                string respon = txbRespon.Text;
                string setor = cmbSetor.Text;
                DateTime data = dtpData.Value;

                dgvTarefa.Rows.Add(tarefa, respon, setor, data);
                 
                //Limpar os campos:
                txbNome.Clear();
                txbRespon.Clear();
                cmbSetor.SelectedIndex = -1;
                dtpData.Value = DateTime.Today; //Retornar a data de hoje
            }



        }

        private void pibApagar_Click(object sender, EventArgs e)
        {
            
            //Verificar se existe alguma celula selecionada:
            if (dgvTarefa.SelectedCells.Count > 0)
            {
                //Obter a linha selecionada:
                int linhaselecionada = dgvTarefa.SelectedCells[0].RowIndex;

                //Perguntar se o usuário quer realmente remover:
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja remover?",
                    "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    //Apagar:
                    dgvTarefa.Rows.RemoveAt(linhaselecionada);
                }
            }
            else
            {
                MessageBox.Show("Selecioneuma linha para remover!",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void dgvTarefa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pibApagar_Click(pibApagar, EventArgs.Empty);
        }
    }
}

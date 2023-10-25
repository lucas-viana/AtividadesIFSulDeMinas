using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeTabela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            carregarDados();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tasks = txtTarefa.Text;
            string date = dateFinishTask.Text;

            //DataTable dt = new DataTable();
            dgTarefas.Rows.Add(new object[] { tasks, date });
            salvarDados();
            //dt.Rows.Add("Lucas", "Teste");
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Deseja mesmo expluir a linha selecionada?", "Deseja excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                    dgTarefas.Rows.RemoveAt(dgTarefas.CurrentRow.Index); 
            }
            salvarDados();
        }

        private void salvarDados()
        {
            using (StreamWriter sw = new StreamWriter("dados.txt"))
            {
                foreach (DataGridViewRow row in dgTarefas.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string linha = "";
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            linha += cell.Value.ToString() + ";";
                        }
                        sw.WriteLine(linha.TrimEnd(';'));
                    }
                }
            }
        }

        public void carregarDados()
        {
            if (File.Exists("dados.txt"))
            {
                using (StreamReader sr = new StreamReader("dados.txt"))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] valores = linha.Split(';'); 

                        if (valores.Length == dgTarefas.ColumnCount)
                            dgTarefas.Rows.Add(valores);                       
                        else
                        {
                            MessageBox.Show("O número de colunas no arquivo não corresponde ao DataGridView.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("O arquivo especificado não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

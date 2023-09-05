using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Reflection;
using TestesFuncionaisSAG.PageObject;

namespace TestesFuncionaisSAG.Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxUsuario;
            textBoxUsuario.Text = "itauf.987340766";
            textBoxSenha.Text = "040506";
        }

        private void radioProducao_CheckedChanged(object sender, EventArgs e)
        {
            if (radioProducao.Checked)
            {
                labelURL.Text = "https://sag.itau.com.br/";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHomologacao.Checked)
            {
                labelURL.Text = "https://saghom.itau.com.br/";
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxLoginVirtual_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLoginVirtual.Checked)
            {
                textBoxEbusinessId.Enabled = true;
            }
            else
            {
                textBoxEbusinessId.Enabled = false;
            }
        }

        private void buttonTestes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsuario.Text) || string.IsNullOrEmpty(textBoxSenha.Text))
            {
                MessageBox.Show("Usuário e Senha são obrigatórios.");

            }
            else
            {
                if (checkBoxLoginVirtual.Checked && string.IsNullOrEmpty(textBoxEbusinessId.Text))
                    MessageBox.Show("EbusinessId é obrigatório quando Login Virtual estiver selecionado.");


                IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

                driver.Manage().Window.Maximize();
                
                var login = new LoginPO(driver);
                var telaInicial = new TelaInicialPO(driver);
                var menuPrincipal = new MenuPrincipalPO(driver);
                var ambienteProducao = radioProducao.Checked;
                var usuario = textBoxUsuario.Text;
                var senha = textBoxSenha.Text;
                var loginVirtual = checkBoxLoginVirtual.Checked;
                var ebusinessId = textBoxEbusinessId.Text;

                try
                {
                    var listaMenuOperacoesRealizadas = checkedListBoxOperacoesRealizadas.CheckedItems;

                    if (listaMenuOperacoesRealizadas.Count > 0)
                    {
                        var menuOperacoesRealizadas = new MenuOperacoesRealizadas(driver, login, telaInicial,
                            menuPrincipal, ambienteProducao, usuario, senha, loginVirtual, ebusinessId);

                        painelStatusExecucao.Text = string.Empty;

                        foreach (string item in listaMenuOperacoesRealizadas)
                        {
                            painelStatusExecucao.AppendText(item + "\r\n");
                            var sucessoExecucao = false;

                            if (item == "Operações Realizadas")
                                sucessoExecucao = menuOperacoesRealizadas.OperacoesRealizadas();
                            else if (item == "Repasses")
                                sucessoExecucao = menuOperacoesRealizadas.Repasses();

                            SetColor(sucessoExecucao, item);

                        }

                        var aca = "";
                    }
                }
                catch (Exception ex)
                {
                    var erro = ex;
                    MessageBox.Show("Ocorreu um erro durante a execução.");
                }

                var casa = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void SetColor(bool sucessoExecucao, string texto)
        {
            painelStatusExecucao.Find(texto);
            if (sucessoExecucao)
                painelStatusExecucao.SelectionColor = Color.Green;
            else
                painelStatusExecucao.SelectionColor = Color.Red;
        }
    }
}
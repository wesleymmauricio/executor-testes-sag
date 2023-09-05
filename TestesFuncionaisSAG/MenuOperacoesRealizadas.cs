using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TestesFuncionaisSAG.PageObject;

namespace TestesFuncionaisSAG
{
    public class MenuOperacoesRealizadas: MenuBase
    {
        public IWebDriver _driver { get; set; }
        public LoginPO _login { get; set; }
        public TelaInicialPO _telaInicial { get; set; }
        public MenuPrincipalPO _menuPrincipal { get; set; }
        public bool _ambienteProducao { get; set; }
        public string _usuario { get; set; }
        public string _senha { get; set; }
        public bool _loginVirtual { get; set; }
        public string _ebusinessId { get; set; }

        public MenuOperacoesRealizadas(IWebDriver driver, LoginPO login, TelaInicialPO telaInicial, 
            MenuPrincipalPO menuPrincipal, bool ambienteProducao, string usuario, string senha, 
            bool loginVirtual, string ebusinessId)
        {
            _driver = driver;
            _login = login;
            _menuPrincipal = menuPrincipal;
            _telaInicial = telaInicial;
            _ambienteProducao = ambienteProducao;
            _usuario = usuario;
            _senha = senha;
            _loginVirtual = loginVirtual;
            _ebusinessId = ebusinessId;

        }

        public void AcoesDefault()
        {
            _login.AcessarTelaLogin(_ambienteProducao);

            if (!_logado)
            {
                _login.RealizarLogin(_usuario, _senha);

                if (_loginVirtual)
                {
                    _telaInicial.RealizarLoginVirtual(_ebusinessId);
                }

                _logado = true;
            }

            _menuPrincipal.SelecionarMenuOperacoesEPosicao();
        }

        public bool OperacoesRealizadas()
        {
            AcoesDefault();
            _menuPrincipal.SelecionarSubMenuOperacoesRealizadas();
            var statusExecucao = _menuPrincipal.ValidarTelaOperacoesRealizadas();
            var screenShot = ((ITakesScreenshot)_driver).GetScreenshot();
            var path = "C:\\Users\\enzom\\OneDrive\\Área de Trabalho\\ScreenShot\\";
            screenShot.SaveAsFile(path + "imagem1.png", ScreenshotImageFormat.Png);
            return statusExecucao;
        }

        public bool Repasses()
        {
            AcoesDefault();
            _menuPrincipal.SelecionarSubMenuRepasses();
            var statusExecucao = _menuPrincipal.ValidarTelaRepasses();
            var screenShot = ((ITakesScreenshot)_driver).GetScreenshot();
            var path = "C:\\Users\\enzom\\OneDrive\\Área de Trabalho\\ScreenShot\\";
            screenShot.SaveAsFile(path + "imagem2.png", ScreenshotImageFormat.Png);
            return statusExecucao;
        }
    }
}
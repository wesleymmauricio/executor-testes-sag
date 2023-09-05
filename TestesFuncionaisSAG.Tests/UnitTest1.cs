using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Reflection;
using TestesFuncionaisSAG.Tests.PageObject;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;

namespace TestesFuncionaisSAG.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            var loginPO = new LoginPO(driver);
            loginPO.AcessarTelaLogin();
            loginPO.RealizarLogin("itauf.987340766", "040506");

            var telaInicialPO = new TelaInicialPO(driver);
            telaInicialPO.RealizarLoginVirtual("itauf.007657653");

            var menuPrincipal = new MenuPrincipalPO(driver);
            menuPrincipal.SelecionarMenuOperacoesEPosicao();
            menuPrincipal.SelecionarSubMenuOperacoesRealizadas();

            var casa = "re";

        }
    }
}
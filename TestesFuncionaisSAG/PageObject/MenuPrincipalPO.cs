using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace TestesFuncionaisSAG.PageObject
{
    public class MenuPrincipalPO
    {
        public IWebDriver _driver { get; set; }

        public MenuPrincipalPO(IWebDriver driver)
        {
            _driver = driver;
        }

        public void SelecionarMenuOperacoesEPosicao()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            var actions = new Actions(_driver);

            // Seleciona menu Opercações e Posição
            Thread.Sleep(1000);
            var xpathMenuOperacoesPosicao = ".//a[text()='Operações e Posição']";
            var middleOfficeElement = wait.Until(drv => drv.FindElement(By.XPath(xpathMenuOperacoesPosicao)));
            actions.MoveToElement(middleOfficeElement);
            actions.MoveToElement(middleOfficeElement).Perform();
        }

        public void SelecionarSubMenuOperacoesRealizadas()
        {
            // Seleciona sub menu Operações Realizadas
            _driver.FindElement(By.LinkText("Operações Realizadas")).Click();
        }

        public bool ValidarTelaOperacoesRealizadas()
        {
            return true;
        }

        public void SelecionarSubMenuRepasses()
        {
            // Seleciona sub menu Repasses
            _driver.FindElement(By.LinkText("Repasses")).Click();
        }

        public bool ValidarTelaRepasses()
        {
            return false;
        }
    }
}

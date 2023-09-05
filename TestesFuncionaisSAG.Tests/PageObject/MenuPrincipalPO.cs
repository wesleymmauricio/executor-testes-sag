using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace TestesFuncionaisSAG.Tests.PageObject
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
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            var actions = new Actions(_driver);

            // Seleciona menu Opercações e Posição
            var menuOperacaoPosicao = ".//a[text()='Operações e Posição']";
            wait.Until(drv => drv.FindElement(By.XPath(menuOperacaoPosicao)));
            var middleOfficeElement = _driver.FindElement(By.XPath(menuOperacaoPosicao));
            actions.MoveToElement(middleOfficeElement);
            actions.MoveToElement(middleOfficeElement).Perform();
        }

        public void SelecionarSubMenuOperacoesRealizadas()
        {
            // Seleciona sub menu Operações Realizadas
            _driver.FindElement(By.LinkText("Operações Realizadas")).Click();
        }
    }
}

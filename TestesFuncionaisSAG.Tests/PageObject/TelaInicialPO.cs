using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace TestesFuncionaisSAG.Tests.PageObject
{
    public class TelaInicialPO
    {
        private IWebDriver _driver { get; set; }
        public TelaInicialPO(IWebDriver driver)
        {
            _driver = driver;
        }

        public void RealizarLoginVirtual(string eBusinesLoginVirtual)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            var actions = new Actions(_driver);
            
            // Seleciona menu Middle-Office
            var xpathMiddleOffice = ".//a[text()='Middle-Office']";
            wait.Until(drv => drv.FindElement(By.XPath(xpathMiddleOffice)));
            var middleOfficeElement = _driver.FindElement(By.XPath(xpathMiddleOffice));
            actions.MoveToElement(middleOfficeElement);
            actions.MoveToElement(middleOfficeElement).Perform();

            // Seleciona Login Virtual
            _driver.FindElement(By.LinkText("Login Virtual")).Click();

            // Seleciona comboBox, opção EbusinessId
            var selectTypeUser = new SelectElement(_driver.FindElement(By.Id("BMFNet_LogonVirtualItaucor_cboChave")));
            selectTypeUser.SelectByValue("E");

            // Digita ebusinessId
            _driver.FindElement(By.Id("BMFNet_LogonVirtualItaucor_txtConteudo")).SendKeys(eBusinesLoginVirtual);

            // Clica no botão buscar
            var buscarButton = _driver.FindElement(By.Id("BMFNet_LogonVirtualItaucor_btnOk"));
            actions.MoveToElement(buscarButton);
            buscarButton.Click();
            
            // Seleciona usuário no grid
            var linkPerfilVirtual = "BMFNet_LogonVirtualItaucor_grdUsuarios_ctl03_Linkbutton2";
            wait.Until(drv => drv.FindElement(By.Id(linkPerfilVirtual)));
            _driver.FindElement(By.Id(linkPerfilVirtual)).Click();
        }
    }
}

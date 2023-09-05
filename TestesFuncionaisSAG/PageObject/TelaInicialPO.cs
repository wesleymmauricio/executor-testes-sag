using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace TestesFuncionaisSAG.PageObject
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
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            var actions = new Actions(_driver);

            try
            {
                // Seleciona menu Middle-Office
                var xpathMiddleOffice = ".//a[text()='Middle-Office']";
                Thread.Sleep(1000);
                var middleOfficeElement = wait.Until(drv => drv.FindElement(By.XPath(xpathMiddleOffice)));
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
                var buscarButton = actions.MoveToElement(_driver.FindElement(By.Id("BMFNet_LogonVirtualItaucor_btnOk")));
                _driver.FindElement(By.Id("BMFNet_LogonVirtualItaucor_btnOk")).Click();

                // Seleciona usuário no grid
                var linkPerfilVirtual = "BMFNet_LogonVirtualItaucor_grdUsuarios_ctl03_Linkbutton2";
                var perfilGrid = wait.Until(drv => drv.FindElement(By.Id(linkPerfilVirtual)));
                perfilGrid.Click();

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

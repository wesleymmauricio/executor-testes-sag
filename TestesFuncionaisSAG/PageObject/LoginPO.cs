using OpenQA.Selenium;

namespace TestesFuncionaisSAG.PageObject
{
    public class LoginPO
    {
        private IWebDriver _driver { get; set; }
        
        public LoginPO(IWebDriver driver)
        {
            _driver = driver;
        }

        public void AcessarTelaLogin(bool producao)
        {
            if (producao)
                _driver.Navigate().GoToUrl("https://sag.itau.com.br/");
            else
                _driver.Navigate().GoToUrl("https://saghom.itau.com.br/");
        }

        public void RealizarLogin(string username, string password)
        {
            _driver.FindElement(By.Id("txtUsuario")).SendKeys(username);
            _driver.FindElement(By.Id("txtSenha")).SendKeys(password);

            _driver.FindElement(By.XPath(".//button[@type='submit']")).Click(); 
        }
    }
}

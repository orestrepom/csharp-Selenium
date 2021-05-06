using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace sahiTest
{
   public class LoginPage : BasePage
    {
    public LoginPage(){
          PageFactory.InitElements(driver, this);
    }

    [FindsBy(How = How.CssSelector, Using = ":nth-child(1) > :nth-child(2) > input")]
    public IWebElement username { get; set; }

    [FindsBy(How = How.CssSelector, Using = ":nth-child(2) > :nth-child(2) > input")]
    public IWebElement password { get; set; }

    [FindsBy(How = How.CssSelector, Using = ".button")]
    public IWebElement loginButton
     { get; set; }
    }

}

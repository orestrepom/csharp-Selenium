using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace sahiTest
{

 public class HomePage : BasePage
  {
       public HomePage(){
          PageFactory.InitElements(driver, this);
       }

    [FindsBy(How = How.CssSelector, Using = "#available > h2")]
    public IWebElement HomePageValidationText { get; set; }

    [FindsBy(How = How.CssSelector, Using = ":nth-child(2) > :nth-child(4) > input")]
    public IWebElement JavaField { get; set; }

    [FindsBy(How = How.CssSelector, Using = ":nth-child(3) > :nth-child(4) > input")]
    public IWebElement RubyField { get; set; }

    [FindsBy(How = How.CssSelector, Using = ":nth-child(4) > :nth-child(4) > input")]
    public IWebElement PythonField { get; set; }

    [FindsBy(How = How.CssSelector, Using = "input[value=Add]")]
    public IWebElement AddButton { get; set; }

    [FindsBy(How = How.CssSelector, Using = "input[value=Clear]")]
    public IWebElement ClearButton { get; set; }

  }
}

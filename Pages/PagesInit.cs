using System;

namespace sahiTest
{
    public class Pages
    {
        [ThreadStatic]
        public static LoginPage loginPage;

        [ThreadStatic]
         public static HomePage homePage;

        public static void Init()
        {
            loginPage = new LoginPage();
            homePage = new HomePage();
        }
    }
}

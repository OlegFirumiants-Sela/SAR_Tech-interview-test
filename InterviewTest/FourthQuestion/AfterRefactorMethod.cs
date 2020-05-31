using System;

namespace FourthQuestion
{
    class AfterRefactorMethod
    {
        void TestMethod(Action action)
        {
            string url = “www.google.com”;

            OpenChromeBrowser();

            NavigateToUrl(url);

            SearchTheWord(“selenium”);

            action();

            CloseTheBrowser();

        }
    }
}

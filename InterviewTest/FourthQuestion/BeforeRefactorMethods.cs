namespace FourthQuestion
{
    class BeforeMethods
    {
        void TestMethod1()
        {
            string url = “www.google.com”;

            OpenChromeBrowser();

            NavigateToUrl(url);

            SearchTheWord(“selenium”);

            OpenFirstLink();

            CloseTheBrowser();

        }

        void TestMethod2()
        {
            string url = “www.bing.com”;

            OpenChromeBrowser();

            NavigateToUrl(url);

            SearchTheWord(“selenium”);

            CountTheResults();

            CloseTheBrowser();

        }

        void TestMethod3()
        {
            string url = “www.youtube.com”;

            OpenChromeBrowser();

            NavigateToUrl(url);

            SearchTheWord(“selenium”);

            PlayTheFirstVideo();

            CloseTheBrowser();

        }

    }
}

}
}

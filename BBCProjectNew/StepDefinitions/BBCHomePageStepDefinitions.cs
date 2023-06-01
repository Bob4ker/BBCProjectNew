using BBCProjectNew.Hooks;
using BBCProjectNew.PageObjects;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BBCProjectNew.StepDefinitions
{
    [Binding]
    public class BBCHomePageStepDefinitions 
    {
        BBCPage bBCPage = new BBCPage();

        [Given(@"A user navigate to a website ""([^""]*)""")]
        public void GivenAUserNavigateToAWebsite(string url)
        {
            bBCPage.NavigateToUrl(url);
        }
        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            bBCPage.ClickLogInButton();
        }

        [When(@"I enter my username ""([^""]*)""")]
        public void WhenIEnterMyUsername(string usr)
        {
            bBCPage.EnterUserName(usr);
        }

        [When(@"I enter my password ""([^""]*)""")]
        public void WhenIEnterMyPassword(string pword)
        {
            bBCPage.EnterPassword(pword);
        }

        [When(@"I click on sign in")]
        public void WhenIClickOnSignIn()
        {
            bBCPage.ClickSignInButton();
        }

        [When(@"I click on sounds on the header")]
        public void WhenIClickOnSoundsOnTheHeader()
        {
            bBCPage.ClickSoundsButton();
        }
        [When(@"I click on music")]
        public void WhenIClickOnMusic()
        {
            bBCPage.ClickMusicButton();
        }
       

        [When(@"I click on Hip Hop, RnB & Dancehall")]
        public void WhenIClickOnHipHopRnBDancehall()
        {
            bBCPage.ClickHipHop();
        }

        [When(@"I click on Xtra's R&B Chill Mix")]
        public void WhenIClickOnXtrasRBChillMix()
        {
            bBCPage.ClickXtra();
        }


        [Then(@"music start playing")]
        public void ThenMusicStartPlaying()
        {
            bBCPage.MusicStartPlaying().Should().BeTrue();
        }

    }
}

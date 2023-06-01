using BBCProjectNew.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCProjectNew.PageObjects
{
    public class BBCPage
    {
        public static IWebDriver driver;

        public BBCPage()
        {
            driver = BaseTest.driver;
        }

        private By sounds = By.CssSelector("#header-content > nav > div.ssrcss-1ocoo3l-Wrap.e42f8511 > div > div.ssrcss-fr8ebb-GlobalNavigationItem.e1gviwgp23 > ul.ssrcss-1p6tp05-ChameleonGlobalNavigationLinkList-En.e16i5fd20 > li:nth-child(6) > a > span");
        private By music = By.CssSelector("#main > div > div > nav > div > div > ul > li:nth-child(2) > a > span");
        private By login = By.CssSelector("#header-content > nav > div.ssrcss-1ocoo3l-Wrap.e42f8511 > div > div.ssrcss-fr8ebb-GlobalNavigationItem.e1gviwgp23 > ul.ssrcss-76eozk-AccountOptionsList.e1gviwgp0 > li.ssrcss-1ylam2-GlobalNavigationProduct-GlobalNavigationNonProductItem-GlobalNavigationAccount.e1gviwgp19 > a > span.ssrcss-qgttmg-AccountText.e1gviwgp4");
        private By username = By.CssSelector("#user-identifier-input");
        private By password = By.CssSelector("#password-input");
        private By signin = By.XPath("//*[@id=\"submit-button\"]/span");
        private By hiphop = By.CssSelector("#sounds-app-promo-experimentation-portal-container > section:nth-child(9) > section > div > ul > li:nth-child(9) > div > a > div > div.sc-c-rectangle-category-card__overlay.gs-u-display-flex.gel-1\\/1.sc-o-island__point.sc-o-island__point--b > div");
        private By xtra = By.CssSelector("#sounds-app-promo-experimentation-portal-container > section:nth-child(4) > section > div > ul > li:nth-child(5) > div > a > div.sc-o-island > div.sc-c-rsimage.sc-o-responsive-image.sc-o-responsive-image--1by1 > div > svg");
        private By subscribe = By.CssSelector("#sounds-app-promo-experimentation-portal-container > div.gel-wrap.gs-u-box-size.gs-u-mt-alt\\+ > div > div.gel-layout.sc-c-action-buttons.gs-u-mb-alt\\+.gs-u-mb0\\@m > button.gs-u-align-middle.sc-c-admin-button.sc-o-button.sc-o-link.sw-qa-subscribe-button > div.sc-c-admin-button__alternative > div.gel-brevier-bold.gs-u-align-middle.sc-o-link__text.gs-u-align-center.sc-o-button__text.gs-u-display-block.gs-u-mt.gs-u-ml0");


        public void ClickSoundsButton()
        {
            driver.FindElement(sounds).Click();
        }
        public void NavigateToUrl(string url)
        {

            driver.Navigate().GoToUrl(url);
        }
        public void ClickMusicButton()
        {
            Thread.Sleep(1000);
            driver.FindElement(music).Click();
        }

        public void ClickLogInButton()
        {
            Thread.Sleep(1000);
            driver.FindElement(login).Click();

        }
        public void EnterUserName(string usr)
        {
            Thread.Sleep(1000);
            driver.FindElement(username).SendKeys(usr);
        }
        public void EnterPassword(string pword)
        {
            Thread.Sleep(1000);
            driver.FindElement(password).SendKeys(pword);
        }
        public void ClickSignInButton()
        {
            Thread.Sleep(1000);


            driver.FindElement(signin).Click();
        }
        public void ClickHipHop()
        {
            Thread.Sleep(1000);
            driver.FindElement(hiphop).Click();
        }
        public void ClickXtra()
        {
            Thread.Sleep(2000);
            driver.FindElement(xtra).Click();
        }

        public bool MusicStartPlaying()
        {
            Thread.Sleep(4000);
            return driver.FindElement(subscribe).Displayed;
        }


    }
}

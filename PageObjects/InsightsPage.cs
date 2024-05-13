using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectTask.PageObjects
{
    public class InsightsPage
    {
        public By keywordInput = By.XPath("//*[@id='new_form_job_search-keyword']");
        public By rightArrowInCaurosel = By.CssSelector("button.slider__right-arrow.slider-navigation-arrow");
        public By articleTitleFromCaurusel = By.CssSelector("span.font-size-60 span.museo-sans-light");
        public By readMoreButton = By.CssSelector("a.custom-link.link-with-bottom-arrow.color-link.body-text.font-900.slider-cta-link");
    }
}

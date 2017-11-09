﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QAExamSite.Pages.AllEuropeCountries
{
   public partial class EuropeCountriesPage
    {

        
        public List<IWebElement> AllEuropeContriesList
        {
            get
            {
                this.Wait.Until(w => w.FindElement(By.XPath("//*[@id=\"content\"]/div[2]")).FindElements(By.TagName("li")));
                
                return this.Driver.FindElement(By.XPath("//*[@id=\"content\"]/div[2]")).FindElements(By.TagName("li")).ToList();
            }
        }


        


    }


}

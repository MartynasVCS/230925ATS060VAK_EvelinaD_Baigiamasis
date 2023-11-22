﻿using Framework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class EShopPhonesPageFunctionality : BaseTests
    {
        [Test]
        public void FiltersFunctionality()
        {
            bool expectedFilteredSearchResult = true;

            Telia.ClickEshopSelectionButton();
            Telia.SelectPhonesFromEshopSelection();
            TeliaPrekes.SelectCheckboxApplePhones();
            bool actualFilteredSearchResult = TeliaPrekes.GetAllFilteredSearchResults();

            Assert.That(actualFilteredSearchResult, Is.EqualTo(expectedFilteredSearchResult));
        }
    }
}
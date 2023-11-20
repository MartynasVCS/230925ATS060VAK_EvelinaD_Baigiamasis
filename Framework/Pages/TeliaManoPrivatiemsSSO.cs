﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class TeliaManoPrivatiemsSSO
    {
        private static string emailInputField = "(//*[@placeholder='El. pašto adresas'])[2]";
        private static string submitButton = "//telia-button//*[text()='Tęsti']";
        private static string emailInputFieldErroMessage = "//telia-text-input//*[text()='Neteisingai įvestas el. pašto adresas']";

        public static void AddValueToEmailInputField(string emailValue)
        {
            Common.SendKeysToElement(emailInputField, emailValue);
        }
        public static void ClickSubmitButton()
        {
            Common.ClickElement(submitButton);
        }

        public static string GetEmailInputErrorMessage()
        {
            string locator = "//*[contains(text(),'Neteisingai įvestas el. pašto adresas')]";
            IWebElement element = Common.GetElement(emailInputFieldErroMessage);
            string actualLocator = element.Text;

            if (locator == actualLocator)
            {
                return locator;
            }
            else
            {
                return actualLocator;
            }
        }

        public static string GetEmailInputBorderColor()
        {
            return Common.GetElementCssPropertyValue(emailInputField, "border-color");
        }
    }
}
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Assignment1
{
    public class Exercise1
    {
        static IWebDriver driver = new ChromeDriver();
        private static object actions;

        //static IWebElement radio1;

        static void Main()
        {
            string url = "http://www.qaclickacademy.com/practice.php ";
            driver.Navigate().GoToUrl(url);
            exerciseone();
            exercisetwo();
            exercisefour();
            execerisethree();
            execerisefive();
            execerisesix();
            execeriseseven();
            execeriseight();
            execerisenine();



        }


        public static void exerciseone()
        {

            IWebElement radio1 = driver.FindElement(By.XPath("//*[@id=\"radio-btn-example\"]/fieldset/label[1]/input"));

            radio1.Click();

            if (radio1.GetAttribute("checked") == "true")
            {
                Console.WriteLine("radio button1 is checked");
            }
            else
            {
                Console.WriteLine("went wrong");
            }
            Thread.Sleep(3000);

            IWebElement radio2 = driver.FindElement(By.XPath("//*[@id=\"radio-btn-example\"]/fieldset/label[2]/input"));

            radio2.Click();

            if (radio2.GetAttribute("checked") == "true")
            {
                Console.WriteLine("radio button2 is checked");
            }
            else
            {
                Console.WriteLine("went wrong");
            }
            Thread.Sleep(3000);


            IWebElement radio3 = driver.FindElement(By.XPath("//*[@id=\"radio-btn-example\"]/fieldset/label[3]/input"));

            radio3.Click();

            if (radio3.GetAttribute("checked") == "true")
            {
                Console.WriteLine("radio button3 is checked");
            }
            else
            {
                Console.WriteLine("went wrong");
            }
            Thread.Sleep(3000);

        }


        public static void exercisetwo()

        {
            IWebElement selectionbox = driver.FindElement(By.Id("autocomplete"));
            selectionbox.SendKeys("united");
            IList<IWebElement> sugbox = driver.FindElements(By.XPath("//*[@id=\"autocomplete\"]"));

            foreach (var suelement in sugbox)
            {
                if (suelement.Text.Contains("United States(USA"))
                {
                    suelement.Click();
                }

            }

        }

        public static void exercisefour()
        {

            //Click the checkbox adjacent to “Option1” in the “Checkbox Example” section and verify that it is checked off.
            driver.FindElement(By.CssSelector("#checkBoxOption1")).Click();
            Thread.Sleep(3000);
            //Console.WriteLine(checkbox1.GetAttribute("value"));

            //Deselect “Option1” and verify that it’s unchecked
            driver.FindElement(By.CssSelector("#checkBoxOption1")).Click();
            Console.WriteLine("Check box1 is Unchecked");
            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector("#checkBoxOption2")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector("#checkBoxOption2")).Click();
            Console.WriteLine("Check box 2 is Unchecked");
            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector("#checkBoxOption3")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector("#checkBoxOption3")).Click();
            Console.WriteLine("Check box 3 is Unchecked");
            Thread.Sleep(3000);

            for (int i = 1; i <= 3; i++)
            {
                IWebElement selectall = driver.FindElement(By.Id("checkBoxOption" + i + ""));
                selectall.Click();
                //Thread.Sleep(3000);
            }

        }

        public static void execerisethree()
        {
            IWebElement dropdown = driver.FindElement(By.XPath("//*[@id=\"dropdown-class-example\"]"));
            SelectElement dSelect = new SelectElement(dropdown);
            dropdown.Click();
            for (int i = 1; i < 4; i++)
            {
                dSelect.SelectByText("Option" + i + "");
                Thread.Sleep(1000);
            }

        }


        public static void execerisefive()
        {
            driver.FindElement(By.Id("openwindow")).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);

        }

        public static void execerisesix()
        {
            driver.FindElement(By.Id("opentab")).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);

        }

        public static void execeriseseven()
        {
            IWebElement al = driver.FindElement(By.Id("name"));
            al.Click();
            al.SendKeys("Prathi");
            Thread.Sleep(1000);
            IWebElement albtn = driver.FindElement(By.Id("alertbtn"));
            albtn.Click();
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1000);

        }

        public static void execeriseight()
        {

            IWebElement ele = driver.FindElement(By.Id("product"));
            ele.Click();
            Actions act = new Actions(driver);
            act.SendKeys(OpenQA.Selenium.Keys.End).Build().Perform();
        }

          
        public static void execerisenine()
        {
            var element = driver.FindElement(By.Id("mousehover"));
            Actions act=new Actions(driver);
            act.MoveToElement(element).Perform();
            Thread.Sleep(2000);
            IWebElement top=driver.FindElement(By.CssSelector("body > div:nth-child(6) > div > fieldset > div > div > a:nth-child(1)"));
            top.Click();
            act.MoveToElement(element).Perform();
            Thread.Sleep(1000);


        }
        

    }
    }

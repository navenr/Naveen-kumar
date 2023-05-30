using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
Tinternal class Class1
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://logicbomb.github.io/ng-directives/drag-drop.html");
        Thread.Sleep(1000);
        driver.Manage().Window.Maximize();

        IWebElement drag = driver.FindElement(By.XPath("//div[@class='peg green']"));
        IWebElement drop = driver.FindElement(By.XPath("//span[@class='slot ng-isolate-scope ng-scope green']"));
        Action builder = new Action(driver);
        Action.dragAndDrop(from, To).build().Perform();

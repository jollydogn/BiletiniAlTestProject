using System;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace BiletiniAlTestProject
{
    [TestFixture]
    public class Tests
    {
        public static string BASE_URL { get; set; } = "https://dev-web.biletinial.com/";

        [Test]
        public void Test_1_SinemaSayfasiGiris()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                IWebElement sinema = driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[1]/a[1]"));
                if (sinema != null)
                {
                    sinema.Click();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Test]
        public void Test_2_TiyatroSayfasiGiris()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                IWebElement sinema = driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[2]/a[1]"));
                if (sinema != null)
                {
                    sinema.Click();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Test]
        public void Test_3_MüzikSayfasiGiris()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                IWebElement sinema = driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[3]/a[1]"));
                if (sinema != null)
                {
                    sinema.Click();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Test]
        public void Test_4_SporSayfasiGiris()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                IWebElement sinema = driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[4]/a[1]"));
                if (sinema != null)
                {
                    sinema.Click();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Test]
        public void Test_5_TCKültürveTurizmBakanlığıSayfasiGiris()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                IWebElement tcKultur = driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[5]/a[1]"));
                IWebElement devletTiyatrolari =
                    driver.FindElement(
                        By.XPath("//body[1]/main[1]/header[1]/div[1]/div[1]/nav[1]/ul[1]/li[5]/div[1]/ul[1]/li[2]"));
                if (tcKultur != null && devletTiyatrolari != null)
                {
                    tcKultur.Click();
                    devletTiyatrolari.Click();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Test]
        public void Test_6_SehirDegisterme()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                IWebElement resimDegistir =
                    driver.FindElement(By.XPath("//body[1]/main[1]/section[2]/div[4]/div[3]/button[2]/span[1]"));
                resimDegistir.Click();
                Thread.Sleep(TimeSpan.FromSeconds(1));
                IWebElement sehirDegistirButton =
                    driver.FindElement(By.XPath("//span[contains(text(),'Şehir Değiştir')]"));
                sehirDegistirButton.Click();
                IWebElement sehirSec = driver.FindElement(By.XPath("//input[@id='citySearch']"));
                sehirSec.SendKeys("İstanbul Anadolu");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                IWebElement secilenSehir = driver.FindElement(By.XPath("//body/main[1]/section[1]/div[1]/div[1]/a[2]/span[2]"));
                secilenSehir.Click();
                Thread.Sleep(TimeSpan.FromSeconds(1));
                driver.WaitForPageLoad();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Test]
        public void Test_7_UyeOl()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://dev-web.biletinial.com/");
            driver.WaitForPageLoad();
            try
            {
                driver.Navigate().GoToUrl("https://dev-web.biletinial.com/WebLogin/Register?lang=tr");
                driver.WaitForPageLoad();
                IWebElement ad = driver.FindElement(By.XPath("//body/main[1]/section[2]/form[1]/div[1]/input[1]"));
                IWebElement soyad = driver.FindElement(By.XPath("//body/main[1]/section[2]/form[1]/div[1]/input[2]"));
                IWebElement email = driver.FindElement(By.XPath("//body/main[1]/section[2]/form[1]/div[2]/input[1]"));
                IWebElement telefon = driver.FindElement(By.XPath("//body/main[1]/section[2]/form[1]/div[3]/input[1]"));
                IWebElement sehir =
                    driver.FindElement(By.XPath("//body[1]/main[1]/section[2]/form[1]/div[4]/select[1]"));
                IWebElement sehirSec = driver.FindElement(By.XPath("//option[contains(text(),'Antalya')]"));
                IWebElement sifre = driver.FindElement(By.XPath("//input[@id='Password']"));
                IWebElement sifreTekrar = driver.FindElement(By.XPath("//input[@id='PasswordApprove']"));
                IWebElement kullanimSart = driver.FindElement(By.XPath("//input[@id='KullSart']"));
                IWebElement aboneOl = driver.FindElement(By.XPath("//input[@id='AboneOl']"));
                IWebElement uyeolButton = driver.FindElement(By.XPath("//button[contains(text(),'Üye Ol')]"));
                ad.SendKeys("Mehmet");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                soyad.SendKeys("KOCA");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                email.SendKeys("524234234sfdgsdfg@gmail.com");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                telefon.SendKeys("4290732091");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                sehir.Click();
                Thread.Sleep(TimeSpan.FromSeconds(1));
                sehirSec.Click();
                Thread.Sleep(TimeSpan.FromSeconds(1));
                sifre.SendKeys("123qweasdMm..");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                sifreTekrar.SendKeys("123qweasdMm..");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                kullanimSart.Click();
                Thread.Sleep(TimeSpan.FromSeconds(1));
                aboneOl.Click();
                Thread.Sleep(TimeSpan.FromSeconds(1));
                uyeolButton.Click();
                Thread.Sleep(TimeSpan.FromSeconds(1));
                driver.WaitForPageLoad();
            }
            catch (Exception e)
            {
                throw new Exception("test başarısız");
            }
        }

        [Test]
        public void Test_8_GirisYap()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                driver.Navigate().GoToUrl("https://dev-web.biletinial.com/WebLogin?lang=tr");
                driver.WaitForPageLoad();
                IWebElement email = driver.FindElement(By.XPath("//body/main[1]/section[2]/form[1]/div[1]/input[1]"));
                IWebElement sifre = driver.FindElement(By.XPath("//body/main[1]/section[2]/form[1]/div[2]/input[1]"));
                IWebElement girisYapButton = driver.FindElement(By.XPath("//button[contains(text(),'Giriş Yap')]"));

                if (email != null && sifre != null && girisYapButton != null)
                {
                    email.SendKeys("524234234sfdgsdfg@gmail.com");
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    sifre.SendKeys("123qweasdMm..");
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    girisYapButton.Click();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                throw new Exception("test başarısız");
            }
        }

        [Test]
        public void Test_9_TümSinemaKayit()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                IWebElement sinema = driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[2]/a[1]"));
                if (sinema != null)
                {
                    IWebElement testDiv =
                        driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[1]/a[1]"));
                    Actions builder = new Actions(driver);
                    Actions hoverClick = builder.MoveToElement(testDiv)
                        .MoveToElement(testDiv.FindElement(By.XPath("//a[contains(text(),'TÜMÜ')]"))).Click();
                    hoverClick.Build().Perform();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Test]
        public void Test_10_BornovaBelediyesi()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                IWebElement tiyatro = driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[2]/a[1]"));
                if (tiyatro != null)
                {
                    IWebElement testDiv =
                        driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[2]/a[1]"));
                    Actions builder = new Actions(driver);
                    Actions hoverClick = builder.MoveToElement(testDiv)
                        .MoveToElement(
                            testDiv.FindElement(By.XPath("//a[contains(text(),'Bornova Belediyesi Şehir Tiyatrosu')]")))
                        .Click();
                    hoverClick.Build().Perform();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Test]
        public void Test_11_TiyatroKafe()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                IWebElement tiyatro = driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[2]/a[1]"));
                if (tiyatro != null)
                {
                    IWebElement testDiv =
                        driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[2]/a[1]"));
                    Actions builder = new Actions(driver);
                    Actions hoverClick = builder.MoveToElement(testDiv)
                        .MoveToElement(testDiv.FindElement(By.XPath("//a[contains(text(),'Tiyatro Kafe')]"))).Click();
                    hoverClick.Build().Perform();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Test]
        public void Test_12_TiyatroKafeSehirEtkinlik()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                IWebElement tiyatro = driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[2]/a[1]"));
                if (tiyatro != null)
                {
                    IWebElement testDiv =
                        driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[2]/a[1]"));
                    Actions builder = new Actions(driver);
                    Actions hoverClick = builder.MoveToElement(testDiv)
                        .MoveToElement(testDiv.FindElement(By.XPath("//a[contains(text(),'Tiyatro Kafe')]"))).Click();
                    hoverClick.Build().Perform();
                    driver.Manage().Window.Maximize();
                    IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
                    jse.ExecuteScript("window.scrollBy(0,350)");
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    //şehir seçimi için
                    IWebElement testDiv2 = driver.FindElement(By.XPath("//b[contains(text(),'Lütfen Şehir Seçin')]"));
                    Actions builder2 = new Actions(driver);
                    Actions hoverClick2 = builder2.MoveToElement(testDiv2)
                        .MoveToElement(testDiv2.FindElement(By.XPath(
                            "//body/main[1]/div[6]/div[1]/div[2]/div[1]/div[2]/ul[1]/li[1]/div[1]/ul[1]/li[1]/input[1]")));
                    hoverClick2.Build().Perform();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    var sehiryaz = driver.FindElement(By.XPath(
                        "//body/main[1]/div[6]/div[1]/div[2]/div[1]/div[2]/ul[1]/li[1]/div[1]/ul[1]/li[1]/input[1]"));
                    sehiryaz.SendKeys("Ankara");
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    IWebElement sehir = driver
                        .FindElement(By.XPath(
                            "//body/main[1]/div[6]/div[1]/div[2]/div[1]/div[2]/ul[1]/li[1]/div[1]/ul[1]/li[2]/label[1]"));
                    sehir.Click();
                    //etkinlik seçimi için
                    IWebElement testDiv3 =
                        driver.FindElement(By.XPath("//b[contains(text(),'Lütfen Etkinlik Türü Seçin')]"));
                    Actions builder3 = new Actions(driver);
                    Actions hoverClick3 = builder3.MoveToElement(testDiv3)
                        .MoveToElement(testDiv2.FindElement(By.XPath(
                            "//body/main[1]/div[6]/div[1]/div[2]/div[1]/div[3]/ul[1]/li[1]/div[1]/ul[1]/li[1]/label[1]")))
                        .Click();
                    hoverClick3.Build().Perform();
                    //seçimleri görmek için fareyi farklı bir yere  götürüyoruz.
                    IWebElement testDiv4 = driver.FindElement(By.XPath("//body/main[1]/div[6]/div[1]/div[2]"));
                    Actions builder4 = new Actions(driver);
                    Actions hoverClick4 = builder4.MoveToElement(testDiv4)
                        .MoveToElement(testDiv2.FindElement(By.XPath(
                            "//body/main[1]/div[6]/div[1]/div[2]/div[1]/div[5]/button[1]/img[1]")));
                    hoverClick4.Build().Perform();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Test]
        public void Test_13_YakinTiyatro()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                IWebElement tiyatro = driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[2]/a[1]"));
                if (tiyatro != null)
                {
                    IWebElement testDiv =
                        driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[2]/a[1]"));
                    Actions builder = new Actions(driver);
                    Actions hoverClick = builder.MoveToElement(testDiv)
                        .MoveToElement(testDiv.FindElement(By.XPath("//a[contains(text(),'Yakın Tiyatro')]"))).Click();
                    hoverClick.Build().Perform();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Test]
        public void Test_14_YakinTiyaroSehirEtkinlik()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                IWebElement tiyatro = driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[2]/a[1]"));
                if (tiyatro != null)
                {
                    IWebElement testDiv =
                        driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[2]/a[1]"));
                    Actions builder = new Actions(driver);
                    Actions hoverClick = builder.MoveToElement(testDiv)
                        .MoveToElement(testDiv.FindElement(By.XPath("//a[contains(text(),'Yakın Tiyatro')]"))).Click();
                    hoverClick.Build().Perform();
                    driver.Manage().Window.Maximize();
                    IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
                    jse.ExecuteScript("window.scrollBy(0,350)");
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    //şehir seçimi için
                    IWebElement testDiv2 = driver.FindElement(By.XPath("//b[contains(text(),'Lütfen Şehir Seçin')]"));
                    Actions builder2 = new Actions(driver);
                    Actions hoverClick2 = builder2.MoveToElement(testDiv2)
                        .MoveToElement(testDiv2.FindElement(By.XPath(
                            "//body/main[1]/div[6]/div[1]/div[2]/div[1]/div[2]/ul[1]/li[1]/div[1]/ul[1]/li[1]/input[1]")));
                    hoverClick2.Build().Perform();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    var sehiryaz = driver.FindElement(By.XPath(
                        "//body/main[1]/div[6]/div[1]/div[2]/div[1]/div[2]/ul[1]/li[1]/div[1]/ul[1]/li[1]/input[1]"));
                    sehiryaz.SendKeys("Ankara");
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    IWebElement sehir = driver
                        .FindElement(By.XPath(
                            "//body/main[1]/div[6]/div[1]/div[2]/div[1]/div[2]/ul[1]/li[1]/div[1]/ul[1]/li[2]/label[1]"));
                    sehir.Click();
                    //etkinlik seçimi için
                    IWebElement testDiv3 =
                        driver.FindElement(By.XPath("//b[contains(text(),'Lütfen Etkinlik Türü Seçin')]"));
                    Actions builder3 = new Actions(driver);
                    Actions hoverClick3 = builder3.MoveToElement(testDiv3)
                        .MoveToElement(testDiv2.FindElement(By.XPath(
                            "//body/main[1]/div[6]/div[1]/div[2]/div[1]/div[3]/ul[1]/li[1]/div[1]/ul[1]/li[1]/label[1]")))
                        .Click();
                    hoverClick3.Build().Perform();
                    //seçimleri görmek için fareyi farklı bir yere  götürüyoruz.
                    IWebElement testDiv4 = driver.FindElement(By.XPath("//body/main[1]/div[6]/div[1]/div[2]"));
                    Actions builder4 = new Actions(driver);
                    Actions hoverClick4 = builder4.MoveToElement(testDiv4)
                        .MoveToElement(testDiv2.FindElement(By.XPath(
                            "//body/main[1]/div[6]/div[1]/div[2]/div[1]/div[5]/button[1]/img[1]")));
                    hoverClick4.Build().Perform();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Test]
        public void Test_15_IfPerformans()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                IWebElement muzik = driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[3]/a[1]"));
                if (muzik != null)
                {
                    IWebElement testDiv =
                        driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[3]/a[1]"));
                    Actions builder = new Actions(driver);
                    Actions hoverClick = builder.MoveToElement(testDiv)
                        .MoveToElement(
                            testDiv.FindElement(By.XPath("//a[contains(text(),'IF Performance Konserleri')]"))).Click();
                    hoverClick.Build().Perform();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Test]
        public void Test_16_IfPerformansSehirEtkinlik()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                IWebElement tiyatro = driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[3]/a[1]"));
                if (tiyatro != null)
                {
                    IWebElement testDiv =
                        driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[3]/a[1]"));
                    Actions builder = new Actions(driver);
                    Actions hoverClick = builder.MoveToElement(testDiv)
                        .MoveToElement(
                            testDiv.FindElement(By.XPath("//a[contains(text(),'IF Performance Konserleri')]"))).Click();
                    hoverClick.Build().Perform();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    IWebElement sehir = driver.FindElement(By.XPath("//select[@id='citySelect']"));
                    IWebElement sehirSec = driver.FindElement(By.XPath("//option[contains(text(),'Ankara')]"));
                    IWebElement tur = driver.FindElement(By.XPath("//select[@id='versionSelect']"));
                    IWebElement turSec = driver.FindElement(By.XPath("//option[contains(text(),'Caz')]"));
                    sehir.Click();
                    sehirSec.Click();
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    tur.Click();
                    turSec.Click();
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    //seçimleri görmek için fareyi farklı bir yere  götürüyoruz.
                    IWebElement secimGoster =
                        driver.FindElement(By.XPath("//strong[contains(text(),'IF Performance Konserleri')]"));
                    secimGoster.Click();
                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Test]
        public void Test_17_IfPerformansTr()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                IWebElement muzik = driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[3]/a[1]"));

                if (muzik != null)
                {
                    IWebElement testDiv =
                        driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[3]/a[1]"));
                    Actions builder = new Actions(driver);
                    Actions hoverClick = builder.MoveToElement(testDiv)
                        .MoveToElement(
                            testDiv.FindElement(By.XPath("//a[contains(text(),'IF Performance Konserleri')]"))).Click();
                    hoverClick.Build().Perform();
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    IWebElement tr =
                        driver.FindElement(By.XPath("//body/main[1]/section[2]/div[1]/div[1]/div[3]/div[1]/a[1]"));
                    tr.Click();
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Test]
        public void Test_18_IfPerformansEn()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                IWebElement muzik = driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[3]/a[1]"));
                IWebElement sporMenuKontrol =
                    driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[4]/a[1]"));
                if (muzik != null && sporMenuKontrol != null)
                {
                    IWebElement testDiv =
                        driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[3]/a[1]"));
                    Actions builder = new Actions(driver);
                    Actions hoverClick = builder.MoveToElement(testDiv)
                        .MoveToElement(
                            testDiv.FindElement(By.XPath("//a[contains(text(),'IF Performance Konserleri')]"))).Click();
                    hoverClick.Build().Perform();
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    IWebElement en =
                        driver.FindElement(By.XPath("//body/main[1]/section[2]/div[1]/div[1]/div[3]/div[1]/a[2]"));
                    en.Click();
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    try
                    {
                        IWebElement sporMenuKontrolTekrar =
                            driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[4]/a[1]"));
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Sayfa ingilizce olarak güncellendi fakat yapısı bozuldu. ");
                    }

                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Test]
        public void Test_19_ZatenUyeyim()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            IWebElement uyeOl = driver.FindElement(By.XPath("//a[@id='aWebRegister']"));
            try
            {
                if (uyeOl != null)
                {
                    uyeOl.Click();
                    Thread.Sleep(TimeSpan.FromSeconds(3));
                    IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
                    jse.ExecuteScript("window.scrollBy(0,450)");
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    var zatenUyeyimButton =
                        driver.FindElement(By.XPath("//a[contains(text(),'Zaten Üyeyim ! Giriş Yap')]"));
                    try
                    {
                        if (zatenUyeyimButton != null)
                        {
                            zatenUyeyimButton.Click();
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }

                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [Test]
        public void Test_20_SehirSecmedenUyeOlma()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            IWebElement uyeOl = driver.FindElement(By.XPath("//a[@id='aWebRegister']"));
            if (uyeOl != null)
            {
                uyeOl.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                IWebElement ad = driver.FindElement(By.XPath("//body/main[1]/section[2]/form[1]/div[1]/input[1]"));
                IWebElement soyad =
                    driver.FindElement(By.XPath("//body/main[1]/section[2]/form[1]/div[1]/input[2]"));
                IWebElement email =
                    driver.FindElement(By.XPath("//body/main[1]/section[2]/form[1]/div[2]/input[1]"));
                IWebElement telefon =
                    driver.FindElement(By.XPath("//body/main[1]/section[2]/form[1]/div[3]/input[1]"));
                IWebElement sifre = driver.FindElement(By.XPath("//input[@id='Password']"));
                IWebElement sifreTekrar = driver.FindElement(By.XPath("//input[@id='PasswordApprove']"));
                IWebElement kullanimSart = driver.FindElement(By.XPath("//input[@id='KullSart']"));
                IWebElement aboneOl = driver.FindElement(By.XPath("//input[@id='AboneOl']"));
                IWebElement uyeolButton = driver.FindElement(By.XPath("//button[contains(text(),'Üye Ol')]"));
                try
                {
                    if (ad != null && soyad != null && email != null && telefon != null && sifre != null &&
                        sifreTekrar != null && kullanimSart != null && aboneOl != null && uyeolButton != null
                        && CheckPhone(telefon.Text))
                    {
                        ad.SendKeys("Mehmet");
                        soyad.SendKeys("KOCA");
                        email.SendKeys("123qweqwe@gmail.com");
                        telefon.SendKeys("5827656543");
                        sifre.SendKeys("123qweasdMm..");
                        sifreTekrar.SendKeys("123qweasdMm..");
                        kullanimSart.Click();
                        aboneOl.Click();
                        uyeolButton.Click();
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        driver.WaitForPageLoad();
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("test başarısız");
                }
            }
        }
        [Test]
        public void Test_21_SifremiUnuttum()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                driver.Navigate().GoToUrl("https://dev-web.biletinial.com/WebLogin?lang=tr");
                driver.WaitForPageLoad();
                IWebElement sifremiUnuttum = driver.FindElement(By.XPath("//a[contains(text(),'Şifremi Unuttum')]"));
                if (sifremiUnuttum != null)
                {
                    sifremiUnuttum.Click();
                    driver.WaitForPageLoad();
                    IWebElement email = driver.FindElement(By.XPath("//input[@id='Email']"));
                    IWebElement gonderButton = driver.FindElement(By.XPath("//button[contains(text(),'Gönder')]"));
                    email.SendKeys("rqewrqewr1234qwer@gmail.com");
                    gonderButton.Click();
                    driver.WaitForPageLoad();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    IWebElement anaSayfayonlendir = driver.FindElement(By.XPath("//a[contains(text(),'Ana Sayfaya Git')]"));
                  
                    anaSayfayonlendir.Click();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    driver.WaitForPageLoad();
                }
            }
            catch (Exception e)
            {
                throw new Exception("test başarısız");
            }
        }
        [Test]
        public void Test_22_UyeliksizDevamEt()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                driver.Navigate().GoToUrl("https://dev-web.biletinial.com/WebLogin?lang=tr");
                driver.WaitForPageLoad();
                IWebElement uyeliksizDevamEt = driver.FindElement(By.XPath("//a[@id='mainHolder_linkUyeliksiz']"));
                uyeliksizDevamEt.Click();
                driver.WaitForPageLoad();
            }
            catch (Exception e)
            {
                throw new Exception("test başarısız");
            }
        }
        [Test]
        public void Test_23_SinemaBiletiAlma()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(BASE_URL);
            driver.WaitForPageLoad();
            try
            {
                //öncelikle şehir değiştiriyoruz
                IWebElement sehirDegistirButton =
                    driver.FindElement(By.XPath("//span[contains(text(),'Şehir Değiştir')]"));
                sehirDegistirButton.Click();
                IWebElement sehirSec = driver.FindElement(By.XPath("//input[@id='citySearch']"));
                sehirSec.SendKeys("İstanbul Anadolu");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                IWebElement secilenSehir = driver.FindElement(By.XPath("//body/main[1]/section[1]/div[1]/div[1]/a[2]/span[2]"));
                secilenSehir.Click();
                Thread.Sleep(TimeSpan.FromSeconds(1));
                driver.WaitForPageLoad();
                //şehri değiştirdik sonra işlemlere başlıyoruz.
                Thread.Sleep(TimeSpan.FromSeconds(1));
                IWebElement sinema = driver.FindElement(By.XPath("//header/div[1]/div[1]/nav[1]/ul[1]/li[1]/a[1]"));
                sinema.Click();
                Thread.Sleep(TimeSpan.FromSeconds(1));
                driver.WaitForPageLoad();
                IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
                jse.ExecuteScript("window.scrollBy(0,350)");
                Thread.Sleep(TimeSpan.FromSeconds(3));
                //çakallarla dans filmine bilet alma
                //öncelikle çakallarla dans filminin üzerine geldik
                IWebElement testDiv2 = driver.FindElement(By.XPath("//body/main[1]/div[5]/div[1]/div[2]/div[3]/div[2]/a[1]/div[1]/img[1]"));
                Actions builder2 = new Actions(driver);
                Actions hoverClick2 = builder2.MoveToElement(testDiv2)
                    .MoveToElement(testDiv2.FindElement(By.XPath(
                        "//body/main[1]/div[5]/div[1]/div[2]/div[3]/div[2]/a[2]"))).Click(); // biletini al butonuna tıklıyoruz
                hoverClick2.Build().Perform();
                Thread.Sleep(TimeSpan.FromSeconds(1));
                driver.WaitForPageLoad();
                jse.ExecuteScript("window.scrollBy(0,650)");
                Thread.Sleep(TimeSpan.FromSeconds(3));
                IWebElement seansSec = driver.FindElement(By.XPath("//tbody/tr[1]/td[2]/div[1]/ul[1]/li[1]"));//seans butonu
                seansSec.Click();
                driver.WaitForPageLoad();
                //giriş yapıyoruz
                Thread.Sleep(TimeSpan.FromSeconds(1));
                IWebElement email = driver.FindElement(By.XPath("//body/main[1]/section[2]/form[1]/div[1]/input[1]"));
                IWebElement sifre = driver.FindElement(By.XPath("//body/main[1]/section[2]/form[1]/div[2]/input[1]"));
                IWebElement girisYapButton = driver.FindElement(By.XPath("//button[contains(text(),'Giriş Yap')]"));
                email.SendKeys("rqewrqewr1234qwer@gmail.com");
                sifre.SendKeys("123qweasdMm..");
                girisYapButton.Click();
                IWebElement koltukSec = driver.FindElement(By.XPath("//span[contains(text(),'E10')]"));
                Thread.Sleep(TimeSpan.FromSeconds(1));
                koltukSec.Click();
                Thread.Sleep(TimeSpan.FromSeconds(1));
                IWebElement odemeYap = driver.FindElement(By.XPath("//button[@id='btnBuy']"));//odeme yap butonu
                odemeYap.Click();
                driver.WaitForPageLoad();
                jse.ExecuteScript("window.scrollBy(0,750)");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                IWebElement kartUzerindekiIsim = driver.FindElement(By.XPath("//input[@id='cardNameT']"));//card üzerindeki isin
                kartUzerindekiIsim.SendKeys("Mustafa DOĞAN");
                Thread.Sleep(TimeSpan.FromSeconds(2));
                IWebElement kartNo = driver.FindElement(By.XPath("//input[@id='cardNumberT']"));//card no
                kartNo.SendKeys("1234567890123456");
                Thread.Sleep(TimeSpan.FromSeconds(2));
                IWebElement ay = driver.FindElement(By.XPath("//select[@id='idAy']"));//ay
                ay.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                IWebElement aysec = driver.FindElement(By.XPath("//body/form[@id='odeme_form']/section[1]/div[1]/div[2]/div[5]/ul[1]/li[1]/div[1]/div[1]/div[1]/div[1]/ul[1]/li[3]/div[1]/select[1]/option[3]"));//ay
                aysec.Click();
                Thread.Sleep(TimeSpan.FromSeconds(1));
                IWebElement yil = driver.FindElement(By.XPath("//select[@id='idYil']"));
                yil.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                IWebElement yilSec = driver.FindElement(By.XPath("//option[contains(text(),'2023')]"));//yıl
                yilSec.Click();
                Thread.Sleep(TimeSpan.FromSeconds(1));
                IWebElement guvenlikKodu = driver.FindElement(By.XPath("//input[@id='cardCvvT']"));//yıl
                guvenlikKodu.SendKeys("123");
                Thread.Sleep(TimeSpan.FromSeconds(1));
                IWebElement sozlesmeOnayla = driver.FindElement(By.XPath("//input[@id='kullSartFk']"));//sözleşmeonayı
                sozlesmeOnayla.Click();
                Thread.Sleep(TimeSpan.FromSeconds(1));
                IWebElement odemeYapButton = driver.FindElement(By.XPath("//button[@id='gobefore']"));//sözleşmeonayı
                odemeYapButton.Click();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private bool CheckPhone(string input)
        {
            string pattern = @"^(0(\d{3}) (\d{3}) (\d{2}) (\d{2}))$";
            Match match = Regex.Match(input, pattern, RegexOptions.IgnoreCase);

            return match.Success;
        }
    }

    public static class Extensions
    {
        public static void WaitForPageLoad(this IWebDriver driver)
        {
            try
            {
                IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)driver;
                WebDriverWait webDriverWait = new WebDriverWait(driver, new TimeSpan(0, 0, 1));
                webDriverWait.Until<bool>((IWebDriver x) =>
                    javaScriptExecutor.ExecuteScript("return document.readyState").Equals("complete"));
            }
            catch (Exception e)
            {
            }
        }
    }
}
package HomeWorkTest;

import org.junit.After;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.interactions.Actions;



public class hwtest {
    private WebDriver driver;

    @Before
    public void setUp() {
        driver = new ChromeDriver();
        driver.manage().window().maximize();
        driver.navigate().to("http://rozetka.com.ua");
    }

    @After
    public void tearDown(){
        driver.quit();
    }

    @Test
    public void firstTest() {
        driver.findElement(By.xpath("//span[@name='splash-button']")).click();
        String login = "1111ivan1234ivanov4321@gmail.com";
        String password = "Qwerty1234";
        driver.findElement(By.xpath("//input[@name='login']")).sendKeys(login);
        driver.findElement(By.xpath("//input[@name='password']")).sendKeys(password);
        driver.findElement(By.xpath("//*[@name='auth_submit']")).click();

    }

    @Test
    public void secondTest() {
        driver.findElement(By.xpath("//*[@data-title='Товары для дома']")).click();
        String expectedURL = "https://rozetka.com.ua/tovary-dlya-doma/c2394287/";
        String actualRL = driver.getCurrentUrl();
        Assert.assertEquals(expectedURL, actualRL);
    }

    @Test
    public void thirdTest() throws InterruptedException {
        driver.findElement(By.xpath("//*[@data-title='Товары для дома']")).click();
        driver.findElement(By.xpath("//a[@class='sprite-side pab-items-i-link']")).click();
        Thread.sleep(2000);
        driver.findElement(By.xpath("//*[@id='271461']//button")).click();
        String expectednameOfProduct = "Матрас Come-for Гармония 160х200 см (2560121602005)";
        Thread.sleep(2000);
        Assert.assertEquals(expectednameOfProduct, driver.findElement(By.xpath("//a[@class='novisited cart-i-title-link']")).getText());
    }

    @Test
    public void fourthTest() throws InterruptedException {
        driver.findElement(By.xpath("//*[@data-title='Товары для дома']")).click();
        driver.findElement(By.xpath("//a[@class='sprite-side pab-items-i-link']")).click();
        Thread.sleep(2000);
        driver.findElement(By.xpath("//*[@id='271461']//button")).click();
        Thread.sleep(2000);
        driver.findElement(By.xpath("//a[@name='close']")).click();

        WebElement buttonCart = driver.findElement(By.xpath("//a[@class='hub-i-link hub-i-cart-link-count sprite-side whitelink']"));
        new Actions(driver).moveToElement(buttonCart).perform();
        Thread.sleep(1000);
        driver.findElement(By.xpath("//span[@class='header-popup-cart-full-to-cart-inner sprite-side xhr inline']")).click();
        String expectednameOfProduct = "Матрас Come-for Гармония 160х200 см (2560121602005)";
        Assert.assertEquals(expectednameOfProduct, driver.findElement(By.xpath("//a[@class='novisited cart-i-title-link']")).getText());
    }

}

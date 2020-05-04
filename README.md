# web-selenium-nunit

This is a test automation project using C#, Selenium and NUnit.

There is one test class and this test is performing a search on Amazon website, adding the product to the cart and checking if the product was added correctly. The title and price are being validated.

This project is using PageObjects pattern.

The test scenario is inside Tests folder, and it is called "AmazonTest".

It is just an example of using Selenium with C# to make Test Automation. It is not a complete project with logs, reports, capture of screenshots, automatic retry in case of failure, etc. 


IMPORTANT: You need to download Chromedriver and make sure it is ponted to correct path on AmazonTests.cs file, line 20.
You can download Chromedriver here: https://chromedriver.chromium.org/downloads

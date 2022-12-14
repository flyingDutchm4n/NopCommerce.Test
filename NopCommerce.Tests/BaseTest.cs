using NopCommerce.API.Assembly;
using NopCommerce.Core;
using NopCommerce.Core.Interfaces;
using NopCommerce.UI.Frame;

namespace NopCommerce.Tests;

[TestFixture]
public class BaseTest
{
    private readonly WebExecutionTool _executionTool;
    protected NopCommerceNavigator Navigator;
    private BasePage _basePage;

    public BaseTest()
    {
        _executionTool = WebExecutionTool.Instance;
        Navigator = new NopCommerceNavigator(_executionTool);
        _basePage = new BasePage(_executionTool);
    }

    [SetUp]
    public void Setup()
    {
        _executionTool.StartApplication();
    }

    [TearDown]
    public void TestTearDown()
    {
        _executionTool.ExitApplication();
    }
}
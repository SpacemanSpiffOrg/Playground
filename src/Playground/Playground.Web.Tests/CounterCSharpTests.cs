using Playground.Web.Components.Pages;

namespace Playground.Web.Tests;
/// <summary>
/// These tests are written entirely in C#.
/// Learn more at https://bunit.dev/docs/getting-started/writing-tests.html#creating-basic-tests-in-cs-files
/// </summary>
public class CounterCSharpTests : TestContext
{
    [Fact]
    public void CounterStartsAtZero()
    {
        // Arrange
        var cut = RenderComponent<Counter>();

        // Assert that content of the paragraph shows counter at zero
        var currentCounter = cut.Find("p").ToMarkup();
        cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 0</p>");
    }

    // Verify that clicking the button increments the counter
    [Fact]
    public void ClickingButtonIncrementsCounter()
    {
        // Arrange
        var cut = RenderComponent<Counter>();

        // Act - click button to increment counter
        cut.Find("button").Click();

        // Assert that the counter was incremented
        var currentCounter = cut.Find("p").ToMarkup();
        cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 1</p>");
    }
}

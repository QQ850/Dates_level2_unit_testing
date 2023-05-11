namespace sample_tests;
using Xunit;
using sample.lib;

public class ConvertToGregorian_Tests
{
    [Fact]
    //TODO: This test will become obsolete if the featured function is fully implemented.
    public void NotImplementedYet()
    {
        Action act = () => Converter.ConvertToGregorian(int.MinValue);
        Assert.Throws<NotImplementedException>(act);
    }

    [Fact]
    //TODO: Initial "red" test to code logic
    public void One()
    {
        int year = 2023;
        string words = Converter.ConvertToGregorian(year);
        Assert.Equal("Saturday, January 28, 2023",words,true);
    }

    [Fact]
    //TODO: Initial "red" test to code logic
    public void Two()
    {
        int year = 2021;
        string words = Converter.ConvertToGregorian(year);
        Assert.Equal("Friday, February 12, 2021",words,true);
    }
}
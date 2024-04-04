namespace repos_chasing_snow_web;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
    }
}
[TestMethod]
public void Can_Create_New_Rating()
{
    var rating = new Rating(1, "Mike", "Great Fit!");
    Assert.AreEqual(1, rating.Stars);
    Assert.AreEqual("Mike", rating.UserName);
    Assert.AreEqual("Great Fit!", rating.Review);
}
[TestMethod]
[ExpectedException(typeof(ArgumentException))]
public void Cannot_Create_Rating_With_Invalid_Stars()
{
    var rating = new Rating(0, "Mike", "Great fit!");
}
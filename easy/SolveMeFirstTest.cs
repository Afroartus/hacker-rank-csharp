using NUnit.Framework;

namespace HackerRank.easy;

[TestFixture]
public class SolveMeFirstTest{
    [Test]
    public void TestSolveMiFirst() {
        var a = 2;
        var b = 3;
        var expected = a + b;
        var got = SolveMeFirst.ExerciseSolveMeFirst(a, b);
        Assert.AreEqual(expected, got);
    }
}
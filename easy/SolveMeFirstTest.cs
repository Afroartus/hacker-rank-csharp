using NUnit.Framework;

namespace HackerRank.easy;

[TestFixture]
public class SolveMeFirstTest{

    [Test]
    public void TestSolveMiFirst() {
        int a = 2;
        int b = 3;
        var expected = a + b;
        var got = SolveMeFirst.ExerciseSolveMeFirst(a, b);
        Assert.AreEqual(expected, got);
    }
}
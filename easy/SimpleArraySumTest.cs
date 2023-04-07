using NUnit.Framework;

namespace HackerRank.easy;

[TestFixture]
public class SimpleArraySumTest{

    [Test]
    public void TestSimpleArraySum() {
        List<int> arr = new List<int>{1,2,3,4,5};
        var actual = SimpleArraySum.ExerciseSimpleArraySum(arr);
        var expected = 15;
        Assert.AreEqual(expected, actual);
    }
}
using NUnit.Framework;

namespace HackerRank.easy;

[TestFixture]
public class GradingStudentsTest{
    [Test]
    public void TestGradingStudents() {
        var arr = new List<int>{ 73, 67, 38, 33 };
        var expected = new List<int>{ 75, 67, 40, 33 };
        var got = GradingStudents.ExerciseGradingStudents(arr);
        for (var i = 0; i < got.Count; i++) Assert.AreEqual(expected[i], got[i]);
    }
}
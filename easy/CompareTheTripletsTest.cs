using NUnit.Framework;

namespace HackerRank.easy;

[TestFixture]
public class CompareTheTripletsTest{
    private readonly List<int> _a = new(){ 6, 6, 8 };
    private readonly List<int> _b = new(){ 5, 6, 7 };
    private readonly List<int> _expected = new(){ 2, 0 };

    [Test]
    public void TestExerciseCompareTheTriplets() {
        var got = CompareTheTriplets.ExerciseCompareTheTriplets(_a, _b);
        Assert.AreEqual(_expected, got);
    }
}
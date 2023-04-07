using NUnit.Framework;

namespace HackerRank.easy;

[TestFixture]
public class TheLoveLetterMysteryTest{
    [Test]
    public void TestTheLoveLetterMystery() {
        string[] arrayNumber ={ "abc", "abcba", "abcd", "cba" };
        int[] expected ={ 2, 0, 4, 2 };
        for (var i = 0; i < arrayNumber.Length; i++){
            var got = TheLoveLetterMystery.ExerciseTheLoveLetterMystery(arrayNumber[i]);
            Assert.AreEqual(expected[i], got);
        }
    }
}
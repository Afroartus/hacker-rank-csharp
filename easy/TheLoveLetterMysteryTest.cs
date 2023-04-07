using NUnit.Framework;

namespace HackerRank.easy;

[TestFixture]
public class TheLoveLetterMysteryTest{

    [Test]
    public void TestTheLoveLetterMystery() {
        string[] arrayNumber ={ "abc", "abcba", "abcd", "cba" };
        int[] expected ={ 2, 0, 4, 2 };

        for (int i = 0; i < arrayNumber.Length; i++){
            int got = TheLoveLetterMystery.ExerciseTheLoveLetterMystery(arrayNumber[i]);
            Assert.AreEqual(expected[i], got);
        }
    }
}
using NUnit.Framework;

namespace HackerRank.easy;

[TestFixture]
public class BeautifulBinaryStringTest{
    [Test]
    public void TestBeautifulBinaryString() {
        string[] arrayNumber ={ "0101010", "01100", "0100101010", "010" };
        int[] expected ={ 2, 0, 3, 1 };
        for (var i = 0; i < arrayNumber.Length; i++){
            var got = BeautifulBinaryString.ExerciseBeautifulBinaryString(arrayNumber[i]);
            Assert.AreEqual(expected[i], got);
        }
    }
}
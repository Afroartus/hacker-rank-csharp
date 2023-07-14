using NUnit.Framework;

namespace HackerRank.easy;
[TestFixture]
public class UtopianTreeTest{

    [Test]
    public void TestUtopianTree() {
        List<int> arr = new List<int>{ 6, 5, 4 };
        List<int> expected = new List<int>{ 15, 14, 7 };

        for (int i = 0; i < arr.Count; i++){
            var got = UtopianTree.ExerciseUtopianTree(arr[i]);
            Assert.AreEqual(expected[i], got);
        }
    }
}
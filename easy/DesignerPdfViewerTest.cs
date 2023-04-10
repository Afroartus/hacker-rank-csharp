using NUnit.Framework;

namespace HackerRank.easy;

[TestFixture]
public class DesignerPdfViewerTest{

    [Test]
    public void TestDesignerPdfViewer() {
        List<int> h1 = new List<int>{ 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
        string word1 = "abc";
        int expected1 = 9;
        var got1 = DesignerPdfViewer.ExerciseDesignerPdfViewer(h1, word1);
        

        List<int> h2 = new List<int>{ 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
        string word2 = "zaba";
        int expected2 = 28;
        var got2 = DesignerPdfViewer.ExerciseDesignerPdfViewer(h2, word2);
 
        Assert.AreEqual(expected1, got1);
        Assert.AreEqual(expected2, got2);
    }
}
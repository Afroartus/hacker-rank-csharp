namespace HackerRank.easy;

public class CompareTheTriplets{
    public static List<int> ExerciseCompareTheTriplets(List<int> a, List<int> b) {
        int aPoint = 0, bPoint = 0;
        var arr = new List<int>();
        for (var i = 0; i < a.Count; i++){
            if (a[i] > b[i]) aPoint += 1;
            if (a[i] < b[i]) bPoint += 1;
        }
        arr.Add(aPoint);
        arr.Add(bPoint);
        return arr;
    }


}
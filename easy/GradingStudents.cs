namespace HackerRank.easy;

public class GradingStudents{
    public static List<int> ExerciseGradingStudents(List<int> grades) {
        var b = new List<int>();
        foreach (var a in grades){
            var c = 0;
            var expr = a % 10;
            if (a >= 38){
                c = expr switch{
                    3 or 8 => a + 2,
                    4 or 9 => a + 1,
                    _ => a
                };
            }
            else c = a;
            b.Add(c);
        }
        return b;
    }
}
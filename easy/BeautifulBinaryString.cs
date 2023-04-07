namespace HackerRank.easy;

public class BeautifulBinaryString{
    public static int ExerciseBeautifulBinaryString(string a) {
        var arr = a.ToCharArray();
        var numberOfOperation = 0;
        var i = 0;
        while (i < a.Length - 2)
            if (arr[i] == '0' && arr[i + 1] == '1' && arr[i + 2] == '0'){
                arr[i + 1] = '0';
                numberOfOperation += 1;
                i += 3;
            }
            else{
                i++;
            }

        return numberOfOperation;
    }


    public static void Exercice() {
        ExerciseBeautifulBinaryString("01010");
    }
}
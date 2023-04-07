namespace HackerRank.easy;

public class TheLoveLetterMystery{
    public static int ExerciseTheLoveLetterMystery(string s) {
        var arr = s.ToCharArray();
        var i = 0;
        var j = arr.Length - 1;
        var countOperation = 0;
        while (j >= arr.Length - arr.Length / 2){
            var runeUno = arr[i];
            var runeDos = arr[j];
            while (runeUno != runeDos){
                if (runeUno > runeDos)
                    runeUno--;
                else
                    runeDos--;
                countOperation++;
            }

            i++;
            j--;
        }

        return countOperation;
    }
}
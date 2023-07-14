namespace HackerRank.easy;

public class UtopianTree{

    public static int ExerciseUtopianTree(int n) {
        int tree = 0;
        for (int i = 0; i <= n; i++){
            if (i == 0){
                tree = 1; 
                continue;
            }
            if (i == 1){
                tree *= 2; 
                continue;
            }
            if (i % 2 == 0){
                tree += 1;
                continue;
            }
            if (i % 1 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0) tree *= 2;
        }
        return tree;
    }
    
}
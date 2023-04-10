namespace HackerRank.easy;

public class DesignerPdfViewer{

    public static int ExerciseDesignerPdfViewer(List<int> h, string word) {
        Dictionary<int, int> letras = new Dictionary<int, int>();
        int altura = 0, anchura = 0;
        anchura = word.Length;
        foreach (var item in word){
            var num = item - 96;
            for (int i = 0; i <= h.Count; i++){
                if ((i+1) == num){
                    if (letras.FirstOrDefault(x => x.Key == item).Key == item){
                        continue;
                    }
                    letras.Add(item, h[i]);
                }
            }
            foreach (KeyValuePair<int, int> map in letras){
                if (map.Value > altura){
                    altura = map.Value;
                }
            }
        }
        return anchura * altura;
    }
    
}
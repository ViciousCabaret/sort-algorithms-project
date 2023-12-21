namespace SortAlgorithmsProject.SortAlgorithm;

public class BubbleSort : ISortAlgorithm
{
    public int[] Sort(int[] tab)
    {
        int n = tab.Length;
        for(int i = 0; i < n - 1; i++){
            for(int j = 0; j < n - i - 1; j++){
                if(tab[j] > tab[j+1])
                {
                    (tab[j + 1], tab[j]) = (tab[j], tab[j + 1]);
                }
            }
        }

        return tab;
    }
}
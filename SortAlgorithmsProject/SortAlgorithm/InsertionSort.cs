namespace SortAlgorithmsProject.SortAlgorithm;

public class InsertionSort : ISortAlgorithm
{
    public int[] Sort(int[] tab)
    {
        for (uint i = 1; i < tab.Length; i++)
        {
            uint j = i; // elementy 0 .. i-1 są już posortowane
            int Buf = tab[j]; // bierzemy i-ty (j-ty) element
            while ((j > 0) && (tab[j - 1] > Buf))
            { // przesuwamy elementy
                tab[j] = tab[j - 1];
                j--;
            }
            tab[j] = Buf; // i wpisujemy na docelowe miejsce
        }

        return tab;
    }
}
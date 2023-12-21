namespace SortAlgorithmsProject.SortAlgorithm;

public class SelectionSort : ISortAlgorithm
{
    public int[] Sort(int[] tab)
    {
        uint k;
        for (uint i = 0; i < (tab.Length - 1); i++)
        {
            int Buf = tab[i]; // bierzemy i-ty element
            k = i; // i jego indeks
            for (uint j = i + 1; j < tab.Length; j++)
                if (tab[j] < Buf) // szukamy najmniejszego z prawej
                {
                    k = j;
                    Buf = tab[j];
                }
            tab[k] = tab[i]; // zamieniamy i-ty z k-tym
            tab[i] = Buf;
        }

        return tab;
    }
}
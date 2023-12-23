namespace SortAlgorithmsProject.SortAlgorithm;

public class SelectionSort : ISortAlgorithm
{
    public int[] Sort(int[] array)
    {
        int k;
        for (int i = 0; i < (array.Length - 1); i++)
        {
            int Buf = array[i]; // bierzemy i-ty element
            k = i; // i jego indeks
            for (int j = i + 1; j < array.Length; j++)
                if (array[j] < Buf) // szukamy najmniejszego z prawej
                {
                    k = j;
                    Buf = array[j];
                }
            array[k] = array[i]; // zamieniamy i-ty z k-tym
            array[i] = Buf;
        }

        return array;
    }

    public string GetName()
    {
        return "Selection sort";
    }
}
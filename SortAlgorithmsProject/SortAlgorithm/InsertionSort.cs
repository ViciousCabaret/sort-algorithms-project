namespace SortAlgorithmsProject.SortAlgorithm;

public class InsertionSort : ISortAlgorithm
{
    public int[] Sort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int j = i; // elementy 0 .. i-1 są już posortowane
            int Buf = array[j]; // bierzemy i-ty (j-ty) element
            while ((j > 0) && (array[j - 1] > Buf))
            { // przesuwamy elementy
                array[j] = array[j - 1];
                j--;
            }
            array[j] = Buf; // i wpisujemy na docelowe miejsce
        }

        return array;
    }

    public string GetName()
    {
        return "Insertion sort";
    }
}
namespace SortAlgorithmsProject.ArrayGenerator;

public class IncreasingArrayGenerator : AbstractArrayGenerator, IArrayGenerator
{
    public IncreasingArrayGenerator(int arraySize) : base(arraySize)
    {
    }

    public int[] Generate()
    {
        int[] array = new int[ArraySize];
        for (int i = 0; i < ArraySize; i++)
        {
            array[i] = i;
        }

        return array;
    }
}
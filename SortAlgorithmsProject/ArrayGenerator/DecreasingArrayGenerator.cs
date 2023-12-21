namespace SortAlgorithmsProject.ArrayGenerator;

public class DecreasingArrayGenerator : AbstractArrayGenerator, IArrayGenerator
{
    public DecreasingArrayGenerator(int arraySize) : base(arraySize)
    {
    }

    public int[] Generate()
    {
        int[] array = new int[ArraySize];
        for (int i = 0; i < ArraySize - 1; i ++)
        {
            array[i] = ArraySize - i;
        }

        return array;
    }
}
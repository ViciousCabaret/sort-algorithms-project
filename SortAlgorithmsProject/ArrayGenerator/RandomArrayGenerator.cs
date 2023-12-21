namespace SortAlgorithmsProject.ArrayGenerator;

public class RandomArrayGenerator : AbstractArrayGenerator, IArrayGenerator
{
    public RandomArrayGenerator(int arraySize) : base(arraySize)
    {
    }

    public int[] Generate()
    {
        int[] array = new int[ArraySize];
        for (int i = 0; i < ArraySize; i++)
        {
            int value = new Random().Next(0, ArraySize);
            array[i] = value;
        }
        return array;
    }
}

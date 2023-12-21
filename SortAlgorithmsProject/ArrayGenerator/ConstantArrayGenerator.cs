namespace SortAlgorithmsProject.ArrayGenerator;

public class ConstantArrayGenerator : AbstractArrayGenerator, IArrayGenerator
{
    public ConstantArrayGenerator(int arraySize) : base(arraySize)
    {
    }

    public int[] Generate()
    {
        int value = new Random().Next(0, ArraySize);
        int[] array = new int[ArraySize];
        for (int i = 0; i < ArraySize; i++)
        {
            array[i] = value;
        }
        return array;
    }
}
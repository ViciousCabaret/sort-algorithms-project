namespace SortAlgorithmsProject.ArrayGenerator;

public class IncreasingArrayGenerator : AbstractArrayGenerator, IArrayGenerator
{
    public IncreasingArrayGenerator(int arraySize) : base(arraySize)
    {
    }

    public GeneratedArray Generate()
    {
        int[] array = new int[ArraySize];
        for (int i = 0; i < ArraySize; i++)
        {
            array[i] = i;
        }

        return CreateGeneratedArray(array);
    }

    protected override string GetArrayType()
    {
        return "Increasing";
    }
}
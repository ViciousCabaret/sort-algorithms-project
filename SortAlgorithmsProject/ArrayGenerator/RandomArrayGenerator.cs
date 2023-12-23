namespace SortAlgorithmsProject.ArrayGenerator;

public class RandomArrayGenerator : AbstractArrayGenerator, IArrayGenerator
{
    public RandomArrayGenerator(int arraySize) : base(arraySize)
    {
    }

    public GeneratedArray Generate()
    {
        int[] array = new int[ArraySize];
        for (int i = 0; i < ArraySize; i++)
        {
            int value = new Random().Next(0, ArraySize);
            array[i] = value;
        }
        return CreateGeneratedArray(array);
    }

    protected override string GetArrayType()
    {
        return "Random array";
    }
}

namespace SortAlgorithmsProject.ArrayGenerator;

public class ConstantArrayGenerator : AbstractArrayGenerator, IArrayGenerator
{
    public ConstantArrayGenerator(int arraySize) : base(arraySize)
    {
    }

    public GeneratedArray Generate()
    {
        int value = new Random().Next(0, ArraySize);
        int[] array = new int[ArraySize];
        for (int i = 0; i < ArraySize; i++)
        {
            array[i] = value;
        }

        return CreateGeneratedArray(array);
    }

    protected override string GetArrayType()
    {
        return "Constant";
    }
}
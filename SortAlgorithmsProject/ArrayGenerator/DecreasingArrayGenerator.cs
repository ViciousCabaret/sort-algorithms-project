namespace SortAlgorithmsProject.ArrayGenerator;

public class DecreasingArrayGenerator : AbstractArrayGenerator, IArrayGenerator
{
    public DecreasingArrayGenerator(int arraySize) : base(arraySize)
    {
    }

    public GeneratedArray Generate()
    {
        int[] array = new int[ArraySize];
        for (int i = 0; i < ArraySize; i ++)
        {
            array[i] = ArraySize - i;
        }
        
        return CreateGeneratedArray(array);
    }
    
    protected override string GetArrayType()
    {
        return "Decreasing";
    }
}
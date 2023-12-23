namespace SortAlgorithmsProject.ArrayGenerator;

public class VShapedArrayGenerator : AbstractArrayGenerator, IArrayGenerator
{
    public VShapedArrayGenerator(int arraySize) : base(arraySize)
    {
    }

    public GeneratedArray Generate()
    {
        int[] decreasingArray = new DecreasingArrayGenerator(ArraySize).Generate().Values;
        int[] vShapedArray = new int[ArraySize];
        
        int counter = 0;
        for (int i = 0; i < ArraySize - 1; i++)
        {
            if (i % 2 == 0)
            {
                vShapedArray[counter] = decreasingArray[i];
            }
            else
            {
                vShapedArray[decreasingArray.Length - counter - 1] = decreasingArray[i];
                counter++;
            }
        }

        return CreateGeneratedArray(vShapedArray);
    }

    protected override string GetArrayType()
    {
        return "V-Shaped array";
    }
}
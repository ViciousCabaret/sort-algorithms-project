namespace SortAlgorithmsProject.ArrayGenerator;

public abstract class AbstractArrayGenerator
{
    protected int ArraySize;
    
    protected AbstractArrayGenerator(int arraySize)
    {
        ArraySize = arraySize;
    }

    protected GeneratedArray CreateGeneratedArray(int[] values)
    {
        return new GeneratedArray(GetArrayType(), values);
    }

    protected abstract string GetArrayType();
}
namespace SortAlgorithmsProject;

public class SortingAlgorithmTimeComplexityResult
{
    private TimeSpan _timeComplexity;
    private string _algorithm;
    private int _arraySize;
    private string _arrayType;
    
    public SortingAlgorithmTimeComplexityResult(TimeSpan timeComplexity, string algorithm, string arrayType, int arraySize)
    {
        _timeComplexity = timeComplexity;
        _algorithm = algorithm;
        _arraySize = arraySize;
        _arrayType = arrayType;
    }
    
    public string FormatResult()
    {
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            _timeComplexity.Hours, _timeComplexity.Minutes, _timeComplexity.Seconds,
            _timeComplexity.Milliseconds / 10);

        return
            $"[{_arrayType} array of {_arraySize} elements] Time complexity result: {elapsedTime} for sorting algorithm: {_algorithm}";
    }
}
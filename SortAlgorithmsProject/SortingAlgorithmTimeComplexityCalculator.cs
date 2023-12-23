using System.Diagnostics;
using SortAlgorithmsProject.ArrayGenerator;
using SortAlgorithmsProject.SortAlgorithm;

namespace SortAlgorithmsProject;

public class SortingAlgorithmTimeComplexityCalculator
{
    private ISortAlgorithm _sortAlgorithm;
    private GeneratedArray _array;
    
    public SortingAlgorithmTimeComplexityCalculator(ISortAlgorithm sortAlgorithm, GeneratedArray array)
    {
        _sortAlgorithm = sortAlgorithm;
        _array = array;
    }

    public SortingAlgorithmTimeComplexityResult Calculate()
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        _sortAlgorithm.Sort(_array.Values);
        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;

        return new SortingAlgorithmTimeComplexityResult(ts, _sortAlgorithm.GetName(), _array.Type, _array.Values.Length);
    }
}
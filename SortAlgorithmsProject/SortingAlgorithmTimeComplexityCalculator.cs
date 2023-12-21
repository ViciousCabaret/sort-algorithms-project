using System.Diagnostics;
using SortAlgorithmsProject.SortAlgorithm;

namespace SortAlgorithmsProject;

public class SortingAlgorithmTimeComplexityCalculator
{
    private ISortAlgorithm _sortAlgorithm;
    private int[] _array;
    
    public SortingAlgorithmTimeComplexityCalculator(ISortAlgorithm sortAlgorithm, int[] array)
    {
        _sortAlgorithm = sortAlgorithm;
        _array = array;
    }

    public SortingAlgorithmTimeComplexityResult Calculate()
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        _sortAlgorithm.Sort(_array);
        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;

        return new SortingAlgorithmTimeComplexityResult(ts, _sortAlgorithm.GetName(), _array.Length);
    }
}
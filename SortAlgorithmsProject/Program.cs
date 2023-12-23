using SortAlgorithmsProject;
using SortAlgorithmsProject.ArrayGenerator;
using SortAlgorithmsProject.SortAlgorithm;
public class Program
{
    private const int CALCULATION_STEP = 50000;
    public static void Main()
    {
        List<ISortAlgorithm> sortAlgorithms = new List<ISortAlgorithm>();
        List<SortingAlgorithmTimeComplexityResult> results = new List<SortingAlgorithmTimeComplexityResult>();
        
        sortAlgorithms.Add(new InsertionSort());
        sortAlgorithms.Add(new SelectionSort());
        sortAlgorithms.Add(new BubbleSort());
        
        for (int i = CALCULATION_STEP; i <= 300000; i += CALCULATION_STEP)
        {
            Console.WriteLine($"Calculation for {i} elements in array");
            sortAlgorithms.ForEach((sortAlgorithm) =>
            {
                Console.WriteLine($"\tCalculations for {sortAlgorithm.GetName()} algorithm:");
                
                Console.WriteLine("\t\tCalculating for constant array...");
                results.Add(new SortingAlgorithmTimeComplexityCalculator(
                    sortAlgorithm,
                    new ConstantArrayGenerator(i).Generate()
                ).Calculate());

                Console.WriteLine("\t\tCalculating for decreasing array...");
                results.Add(new SortingAlgorithmTimeComplexityCalculator(
                    sortAlgorithm,
                    new DecreasingArrayGenerator(i).Generate()
                ).Calculate());
                
                Console.WriteLine("\t\tCalculating for increasing array...");
                results.Add(new SortingAlgorithmTimeComplexityCalculator(
                    sortAlgorithm,
                    new IncreasingArrayGenerator(i).Generate()
                ).Calculate());
                
                Console.WriteLine("\t\tCalculating for random array...");
                results.Add(new SortingAlgorithmTimeComplexityCalculator(
                    sortAlgorithm,
                    new RandomArrayGenerator(i).Generate()
                ).Calculate());
                
                Console.WriteLine("\t\tCalculating for vshaped array...");
                results.Add(new SortingAlgorithmTimeComplexityCalculator(
                    sortAlgorithm,
                    new VShapedArrayGenerator(i).Generate()
                ).Calculate());
            });
        }

        foreach (var result in results)
        {
            Console.WriteLine(result.FormatResult());
        }
    }

}
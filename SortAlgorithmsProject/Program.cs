using SortAlgorithmsProject;
using SortAlgorithmsProject.ArrayGenerator;
using SortAlgorithmsProject.SortAlgorithm;
// selection sort, insertion sort, bubble sort
public class Program
{
    private const int MILION = 1000000;
    public static void Main()
    {
        SortingAlgorithmTimeComplexityCalculator calculator = new SortingAlgorithmTimeComplexityCalculator(
            new InsertionSort(),
            new DecreasingArrayGenerator(100000).Generate()
        );

        Console.WriteLine(calculator.Calculate().FormatResult());
    }
}
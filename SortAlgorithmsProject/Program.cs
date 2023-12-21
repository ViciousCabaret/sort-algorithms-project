using SortAlgorithmsProject.SortAlgorithm;
// selection sort, insertion sort, bubble sort
public class Program
{
    public static void Main()
    {
        int[] values = { 4, 2, 1, 7, 10 };
        
        int[] bubbleResult = new BubbleSort().Sort(values);
        int[] selectionResult = new SelectionSort().Sort(values);
        int[] insertionResult = new InsertionSort().Sort(values);

        foreach (var VARIABLE in bubbleResult)
        {
            Console.WriteLine(VARIABLE);
        }
        Console.WriteLine("===--------------===");
        foreach (var VARIABLE in selectionResult)
        {
            Console.WriteLine(VARIABLE);
        }

        Console.WriteLine("===--------------===");

        foreach (var VARIABLE in insertionResult)
        {
            Console.WriteLine(VARIABLE);
        }
    }
}
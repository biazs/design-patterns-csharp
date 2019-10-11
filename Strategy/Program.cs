using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList studentRecords = new SortedList();
            studentRecords.Add("Maria");
            studentRecords.Add("Joao");
            studentRecords.Add("Pedro");
            studentRecords.Add("Ana");
            studentRecords.Add("Carlos");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();
            

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();


            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            Console.ReadKey();
        }
    }
}

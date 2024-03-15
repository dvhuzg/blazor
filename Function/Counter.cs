using Microsoft.AspNetCore.Components;

namespace BezApp.Function
{
    public class Counter : ComponentBase
    {
        public int CurrentCount { get; set; } = 0;

        public void IncrementCount()
        {
            CurrentCount++;
            Console.WriteLine("Dohung: " + CurrentCount);
        }
    }
}
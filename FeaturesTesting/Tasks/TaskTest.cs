using System;
using System.Threading.Tasks;

namespace FeaturesTesting.Tasks
{
    class TaskTest
    {
        public static async Task MyMethodAsync()
        {
            Task<int> longRunningTask = LongRunningOperation();
            // independent work which doesn't need the result of LongRunningOperationAsync can be done here
            Console.WriteLine("Independent Works of now executes in MyMethodAsync()");
            //and now we call await on the task 
            int result = await longRunningTask;
            //use the result 
            Console.WriteLine("Result of LongRunningOperation() is " + result);
        }

        public static async Task<int> LongRunningOperation() // assume we return an int from this long running operation 
        {
            Console.WriteLine("LongRunningOperation() Started");
            await Task.Delay(2000); // 2 second delay
            Console.WriteLine("LongRunningOperation() Finished after 2 Seconds");
            return 1;
        }
    }
}

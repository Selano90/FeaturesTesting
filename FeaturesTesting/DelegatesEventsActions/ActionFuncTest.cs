using System;

namespace FeaturesTesting.DelegatesEventsActions
{
    class ActionFuncTest
    {
        private Action<int?> action;
        private Func<int?, double> function;

        public Action<int?> Action { get => action; set => action = value; }
        public Func<int?, double> Function { get => function; set => function = value; }
        public double AuCarre(int? number) => number != null ? (int)number * (int)number : 0;
        public void PrintAction(int? number)
        {
            Console.WriteLine("Action!! " + number);
        }
    }
}

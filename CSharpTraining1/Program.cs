using System;

namespace CSharpTraining1
{
    class Program
    {
        static void Main(string[] args)
        {
            TuplesDemo tuplesDemo = new TuplesDemo();
            tuplesDemo.Run();

            DelegateDemo delegateDemo = new DelegateDemo();
            delegateDemo.Run();

            GuidDemo guidDemo = new GuidDemo();
            guidDemo.Run();
        }
    }
}

using System;
namespace PracticeCSharp.StudyDelegate
{
    public delegate void OnLaunchHandler();

    public class Car
    {
        public void Run(OnLaunchHandler handler)
        {
            handler();

            Console.WriteLine("I can run.");
        }

        public void RunByEngine(EngineBase engine)
        {
            engine.Launch();

            Console.WriteLine("I can run by engine {0}", engine);
        }
    }
}

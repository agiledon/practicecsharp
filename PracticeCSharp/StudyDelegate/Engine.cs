using System;
namespace PracticeCSharp.StudyDelegate
{
    public abstract class EngineBase
    {
        public void Launch()
        {
            SwitchOn();
            InternalLaunch();
        }

        protected abstract void InternalLaunch();

        private void SwitchOn()
        {
            Console.WriteLine("On");
        }

    }

    public class EletricEngine : EngineBase
    {
        protected override void InternalLaunch()
        {

            Console.WriteLine("Electric");
        }
    }

    public class SolarEngine : EngineBase
    {
        protected override void InternalLaunch()
        {

            Console.WriteLine("Solar");
        }
    }

    public class AIEngine
    {
        public void Launch()
        {
            SwitchOn();
            InternalLaunch();
        }

        private void SwitchOn()
        {
            Console.WriteLine("On");
        }


        private void InternalLaunch()
        {

            Console.WriteLine("AI");
        }

    }
}

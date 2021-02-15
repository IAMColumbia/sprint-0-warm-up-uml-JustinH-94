namespace Sprint_0_Warm_Up
{
    public class Engine
    {
        public bool isStarted;

        public Engine()
        {
            Stop();
        }

        public string About()
        {
            if (isStarted)
                return "Engine is starting.";
            return "Engine has not started.";
        }

        public void Start()
        {
            isStarted = true;
        }

        public void Stop()
        {
            isStarted = false;
        }
    }
}
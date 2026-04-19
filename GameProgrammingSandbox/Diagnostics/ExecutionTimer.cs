using System.Diagnostics;

namespace GameProgrammingSandbox.Diagnostics;

public class ExecutionTimer
{
    private readonly Stopwatch _stopwatch = new();

    public void Start()
    {
        _stopwatch.Restart();
    }

    public TimeSpan Stop()
    {
        _stopwatch.Stop();
        return _stopwatch.Elapsed;
    }
}

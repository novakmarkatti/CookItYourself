using UnityEngine;

public class Main : MonoBehaviour
{
    private void Start()
    {
        Application.targetFrameRate = 60;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}
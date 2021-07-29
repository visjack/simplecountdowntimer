using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    [Tooltip("Number of seconds to be ouf bounds before resetting")]
    public float timeoutDuration = 3f;

    [Tooltip("Set this bool to true to start the countdown, if set to false the countdown will stop")]
    public bool trigger = false;

    float time;
    float remainingTime;
    public bool timesUp;
    bool timerIsRunning = false;
    
    void Start()
    {
        timesUp = false;
        time = Time.time;
    }

    void Update()
    {        
        if (!trigger && timerIsRunning)
        {
            StopTimer();
        }
        else if(timerIsRunning)
        {
            UpdateTimer ();
        }
        else if(!timerIsRunning && trigger)
        {
            StartTimer();
        }
    }

    void StartTimer()
    {
        Debug.Log("Timer Started");
        time = Time.time;
        timerIsRunning = true;
    }

    void StopTimer()
    {
        Debug.Log("Timer Stopped");
        timerIsRunning = false;
    }

    void UpdateTimer()
    {
        remainingTime = time + timeoutDuration - Time.time;
        //Debug.Log("Remaining Time: " + remainingTime.ToString());

        if(remainingTime <= 0)
        {
            Debug.Log("Times Complete");
            // Call a function here to be triggered
            timerIsRunning = false;
        }
    }
}

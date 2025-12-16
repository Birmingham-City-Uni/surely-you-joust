using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ROUNDDECAL : MonoBehaviour
{
    public RawImage r1;
    public RawImage r2;
    public RawImage r3;
    public RawImage r4;
    public RawImage r5;
    public RawImage r6;
    bool timer_is_running = true;
    public int strttime;
    public float currentime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentime = strttime * 60;
        r1.enabled = true;
        r2.enabled = false;
        r3.enabled = false;
        r4.enabled = false;
        r5.enabled = false;
        r6.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (timer_is_running == true)
        {
            currentime = currentime - Time.deltaTime;

        }
        if (currentime <= 0)
        {

            Debug.Log("Time Out");
            timer_is_running = false;
            if (r1.enabled== true)
            {
                currentime = strttime * 60;
                timer_is_running = true;
                r1.enabled = false;
                r2.enabled = true;
            }
            else if (r2.enabled == true)
            {
                currentime = strttime * 60;
                timer_is_running = true;
                r2.enabled = false;
                r3.enabled = true;
            }
            else if (r3.enabled == true)
            {
                currentime = strttime * 60;
                timer_is_running = true;
                r3.enabled = false;
                r4.enabled = true;
            }
            else if (r4.enabled == true)
            {
                currentime = strttime * 60;
                timer_is_running = true;
                r4.enabled = false;
                r5.enabled = true;
            }
            else if (r5.enabled == true)
            {
                currentime = strttime * 60;
                timer_is_running = true;
                r5.enabled = false;
                r6.enabled = true;
            }

        }
    }
}

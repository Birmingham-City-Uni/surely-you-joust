using UnityEngine;
using TMPro;
using System.Timers;
using UnityEngine.UI;
using System;



public class countdown : MonoBehaviour
{
    bool timer_is_running = true;
    float currentTime;
    public TMPro.TextMeshProUGUI currenttimetext;
    public int starttime;
    public float elapsedtime;
    public Slider blue;
    public Slider red;
    public float increasered;
    public float increaseblue;
    public float starttimeFLOAT;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        currentTime = starttime * 60;
        starttimeFLOAT = (float)starttime;
    
     
       
        
    }

    // Update is called once per frame
    void Update()
    {    elapsedtime= starttime; 
        increasered = elapsedtime + red.value ;
        increaseblue = elapsedtime + blue.value;
        if (timer_is_running == true)
        {
            currentTime = currentTime - Time.deltaTime;
            red.value = increasered;
            blue.value = increaseblue;
        }
      TimeSpan time= TimeSpan.FromSeconds(currentTime);
        currenttimetext.text= time.Seconds.ToString();
        if (currentTime<= 0)
        {
            timer_is_running=false;
        }
    }
    
}

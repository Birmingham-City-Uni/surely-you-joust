using UnityEngine;
using TMPro;
using System.Timers;
using UnityEngine.UI;
using System;
using JetBrains.Annotations;



public class countdown : MonoBehaviour
{
    bool timer_is_running = true;
    [SerializeField]
    public float currentTime;
    public TMPro.TextMeshProUGUI currenttimetext;
    public int starttime;
    public float elapsedtime;
    public Slider blue;
    public Slider red;
    public float increasered;
    public float increaseblue;
    public float starttimeFLOAT;
    public Camera main;
    public Camera main2;
    public Image round2;
    public Image round1;
    public Image round3;
    public Image round4;
    public Image round5;
    public Image round6;
   private winandloss winandloss;
    private button_script velocityaccuracy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        currentTime = starttime * 60;
        starttimeFLOAT = (float)starttime;
        winandloss = GetComponent<winandloss>();
      velocityaccuracy = GetComponent<button_script>();


    }

    // Update is called once per frame
    void Update()
    {
        elapsedtime += Time.deltaTime;
        increasered = elapsedtime;
        increaseblue = elapsedtime;
        round1.enabled = true;
        
        if (timer_is_running == true)
        {
            currentTime = currentTime - Time.deltaTime;
            red.value = increasered;
            blue.value = increaseblue;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currenttimetext.text = time.Seconds.ToString();
        if (currentTime <= 0)
        {
            timer_is_running = false;
            round1.enabled = false;
            winandloss.win1();
    
           
            
        }
    }
    public void r2()
    {
        {
            velocityaccuracy.velocity = 0;
            velocityaccuracy.accuaracy = 0;
            round2.enabled = true;
            // main.enabled = false;
            //  main2.enabled = true;
            currentTime = starttime * 60;
            timer_is_running=true;
            if (currentTime <= 0)
            {
               
                round2.enabled = false;

            }
        }

    }
    public void r3()
    {
        {
           
            round3.enabled = true;
            main2.enabled = false;
            main.enabled = true;
            if (currentTime <= 0)
            { 
               
                round3.enabled = false;
            }
        }
    }
    public void r4()
    {
        {

            round4.enabled = true;
            main.enabled = false;
            main2.enabled = true;
            if (currentTime <= 0)
            {
                
                round4.enabled = false;
            }
        }
    }
    public void r5()
    {
        {
        
            round5.enabled = true;
            main2.enabled = false;
            main.enabled = true;
            if (currentTime <= 0)
            {
                
                round5.enabled = false;
            }
        }
    }
    public void r6()
    {
        {
          
            round6.enabled = true;
            main.enabled = false;
            main2.enabled = true;
            if (currentTime <= 0)
            {
               
                round6.enabled = false;
            }
        }
    }
}

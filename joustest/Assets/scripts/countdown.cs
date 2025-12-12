using UnityEngine;
using TMPro;
using System.Timers;
using UnityEngine.UI;
using System;
using JetBrains.Annotations;
using Unity.VisualScripting;



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
    public bool round1start = false;
    public bool round2start = false;
    public bool round3start = false;
    public bool round4start = false;
    public bool round5start = false;
    public bool round6start = false;
    public jousters jousters;
    public jousters jousters2;
    public AudioSource impact;
    public AudioSource armour;
    public AudioSource crab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        currentTime = starttime * 60;
        starttimeFLOAT = (float)starttime;
        winandloss = GetComponent<winandloss>();
        velocityaccuracy = GetComponent<button_script>();
        jousters = GameObject.Find("combat(alpha)").GetComponent<jousters>();
        jousters = GameObject.Find("crab_rideable (1)").GetComponent<jousters>();
        round1.enabled = true;
        round2.enabled = false;
        round3.enabled = false;
        round4.enabled = false;
        round5.enabled = false;
        round6.enabled = false;
        impact.enabled = false;



    }

    // Update is called once per frame

    void Update()
    {
        elapsedtime += Time.deltaTime;
        increasered = elapsedtime;
        increaseblue = elapsedtime;


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
            round1start = true;
            impact.enabled = true;
            if (impact.enabled == true)
            {
                armour.enabled = false;
                crab.enabled = false;
            }
            else
            {
                                armour.enabled = true;
                crab.enabled = true;
            }
            if (currentTime <= 58)
            {
                impact.enabled = false;
     
            }

        }
        if (round1start == true)

        {
            if (currentTime <= 0)
            {


                winandloss.win1();
                round1start=false;
                round2start = true;
                round1.enabled=false;
                round2.enabled=true;

                
            

            }
        }
        if (round2start == true) 
        {
            if (currentTime <= 0)
            {
              
                round2start=false;
                round3start = true;
                round2.enabled = false;
                round3.enabled = true;
                winandloss.win1();
         
            }
        }
        if (round3start == true)
        {
            if (currentTime <= 0)
            {
                winandloss.win1();
                round3start = false;
                round4start = true;
                round3.enabled = false;
                round4.enabled = true;
          
            }
        }
        if (round4start == true)
        {
            if (currentTime <= 0)
            {
                winandloss.win1();
                round4start = false;
                round5start = true;
                round4.enabled = false;
                round5.enabled = true;
          
            }
        }
        if (round5start == true)
        {
            if (currentTime <= 0)
            {
                winandloss.win1();
                round5start = false;
                round6start = true;
                round5.enabled = false;
                round6.enabled = true;
     
            }
        }
        if (round6start == true)
        {
            if (currentTime <= 0)
            {
                winandloss.win1();
               
            }
        }
     
    }
    public void rr2()
    {

        elapsedtime = 0;
        velocityaccuracy.velocity = 0;
        velocityaccuracy.accuaracy = 0;
        round2.enabled = true;
        // main.enabled = false;
        //  main2.enabled = true;
        currentTime = starttime * 60;
        timer_is_running = true;
        round2start = true;




    }
}






 
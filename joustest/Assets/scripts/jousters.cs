using JetBrains.Annotations;
using System.Collections;
using System.Diagnostics.Contracts;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.Rendering;

public class jousters : MonoBehaviour
{
    public float moveduration = 5;
    public Vector3 target = new Vector3(178, 211, -37);
    public countdown time;
    public Vector3 returntarget = new Vector3(0, 0, 0);

    public Vector3 startPos;
    public Vector3 currentPos;
    Coroutine current;
    Coroutine current2;
    Coroutine current3;
    Coroutine current4;
    Coroutine current5;

    public bool charge1 = false;
    public bool charge2 = false;
    public bool charge3 = false;
    public bool charge4 = false;
    public bool charge5 = false;

    public bool r1 = false;
    public bool r2 = false;
    public bool r3 = false;
    public bool r4 = false;
    public bool r5 = false;
    public bool r6 = false;
    bool timerrun = true;
    public float currentime;
    public int strttime;







    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        current = StartCoroutine(moveplayer(target));
        time = GameObject.Find("score_manager").GetComponent<countdown>();
        currentime = strttime * 60;


        startPos = transform.position;
    }


    void Update()
    {
        currentPos = transform.position;
        Debug.Log(time.currentTime);
        if (timerrun == true)
        {
            currentime = currentime - Time.deltaTime;

        }
        if (currentime <= 0)
        {

            Debug.Log("Time Out");
            timerrun = false;
            r1 = true;







            
                            if (r5 == true)
                            {

                                StopCoroutine(current5);
                                charge5 = true;

                            }
          
                        if (r4 == true)
                        {
                            StopCoroutine(current4);
                            charge4 = true;
                            TeleportBack(startPos);
                        }
          
                    if (r3 == true)
                    {
                        StopCoroutine(current3);
                        charge3 = true;
                        TeleportBack(startPos);
                    }
          
                if (r2 == true)
                {
                    StopCoroutine(current2);
                    charge2 = true;
                    TeleportBack(startPos);
                }
            if (r1 == true)
            {
                StopCoroutine(current);
                charge1 = true;
                TeleportBack(startPos);

            }
        }
        
    }

    IEnumerator moveplayer(Vector3 targetposition)
    {

        Vector3 startpostion = transform.position;
        float timeelapsed = 0;
        while (timeelapsed < moveduration)
        {
            transform.position = Vector3.Lerp(startpostion, targetposition, timeelapsed / moveduration);
            timeelapsed += Time.deltaTime;
            yield return null;
        }

    }


    void TeleportBack(Vector3 _startPos)
    {
        Debug.Log("TELEPORT");
        transform.position = _startPos;

        if (charge1 == true)
        {

            r1 = false;
           

                currentime = strttime * 60;
                timerrun = true;
             r2 = true;
            current2 = StartCoroutine(moveplayer(target));
            charge1 = false;


        }
        if (charge2 == true)
        {
            
            r2 = false;
                currentime = strttime * 60;
                timerrun = true;
            r3 = true;
            {
                current3 = StartCoroutine(moveplayer(target));
                charge2 = false;
            }
            if (charge3 == true)
            {
              r3 = false;
                    currentime = strttime * 60;
                    timerrun = true;
                r4 = true;
                current4 = StartCoroutine(moveplayer(target));
                charge3 = false;
            }
            if (charge4 == true)
            {
               r4= false;
                    currentime = strttime * 60;
                    timerrun = true;
               r5 = true;
                {
                    current5 = StartCoroutine(moveplayer(target));
                    charge4 = false;
                }
                if (charge5 == true)
                {
                   r5= false;
                        currentime = strttime * 60;
                        timerrun = true;
                    
                    StartCoroutine(moveplayer(target));
                    charge5 = false;
                }
            }
        }
    }
}
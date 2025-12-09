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

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        current = StartCoroutine(moveplayer(target));
        time = GameObject.Find("score_manager").GetComponent<countdown>();

        startPos = transform.position;
    }


    void Update()
    {
        currentPos = transform.position;
        if (time.round1start == true) 
        {
            r1 = true;
      
        }


        if (r1 == true)
            if (r2 == true)
                if (r3 == true)
                    if (r4 == true)
                        if (r5 == true)
        {
         
            StopCoroutine(current5);
            charge5 = true;
           
        }
        if (r1 == true)
        if (r2 == true)
                if (r3 == true)
                    if (r4 == true)
        {
            StopCoroutine(current4);
            charge4 = true;
            TeleportBack(startPos);
        }
        if (r1 == true)
            if (r2 == true)
                if (r3 == true)
        {
            StopCoroutine (current3);
            charge3 = true;
            TeleportBack(startPos);
        }
        if (r1 == true)
            if (r2 == true)
        {
        StopCoroutine(current2);
            charge2 = true;
            TeleportBack(startPos);
        }
        if (r1== true)
        {
            StopCoroutine(current);
            charge1 = true;
            TeleportBack (startPos);

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
        transform.position = _startPos;

       if (charge1==true)
        {
           if (r1 == true) 
            {
                r2= true;
                Debug.Log("finalllyyyy");
            }
            current2 = StartCoroutine(moveplayer(target));
            charge1 = false;
            

        }
        if (charge2 == true)
        {
        current3 = StartCoroutine(moveplayer(target));
            charge2=false;
        }
       if (charge3 == true)
        {
        current4 = StartCoroutine(moveplayer(target));
            charge3 = false;
        }
        if (charge4 == true)
        {
        current5 = StartCoroutine(moveplayer(target));
            charge4 = false;
        }
        if (charge5 == true)
        {
             StartCoroutine(moveplayer(target));
            charge5 = false;
        }
    }
}
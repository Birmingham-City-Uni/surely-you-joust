using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
[RequireComponent(typeof(Image))]

public class flash : MonoBehaviour
{
    public Image image = null;
    Coroutine currentcoroutine = null;
    private countdown timer;
    public bool hasflashed= false;

    private void Awake()
    {
      timer = GetComponent<countdown>();
        image = GetComponent<Image>();
    }
    public void Update()
    {
            if(!hasflashed && timer.currentTime <= 0) 
            { 
        
            startflash(1, 1);
            hasflashed = true;
        }
    }
    public void startflash(float secondsforflash, float maxalpha)
    {
        maxalpha = Mathf.Clamp(maxalpha, 0, 1);
        StartCoroutine(flashcoroutine(secondsforflash, maxalpha));
    }    
        IEnumerator flashcoroutine(float secondsforflash, float maxalpha)
        {
            float flashin = secondsforflash / 2;
            for (float t = 0; t <= flashin; t += Time.deltaTime)
            {
                if (image != null)
                {
                    Color color = image.color;
                    color.a = Mathf.Lerp(0, maxalpha, t / flashin);
                    image.color = color;

                }
                yield return null;
            }              

            
             float flashout = secondsforflash / 2;
            for (float t = 0; t < flashout; t += Time.deltaTime)
             
                    {
                Color color = image.color;
                color.a = Mathf.Lerp(maxalpha, 0f, t / flashout);
                image.color = color;
                yield return null;

            }

                Color final = image.color;
                final.a = 0;
                image.color = final;
          
            currentcoroutine = null;

        }
      
    
}
   

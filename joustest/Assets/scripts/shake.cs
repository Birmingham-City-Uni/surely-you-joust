using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake : MonoBehaviour
{
    public float duration = 1;
    public bool star = false;   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
if (star)
        {
            star = false;
            StartCoroutine(shaking());
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
   IEnumerator shaking()
    {
        Vector3 startpostion = transform.position;
        float elapsedtime = 0;
        while (elapsedtime < duration)
        {
       elapsedtime += Time.deltaTime;
            transform.position = startpostion + Random.insideUnitSphere;
            yield return null;
        }
   transform.position = startpostion;
    }
}
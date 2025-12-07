using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class shakenflash : MonoBehaviour
{
    public bool start = false;
    public AnimationCurve curve;
    public float duration;
    private countdown time;
    public bool hasshaken = false;
    private flashs flash;
    [SerializeField] flashs flashs= null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time = GetComponent<countdown>();
     
    }

    // Update is called once per frame
    void Update()
    { if (time.currentTime <= 0 && !hasshaken)
        {
          
            
                start = false;
            StartCoroutine(shaking());
          flashs.strtflsh(1,0.8f, Color.white);
            hasshaken=true;
             
            
        }
       
    }
    IEnumerator shaking()
        {
            Vector3 startposition = transform.position;
            float elapsedtime = 0f;
            while (elapsedtime < duration)
            {
                elapsedtime += Time.deltaTime;
                float strength = curve.Evaluate(elapsedtime / duration);
                transform.position = startposition + Random.insideUnitSphere * strength;
                yield return null;
            }
            transform.position = startposition;
        }
}

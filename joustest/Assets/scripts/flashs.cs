using System.Collections;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class flashs : MonoBehaviour
{
    Image image = null;
    Coroutine current = null;
    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public void strtflsh(float duration, float alpha, Color newcolor)
    {
        image.color = newcolor;
        if (current != null)
        {
            StopCoroutine(current);
            current = StartCoroutine(Flash(duration, alpha));
        }

       
    }
    IEnumerator Flash(float duration, float alpha)
        {
            float flashin = duration / 2;
            for (float t = 0; t <= flashin; t += Time.deltaTime)
            {
            Color color = image.color;
            color.a = Mathf.Lerp(0, alpha,t/flashin);
            image.color = color;
            yield return null;
            }   
        float flashout = duration / 2;
        for (float t = 0; t <= flashout; t += Time.deltaTime)
        {
            Color color = image.color;
            color.a = Mathf.Lerp(alpha, 0, t / flashout);
            image.color = color;
            yield return null;
        }
        image.color= new Color32(0,0,0,0);
        }
 
} 

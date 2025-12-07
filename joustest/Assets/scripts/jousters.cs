using System.Collections;
using UnityEngine;

public class jousters : MonoBehaviour
{
    public float moveduration = 5;
    public Vector3 target = new Vector3(178, 211, -37);
    private countdown time;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(moveplayer(target));
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
        transform.position = targetposition;
        if (time.currentTime == 0)
        {
            transform.position = startpostion;
        }
    }
}


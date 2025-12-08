using JetBrains.Annotations;
using System.Collections;
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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        current = StartCoroutine(moveplayer(target));
        time = GameObject.Find("score_manager").GetComponent<countdown>();

        startPos = transform.position;
    }


    private void Update()
    {
        currentPos = transform.position;

        if (time.currentTime <= 0)
        {
            Debug.Log("End");

            StopCoroutine(current);

            TeleportBack(startPos);
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

        Debug.Log("MoveBack");
    }
}
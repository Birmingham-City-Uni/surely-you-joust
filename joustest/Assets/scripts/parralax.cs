using UnityEngine;
using UnityEngine.UI;

public class parralax : MonoBehaviour
{

    Vector2 strtposition;
    [SerializeField] int parralaxspeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       strtposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        float posx = Mathf.Lerp (transform.position.x, strtposition.x +(position.x * parralaxspeed), 2f* Time.deltaTime);
        float posy = Mathf.Lerp(transform.position.y, strtposition.y + (position.y * parralaxspeed), 2f * Time.deltaTime);
        transform.position = new Vector3(posx, posy,0);
    }
}

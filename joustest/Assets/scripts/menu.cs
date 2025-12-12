using UnityEngine;

public class menu : MonoBehaviour
{
    public Canvas canvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvas.enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        canvas.enabled = true;
    }
     void OnTriggerExit(Collider other)
    {
        
        canvas.enabled = false;
    }
}

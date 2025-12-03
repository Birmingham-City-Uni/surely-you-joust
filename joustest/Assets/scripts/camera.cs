using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject pCyclinder19;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position= pCyclinder19.transform.position + new Vector3 (20, 4,0); 
    }
}

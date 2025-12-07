using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class accuracycalc : MonoBehaviour
{
    public GameObject core;
    public GameObject leftouter;
    public GameObject rightouter;
    public GameObject bottomouter;
    public GameObject topouter;
    public GameObject left;
        public GameObject right;
    public GameObject top;
    public Vector3 mouseposition;
    public int accuracyvalue=10;
    public int accuracymulti = 0;
    public int accuarracynumber;    
    Vector3 worldposition;
    public float cooldown = 0.5f;
    public float lastplus= 0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        accuarracynumber = accuracyvalue * accuracymulti;
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            mouseposition = Mouse.current.position.ReadValue();
            Ray ray = Camera.main.ScreenPointToRay(mouseposition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                GameObject hitobj = hit.collider.gameObject;
                if (hitobj == core)
                {
                    accuracymulti = 5;
                    Debug.Log("bullseye");

                }

                else if (hitobj == left)
                {
                    accuracymulti = 3;
                    Debug.Log("outering");
                }
                else if (hitobj == bottomouter)
                {
                    accuracymulti = 2;
                    Debug.Log("bottomoutering");
                }
                else if (hitobj == right)
                {
                    accuracymulti = 3;
                    Debug.Log("outering");
                }
                else if (hitobj == top)
                {
                    accuracymulti = 3;
                    Debug.Log("outering");
                }
                else if (hitobj == leftouter)
                {
                    accuracymulti = 1;
                    Debug.Log("dud");
                }
                else if (hitobj == rightouter)
                {
                    accuracymulti = 1;
                    Debug.Log("dud");
                }
                else if (hitobj == topouter)
                {
                    accuracymulti = 1;
                    Debug.Log("dud");
                }
                else
                {
                    accuracymulti = 0;
                    Debug.Log("missed");
                }

            }
        }
    }
}
 

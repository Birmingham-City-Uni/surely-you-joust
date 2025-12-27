
using UnityEngine;

public class footnamrour : MonoBehaviour
{
    public AudioSource foot;
    public AudioSource armour;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     foot.enabled = false;
        armour.enabled = false;
   
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.W))
        {
  
            foot.enabled = true;
            armour.enabled = true;
            Debug.Log("W key was pressed");
        }
        else if (Input.GetKey(KeyCode.S))
        {
           
            foot.enabled = true;
            armour.enabled = true;
            Debug.Log("S key was pressed");
        }
        else if (Input.GetKey(KeyCode.A))
        {
           
            foot.enabled = true;
            armour.enabled = true;
            Debug.Log("A key was pressed");
        }
        else if (Input.GetKey(KeyCode.D))
        {
           
            foot.enabled = true;
            armour.enabled = true;
            Debug.Log("D key was pressed");
        }
        else 
        {
             foot.enabled = false;
               armour.enabled = false;
        }

    }
}

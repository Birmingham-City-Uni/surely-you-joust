using UnityEngine;

public class camerareset : MonoBehaviour
{
    public static camerareset instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if(instance == null)
        {
          instance= this;
            Destroy(gameObject);
        }

    }
}
    



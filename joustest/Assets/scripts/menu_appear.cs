using UnityEngine;

public class menu_appear : MonoBehaviour
{
    public Canvas battlemenu;
    private void Start()
    {
        battlemenu.enabled = false;
    }
    private void OnTriggerEnter(Collider collider)
    {
     if (battlemenu.tag == "player")
        battlemenu.enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if (battlemenu.tag == "player")
            battlemenu.enabled = false;
    }
}

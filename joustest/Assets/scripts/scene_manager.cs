using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_manager : MonoBehaviour
{
    public void loadlevel ()
        {
        SceneManager.LoadScene("combat");
    }
    public void menu()
        
    {
        SceneManager.LoadScene("ingame menu");
    }
}


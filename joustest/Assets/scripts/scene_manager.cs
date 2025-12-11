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
    public void exit () 
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}


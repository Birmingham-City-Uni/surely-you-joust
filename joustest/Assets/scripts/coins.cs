using UnityEngine;

    using TMPro;

public class coins : MonoBehaviour
{
    public GameObject coin;
    public TMPro.TextMeshProUGUI coinscore;
    public int score=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         coinscore.text = score.ToString();
    }
     
}

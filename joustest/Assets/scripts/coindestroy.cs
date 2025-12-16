using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class coindestroy : MonoBehaviour
{
    public GameObject coin;
    public TMPro.TextMeshProUGUI coinscore;
    private coins coinsScript;
    public int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinsScript = GameObject.Find("ui_manager").GetComponent<coins>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void OnTriggerEnter(Collider other)
    {
     coinsScript.destroyandadd(1);
    Destroy(coin);
          

        

    }

}

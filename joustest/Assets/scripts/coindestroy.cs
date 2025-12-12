using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
public class coindestroy : MonoBehaviour
{
    public GameObject coin;
    public TMPro.TextMeshProUGUI coinscore;
    private coins coinsScript;
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
        Destroy(coin);
        coinsScript.score = coinsScript.score + 1;
        coinsScript.coincount = coinsScript.coincount - 1;

    }
}

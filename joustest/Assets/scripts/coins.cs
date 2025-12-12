using UnityEngine;

    using TMPro;

public class coins : MonoBehaviour
{
    public GameObject coin;
    public TMPro.TextMeshProUGUI coinscore;
    public int score=0;

    public float itemspreadx = 10f;
    public float itemspready = 0f;
    public float itemspreadz = 10f;
    public float itemspreadxmin = 0f;
    public float itemspreadzmin = 0f;
    public int coincount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (coincount < 50)
        {
            spreaditem();
            coincount = coincount + 1;
        }
       

        coinscore.text = score.ToString();
       
    }
    public void spreaditem()
    {
        Vector3 spreadposition = new Vector3(Random.Range(itemspreadxmin, itemspreadx), itemspready, Random.Range(itemspreadzmin, itemspreadz) );
        GameObject clonedcoin = Instantiate(coin, spreadposition, Quaternion.identity);

    }
     
}

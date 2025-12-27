using UnityEngine;

    using TMPro;

public class coins : MonoBehaviour
{
    public GameObject coin;
    public TMPro.TextMeshProUGUI coinscore;
 
    public static coins Instance;
    public float itemspreadx = 10f;
    public float itemspready = 0f;
    public float itemspreadz = 10f;
    public float itemspreadxmin = 0f;
    public float itemspreadzmin = 0f;
    public int coincount = 0;
    public int score;
    public int maxcoins = 50;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if(Instance == null)
        {
            Instance= this;
            DontDestroyOnLoad(gameObject);
        }
        else         {
            Destroy(gameObject);
            return;
        }

    }
    void Start()
    {
       updadatescoreui();
    }

    // Update is called once per frame
    void Update()
    {
       if (coincount <= 50)
        {
            spreaditem();
            coincount = coincount + 1;
        }

       if (coincount <maxcoins)
        {
                       spreaditem();
            coincount = coincount + 1;
        }

  
       
    }
    public void spreaditem()
    {
        Vector3 spreadposition = new Vector3(Random.Range(itemspreadxmin, itemspreadx), itemspready, Random.Range(itemspreadzmin, itemspreadz) );
        GameObject clonedcoin = Instantiate(coin, spreadposition, Quaternion.identity);

    }
    public void destroyandadd(int amount)
    {
       
        {
            
            score= score + amount;
            coinscore.text = score.ToString();
            coincount = coincount - 1;


        }
    }
    void updadatescoreui()
    {
        if (coinscore != null)
        {
            coinscore.text = score.ToString();
        }
    }
     
}

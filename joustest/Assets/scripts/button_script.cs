using TMPro;
using UnityEngine;

public class button_script : MonoBehaviour
{
    public TMPro.TextMeshProUGUI velocitytext;
   public TMPro.TextMeshProUGUI accuracytext;
    public int velocity;
    public int accuaracy;
    private accuracycalc calc;
    private winandloss winandloss;

     void Start()
    {
        calc = GetComponent<accuracycalc>();
        winandloss = GetComponent<winandloss>();
    }
    public void addvelocity(int points)
    {
        velocity += points ;
       
        velocitytext.text = velocity.ToString();
        if (winandloss.roundended1 == true)
        {
            velocity = 0;

        }
        if (winandloss.roundended2 == true)
        {
            velocity = 0;

        }
        if (winandloss.roundended3 == true)
        {
            velocity = 0;

        }
        if (winandloss.roundended4 == true)
        {
            velocity = 0;

        }
        if (winandloss.roundended5 == true)
        {
            velocity = 0;

        }
        if (winandloss.roundended6 == true)
        {
            velocity = 0;

        }

    }
    public void addaccuracy(int points)
    {
        accuaracy += calc.accuarracynumber + points;
        accuracytext.text = accuaracy.ToString();
    if (winandloss.roundended1 == true)
        {
            accuaracy = 0;

        }
        if (winandloss.roundended2 == true)
        {
            velocity = 0;

        }
        if (winandloss.roundended3 == true)
        {
            velocity = 0;

        }
        if (winandloss.roundended4 == true)
        {
            velocity = 0;

        }
        if (winandloss.roundended5 == true)
        {
            velocity = 0;

        }
        if (winandloss.roundended6 == true)
        {
            velocity = 0;

        }
    }
   
}

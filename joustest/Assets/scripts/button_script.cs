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
        velocity += points;

        velocitytext.text = velocity.ToString();


    }
    public void addaccuracy(int points)
    {
        accuaracy += calc.accuarracynumber + points;
        accuracytext.text = accuaracy.ToString();


    }
}

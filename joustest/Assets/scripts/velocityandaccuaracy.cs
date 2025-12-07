using UnityEngine;

public class velocityandaccuaracy : MonoBehaviour
{
    private accuracycalc newvalue;
    private button_script plus;
    private countdown time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        plus = GameObject.Find("score_manager").GetComponent<button_script>();
        time= GetComponent<countdown>();
       

    }

    // Update is called once per frame
    public void increase()
    {
       
        plus.addvelocity(30);
        plus.addaccuracy(10);
        if (time.currentTime <= 0)
        {
            plus.addaccuracy(-10);
            plus.addvelocity(0);
        }
    }

}

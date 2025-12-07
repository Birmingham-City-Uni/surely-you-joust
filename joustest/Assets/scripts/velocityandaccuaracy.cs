using UnityEngine;

public class velocityandaccuaracy : MonoBehaviour
{
    private accuracycalc newvalue;
    private button_script plus;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        plus = GameObject.Find("score_manager").GetComponent<button_script>();
       

    }

    // Update is called once per frame
    public void increase()
    {
        plus.addvelocity(10);
        plus.addaccuracy(10);
    }

}

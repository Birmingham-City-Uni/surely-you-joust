using JetBrains.Annotations;

using UnityEngine;
using UnityEngine.UI;

public class winandloss : MonoBehaviour
{
    public int enemyscore = 25000;
    private button_script score;
    public int number;
    public int playerlifes = 3;
    public int enemylife = 3;
    public RawImage life;
    public RawImage life2;
    public RawImage life3;
    public RawImage enemy_life;
    public RawImage enemylife2;
    public RawImage enemylife3;
    public Canvas winner;
    public Canvas loser;
    public bool haslifebeentaken = false;
    public bool roundended1 = false;
    public bool roundended2 = false;
    public bool roundended3 = false;
    public bool roundended4 = false;
    public bool roundended5 = false;
    public bool roundended6 = false;
    private countdown time;
    public void Start()
    {
        score = gameObject.GetComponent<button_script>();
        time = gameObject.GetComponent<countdown>();
        winner.enabled = false;
        loser.enabled = false;
    }
    public void Update()
    {
        number = score.velocity + score.accuaracy;
    }
    public void win1()
    {

        if (time.currentTime <= 0)
        {

            if (number > enemyscore)
            {
                if (enemylife == 1)
                {
                    enemylife3.enabled = false;
                    winner.enabled = true;

                }
                else if (enemylife == 3)
                {
                    enemylife = 2;
                    enemy_life.enabled = false;
                    enemyscore = enemyscore + 5000;
                    haslifebeentaken = true;
                    roundended1 = true;

                }
                else if (enemylife == 2)
                {
                    enemylife = 1;
                    enemylife2.enabled = false;
                    enemyscore = enemyscore + 5000;
                    haslifebeentaken = true;
                    roundended1 = true;

                }

                if (roundended1 == true)
                {
                    roundended1 = false;
                    haslifebeentaken = false;
                    time.rr2();
                    Debug.Log("WIN");


                }


            }
            else
            {
                loss1();
            }
        }

    }
 
    public void loss1()
    {
        if (playerlifes == 1)
        {
            life.enabled = false;
            loser.enabled = true;
            roundended1 = true;
        }
        else if (playerlifes == 3)
        {
            life3.enabled = false;
            playerlifes = 2;
            enemyscore = enemyscore - 5000;
            haslifebeentaken = true;
            roundended1 = true;

        }
        else if (playerlifes == 2)
        {
            life2.enabled = false;
            playerlifes = 1;
            enemyscore = enemyscore - 5000;
            haslifebeentaken = true;
            roundended1 = true;
        }
        if (roundended1 == true)
        {
            roundended1 = false;
            haslifebeentaken = false;
            Debug.Log("LOSS");

            time.rr2();


        }
    }
}
 








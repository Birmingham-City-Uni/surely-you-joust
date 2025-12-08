using JetBrains.Annotations;

using UnityEngine;
using UnityEngine.UI;

public class winandloss : MonoBehaviour
{
    public int enemyscore = 25000;
    private button_script score;
    public int number;
    public int playerlifes= 3;
    public int enemylife= 3;
    public Image life;
    public Image life2;
    public Image life3;
    public Image enemy_life;
    public Image enemylife2;
    public Image enemylife3;
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
    public void Start ()
    {
        score = gameObject.GetComponent<button_script>();
        time= gameObject.GetComponent<countdown>();
    }
    public void Update()
    {
        number = score.velocity + score.accuaracy;
    }
    public void win1()
    {
        
        if (time.currentTime <= 0)
        {

            if (number < enemyscore)
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
                    time.r2();
                    Debug.Log("win");

                }


            }
            else
            {
                loss1();
            }
        }
       
    }
    public void win2()
    {
        if (time.currentTime <= 0)
        {

            if (number < enemyscore)
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

                }
                else if (enemylife == 2)
                {
                    enemylife = 1;
                    enemylife2.enabled = false;
                    enemyscore = enemyscore + 5000;
                    haslifebeentaken = true;
                }
                if (roundended2 ==false)
                {
                    roundended2 = true;
                    haslifebeentaken = false;
                    time.r3();
                   
                }


            }

        }

    }
    public void win3()
    {
        if (time.currentTime <= 0)
        {

            if (number < enemyscore)
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

                }
                else if (enemylife == 2)
                {
                    enemylife = 1;
                    enemylife2.enabled = false;
                    enemyscore = enemyscore + 5000;
                    haslifebeentaken = true;
                }
                if (roundended3 == false)
                {
                    roundended3 = true;
                    haslifebeentaken = false;
                    time.r4();

                }


            }

        }

    }
    public void win4()
    {
        if (time.currentTime <= 0)
        {

            if (number < enemyscore)
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

                }
                else if (enemylife == 2)
                {
                    enemylife = 1;
                    enemylife2.enabled = false;
                    enemyscore = enemyscore + 5000;
                    haslifebeentaken = true;
                }
                if (roundended4 == false)
                {
                    roundended4 = true;
                    haslifebeentaken = false;
                    time.r5();

                }


            }

        }

    }
    public void win5()
    {
        if (time.currentTime <= 0)
        {

            if (number < enemyscore)
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

                }
                else if (enemylife == 2)
                {
                    enemylife = 1;
                    enemylife2.enabled = false;
                    enemyscore = enemyscore + 5000;
                    haslifebeentaken = true;
                }
                if (roundended5 == false)
                {
                    roundended5 = true;
                    haslifebeentaken = false;
                    time.r6();

                }


            }

        }

    }
    public void win6()
    {
        if (time.currentTime <= 0)
        {

            if (number < enemyscore)
            {
                if (enemylife == 1)
                {
                    enemylife3.enabled = false;
                    winner.enabled = true;
                }
            }

        }

    }
    public void loss1 ()
    {
        if (playerlifes == 1)
        {
            life.enabled = false;
            loser.enabled = true;
            roundended1 = true;
        }
        else if (playerlifes == 3)
        {
            life3 .enabled = false;
            playerlifes = 2;
            enemyscore = enemyscore -5000;
            haslifebeentaken=true;
            roundended1 = true;
            Debug.Log("calcapplied");
        }
        else if (playerlifes == 2)
        {
            life2 .enabled = false;
            playerlifes=1;
            enemyscore = enemyscore - 5000;
            haslifebeentaken=true;
            roundended1 = true;
        }
        if (roundended1 == true)
        {
            roundended1 = false;
            haslifebeentaken = false;
            time.r2();
            Debug.Log("lose");

        }
    }
    public void loss2()
    {
        if (playerlifes == 1)
        {
            life.enabled = false;
            loser.enabled = true;
        }
        else if (playerlifes == 3)
        {
            life3.enabled = false;
            playerlifes = 2;
            enemyscore = enemyscore - 5000;
            haslifebeentaken = true;
        }
        else if (playerlifes == 2)
        {
            life2.enabled = false;
            playerlifes = 1;
            enemyscore = enemyscore - 5000;
            haslifebeentaken = true;
        }
        if (roundended2 == false)
        {
            roundended2 = true;
            haslifebeentaken = false;
            time.r3();

        }
    }
    public void loss3()
    {
        if (playerlifes == 1)
        {
            life.enabled = false;
            loser.enabled = true;
        }
        else if (playerlifes == 3)
        {
            life3.enabled = false;
            playerlifes = 2;
            enemyscore = enemyscore - 5000;
            haslifebeentaken = true;
        }
        else if (playerlifes == 2)
        {
            life2.enabled = false;
            playerlifes = 1;
            enemyscore = enemyscore - 5000;
            haslifebeentaken = true;
        }
        if (roundended3 == false)
        {
            roundended3 = true;
            haslifebeentaken = false;
            time.r4();

        }
    }
    public void loss4()
    {
        if (playerlifes == 1)
        {
            life.enabled = false;
            loser.enabled = true;
        }
        else if (playerlifes == 3)
        {
            life3.enabled = false;
            playerlifes = 2;
            enemyscore = enemyscore - 5000;
            haslifebeentaken = true;
        }
        else if (playerlifes == 2)
        {
            life2.enabled = false;
            playerlifes = 1;
            enemyscore = enemyscore - 5000;
            haslifebeentaken = true;
        }
        if (roundended4 == false)
        {
            roundended4 = true;
            haslifebeentaken = false;
            time.r5();

        }
    }
    public void loss5()
    {
        if (playerlifes == 1)
        {
            life.enabled = false;
            loser.enabled = true;
        }
        else if (playerlifes == 3)
        {
            life3.enabled = false;
            playerlifes = 2;
            enemyscore = enemyscore - 5000;
            haslifebeentaken = true;
        }
        else if (playerlifes == 2)
        {
            life2.enabled = false;
            playerlifes = 1;
            enemyscore = enemyscore - 5000;
            haslifebeentaken = true;
        }
        if (roundended5 == false)
        {
            roundended5 = true;
            haslifebeentaken = false;
            time.r6();

        }
    }
    public void loss6()
    {
        if (playerlifes == 1)
        {
            life.enabled = false;
            loser.enabled = true;
        }  
    }
}







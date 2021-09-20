using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoardDisplay : MonoBehaviour
{

    public Text Position;
    public Text Name;
    public Text Minutes;
    public Text Seconds;

    public bool AI1;
    public bool AI2;
    public bool AI3;
    public bool AI4;
    public bool AI5;
    public bool AI6;
    public bool AI7;
    public bool Player;


    
    void Update()
    {
        if (AI1 == true)
        {
            Position.text = FinishLineAI.AICar1FinishPosition.ToString();
            Name.text = FinishLineAI.AICar1Name;
            if(FinishLineAI.AICar1RTMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICar1RTMinutes).ToString() + ":";
            }
            if(FinishLineAI.AICar1RTMinutes >= 10)
            {
                Minutes.text =Mathf.Round(FinishLineAI.AICar1RTMinutes).ToString() + ":";
            }

            if (FinishLineAI.AICar1RTSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICar1RTSeconds).ToString();
            }
            if (FinishLineAI.AICar1RTMinutes >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICar1RTSeconds).ToString();
            }
        }


        if (AI2 == true)
        {
            Position.text = FinishLineAI.AICar2FinishPosition.ToString();
            Name.text = FinishLineAI.AICar2Name;
            if (FinishLineAI.AICar2RTMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICar2RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar2RTMinutes >= 10)
            {
                Minutes.text = Mathf.Round(FinishLineAI.AICar2RTMinutes).ToString() + ":";
            }

            if (FinishLineAI.AICar2RTSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICar2RTSeconds).ToString();
            }
            if (FinishLineAI.AICar2RTSeconds >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICar2RTSeconds).ToString();
            }
        }



        if (AI3 == true)
        {
            Position.text = FinishLineAI.AICar3FinishPosition.ToString();
            Name.text = FinishLineAI.AICar3Name;
            if (FinishLineAI.AICar3RTMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICar3RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar3RTMinutes >= 10)
            {
                Minutes.text = Mathf.Round(FinishLineAI.AICar3RTMinutes).ToString() + ":";
            }

            if (FinishLineAI.AICar3RTSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICar3RTSeconds).ToString();
            }
            if (FinishLineAI.AICar3RTSeconds >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICar3RTSeconds).ToString();
            }
        }




        if (AI4 == true)
        {
            Position.text = FinishLineAI.AICar4FinishPosition.ToString();
            Name.text = FinishLineAI.AICar4Name;
            if (FinishLineAI.AICar4RTMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICar4RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar4RTMinutes >= 10)
            {
                Minutes.text = Mathf.Round(FinishLineAI.AICar4RTMinutes).ToString() + ":";
            }

            if (FinishLineAI.AICar4RTSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICar4RTSeconds).ToString();
            }
            if (FinishLineAI.AICar4RTSeconds >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICar4RTSeconds).ToString();
            }
        }


        if (AI5 == true)
        {
            Position.text = FinishLineAI.AICar5FinishPosition.ToString();
            Name.text = FinishLineAI.AICar5Name;
            if (FinishLineAI.AICar5RTMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICar5RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar5RTMinutes >= 10)
            {
                Minutes.text = Mathf.Round(FinishLineAI.AICar5RTMinutes).ToString() + ":";
            }

            if (FinishLineAI.AICar5RTSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICar5RTSeconds).ToString();
            }
            if (FinishLineAI.AICar5RTSeconds >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICar5RTSeconds).ToString();
            }
        }



        if (AI6 == true)
        {
            Position.text = FinishLineAI.AICar6FinishPosition.ToString();
            Name.text = FinishLineAI.AICar6Name;
            if (FinishLineAI.AICar6RTMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICar6RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar6RTMinutes >= 10)
            {
                Minutes.text = Mathf.Round(FinishLineAI.AICar6RTMinutes).ToString() + ":";
            }

            if (FinishLineAI.AICar6RTSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICar6RTSeconds).ToString();
            }
            if (FinishLineAI.AICar6RTSeconds >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICar6RTSeconds).ToString();
            }
        }

        if (AI7 == true)
        {
            Position.text = FinishLineAI.AICar7FinishPosition.ToString();
            Name.text = FinishLineAI.AICar7Name;
            if (FinishLineAI.AICar7RTMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(FinishLineAI.AICar7RTMinutes).ToString() + ":";
            }
            if (FinishLineAI.AICar7RTMinutes >= 10)
            {
                Minutes.text = Mathf.Round(FinishLineAI.AICar7RTMinutes).ToString() + ":";
            }

            if (FinishLineAI.AICar7RTSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(FinishLineAI.AICar7RTSeconds).ToString();
            }
            if (FinishLineAI.AICar7RTSeconds >= 10)
            {
                Seconds.text = Mathf.Round(FinishLineAI.AICar7RTSeconds).ToString();
            }
        }



        if (Player == true)
        {
            Position.text = FinishLine.PlayerFinishPosition.ToString();
            Name.text = FinishLine.PName;
            if (SaveScript.RaceTimeMinutes <= 9)
            {
                Minutes.text = "0" + Mathf.Round(SaveScript.RaceTimeMinutes).ToString() + ":";
            }
            if (SaveScript.RaceTimeMinutes >= 10)
            {
                Minutes.text = Mathf.Round(SaveScript.RaceTimeMinutes).ToString() + ":";
            }

            if (SaveScript.RaceTimeSeconds <= 9)
            {
                Seconds.text = "0" + Mathf.Round(SaveScript.RaceTimeSeconds).ToString();
            }
            if (SaveScript.RaceTimeSeconds >= 10)
            {
                Seconds.text = Mathf.Round(SaveScript.RaceTimeSeconds).ToString();
            }
        }


    }
}

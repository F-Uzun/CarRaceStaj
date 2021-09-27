using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRaceTrack : MonoBehaviour
{
    public Text WinMessage;
    public Text Credits;
    public GameObject LeaderBoard;
    public int FirstPlaceCredits = 2000;
    public int SecondPlaceCredits = 1000;
    public int ThirdPlaceCredits = 500;




    void Start()
    {
        LeaderBoard.SetActive(false);

        if(UniversalSave.OpponentCounts > 0)
        {
            FirstPlaceCredits *= UniversalSave.OpponentCounts;
            SecondPlaceCredits *= UniversalSave.OpponentCounts;
            ThirdPlaceCredits *= UniversalSave.OpponentCounts;

        }

        if(FinishLine.PlayerFinishPosition == 1)
        {
            WinMessage.text = "1ST PLACE";
            Credits.text = FirstPlaceCredits.ToString();
            UniversalSave.CreditAmount = UniversalSave.CreditAmount += FirstPlaceCredits;
            UniversalSave.RacesWon++;
        }

        if (FinishLine.PlayerFinishPosition == 2)
        {
            WinMessage.text = "2ND PLACE";
            Credits.text = FirstPlaceCredits.ToString();
            UniversalSave.CreditAmount = UniversalSave.CreditAmount += SecondPlaceCredits;
            UniversalSave.RacesWon++;
        }

        if (FinishLine.PlayerFinishPosition == 3)
        {
            WinMessage.text = "3RD PLACE";
            Credits.text = FirstPlaceCredits.ToString();
            UniversalSave.CreditAmount = UniversalSave.CreditAmount += ThirdPlaceCredits;
            UniversalSave.RacesWon++;
        }

        if (FinishLine.PlayerFinishPosition == 4)
        {
            WinMessage.text = "4TH PLACE";
            Credits.text = "0";
            UniversalSave.RacesLost++;
        }

        if (FinishLine.PlayerFinishPosition == 5)
        {
            WinMessage.text = "5TH PLACE";
            Credits.text = "0";
            UniversalSave.RacesLost++;
        }

        if (FinishLine.PlayerFinishPosition == 6)
        {
            WinMessage.text = "6TH PLACE";
            Credits.text = "0";
            UniversalSave.RacesLost++;
        }

        if (FinishLine.PlayerFinishPosition == 7)
        {
            WinMessage.text = "7TH PLACE";
            Credits.text = "0";
            UniversalSave.RacesLost++;
        }

        if (FinishLine.PlayerFinishPosition == 8)
        {
            WinMessage.text = "8TH PLACE";
            Credits.text = "0";
            UniversalSave.RacesLost++;
        }

        UniversalSave.Saving = true;
    }

    public void DisplayLeaderBoard()
    {
        LeaderBoard.SetActive(true);
        this.gameObject.SetActive(false);
        Time.timeScale = 0;
    }
    
}

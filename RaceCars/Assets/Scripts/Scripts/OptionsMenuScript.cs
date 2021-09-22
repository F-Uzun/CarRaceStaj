using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OptionsMenuScript : MonoBehaviour
{
    public Text Mode;
    public Text LapCount;
    public Text Opponent;
    private bool TimeTrial = true;
    private int CurrentLapCount = 1;
    private int OpponentCount = 1;
    public int TimeTrialSceneNumber;
    public int RaceTrackSceneNumber;
    public GameObject LoadScreen;
    public GameObject TrackSelectScreen;
    public GameObject OpponentsOn;
    public GameObject LapsOn;

    public void ModeNext()
    {
        if(TimeTrial == true)
        {
            Mode.text = "RACE";
            TimeTrial = false;
            OpponentsOn.SetActive(true);
            LapsOn.SetActive(true);
        }
    }


    public void ModeBack()
    {
        if(TimeTrial == false)
        {
            Mode.text = "TIME TRIAL";
            TimeTrial = true;
            OpponentsOn.SetActive(false);
            LapsOn.SetActive(false);
        }
    }

    public void LapCountNext()
    {
        if(CurrentLapCount < 12)
        {
            CurrentLapCount++;
            LapCount.text = CurrentLapCount + " LAPS";
            UniversalSave.LapCounts = CurrentLapCount;
          
        }
    }


    public void LapCountBack()
    {
        if (CurrentLapCount >2)
        {
            CurrentLapCount--;
            LapCount.text = CurrentLapCount + " LAPS";
            UniversalSave.LapCounts = CurrentLapCount;
        }

        else if (CurrentLapCount ==2)
        {
            CurrentLapCount--;
            LapCount.text = CurrentLapCount + " LAP";
            UniversalSave.LapCounts = CurrentLapCount;
        }
    }

    public void OpponentNext()
    {
        if(OpponentCount < 7)
        {
            OpponentCount++;
            Opponent.text = OpponentCount + " OPPONENTS";
            UniversalSave.OpponentCounts = OpponentCount;
        }
    }

    public void OpponentBack()
    {
        if (OpponentCount > 2)
        {
            OpponentCount--;
            Opponent.text = OpponentCount + " OPPONENTS";
            UniversalSave.OpponentCounts = OpponentCount;
        }

        else if (OpponentCount == 2)
        {
            OpponentCount--;
            Opponent.text = OpponentCount + " OPPONENT";
            UniversalSave.OpponentCounts = OpponentCount;
        }
    }


    public void StartRace()
    {
        if (TimeTrial == true)
        {
            StartCoroutine(WaitToLoad());
            
        }

        if (TimeTrial == false)
        {
            StartCoroutine(WaitToLoad2());

        }
    }

    void ResetValues()
    {
        Time.timeScale = 1.0f;
        SaveScript.LapNumber = 0;
        SaveScript.LapChange = false;
        SaveScript.LapTimeMinutes = 0.0f;
        SaveScript.LapTimeSeconds = 0.0f;
        SaveScript.RaceTimeMinutes = 0.0f;
        SaveScript.RaceTimeSeconds = 0.0f;
        SaveScript.LastLapM = 0.0f;
        SaveScript.LastLapS = 0.0f;
        SaveScript.GameTime = 0.0f;
        SaveScript.LastCheckPoint1 = 0.0f;
        SaveScript.LastCheckPoint2 = 0.0f;
        SaveScript.ThisCheckPoint1 = 0.0f;
        SaveScript.ThisCheckPoint2 = 0.0f;
        SaveScript.CheckPointPass1 = false;
        SaveScript.CheckPointPass2 = false;
        SaveScript.HalfWayActivated = true;
        SaveScript.RaceStart = false;
        SaveScript.RaceOver = false;
        SaveScript.PlayerPosition = 0;
        SaveScript.Gold = false;
        SaveScript.Bronze = false;
        SaveScript.Silver = false;
        SaveScript.Fail = false;
        SaveScript.PenaltySeconds = 0;
        SaveScript.AICar1LapNumber = 0;
        SaveScript.AICar2LapNumber = 0;
        SaveScript.AICar3LapNumber = 0;
        SaveScript.AICar4LapNumber = 0;
        SaveScript.AICar5LapNumber = 0;
        SaveScript.AICar6LapNumber = 0;
        SaveScript.AICar7LapNumber = 0;
        SaveScript.FinishPositionID = 0;

    }


    IEnumerator WaitToLoad()
    {
        ResetValues();
        TrackSelectScreen.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        LoadScreen.SetActive(true);
        UniversalSave.LapCounts = 1;
        UniversalSave.OpponentCounts = 0;
        SceneManager.LoadScene(TimeTrialSceneNumber);
    }


    IEnumerator WaitToLoad2()
    {
        ResetValues();
        TrackSelectScreen.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        LoadScreen.SetActive(true);
        UniversalSave.LapCounts = CurrentLapCount;
        UniversalSave.OpponentCounts = OpponentCount;
        SceneManager.LoadScene(RaceTrackSceneNumber);
    }


}

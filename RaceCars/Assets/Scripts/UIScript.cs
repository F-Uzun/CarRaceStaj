using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Image SpeedRing;
    public Text SpeedText;
    public Text GearText;
    public Text LapNumberText;
    public Text TotalLapText;
    public Text LapTimeMinutesText;
    public Text LapTimeSecondsText;
    public Text RaceTimeMinutesText;
    public Text RaceTimeSecondsText;
    public Text BestLapTimeMinutes;
    public Text BestLapTimeSeconds;
    public Text CheckPointTime;
    public GameObject CheckPointDisplay;
    public GameObject NewLapRecord;

    private float DisplaySpeed;
    public int TotalLaps = 3;
    
    

    void Start()
    {
        SpeedRing.fillAmount = 0;
        SpeedText.text = "0";
        GearText.text = "1";
        LapNumberText.text = "0";
        TotalLapText.text = "/ " + TotalLaps.ToString();
        CheckPointDisplay.SetActive(false);
        NewLapRecord.SetActive(false);
    }

    void Update()
    {
        //Hız göstergesi
        DisplaySpeed = SaveScript.Speed / SaveScript.TopSpeed;
        SpeedRing.fillAmount = DisplaySpeed;
        SpeedText.text = (Mathf.Round(SaveScript.Speed).ToString());
        GearText.text = (SaveScript.Gear+1).ToString();

        //Lap number
        LapNumberText.text = SaveScript.LapNumber.ToString();

        //LapTime
        if(SaveScript.LapTimeMinutes <= 9)
        {
            LapTimeMinutesText.text = "0" + (Mathf.Round(SaveScript.LapTimeMinutes).ToString()) + ":";
        }

        else if (SaveScript.LapTimeMinutes >= 10)
        {
            LapTimeMinutesText.text =(Mathf.Round(SaveScript.LapTimeMinutes).ToString()) + ":";
        }

        if (SaveScript.LapTimeSeconds <= 9)
        {
            LapTimeSecondsText.text = "0" + (Mathf.Round(SaveScript.LapTimeSeconds).ToString());
        }

        else if (SaveScript.LapTimeSeconds >= 10)
        {
            LapTimeSecondsText.text = (Mathf.Round(SaveScript.LapTimeSeconds).ToString());
        }


        //RaceTime
        if (SaveScript.RaceTimeMinutes <= 9)
        {
            RaceTimeMinutesText.text = "0" + (Mathf.Round(SaveScript.RaceTimeMinutes).ToString()) + ":";
        }

        else if (SaveScript.RaceTimeMinutes >= 10)
        {
            RaceTimeMinutesText.text = (Mathf.Round(SaveScript.RaceTimeMinutes).ToString()) + ":";
        }

        if (SaveScript.LapTimeSeconds <= 9)
        {
            RaceTimeSecondsText.text =(Mathf.Round(SaveScript.RaceTimeSeconds).ToString());
        }

        else if (SaveScript.LapTimeSeconds >= 10)
        {
            RaceTimeSecondsText.text = (Mathf.Round(SaveScript.RaceTimeSeconds).ToString());
        }

        //BestLapTime
        if(SaveScript.LapChange == true && SaveScript.LapNumber>1)
        {
            if (SaveScript.LastLapM == SaveScript.BestLapTimeM)
            {
                if (SaveScript.LastLapS < SaveScript.BestLapTimeS)
                {
                    SaveScript.BestLapTimeS = SaveScript.LastLapS;
                    SaveScript.NewRecord = true;
                }
            }

            if (SaveScript.LastLapM == SaveScript.BestLapTimeM)
            {
                SaveScript.BestLapTimeM = SaveScript.LastLapM;
                SaveScript.BestLapTimeS = SaveScript.LastLapS;
                SaveScript.NewRecord = true;
            }
        }
        


        //Display Best Lap Time
        if (SaveScript.BestLapTimeM <= 9)
        {
            BestLapTimeMinutes.text = "0" + (Mathf.Round(SaveScript.BestLapTimeM).ToString()) + ":";
        }

        else if (SaveScript.BestLapTimeM >= 10)
        {
            BestLapTimeMinutes.text = (Mathf.Round(SaveScript.BestLapTimeM).ToString()) + ":";
        }

        if (SaveScript.BestLapTimeS <= 9)
        {
            BestLapTimeSeconds.text = (Mathf.Round(SaveScript.BestLapTimeS).ToString());
        }

        else if (SaveScript.BestLapTimeS >= 10)
        {
            BestLapTimeSeconds.text = (Mathf.Round(SaveScript.BestLapTimeS).ToString());
        }

        if (SaveScript.NewRecord == true)
        {
            NewLapRecord.SetActive(true);
            StartCoroutine(LapRecordOff());
        }


        //checkpoint1

        if (SaveScript.CheckPointPass1 == true)
        {
            SaveScript.CheckPointPass1 = false;
            if(SaveScript.LapNumber > 1)
            {
                CheckPointDisplay.SetActive(true);

                if (SaveScript.ThisCheckPoint1 > SaveScript.LastCheckPoint1)
                {
                    CheckPointTime.color = Color.red;
                    CheckPointTime.text = "-" + (SaveScript.ThisCheckPoint1 - SaveScript.LastCheckPoint1).ToString();
                    StartCoroutine(CheckPointOff());
                }

                if (SaveScript.ThisCheckPoint1 < SaveScript.LastCheckPoint1)
                {
                    CheckPointTime.color = Color.green;
                    CheckPointTime.text = "+" + (SaveScript.LastCheckPoint1 - SaveScript.ThisCheckPoint1).ToString();
                    StartCoroutine(CheckPointOff());
                }
            }
            
        }


        //checkpoint2

        if (SaveScript.CheckPointPass2 == true)
        {
            SaveScript.CheckPointPass2 = false;
            if(SaveScript.LapNumber > 1)
            {
                CheckPointDisplay.SetActive(true);

                if (SaveScript.ThisCheckPoint2 > SaveScript.LastCheckPoint2)
                {
                    CheckPointTime.color = Color.red;
                    CheckPointTime.text = "-" + (SaveScript.ThisCheckPoint2 - SaveScript.LastCheckPoint2).ToString();
                    StartCoroutine(CheckPointOff());
                }

                if (SaveScript.ThisCheckPoint2 < SaveScript.LastCheckPoint2)
                {
                    CheckPointTime.color = Color.green;
                    CheckPointTime.text = "+" + (SaveScript.LastCheckPoint2 - SaveScript.ThisCheckPoint2).ToString();
                    StartCoroutine(CheckPointOff());
                }
            }
            
        }

    }

    IEnumerator CheckPointOff()
    {
        yield return new WaitForSeconds(2);
        CheckPointDisplay.SetActive(false);
    }

    IEnumerator LapRecordOff()
    {
        yield return new WaitForSeconds(2);
        SaveScript.NewRecord = false;
        NewLapRecord.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIScript : MonoBehaviour
{
    public Image SpeedRing;
    public Text SpeedText;
    public Text GearText;
    public Text LapNumberText;
    public Text TotalLapsText;
    public Text LapTimeMinutesText;
    public Text LapTimeSecondsText;
    public Text RaceTimeMinutesText;
    public Text RaceTimeSecondsText;
    public Text BestLapTimeMinutes;
    public Text BestLapTimeSeconds;
    public Text CheckPointTime;
    public Text WrongWayT;
    public Text TotalCarsText;
    public Text PlayersPosition;
    public GameObject CheckPointDisplay;
    public GameObject NewLapRecord;
    public GameObject WrongWayText;
    private float DisplaySpeed;
    private int TotalLaps = 3;
    private int TotalCars = 1;
    public bool RaceTrack = true;
    public GameObject F1Opponent1;
    public GameObject F1Opponent2;
    public GameObject F1Opponent3;
    public GameObject F1Opponent4;
    public GameObject F1Opponent5;
    public GameObject F1Opponent6;
    public GameObject F1Opponent7;
    public GameObject QuitMenu;




    void Start()
    {
        TotalLaps = UniversalSave.LapCounts;
        TotalCars = UniversalSave.OpponentCounts + 1;
        SpeedRing.fillAmount = 0;
        SpeedText.text = "0";
        GearText.text = "1";
        LapNumberText.text = "0";
        TotalLapsText.text = "/" + TotalLaps.ToString();
        CheckPointDisplay.SetActive(false);
        NewLapRecord.SetActive(false);
        WrongWayText.SetActive(false);
        SaveScript.MaxLaps = TotalLaps;
        TotalCarsText.text = "/" + TotalCars.ToString();
        PlayersPosition.text = "1";
        if(RaceTrack == true)
        {
            SetCarVisibility();
            QuitMenu.SetActive(false);
        }
        
    }


    void SetCarVisibility()
    {
        if (TotalCars == 1)
        {
            F1Opponent1.SetActive(false);
            F1Opponent2.SetActive(false);
            F1Opponent3.SetActive(false);
            F1Opponent4.SetActive(false);
            F1Opponent5.SetActive(false);
            F1Opponent6.SetActive(false);
            F1Opponent7.SetActive(false);
        }

        if (TotalCars == 2)
        {
            F1Opponent1.SetActive(true);
            F1Opponent2.SetActive(false);
            F1Opponent3.SetActive(false);
            F1Opponent4.SetActive(false);
            F1Opponent5.SetActive(false);
            F1Opponent6.SetActive(false);
            F1Opponent7.SetActive(false);
        }

        if (TotalCars == 3)
        {
            F1Opponent1.SetActive(true);
            F1Opponent2.SetActive(true);
            F1Opponent3.SetActive(false);
            F1Opponent4.SetActive(false);
            F1Opponent5.SetActive(false);
            F1Opponent6.SetActive(false);
            F1Opponent7.SetActive(false);
        }

        if (TotalCars == 4)
        {
            F1Opponent1.SetActive(true);
            F1Opponent2.SetActive(true);
            F1Opponent3.SetActive(true);
            F1Opponent4.SetActive(false);
            F1Opponent5.SetActive(false);
            F1Opponent6.SetActive(false);
            F1Opponent7.SetActive(false);
        }

        if (TotalCars == 5)
        {
            F1Opponent1.SetActive(true);
            F1Opponent2.SetActive(true);
            F1Opponent3.SetActive(true);
            F1Opponent4.SetActive(true);
            F1Opponent5.SetActive(false);
            F1Opponent6.SetActive(false);
            F1Opponent7.SetActive(false);
        }

        if (TotalCars == 6)
        {
            F1Opponent1.SetActive(true);
            F1Opponent2.SetActive(true);
            F1Opponent3.SetActive(true);
            F1Opponent4.SetActive(true);
            F1Opponent5.SetActive(true);
            F1Opponent6.SetActive(false);
            F1Opponent7.SetActive(false);
        }

        if (TotalCars == 7)
        {
            F1Opponent1.SetActive(true);
            F1Opponent2.SetActive(true);
            F1Opponent3.SetActive(true);
            F1Opponent4.SetActive(true);
            F1Opponent5.SetActive(true);
            F1Opponent6.SetActive(true);
            F1Opponent7.SetActive(false);
        }

        if (TotalCars == 8)
        {
            F1Opponent1.SetActive(true);
            F1Opponent2.SetActive(true);
            F1Opponent3.SetActive(true);
            F1Opponent4.SetActive(true);
            F1Opponent5.SetActive(true);
            F1Opponent6.SetActive(true);
            F1Opponent7.SetActive(true);
        }
    }


    void Update()
    {
        //Hız göstergesi
        DisplaySpeed = SaveScript.Speed / SaveScript.TopSpeed;
        SpeedRing.fillAmount = DisplaySpeed;
        SpeedText.text = (Mathf.Round(SaveScript.Speed).ToString());
        GearText.text = (SaveScript.Gear + 1).ToString();


        //Lap number
        LapNumberText.text = SaveScript.LapNumber.ToString();


        //LapTime
        if (SaveScript.LapTimeMinutes <= 9)
        {
            LapTimeMinutesText.text = "0" + (Mathf.Round(SaveScript.LapTimeMinutes).ToString()) + ":";
        }
        else if (SaveScript.LapTimeMinutes >= 10)
        {
            LapTimeMinutesText.text = (Mathf.Round(SaveScript.LapTimeMinutes).ToString()) + ":";
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
        if (SaveScript.RaceTimeSeconds <= 9)
        {
            RaceTimeSecondsText.text = "0" + (Mathf.Round(SaveScript.RaceTimeSeconds).ToString());
        }
        else if (SaveScript.RaceTimeSeconds >= 10)
        {
            RaceTimeSecondsText.text = (Mathf.Round(SaveScript.RaceTimeSeconds).ToString());
        }

        //BestLapTime
        if (SaveScript.LapChange == true)
        {
            if (SaveScript.LastLapM == SaveScript.BestLapTimeM)
            {
                if (SaveScript.LastLapS < SaveScript.BestLapTimeS)
                {
                    SaveScript.BestLapTimeS = SaveScript.LastLapS;
                    SaveScript.NewRecord = true;
                }
            }
            if (SaveScript.LastLapM < SaveScript.BestLapTimeM)
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
            BestLapTimeSeconds.text = "0" + (Mathf.Round(SaveScript.BestLapTimeS).ToString());
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
            Debug.Log("CheckPoint1 Passed");
            if (SaveScript.LapNumber > 1)
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
            Debug.Log("CheckPoint2 Passed");
            if (SaveScript.LapNumber > 1)
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



        //Wrong way message
        if (SaveScript.WrongWay == true)
        {
            WrongWayText.SetActive(true);
        }
        if (SaveScript.WrongWay == false)
        {
            WrongWayText.SetActive(false);
        }
        //Wrong Way Reset Text
        if (SaveScript.WWTextReset == false)
        {
            WrongWayT.text = "WRONG WAY!";
        }
        if (SaveScript.WWTextReset == true)
        {
            WrongWayT.text = " ";
        }


        //DisplayPosition
        PlayersPosition.text = SaveScript.PlayerPosition.ToString();


        //QuitMenu
        if (RaceTrack == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                QuitMenu.SetActive(true);
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

    public void QuitRace()
    {
        SceneManager.LoadScene(1);
    }

    public void CloseQuit()
    {
        QuitMenu.SetActive(false);
    }

    public void RaceReturnToMenu()
    {
        SceneManager.LoadScene(1);
    }
}

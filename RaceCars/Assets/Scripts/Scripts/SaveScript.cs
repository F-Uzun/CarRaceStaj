using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class SaveScript : MonoBehaviour
{
    public static float Speed;
    public static float TopSpeed;
    public static bool BrakeSlide;
    public static int Gear;
    public static int LapNumber;
    public static bool LapChange = false;
    public static float LapTimeMinutes;
    public static float LapTimeSeconds;
    public static float RaceTimeMinutes;
    public static float RaceTimeSeconds;
    public static float BestLapTimeM;
    public static float BestLapTimeS;
    public static float LastLapM;
    public static float LastLapS;
    public static float GameTime;
    public static float LastCheckPoint1;
    public static float ThisCheckPoint1;
    public static float LastCheckPoint2;
    public static float ThisCheckPoint2;
    public static bool CheckPointPass1 = false;
    public static bool CheckPointPass2 = false;
    public static bool NewRecord = false;
    public static bool OnTheRoad = true;
    public static bool OnTheTerrain = false;
    public static bool Rumble1 = false;
    public static bool Rumble2 = false;
    public static bool WrongWay = false;
    public static bool HalfWayActivated = true;
    public static bool WWTextReset = false;
    public static bool RaceStart = false;
    public static float TimeTrialMinG;
    public static float TimeTrialMinS;
    public static float TimeTrialMinB;
    public static float TimeTrialSecondsG;
    public static float TimeTrialSecondsS;
    public static float TimeTrialSecondsB;
    public static int MaxLaps;
    public static bool RaceOver = false;
    public static int PlayerPosition;
    public static bool Gold = false;
    public static bool Silver = false;
    public static bool Bronze = false;
    public static bool Fail = false;
    public static float PenaltySeconds = 0;
    public static int AICar1LapNumber = 0;
    public static int AICar2LapNumber = 0;
    public static int AICar3LapNumber = 0;
    public static int AICar4LapNumber = 0;
    public static int AICar5LapNumber = 0;
    public static int AICar6LapNumber = 0;
    public static int AICar7LapNumber = 0;
    public static int FinishPositionID = 0;



    void Start()
    {
        
    }

    void Update()
    {
        if (RaceOver == false)
        {
            if (LapChange == true)
            {
                LapChange = false;
                LapTimeMinutes = 0f;
                LapTimeSeconds = 0f;
                GameTime = 0f;
            }
            if (LapNumber >= 1)
            {
                LapTimeSeconds = LapTimeSeconds + 1 * Time.deltaTime;
                RaceTimeSeconds = RaceTimeSeconds + 1 * Time.deltaTime;
                GameTime = GameTime + 1 * Time.deltaTime;
            }
            if (LapTimeSeconds > 59)
            {
                LapTimeSeconds = 0f;
                LapTimeMinutes++;
            }
            if (RaceTimeSeconds > 59)
            {
                RaceTimeSeconds = 0f;
                RaceTimeMinutes++;
            }
        }
    }
}

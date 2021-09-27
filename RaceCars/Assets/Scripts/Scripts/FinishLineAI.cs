using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineAI : MonoBehaviour
{
    public bool AI1;
    public bool AI2;
    public bool AI3;
    public bool AI4;
    public bool AI5;
    public bool AI6;
    public bool AI7;
    public string CarName;

    public static int AICar1FinishPosition;
    public static string AICar1Name;
    public static float AICar1RTMinutes;
    public static float AICar1RTSeconds;
    public static int AICar2FinishPosition;
    public static string AICar2Name;
    public static float AICar2RTMinutes;
    public static float AICar2RTSeconds;
    public static int AICar3FinishPosition;
    public static string AICar3Name;
    public static float AICar3RTMinutes;
    public static float AICar3RTSeconds;
    public static int AICar4FinishPosition;
    public static string AICar4Name;
    public static float AICar4RTMinutes;
    public static float AICar4RTSeconds;
    public static int AICar5FinishPosition;
    public static string AICar5Name;
    public static float AICar5RTMinutes;
    public static float AICar5RTSeconds;
    public static int AICar6FinishPosition;
    public static string AICar6Name;
    public static float AICar6RTMinutes;
    public static float AICar6RTSeconds;
    public static int AICar7FinishPosition;
    public static string AICar7Name;
    public static float AICar7RTMinutes;
    public static float AICar7RTSeconds;

    private void Start()
    {
        AICar1FinishPosition = 0;
        AICar1RTMinutes = 0;
        AICar1RTSeconds = 0;

        AICar2FinishPosition = 0;
        AICar2RTMinutes = 0;
        AICar2RTSeconds = 0;

        AICar3FinishPosition = 0;
        AICar3RTMinutes = 0;
        AICar3RTSeconds = 0;

        AICar4FinishPosition = 0;
        AICar4RTMinutes = 0;
        AICar4RTSeconds = 0;

        AICar5FinishPosition = 0;
        AICar5RTMinutes = 0;
        AICar5RTSeconds = 0;

        AICar6FinishPosition = 0;
        AICar6RTMinutes = 0;
        AICar6RTSeconds = 0;

        AICar7FinishPosition = 0;
        AICar7RTMinutes = 0;
        AICar7RTSeconds = 0;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (AI1 == true)
        {
            if (other.gameObject.CompareTag("ProgressAI1"))
            {
                SaveScript.FinishPositionID++;
                AICar1FinishPosition = SaveScript.FinishPositionID;
                AICar1Name = CarName;
                AICar1RTMinutes = SaveScript.RaceTimeMinutes;
                AICar1RTSeconds = SaveScript.RaceTimeSeconds;
            }
        }

        if (AI2 == true)
        {
            if (other.gameObject.CompareTag("ProgressAI2"))
            {
                SaveScript.FinishPositionID++;
                AICar2FinishPosition = SaveScript.FinishPositionID;
                AICar2Name = CarName;
                AICar2RTMinutes = SaveScript.RaceTimeMinutes;
                AICar2RTSeconds = SaveScript.RaceTimeSeconds;
            }
        }

        if (AI3 == true)
        {
            if (other.gameObject.CompareTag("ProgressAI3"))
            {
                SaveScript.FinishPositionID++;
                AICar3FinishPosition = SaveScript.FinishPositionID;
                AICar3Name = CarName;
                AICar3RTMinutes = SaveScript.RaceTimeMinutes;
                AICar3RTSeconds = SaveScript.RaceTimeSeconds;
            }
        }

        if (AI4 == true)
        {
            if (other.gameObject.CompareTag("ProgressAI4"))
            {
                SaveScript.FinishPositionID++;
                AICar4FinishPosition = SaveScript.FinishPositionID;
                AICar4Name = CarName;
                AICar4RTMinutes = SaveScript.RaceTimeMinutes;
                AICar4RTSeconds = SaveScript.RaceTimeSeconds;
            }
        }

        if (AI5 == true)
        {
            if (other.gameObject.CompareTag("ProgressAI5"))
            {
                SaveScript.FinishPositionID++;
                AICar5FinishPosition = SaveScript.FinishPositionID;
                AICar5Name = CarName;
                AICar5RTMinutes = SaveScript.RaceTimeMinutes;
                AICar5RTSeconds = SaveScript.RaceTimeSeconds;
            }
        }


        if (AI6 == true)
        {
            if (other.gameObject.CompareTag("ProgressAI6"))
            {
                SaveScript.FinishPositionID++;
                AICar6FinishPosition = SaveScript.FinishPositionID;
                AICar6Name = CarName;
                AICar6RTMinutes = SaveScript.RaceTimeMinutes;
                AICar6RTSeconds = SaveScript.RaceTimeSeconds;
            }
        }

        if (AI7 == true)
        {
            if (other.gameObject.CompareTag("ProgressAI7"))
            {
                SaveScript.FinishPositionID++;
                AICar7FinishPosition = SaveScript.FinishPositionID;
                AICar7Name = CarName;
                AICar7RTMinutes = SaveScript.RaceTimeMinutes;
                AICar7RTSeconds = SaveScript.RaceTimeSeconds;
            }
        }
    }
}

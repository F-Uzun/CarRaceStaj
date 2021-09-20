﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject LeaderBoard;
    public string PlayerName;
    public static int PlayerFinishPosition;
    public static string PName;

    private void Start()
    {
        PName = PlayerName;
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SaveScript.FinishPositionID++;
            PlayerFinishPosition = SaveScript.FinishPositionID;
            SaveScript.RaceOver = true;
            Time.timeScale = 0.2f;
            LeaderBoard.SetActive(true);
        }
    }
}

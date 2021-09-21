using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public GameObject FinishPoint;
    public GameObject FinishPointAI1;
    public GameObject FinishPointAI2;
    public GameObject FinishPointAI3;
    public GameObject FinishPointAI4;
    public GameObject FinishPointAI5;
    public GameObject FinishPointAI6;
    public GameObject FinishPointAI7;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Progress"))
        {
            SaveScript.HalfWayActivated = true;
            if
           (SaveScript.LapNumber == SaveScript.MaxLaps)
            {
                FinishPoint.SetActive(true);
            }
        }
        if (other.gameObject.CompareTag("ProgressAI1"))
        {
            if (SaveScript.AICar1LapNumber == SaveScript.MaxLaps)
            {
                FinishPointAI1.SetActive(true);
            }
        }

        if (other.gameObject.CompareTag("ProgressAI2"))
        {
            if
           (SaveScript.AICar2LapNumber == SaveScript.MaxLaps)
            {
                FinishPointAI2.SetActive(true);
            }
        }
        if (other.gameObject.CompareTag("ProgressAI3"))
        {
            if (SaveScript.AICar3LapNumber == SaveScript.MaxLaps)
            {
                FinishPointAI3.SetActive(true);
            }
        }
        if (other.gameObject.CompareTag("ProgressAI4"))
        {
            if (SaveScript.AICar4LapNumber == SaveScript.MaxLaps)
            {
                FinishPointAI4.SetActive(true);
            }
        }
        if (other.gameObject.CompareTag("ProgressAI5"))
        {
            if (SaveScript.AICar5LapNumber == SaveScript.MaxLaps)
            {
                FinishPointAI5.SetActive(true);
            }
        }
        if (other.gameObject.CompareTag("ProgressAI6"))
        {
            if(SaveScript.AICar6LapNumber == SaveScript.MaxLaps)
            {
                FinishPointAI6.SetActive(true);
            }
        }
        if (other.gameObject.CompareTag("ProgressAI7"))
        {
            if(SaveScript.AICar7LapNumber == SaveScript.MaxLaps)
            {
                FinishPointAI7.SetActive(true);
            }
        }
    }
}
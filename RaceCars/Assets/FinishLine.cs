using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("HELLO");
            SaveScript.RaceOver = true;
            Time.timeScale = 0.2f;
        }
    }
}

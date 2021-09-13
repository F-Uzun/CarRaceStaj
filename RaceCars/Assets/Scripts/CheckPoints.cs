using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{
    public bool CheckPoint1 = true;
    public bool CheckPoint2 = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(CheckPoint1 == true)
            {
                Debug.Log("c1");
                SaveScript.ThisCheckPoint1 = SaveScript.GameTime;
                SaveScript.CheckPointPass1 = true;
            }

            if (CheckPoint2 == true)
            {
                Debug.Log("c2");
                SaveScript.ThisCheckPoint2 = SaveScript.GameTime;
                SaveScript.CheckPointPass2 = true;
            }
        }
    }
}

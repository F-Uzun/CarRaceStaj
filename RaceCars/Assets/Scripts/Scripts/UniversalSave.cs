using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalSave : MonoBehaviour
{
    public static int LapCounts;
    public static int OpponentCounts;

    void Start()
    {
        DontDestroyOnLoad(this);
    }

  
}

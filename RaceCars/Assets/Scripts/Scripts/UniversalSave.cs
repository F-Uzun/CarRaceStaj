using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalSave : MonoBehaviour
{
    public static int LapCounts;
    public static int OpponentCounts;
    public static int CreditAmount;
    public static bool Saving = false;

    void Start()
    {
        DontDestroyOnLoad(this);
        LoadStats();
    }

    private void Update()
    {
        if(Saving == true)
        {
            Saving = false;
            SaveStats();
        }
    }


    public void SaveStats()
    {
        PlayerPrefs.SetInt("MyCredits", CreditAmount);
    }

    public void LoadStats()
    {
        CreditAmount = PlayerPrefs.GetInt("MyCredtis");
    }
  
}

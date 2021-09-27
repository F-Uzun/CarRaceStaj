using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIMainMenu : MonoBehaviour
{

    public Text CreditsText;
    public GameObject StatsPanel;
    public GameObject TrackSelect;


    void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(WaitForCredits());
    }

    

    IEnumerator WaitForCredits()
    {
        yield return new WaitForSeconds(0.2f);
        CreditsText.text = UniversalSave.CreditAmount.ToString();
    }

    public void SwitchOnStats()
    {
        TrackSelect.SetActive(false);
        StatsPanel.SetActive(true);
        
    }
}

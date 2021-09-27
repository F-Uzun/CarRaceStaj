using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStats : MonoBehaviour
{
    public Text NameDisplay;
    public Text NewName;
    public Text RacesWonDisplay;
    public Text RacesLostDisplay;
    public GameObject InputField;
    private bool DisplayChange = false;
    public GameObject StatsPanel;
    public GameObject TrackSelect;



    void Start()
    {
        InputField.SetActive(false);
        StartCoroutine(UpdateStats());
    }



    void Update()
    {
        if (DisplayChange == true)
        {
            DisplayChange = false;
            StartCoroutine(UpdateStats());
        }
    }

    IEnumerator UpdateStats()
    {
        yield return new WaitForSeconds(0.05f);
        NameDisplay.text = UniversalSave.PlayerName;
        RacesWonDisplay.text = UniversalSave.RacesWon.ToString();
        RacesLostDisplay.text = UniversalSave.RacesLost.ToString();
    }

    public void ChangeName()
    {
        UniversalSave.PlayerName = NewName.text;
        UniversalSave.Saving = true;
        DisplayChange = true;
        InputField.SetActive(false);
    }

    public void EditName()
    {
        InputField.SetActive(true);
    }

    public void SwitchOffStats()
    {
        StatsPanel.SetActive(false);
        TrackSelect.SetActive(true);
    }
}

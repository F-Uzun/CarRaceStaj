using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceTrackMenu : MonoBehaviour
{

    public GameObject TrackOptions;
    public GameObject TrackSelect;
    

    public void OptionsOn()
    {
        TrackSelect.SetActive(false);
        TrackOptions.SetActive(true);
        
    }

    public void OptionsOff()
    {
        TrackOptions.SetActive(false);
        TrackSelect.SetActive(true);
    }
}

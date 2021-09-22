using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceTrackMenu : MonoBehaviour
{

    public GameObject TrackOptions;
    public GameObject TrackSelect;
    

    public void OptionsOn()
    {
        TrackOptions.SetActive(true);
        TrackSelect.SetActive(false);
    }

    public void OptionsOff()
    {
        TrackOptions.SetActive(false);
        TrackSelect.SetActive(true);
    }
}

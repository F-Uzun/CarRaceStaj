using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingLights : MonoBehaviour
{
    public GameObject RLightOff;
    public GameObject RLightOn;
    public GameObject ALightOff;
    public GameObject ALightOn;
    public GameObject GLightOff;
    public GameObject GLightOn;
    public AudioSource Sound1;
    public AudioSource Sound2;
    public GameObject Go;

    void Start()
    {
        Go.SetActive(false);
        StartCoroutine(StartingLight());

    }

    IEnumerator StartingLight()
    {
        yield return new WaitForSeconds(1);
        RLightOff.SetActive(false);
        RLightOn.SetActive(true);
        Sound1.Play();
        yield return new WaitForSeconds(1);
        RLightOff.SetActive(true);
        RLightOn.SetActive(false);
        Sound1.Play();
        ALightOff.SetActive(false);
        ALightOn.SetActive(true);
        yield return new WaitForSeconds(1);
        ALightOff.SetActive(true);
        ALightOn.SetActive(false);
        Sound2.Play();
        GLightOff.SetActive(false);
        GLightOn.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        SaveScript.RaceStart = true;
        Go.SetActive(true);
        yield return new WaitForSeconds(2f);
        Go.SetActive(false);
    }

}

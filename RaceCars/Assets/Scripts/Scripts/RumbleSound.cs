using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RumbleSound : MonoBehaviour
{

    private AudioSource Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SaveScript.Rumble1==true || SaveScript.Rumble2 == true)
        {
            Player.Play();
        }
        else
        {
            Player.Stop();
        }
    }
}

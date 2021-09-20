using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressWaypoints : MonoBehaviour
{

    public int WPNumber;
    public int CarTracking = 0;
    public bool PenaltyOption = false;
    public int PenaltyWayPoint;
    public int Position = 0;

    private int Lap1Position = 0;
    private int Lap2Position = 0;
    private int Lap3Position = 0;
    private int Lap4Position = 0;
    private int Lap5Position = 0;
    private int Lap6Position = 0;
    private int Lap7Position = 0;
    private int Lap8Position = 0;
    private int Lap9Position = 0;
    private int Lap10Position = 0;
    private int Lap11Position = 0;
    private int Lap12Position = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Progress"))
        {
            CarTracking = other.GetComponent<ProgressTracker>().CurrentWP;
            if(CarTracking < WPNumber)
            {
                other.GetComponent<ProgressTracker>().CurrentWP = WPNumber;
                //Debug.Log("CurrentWP = " + other.GetComponent<ProgressTracker>().CurrentWP);
                if(SaveScript.LapNumber == 1)
                {
                    Lap1Position++;
                    SaveScript.PlayerPosition = Lap1Position;
                }

                if (SaveScript.LapNumber == 2)
                {
                    Lap2Position++;
                    SaveScript.PlayerPosition = Lap2Position;
                }


                if (SaveScript.LapNumber == 3)
                {
                    Lap3Position++;
                    SaveScript.PlayerPosition = Lap3Position;
                }

                if (SaveScript.LapNumber == 4)
                {
                    Lap4Position++;
                    SaveScript.PlayerPosition = Lap4Position;
                }

                if (SaveScript.LapNumber == 5)
                {
                    Lap5Position++;
                    SaveScript.PlayerPosition = Lap5Position;
                }

                if (SaveScript.LapNumber == 6)
                {
                    Lap6Position++;
                    SaveScript.PlayerPosition = Lap6Position;
                }

                if (SaveScript.LapNumber == 7)
                {
                    Lap7Position++;
                    SaveScript.PlayerPosition = Lap7Position;
                }

                if (SaveScript.LapNumber == 8)
                {
                    Lap8Position++;
                    SaveScript.PlayerPosition = Lap8Position;
                }


                if (SaveScript.LapNumber == 9)
                {
                    Lap9Position++;
                    SaveScript.PlayerPosition = Lap9Position;
                }

                if (SaveScript.LapNumber == 10)
                {
                    Lap10Position++;
                    SaveScript.PlayerPosition = Lap10Position;
                }

                if (SaveScript.LapNumber == 11)
                {
                    Lap11Position++;
                    SaveScript.PlayerPosition = Lap11Position;
                }

                if (SaveScript.LapNumber == 12)
                {
                    Lap12Position++;
                    SaveScript.PlayerPosition = Lap12Position;
                }
            }


            if (CarTracking > WPNumber)
            {
                other.GetComponent<ProgressTracker>().LastWPNumber = WPNumber;
            }

            if (PenaltyOption == true)
            {
                if(CarTracking < PenaltyWayPoint)
                {
                    Debug.Log("penalty");
                    SaveScript.PenaltySeconds += 5f;
                    PenaltyOption = false;
                }
            }

        }

        if (other.gameObject.CompareTag("ProgressAI1"))
        {
            if(SaveScript.AICar1LapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICar1LapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICar1LapNumber == 3)
            {
                Lap3Position++;
            }
            if (SaveScript.AICar1LapNumber == 4)
            {
                Lap4Position++;
            }
            if (SaveScript.AICar1LapNumber == 5)
            {
                Lap5Position++;
            }
            if (SaveScript.AICar1LapNumber == 6)
            {
                Lap6Position++;
            }
            if (SaveScript.AICar1LapNumber == 7)
            {
                Lap7Position++;
            }
            if (SaveScript.AICar1LapNumber == 8)
            {
                Lap8Position++;
            }
            if (SaveScript.AICar1LapNumber == 9)
            {
                Lap9Position++;
            }
            if (SaveScript.AICar1LapNumber == 10)
            {
                Lap10Position++;
            }
            if (SaveScript.AICar1LapNumber == 11)
            {
                Lap11Position++;
            }
            if (SaveScript.AICar1LapNumber == 12)
            {
                Lap12Position++;
            }
        }




        if (other.gameObject.CompareTag("ProgressAI2"))
        {
            if (SaveScript.AICar2LapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICar2LapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICar2LapNumber == 3)
            {
                Lap3Position++;
            }
            if (SaveScript.AICar2LapNumber == 4)
            {
                Lap4Position++;
            }
            if (SaveScript.AICar2LapNumber == 5)
            {
                Lap5Position++;
            }
            if (SaveScript.AICar2LapNumber == 6)
            {
                Lap6Position++;
            }
            if (SaveScript.AICar2LapNumber == 7)
            {
                Lap7Position++;
            }
            if (SaveScript.AICar2LapNumber == 8)
            {
                Lap8Position++;
            }
            if (SaveScript.AICar2LapNumber == 9)
            {
                Lap9Position++;
            }
            if (SaveScript.AICar2LapNumber == 10)
            {
                Lap10Position++;
            }
            if (SaveScript.AICar2LapNumber == 11)
            {
                Lap11Position++;
            }
            if (SaveScript.AICar2LapNumber == 12)
            {
                Lap12Position++;
            }
        }


        if (other.gameObject.CompareTag("ProgressAI3"))
        {
            if (SaveScript.AICar3LapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICar3LapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICar3LapNumber == 3)
            {
                Lap3Position++;
            }
            if (SaveScript.AICar3LapNumber == 4)
            {
                Lap4Position++;
            }
            if (SaveScript.AICar3LapNumber == 5)
            {
                Lap5Position++;
            }
            if (SaveScript.AICar3LapNumber == 6)
            {
                Lap6Position++;
            }
            if (SaveScript.AICar3LapNumber == 7)
            {
                Lap7Position++;
            }
            if (SaveScript.AICar3LapNumber == 8)
            {
                Lap8Position++;
            }
            if (SaveScript.AICar3LapNumber == 9)
            {
                Lap9Position++;
            }
            if (SaveScript.AICar3LapNumber == 10)
            {
                Lap10Position++;
            }
            if (SaveScript.AICar3LapNumber == 11)
            {
                Lap11Position++;
            }
            if (SaveScript.AICar3LapNumber == 12)
            {
                Lap12Position++;
            }
        }

        if (other.gameObject.CompareTag("ProgressAI4"))
        {
            if (SaveScript.AICar4LapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICar4LapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICar4LapNumber == 3)
            {
                Lap3Position++;
            }
            if (SaveScript.AICar4LapNumber == 4)
            {
                Lap4Position++;
            }
            if (SaveScript.AICar4LapNumber == 5)
            {
                Lap5Position++;
            }
            if (SaveScript.AICar4LapNumber == 6)
            {
                Lap6Position++;
            }
            if (SaveScript.AICar4LapNumber == 7)
            {
                Lap7Position++;
            }
            if (SaveScript.AICar4LapNumber == 8)
            {
                Lap8Position++;
            }
            if (SaveScript.AICar4LapNumber == 9)
            {
                Lap9Position++;
            }
            if (SaveScript.AICar4LapNumber == 10)
            {
                Lap10Position++;
            }
            if (SaveScript.AICar4LapNumber == 11)
            {
                Lap11Position++;
            }
            if (SaveScript.AICar4LapNumber == 12)
            {
                Lap12Position++;
            }
        }

        if (other.gameObject.CompareTag("ProgressAI5"))
        {
            if (SaveScript.AICar5LapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICar5LapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICar5LapNumber == 3)
            {
                Lap3Position++;
            }
            if (SaveScript.AICar5LapNumber == 4)
            {
                Lap4Position++;
            }
            if (SaveScript.AICar5LapNumber == 5)
            {
                Lap5Position++;
            }
            if (SaveScript.AICar5LapNumber == 6)
            {
                Lap6Position++;
            }
            if (SaveScript.AICar5LapNumber == 7)
            {
                Lap7Position++;
            }
            if (SaveScript.AICar5LapNumber == 8)
            {
                Lap8Position++;
            }
            if (SaveScript.AICar5LapNumber == 9)
            {
                Lap9Position++;
            }
            if (SaveScript.AICar5LapNumber == 10)
            {
                Lap10Position++;
            }
            if (SaveScript.AICar5LapNumber == 11)
            {
                Lap11Position++;
            }
            if (SaveScript.AICar5LapNumber == 12)
            {
                Lap12Position++;
            }
        }

        if (other.gameObject.CompareTag("ProgressAI6"))
        {
            if (SaveScript.AICar6LapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICar6LapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICar6LapNumber == 3)
            {
                Lap3Position++;
            }
            if (SaveScript.AICar6LapNumber == 4)
            {
                Lap4Position++;
            }
            if (SaveScript.AICar6LapNumber == 5)
            {
                Lap5Position++;
            }
            if (SaveScript.AICar6LapNumber == 6)
            {
                Lap6Position++;
            }
            if (SaveScript.AICar6LapNumber == 7)
            {
                Lap7Position++;
            }
            if (SaveScript.AICar6LapNumber == 8)
            {
                Lap8Position++;
            }
            if (SaveScript.AICar6LapNumber == 9)
            {
                Lap9Position++;
            }
            if (SaveScript.AICar6LapNumber == 10)
            {
                Lap10Position++;
            }
            if (SaveScript.AICar6LapNumber == 11)
            {
                Lap11Position++;
            }
            if (SaveScript.AICar6LapNumber == 12)
            {
                Lap12Position++;
            }
        }

        if (other.gameObject.CompareTag("ProgressAI7"))
        {
            if (SaveScript.AICar7LapNumber == 1)
            {
                Lap1Position++;
            }
            if (SaveScript.AICar7LapNumber == 2)
            {
                Lap2Position++;
            }
            if (SaveScript.AICar7LapNumber == 3)
            {
                Lap3Position++;
            }
            if (SaveScript.AICar7LapNumber == 4)
            {
                Lap4Position++;
            }
            if (SaveScript.AICar7LapNumber == 5)
            {
                Lap5Position++;
            }
            if (SaveScript.AICar7LapNumber == 6)
            {
                Lap6Position++;
            }
            if (SaveScript.AICar7LapNumber == 7)
            {
                Lap7Position++;
            }
            if (SaveScript.AICar7LapNumber == 8)
            {
                Lap8Position++;
            }
            if (SaveScript.AICar7LapNumber == 9)
            {
                Lap9Position++;
            }
            if (SaveScript.AICar7LapNumber == 10)
            {
                Lap10Position++;
            }
            if (SaveScript.AICar7LapNumber == 11)
            {
                Lap11Position++;
            }
            if (SaveScript.AICar7LapNumber == 12)
            {
                Lap12Position++;
            }
        }




    }

}

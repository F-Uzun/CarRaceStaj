using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIMainMenu : MonoBehaviour
{

    public Text CreditsText;


    void Start()
    {
        
    }

    void Update()
    {
        StartCoroutine(WaitForCredits());
      
    }

    IEnumerator WaitForCredits()
    {
        yield return new WaitForSeconds(0.2f);
        CreditsText.text = UniversalSave.CreditAmount.ToString();
    }
}

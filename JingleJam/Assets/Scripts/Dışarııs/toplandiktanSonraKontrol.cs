using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class toplandiktanSonraKontrol : MonoBehaviour
{
    public GameObject canvas;
    public TextMeshProUGUI toplSonraKonusma;
    public GameObject elfvekontrol;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           
                canvas.SetActive(true);
            StartCoroutine(topladiktanSonraK());
        }
    }

    IEnumerator topladiktanSonraK()
    {
        toplSonraKonusma.text = "aa demek döndün";
        yield return new WaitForSeconds(2);
        canvas.SetActive(false);
        elfvekontrol.SetActive(false);
    }
    
}

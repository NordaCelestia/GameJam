using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class toplandiktanSonraKontrol : MonoBehaviour
{
    public GameObject canvas;
    public TextMeshProUGUI toplSonraKonusma;
    public GameObject elfvekontrol;
    public TextMeshProUGUI isim;
    public AudioSource EllieDonus;
    
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
        //EllieDonus.Play();
        isim.text = "Ellie";
        toplSonraKonusma.text = "Harikas�n Nicholas! S�sleri biz yerle�tiririz. Sen koro �efimiz bay HuysuzAyak'� bulmal�s�n! Her zamanki gibi sol altta buzullar�n i�inde debeleniyordur. ";
        yield return new WaitForSeconds(6);
        canvas.SetActive(false);
        elfvekontrol.SetActive(false);
    }
    
}

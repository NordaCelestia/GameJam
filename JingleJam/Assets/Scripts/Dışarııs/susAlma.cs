using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class susAlma : MonoBehaviour
{
    public int toplananSus = 0;
    public TextMeshProUGUI tmrpo;
    public GameObject eveDonunce;
    public GameObject kontrol;
    public GameObject basKonusma;
    public TextMeshProUGUI donuncaKonusma;
    public TextMeshProUGUI bastaKonusma;


    private void Start()
    {
        basKonusma.SetActive(true);
        StartCoroutine(baslangic());
    }
    private void Update()
    {
        if (toplananSus == 3)
        {
            toplananSus++;
            Debug.Log("topladý 1 arttýrlýdý.");
            kontrol.SetActive(true);
            Debug.Log("aktive olmasý lazým.");
            StartCoroutine(topladiktanSonraKonusma());
            
        }
    }

    public void susAl()
    {
        toplananSus++;
        tmrpo.text = "Hala kayýp olan süs sayýsý: " + (3 - toplananSus);


    }

    IEnumerator topladiktanSonraKonusma()
    {
        
        donuncaKonusma.text = "AA demek döndün";
        yield return new WaitForSeconds(3);
        kontrol.SetActive(false);

    }

     IEnumerator baslangic()
    {
        bastaKonusma.text = "hadi git topla";
        yield return new WaitForSeconds(3);
        basKonusma.SetActive(false);
    }
}

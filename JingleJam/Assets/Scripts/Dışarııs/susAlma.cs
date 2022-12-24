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
    public GameObject engel;
    public GameObject gorev;


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
            engel.SetActive(false);
            
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            gorev.SetActive(true);
        }
    }

    public void susAl()
    {
        toplananSus++;
        tmrpo.text = "Hala kayýp olan süs sayýsý: " + (3 - toplananSus);


    }

    

     IEnumerator baslangic()
    {
        bastaKonusma.text = "hadi git topla";
        yield return new WaitForSeconds(3);
        basKonusma.SetActive(false);
    }
}

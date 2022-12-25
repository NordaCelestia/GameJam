using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class susAlma : MonoBehaviour
{
    public int toplananSus = 0;
    public TextMeshProUGUI tmrpo;
    public GameObject eveDonunce;
    public GameObject kontrol;
    public GameObject basKonusma;
    public TextMeshProUGUI isim;
    public TextMeshProUGUI donuncaKonusma;
    public TextMeshProUGUI bastaKonusma;
    public GameObject engel;
    public GameObject gorev;
    public AudioSource EllieSes;


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
        //EllieSes.Play();
        isim.text = "Ellie";
        bastaKonusma.text = "Haydi Nicholas, etrafta kayýp olan aðaç süslerini bulmalýyýz! Bulunca tekrar yanýmýza gel.";
        yield return new WaitForSeconds(6);
        basKonusma.SetActive(false);
    }

    public void ikinciEveGiris()
    {
        SceneManager.LoadScene(3);
    }

}

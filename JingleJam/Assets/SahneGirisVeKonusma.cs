using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SahneGirisVeKonusma : MonoBehaviour
{
    public GameObject canvas,koro;
    public TextMeshProUGUI isim;
    public TextMeshProUGUI konusma;
    public AudioSource elli1, elli2, nicholas;
    void Start()
    {
        StartCoroutine(konusA());
    }

   
    void Update()
    {
        
    }

    IEnumerator konusA()
    {
        

        yield return new WaitForSeconds(22);
        canvas.SetActive(true);
        koro.SetActive(false);

        elli1.Play();
        isim.text = "Ellie";
        konusma.text = "Aa Nicholas sonunda geldin! Noel Babaya þarký söylemeyi denedik ama...";
        yield return new WaitForSeconds(5);

        
        konusma.text = "Pek iþe yaramadý. Bu arada harika iþ çýkardýn! Biz hediyeleri hazýrlamaya baþladýk.";
        yield return new WaitForSeconds(7);

        nicholas.Play();
        isim.text = "Nicholas";
        konusma.text = "Tabi ya! Hediye! Ellie, Noel Baba'nýn ren geyikleri nerde?";
        yield return new WaitForSeconds(7);

        elli2.Play();
        isim.text = "Ellie";
        konusma.text = "En son, bahçede gördüm.";
        yield return new WaitForSeconds(5);

        canvas.SetActive(false);
    }
}

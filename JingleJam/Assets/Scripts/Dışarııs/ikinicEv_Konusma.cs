using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ikinicEv_Konusma : MonoBehaviour
{

    public GameObject canvas;
    public TextMeshProUGUI isim;
    public TextMeshProUGUI konusma;
    public AudioSource konusma1,konusma1_1, konusma2, konusma3;

    private void Start()
    {
        StartCoroutine(ikinciEvEllie());
    }

    IEnumerator ikinciEvEllie()
    {
        

        
        //konusma1.Play();
        isim.text = "Ellie";
        konusma.text = "Aa Nicholas sonunda geldin! Noel Babaya �ark� s�ylemeyi denedik ama...";
        yield return new WaitForSeconds(5);

        //konusma1_1.Play();
        isim.text = "Ellie";
        konusma.text = "Pek i�e yaramad�, Bu arada harika i� ��kard�n. Biz hediyeleri haz�rlamaya ba�lad�k";
        yield return new WaitForSeconds(5);

        konusma2.Play();
        isim.text = "Nicholas";
        konusma.text = "Tabi ya hediye! Ellie? Noel baban�n ren geyikleri nerde?";
        yield return new WaitForSeconds(6);

        //konusma3.Play();
        isim.text = "Ellie";
        konusma.text = "En son bah�ede g�rd�m.";
        yield return new WaitForSeconds(6);


    }

   

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class birinciDiyalog : MonoBehaviour
{

    public GameObject canvas;
    public TextMeshProUGUI isim;
    public TextMeshProUGUI konusma;

    private void Start()
    {
        StartCoroutine(birinciKonusma());
    }

    IEnumerator birinciKonusma()
    {
        isim.text = "Noel Baba";
        isim.text = "Nicholas";
        //yield return new WaitForSeconds(3);
        konusma.text = "";

        isim.text = "Nicholas";
        konusma.text = "Neyin var Noel Baba?";
        yield return new WaitForSeconds(5);

        isim.text = "Noel Baba";
        konusma.text = "Ah benim sevgili elfim çok mutsuzum bu yýl bensiz Noel'i kutlamalýsýnýz.";
        yield return new WaitForSeconds(6);

        isim.text = "Nicholas";
        konusma.text = "Sensiz kutlayamayýz ki Noel Baba!";
        yield return new WaitForSeconds(5);

        isim.text = "Nicholas";
        konusma.text = "Burasý hiç Noel 'e hazýr deðil! Burayý noel'e hazýrlamak için dýþarý çýkýp süs ve malzeme bulmalýyým.";
        yield return new WaitForSeconds(6);
        canvas.SetActive(false);
    }
}

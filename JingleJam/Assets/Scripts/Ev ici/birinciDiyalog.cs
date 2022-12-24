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
        konusma.text = "Ah benim sevgili elfim �ok mutsuzum bu y�l bensiz Noel'i kutlamal�s�n�z.";
        yield return new WaitForSeconds(6);

        isim.text = "Nicholas";
        konusma.text = "Sensiz kutlayamay�z ki Noel Baba!";
        yield return new WaitForSeconds(5);

        isim.text = "Nicholas";
        konusma.text = "Buras� hi� Noel 'e haz�r de�il! Buray� noel'e haz�rlamak i�in d��ar� ��k�p s�s ve malzeme bulmal�y�m.";
        yield return new WaitForSeconds(6);
        canvas.SetActive(false);
    }
}

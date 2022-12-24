using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ikinicEv_Konusma : MonoBehaviour
{

    public GameObject canvas;
    public TextMeshProUGUI isim;
    public TextMeshProUGUI konusma;

    private void Start()
    {
        StartCoroutine(ikinciEvGiris());
    }

    IEnumerator ikinciEvGiris()
    {
        isim.text = "Ellie";
        konusma.text = "Harika iþ çýkardýn Nicholas!  Þimdi Noel'in olmazsa olmazý hediyeleri hazýrlamaya baþladýk";
        yield return new WaitForSeconds(6);

        isim.text = "Nicholas";
        konusma.text = "Tabi ya hediye! Ellie? Noel babanýn ren geyikleri nerde?";
        yield return new WaitForSeconds(5);

        isim.text = "Ellie";
        konusma.text = "En son bahçede gördüm.";
        yield return new WaitForSeconds(6);


    }

}

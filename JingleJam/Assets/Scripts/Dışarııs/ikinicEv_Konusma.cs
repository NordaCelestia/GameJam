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
        konusma.text = "Harika i� ��kard�n Nicholas!  �imdi Noel'in olmazsa olmaz� hediyeleri haz�rlamaya ba�lad�k";
        yield return new WaitForSeconds(6);

        isim.text = "Nicholas";
        konusma.text = "Tabi ya hediye! Ellie? Noel baban�n ren geyikleri nerde?";
        yield return new WaitForSeconds(5);

        isim.text = "Ellie";
        konusma.text = "En son bah�ede g�rd�m.";
        yield return new WaitForSeconds(6);


    }

}

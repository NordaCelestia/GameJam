using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class kagitOkumaaaaa : MonoBehaviour
{
    public GameObject canvas;
    public GameObject konusmaCanvas;
    public AudioSource ses1;
    public TextMeshProUGUI isim;
    public TextMeshProUGUI yazi;
   public void kagitOku()
    {
        StartCoroutine(kagitOk());
    }

    IEnumerator kagitOk()
    {
        canvas.SetActive(true);
        yield return new WaitForSeconds(29);
        canvas.SetActive(false);

        konusmaCanvas.SetActive(true);
        ses1.Play();        
        isim.text = "Nicholas";
        yazi.text = "Ah Noel Baba! Noel'de herkes hediye almayayý eder! Dileðini gerçekleþtirip Noel'i kartarýcam.";
        yield return new WaitForSeconds(7);

        konusmaCanvas.SetActive(false);
    }
}

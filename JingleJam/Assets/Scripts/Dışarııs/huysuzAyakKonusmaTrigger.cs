using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class huysuzAyakKonusmaTrigger : MonoBehaviour
{
    public GameObject huysuzAkonusma;
    public TextMeshProUGUI huysuzAyazi;
    public GameObject huysuzAyak;
    public GameObject ikincievegir;
    public TextMeshProUGUI isim;

    public AudioSource konusma1;
    public AudioSource konusma2;
    public AudioSource konusma3;
    public AudioSource konusma4;
    public AudioSource konusma5;
    public AudioSource konusma6;
    public AudioSource konusma7;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            
            
                huysuzAkonusma.SetActive(true);
                StartCoroutine(huysuzAtext());
            
            
        }
    }

    IEnumerator huysuzAtext()
    {
        konusma1.Play();
        isim.text = "Bay HuysuzAyak";
        huysuzAyazi.text = "Ne! Ne istiyorsun, Ucube elf!";
        yield return new WaitForSeconds(4);

        konusma2.Play();
        isim.text = "Nicholas";
        huysuzAyazi.text = "Bay HuysuzAyak Noel ruhunu canlandýrmamýz için size ihtiyacýmýz var. ";
        yield return new WaitForSeconds(5);

        konusma3.Play();
        isim.text = "Bay HuysuzAyak";
        huysuzAyazi.text = "Ben ne biliyim ya! Banane noel'den. ";
        yield return new WaitForSeconds(5);

        konusma4.Play();
        isim.text = "Nicholas";
        huysuzAyazi.text = "O zaman... bizde rovaniemi'nin en yetenekli baþka þefine gideriz! Baþka þansýmýz kalmadý..";
        yield return new WaitForSeconds(8);

        konusma5.Play();
        isim.text = "Bay HuysuzAyak";
        huysuzAyazi.text = "Kimmiþ O!  Benden daha iyi olan??";
        yield return new WaitForSeconds(5);

        konusma6.Play();
        isim.text = "Nicholas";
        huysuzAyazi.text = "Yani bilemiyorum... Madem Noel umrunda deðil, buda neden umrunda olsun ki!";
        yield return new WaitForSeconds(7);

        konusma7.Play();
        isim.text = "Bay HuysuzAyak";
        huysuzAyazi.text = "Pekala yapýcam! Ama Noel için deðil itibarým için!";
        yield return new WaitForSeconds(5);

        huysuzAkonusma.SetActive(false);
        huysuzAyak.SetActive(false);
        ikincievegir.SetActive(true);
    }
}

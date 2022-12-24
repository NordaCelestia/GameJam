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
        
        isim.text = "Bay HuysuzAyak";
        huysuzAyazi.text = "Ne! Ne istiyorsun, Ucube elf!";
        yield return new WaitForSeconds(4);

        isim.text = "Nicholas";
        huysuzAyazi.text = "Bay HuysuzAyak Noel ruhunu canlandýrmamýz için size ihtiyacýmýz var. ";
        yield return new WaitForSeconds(6);

        isim.text = "Bay HuysuzAyak";
        huysuzAyazi.text = "Ben ne biliyim ya! Banane noel'den. ";
        yield return new WaitForSeconds(5);

        isim.text = "Nicholas";
        huysuzAyazi.text = "O zaman... bizde rovaniemi'nin en yetenekli baþka þefine gideriz! Baþka þansýmýz kalmadý..";
        yield return new WaitForSeconds(6);

        isim.text = "Bay HuysuzAyak";
        huysuzAyazi.text = "Kimmiþ O!  Benden daha iyi olan??";
        yield return new WaitForSeconds(5);

        isim.text = "Nicholas";
        huysuzAyazi.text = "Yani bilemiyorum... Madem Noel umrunda deðil, buda neden umrunda olsun ki!";
        yield return new WaitForSeconds(6);

        isim.text = "Bay HuysuzAyak";
        huysuzAyazi.text = "Pekala yapýcam! Ama Noel için deðil itibarým için!";
        yield return new WaitForSeconds(5);

        huysuzAkonusma.SetActive(false);
        huysuzAyak.SetActive(false);
        ikincievegir.SetActive(true);
    }
}

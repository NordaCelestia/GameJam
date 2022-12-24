using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class huysuzAyakKonusmaTrigger : MonoBehaviour
{
    public GameObject huysuzAkonusma;
    public TextMeshProUGUI huysuzAyazi;
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
        huysuzAyazi.text = "sen kimsin ben huysuz ayak";
        yield return new WaitForSeconds(2);
    }
}

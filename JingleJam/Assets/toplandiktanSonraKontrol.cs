using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class toplandiktanSonraKontrol : MonoBehaviour
{
    public GameObject canvas;
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           
                canvas.SetActive(true);
            
        }
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class kagitToplama : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    public GameObject kagit;
    public GameObject canvas;
    public AudioSource not;
    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (true)
            {
                isInRange = true;
                Debug.Log("Player is in range");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Player is not in range");
        }
    }

    public void kagitAl()
    {
        Destroy(kagit);
        canvas.SetActive(true);
        not.Play();
    }
}

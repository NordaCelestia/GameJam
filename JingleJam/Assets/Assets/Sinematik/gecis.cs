using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gecis : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(sahneGecis());
    }

    IEnumerator sahneGecis()
    {
        yield return new WaitForSeconds(30);
        SceneManager.LoadScene(1);
    }
}

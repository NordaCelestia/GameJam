using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gorevCubugu : MonoBehaviour
{
    public GameObject canvas;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            canvasAc();
        }
    }

    public void canvasAc()
    {
        canvas.SetActive(true);
    }
}

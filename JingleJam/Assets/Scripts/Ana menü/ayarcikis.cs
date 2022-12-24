using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ayarcikis : MonoBehaviour
{
    public GameObject canvas;
    public GameObject nasiloyna;

    public void ayarKapa()
    {
        canvas.SetActive(false);
    }

    public void nasilOynaKapa()
    {
        nasiloyna.SetActive(false);
    }
}

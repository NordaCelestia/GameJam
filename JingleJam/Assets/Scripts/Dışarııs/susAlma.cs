using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class susAlma : MonoBehaviour
{
    public int toplananSus = 0;
    public TextMeshProUGUI tmrpo;

    public void susAl()
    {
        toplananSus++;
        tmrpo.text = "Hala kay�p olan s�s say�s�: " + (3 - toplananSus);


    }
}

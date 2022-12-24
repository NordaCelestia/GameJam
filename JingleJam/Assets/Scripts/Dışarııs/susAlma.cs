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
        tmrpo.text = "Hala kayýp olan süs sayýsý: " + (3 - toplananSus);


    }
}

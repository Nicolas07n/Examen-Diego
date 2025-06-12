using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateWallHitText : MonoBehaviour
{
    public TextMeshProUGUI textoCambios;

    void Update()
    {
        if (GameManager.instance != null)
        {
            textoCambios.text = "Cambios de dirección: " + GameManager.instance.CambiosDireccion;
        }
    }
}

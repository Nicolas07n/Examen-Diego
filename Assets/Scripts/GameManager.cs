using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int cambiosDireccion = 0;

    public int CambiosDireccion => cambiosDireccion; // propiedad pública solo de lectura

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // permanece entre escenas
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void RegistrarCambioDireccion()
    {
        cambiosDireccion++;
    }
}

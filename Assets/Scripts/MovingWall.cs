using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class MovingWall : MonoBehaviour
{

    public float speed = 2f;          // Velocidad del movimiento
    private Vector2 direction = Vector2.right;  // Dirección inicial
    public AudioClip sonidoCambioDireccion;//Para que haya sonido

    void Start()
    {
        StartCoroutine(MoveWall());
    }
    //!!!!!!!Añadir RIGIDBODY KINEMATIC !!!!!!!
    IEnumerator MoveWall()
    {
        while (true)
        {
            // Mover la pared continuamente en una dirección
            GetComponent<Rigidbody2D>().velocity = direction * speed;

            // Espera 3 segundos y cambia la dirección
            yield return new WaitForSeconds(3f);
            direction *= -1; // Invertir dirección
            //Para elGame Manager
            if (GameManager.instance != null)
            {
                GameManager.instance.RegistrarCambioDireccion();
            }
            //Para que haya sonido 
            if (sonidoCambioDireccion != null && AudioManager.instance != null)
            {
                AudioManager.instance.PlayAudio(sonidoCambioDireccion, "CambioDireccion");
            }
        }
    }
}

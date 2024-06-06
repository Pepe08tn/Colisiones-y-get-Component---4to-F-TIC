using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PisoScript : MonoBehaviour
{
    public int resistencia;
    public EsferaScript esfera;

    private void OnCollisionEnter(Collision collision)
    {
        esfera = collision.gameObject.GetComponent<EsferaScript>();
        Debug.Log("Contacto con una esfera que pesa " + esfera.peso);
    }
}

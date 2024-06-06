﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public Vehiculo[] vehiculos;


    // Start is called before the first frame update
    void Start()
    {
        ActivarPromoMeno4Ruedas();
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

        }   
    }

    void ResetearVehiculos()
    {

    }

    void ActivarPromoMeno4Ruedas()
    {
        for(int i = 0; i < vehiculos.Length; i++)
        {
            if(vehiculos[i].cantRuedas >= 4)
            {
                vehiculos[i].CartelPromo.SetActive(false);
            }
        }
    }
}

//Sandoval Rodríguez Lendy Joanna 1219100438
//GDGS2102-E 23/09/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Se crea  un objeto llamado player
    public GameObject player;
    //Variable que indicará la posición de donde se encontrará la cámara
    private Vector3 offset = new Vector3(0,9,-10);
    
    void Start()
    {
        
    }

    void LateUpdate() 
    {
        /*Se indica que la camara se va desplazar detrás del jugador (vehículo)
         comenzando a partir de la posición establecida al inicio
        */
        transform.position = player.transform.position + offset;
    }
}

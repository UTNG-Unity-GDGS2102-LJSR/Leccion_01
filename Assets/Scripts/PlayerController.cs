//Sandoval Rodríguez Lendy Joanna 1219100438
//GDGS2102-E 23/09/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Se declara variable para manejar la velocidad del vehículo
    private float speed = 5.0f;
    //Se declara variable para mover el vehículo (hacia izquierda o derecha)
    private float turnSpeed = 25.0f;
    //Se declara variable que va controlar el movimiento del vehículo
    private float horizontalInput;
    private float forwardInput;

    void Start()
    {
        
    }
    
    void Update()
    {
        //Se indica que se podrá usar las teclas para el manejo del movimiento.
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Se indica que se moverá el vehículo hacia adelante a la velocidad declarada al inicio
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Se indica que el vehículo podrá mover y controlar
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}

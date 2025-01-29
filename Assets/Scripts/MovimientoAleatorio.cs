using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public Rigidbody2D rb;
    public float forceMax = 100f;
    public float forceMin = 50f;

    void Start()
    {
        // 2. MOVIMIENTO:

        // Genero una fuerza aleatoria (lenta) en los ejes X e Y de los asteroides.
        float randomX = Random.Range(forceMin, forceMax);
        float randomY = Random.Range(forceMin, forceMax);

        // Muevo la forma física del asteroide:
        rb = GetComponent<Rigidbody2D>();
        // Aplico la fuerza generada al Rigidbody2D (el asteroide):
        rb.AddForce(new Vector2(randomX, randomY));


        // 3. ROTACIÓN:

        // Genero una rotación aleatoria entre 0 y 180 grados:
        float randomRotation = Random.Range(0f, 180f);

        // Aplico la rotación al asteroide:
        transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, -randomX * randomRotation);
        // Ref.: Línea 36 de CaracterMover.cs.
    }
}
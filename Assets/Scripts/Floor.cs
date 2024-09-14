using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Suelo : MonoBehaviour
{
    public Transform transformDelOtroSuelo;
    public Bird bird;

    void Start()
    {   
    }

    void Update()
    {
        if (!bird.isDead && !bird.isGameOver)
        {
            if (transform.position.x < -5.0f)
                transform.position = new Vector3(transformDelOtroSuelo.position.x + 5.0f, transformDelOtroSuelo.position.y, transform.position.z);

            transform.position = transform.position - new Vector3(1f * Time.deltaTime, 0, 0);
        }
    }
}

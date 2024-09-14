using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuberia : MonoBehaviour
{
    public Bird bird;

    void Start()
    {
        transform.position = new Vector3(transform.position.x, Random.Range(-0.2f, 0.6f), transform.position.z);
    }

    void Update()
    {
        if (!bird.isDead && !bird.isGameOver)
        {
            if (transform.position.x < -2.7f)
                transform.position = new Vector3(2.7f, transform.position.y, transform.position.z);

            transform.position += new Vector3(-1f * Time.deltaTime, 0, 0);
        }
    }
}

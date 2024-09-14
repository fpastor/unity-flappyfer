using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D birdRigidbody2D;
    public bool isDead = false;
    public bool isGameOver = true;

    void Start()
    {
        birdRigidbody2D.gravityScale = 0;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            birdRigidbody2D.gravityScale = 1;
            isGameOver = false;

            if (!isDead)
                birdRigidbody2D.velocity = new Vector2(0, 3.5f);
            else
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        if (transform.position.y > 1.2f)
            transform.position = new Vector3(transform.position.x, 1.2f, transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isDead)
        {
            isDead = true; // Si hay colisión matamos al pájaro...
            birdRigidbody2D.velocity = new Vector2(0, 0); // ...y lo dejamos de mover.

            isGameOver = true; // El juego ha terminado.
        }
    }
}

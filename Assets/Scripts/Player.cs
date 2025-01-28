using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float upForce = 350f;

    private bool isDead;
    private Rigidbody2D playerRb;
    private Animator playerAnimator;
    

    public AudioSource audioSource;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Detecta clic izquierdo del ratón o la tecla Espacio
        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) && !isDead)
        {
            Flap();
        }
    }

    private void Flap()
    {
        // Resetea la velocidad y aplica fuerza hacia arriba
        playerRb.velocity = Vector2.zero;
        playerRb.AddForce(Vector2.up * upForce);
        playerAnimator.SetTrigger("Flap");
    }

    private void OnCollisionEnter2D()
    {
        // Marca al jugador como muerto y ejecuta la animación y lógica de Game Over
        isDead = true;
        playerAnimator.SetTrigger("Die");
        GameManager.Instance.GameOver();
        audioSource.Play();
    }
}

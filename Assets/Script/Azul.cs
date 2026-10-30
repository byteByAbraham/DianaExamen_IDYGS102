using UnityEngine;
using UnityEngine.InputSystem;

public class Azul : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Keyboard teclado = Keyboard.current;
        if (teclado == null) return;

        Vector2 direccion = Vector2.zero;

        // Lectura de las Flechas del teclado
        if (teclado.upArrowKey.isPressed) direccion.y += 1f;
        if (teclado.downArrowKey.isPressed) direccion.y -= 1f;
        if (teclado.leftArrowKey.isPressed) direccion.x -= 1f;
        if (teclado.rightArrowKey.isPressed) direccion.x += 1f;

        direccion = direccion.normalized;
        rb.linearVelocity = direccion * velocidad;
    }
}
using UnityEngine;
using UnityEngine.InputSystem;

public class Rojo : MonoBehaviour
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

       
        if (teclado.wKey.isPressed) direccion.y += 1f;
        if (teclado.sKey.isPressed) direccion.y -= 1f;
        if (teclado.aKey.isPressed) direccion.x -= 1f;
        if (teclado.dKey.isPressed) direccion.x += 1f;

        direccion = direccion.normalized;
        rb.linearVelocity = direccion * velocidad;
    }
}
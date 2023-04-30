using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeed = 10f; // Vitesse de déplacement du joueur
    public float acceleration = 5f; // Accélération du joueur
    public float deceleration = 2; // Décélération du joueur

    private Rigidbody2D rb; // Référence au rigidbody du joueur
    private Vector2 movement; // Vecteur de déplacement du joueur

    float moveHorizontal;
    float moveVertical;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
    }


    void FixedUpdate()
    {
        // Calcul du vecteur de déplacement
        Vector2 inputMovement = new Vector2(moveHorizontal, moveVertical);

        // Si l'entrée de mouvement est différente de zéro, ajoute l'accélération
        if (inputMovement.magnitude != 0f)
        {
            movement += inputMovement;
        }
        // Sinon, applique une décélération pour ralentir le joueur
        else
        {
            movement = Vector2.Lerp(movement, Vector2.zero, deceleration * Time.deltaTime);
        }

        // Limite la vitesse maximale
        movement = Vector2.ClampMagnitude(movement, maxSpeed);

        // Applique le vecteur de déplacement sur le rigidbody
        rb.velocity = movement;

        // Tourne le joueur en fonction de la direction de déplacement
        if (movement.magnitude > 0f)
        {
            float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeed = 10f; // Vitesse de d�placement du joueur
    public float acceleration = 5f; // Acc�l�ration du joueur
    public float deceleration = 2; // D�c�l�ration du joueur

    private Rigidbody2D rb; // R�f�rence au rigidbody du joueur
    private Vector2 movement; // Vecteur de d�placement du joueur

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
        // Calcul du vecteur de d�placement
        Vector2 inputMovement = new Vector2(moveHorizontal, moveVertical);

        // Si l'entr�e de mouvement est diff�rente de z�ro, ajoute l'acc�l�ration
        if (inputMovement.magnitude != 0f)
        {
            movement += inputMovement;
        }
        // Sinon, applique une d�c�l�ration pour ralentir le joueur
        else
        {
            movement = Vector2.Lerp(movement, Vector2.zero, deceleration * Time.deltaTime);
        }

        // Limite la vitesse maximale
        movement = Vector2.ClampMagnitude(movement, maxSpeed);

        // Applique le vecteur de d�placement sur le rigidbody
        rb.velocity = movement;

        // Tourne le joueur en fonction de la direction de d�placement
        if (movement.magnitude > 0f)
        {
            float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corner : MonoBehaviour
{
    // Récupérez les GameObjects représentant les coins de votre carte rectangulaire
    Transform topLeft;
    Transform topRight;
    Transform bottomLeft;
    Transform bottomRight;

    // Déterminez les limites de votre périmètre en X et en Y
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;


    // Start is called before the first frame update
    void Start()
    {
        topLeft = this.transform.Find("TopLeft");
        topRight = this.transform.Find("TopRight");
        bottomLeft = this.transform.Find("BottomLeft");
        bottomRight = this.transform.Find("BottomRight");

        xMin = Mathf.Min(topLeft.position.x, topRight.position.x, bottomLeft.position.x, bottomRight.position.x);
        xMax = Mathf.Max(topLeft.position.x, topRight.position.x, bottomLeft.position.x, bottomRight.position.x);
        yMin = Mathf.Min(topLeft.position.y, topRight.position.y, bottomLeft.position.y, bottomRight.position.y);
        yMax = Mathf.Max(topLeft.position.y, topRight.position.y, bottomLeft.position.y, bottomRight.position.y);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

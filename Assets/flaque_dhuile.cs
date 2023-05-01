using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flaque_dhuile : MonoBehaviour
{
    public float slowdownFactor = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player playerController = other.gameObject.GetComponent<Player>();
            playerController.SetSlowdownFactor(slowdownFactor);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player playerController = other.gameObject.GetComponent<Player>();
            playerController.ResetSlowdownFactor();
        }
    }
}

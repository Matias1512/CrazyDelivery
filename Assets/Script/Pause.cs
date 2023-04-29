using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pause;

    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("escape"))
        {
            print("space key was pressed");
        }

    }

}

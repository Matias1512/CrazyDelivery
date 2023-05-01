using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotBox : MonoBehaviour
{

    private GameObject SlotUI;
    
    // Start is called before the first frame update
    void Start()
    {
        SlotUI = GameObject.Find("Colis");
        SlotUI.SetActive(false);

    }


    void BoxInSlot()
    {

        SlotUI.SetActive(true);

    }

    void SlotEmpty()
    {

        SlotUI.SetActive(false);

    }
}

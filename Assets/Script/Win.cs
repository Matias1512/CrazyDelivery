using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{

    private GameObject victoryUI;
    private GameObject winUI;

    // Start is called before the first frame update
    void Start()
    {
        victoryUI = GameObject.Find("Victory");
        victoryUI.SetActive(false);

        winUI = GameObject.Find("Win");
        winUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void VictoryDelivery()
    {
        victoryUI.SetActive(true);

        Invoke("VictoryDeliveryEnd", 2f);

    }

    void VictoryDeliveryEnd()
    {

        victoryUI.SetActive(false);

    }

    public void WinUI()
    {
        winUI.SetActive(true);
        Invoke("WinUIEnd", 2f);

    }

    void WinUIEnd()
    {
        winUI.SetActive(false);

    }
}

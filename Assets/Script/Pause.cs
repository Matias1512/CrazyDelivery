using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pause;
    private bool isPause = false;
    



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("escape"))
        {
            
            if (isPause)
            {
                SetUnPause();
                SetUnPauseTime();
            }
            else
            {
                
                SetPause();
                SetPauseTime();
                
            }
             
        }

    }

    public void SetPause()
    {
        pause.SetActive(true);
        isPause = true;
    }

    public void SetUnPause()
    {
        pause.SetActive(false);
        isPause = false;
    }

    public void SetPauseTime()
    {
        Time.timeScale = 0;
    }

    public void SetUnPauseTime()
    {
        Time.timeScale = 1;
    }

}

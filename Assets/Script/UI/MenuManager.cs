using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    #region Attributes

    public Animator boxAnimation;

    #endregion
    // Start is called before the first frame update
    public void Start()
    {
        Cursor.visible = true;
        boxAnimation = GameObject.FindGameObjectWithTag("box").GetComponent<Animator>();
    }
    public void goExit()
    {
        Application.Quit();
    }

    public void goStart()
    {
        this.boxAnimation.SetBool("isPlayPressed", true);
        //SceneManager.LoadScene("Intro");
    }

    public void goCredit()
    {
        SceneManager.LoadScene("Credit");
    }
}

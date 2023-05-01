using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    #region Attributes

    private Animator boxAnimation;
    public GameObject startPressed;
    public GameObject quitPressed;

    #endregion
    // Start is called before the first frame update
    public void Start()
    {
        Cursor.visible = true;
        boxAnimation = GameObject.FindGameObjectWithTag("box").GetComponent<Animator>();
    }
    public void goExit()
    {
        GameObject.Find("quit").SetActive(false);
        quitPressed.SetActive(true);
        Application.Quit();
    }

    public void goStart()
    {
        boxAnimation.SetBool("isPlayPressed", true);
        GameObject.Find("start").SetActive(false);
        startPressed.SetActive(true);
    }

    public void goCredit()
    {

        SceneManager.LoadScene("Credit");
    }
}

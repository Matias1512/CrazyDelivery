using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationManager : MonoBehaviour
{

    public GameObject nextAnimation;
    public GameObject uiVictory;
    public GameObject uiCheck;

    public void PlayNextAnimation()
    {
        nextAnimation.GetComponent<Animator>().SetBool("shouldCamionMove", true);
    }
    
    public void ChangeScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void deactivateVictory()
    {
        uiVictory.SetActive(false);
        uiCheck.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationManager : MonoBehaviour
{

    public GameObject nextAnimation;

    public void PlayNextAnimation()
    {
        nextAnimation.GetComponent<Animator>().SetBool("shouldCamionMove", true);
    }
    
    public void ChangeScene()
    {
        //SceneManager.LoadScene("sayo_test");
    }
}

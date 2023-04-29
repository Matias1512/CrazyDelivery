using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBarre : MonoBehaviour
{
    private float timeCourseMax = 20;
    public float timeCourse = 20;
    public Image barre;
    public bool startGame = true;
    public Text timeText;


    void Start()
    {
        timeCourseMax = timeCourse;
        StartCoroutine(timer());
    }


    // Update is called once per frame
    void Update()
    {
        if (startGame == true)
        {

            barre.fillAmount -= 1.0f / timeCourseMax * Time.deltaTime;
           
        }

    }


    IEnumerator timer()
    {

         while(timeCourse > 0)
        {
            
            timeCourse--;
            yield return new WaitForSeconds(1f);
            timeText.text = "Time : " + timeCourse + " s";
        }

    }


}

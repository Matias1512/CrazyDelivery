using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeBarre : MonoBehaviour
{
    
    public float timeCourse = 70;
  
    public bool startGame = true;
    public Text timeText;
    public float timeAjout;
    public GameObject ajoutTimeText;
    public GameObject loseUI;
    private QuestManager questManager;
    public GameObject camion;

    void Start()
    {
        
        StartCoroutine(timer());
        questManager = this.GetComponent<QuestManager>();


    }


    IEnumerator timer()
    {

         while(timeCourse > 0)
        {
            
            timeCourse--;
            yield return new WaitForSeconds(1f);
            //timeText.text = "Time : " + timeCourse + " s";

            if(timeCourse <= 0)
            {
                timeText.text = "";
            }
            else
            {
                timeText.text = "" + string.Format("{0:0}:{1:00}", Mathf.Floor(timeCourse / 60), timeCourse % 60) + " s";
            }
            
            MajColor(timeCourse);
        }

    }

    private void MajColor(float currentTime)
    {

        if(currentTime < 10)
        {
            timeText.color = Color.red;
        }else if (currentTime > 10 && currentTime < 50)
        {
            timeText.color = Color.yellow;
        }
        
        if(currentTime <= 0)
        {
            
            loseUI.SetActive(true);
            // Time.timeScale = 0;
            camion.SetActive(false);
        }



    }

    //TIME
    public void AddTime(float addTime)
    {

        timeCourse = timeCourse + addTime;
        ajoutTimeText.GetComponent<Text>().text = "+ " + addTime + " s";
        Invoke("AddTimeUI", 0f);
        Invoke("AddTimeUIEnd", 2.5f);
    }

    void AddTimeUI()
    {
        ajoutTimeText.SetActive(true);
        
    } 

    private void AddTimeUIEnd()
    {
        ajoutTimeText.SetActive(false);
    }

    public void Retry()
    {

        SceneManager.LoadScene("Game");

    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("menu");
    }
    




}

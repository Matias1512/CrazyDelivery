using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientManager : MonoBehaviour
{
    private QuestManager gmQuestManager;
    public Building buildingInformation;

    // Start is called before the first frame update
    void Start()
    {
        buildingInformation.position = this.transform.position;
        print(buildingInformation.position.y);
        gmQuestManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<QuestManager>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && gmQuestManager.currentQuest.buildingInfo.position == this.gameObject.transform.position)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            // Quest completed get a new quest !
            gmQuestManager.GetQuest(false);
        }
    }

    void Update()
    {
        if(gmQuestManager.currentQuest.buildingInfo.position == this.gameObject.transform.position)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}

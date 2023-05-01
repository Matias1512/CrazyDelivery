using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientManager : MonoBehaviour
{
    private QuestManager gmQuestManager;

    // Start is called before the first frame update
    void Start()
    {
        gmQuestManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<QuestManager>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && gmQuestManager.currentQuest.buildingInfo.position == this.gameObject.transform.position)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            // Quest completed get a new quest !
            gmQuestManager.SuccessDelivery(false);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    public Building buildingInformation;
    private QuestManager gmQuestManager;

    // Start is called before the first frame update
    void Start()
    {
        buildingInformation.position = this.transform.position;
        gmQuestManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<QuestManager>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && gmQuestManager.currentQuest.buildingInfo.position == this.buildingInformation.position)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            // Quest completed get a new quest !
            gmQuestManager.SuccessDelivery(true);
        }
    }

    void Update()
    {
        if (gmQuestManager.currentQuest.buildingInfo.position == this.buildingInformation.position)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}

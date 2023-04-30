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
        gmQuestManager = GameObject.FindGameObjectWithTag("GM").GetComponent<QuestManager>();
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && gmQuestManager.currentQuest.buildingInfo.position == this.buildingInformation.position)
        {
            // Quest completed get a new quest !
            gmQuestManager.GetQuest(true);
        }
    }
}

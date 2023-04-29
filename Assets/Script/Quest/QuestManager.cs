using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    #region Attributes

    private GameObject[] buildings;
    public GameObject[] clients;
    public Quest currentQuest;
    private Corner corner;


    #endregion

    // Start is called before the first frame update
    void Start()
    {
        // get border of map
        corner = GameObject.Find("Corner").GetComponent<Corner>();

        // Get all building (fast-food or another)
        buildings = GameObject.FindGameObjectsWithTag("building");

        // Get all clients
        clients = GameObject.FindGameObjectsWithTag("client");
        GetQuest();
        
    }

    // When a quest was ended we get a new
    public void GetQuest(bool searchClients = false)
    {
        GameObject target = null;
        float randomX = Random.Range(corner.xMin, corner.xMax);
        float randomY = Random.Range(corner.yMin, corner.yMax);

        float nearestDistance = float.MaxValue;

        Vector3 randomPosition = new Vector3(randomX, randomY);

        if(searchClients)
        {
            foreach (GameObject possibleTarget in clients)
            {
                float distance = Vector2.Distance(randomPosition, possibleTarget.transform.position);
                if (distance < nearestDistance)
                {
                    target = possibleTarget;
                    nearestDistance = distance;
                }
            }
            currentQuest = new Quest(target.GetComponent<ClientManager>().buildingInformation);
        }
        else
        {
            foreach (GameObject possibleTarget in buildings)
            {
                float distance = Vector2.Distance(randomPosition, possibleTarget.transform.position);
                if (distance < nearestDistance)
                {
                    target = possibleTarget;
                    nearestDistance = distance;
                }
            }
            currentQuest = new Quest(target.GetComponent<BuildingManager>().buildingInformation);
        }

        print(currentQuest.buildingInfo);

        // vitesse du joueur a ajouter ici 
        float timeToAdd = Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position, target.transform.position) / 5f;
        // now call the method for add to the timeManager

    }


}

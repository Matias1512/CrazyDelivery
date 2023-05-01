using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voiture : MonoBehaviour
{

    public Transform[] waypoints;
    public AIDestinationSetter targetSetter;
    public Transform target;
    public int indextarget;
    // Start is called before the first frame update
    void Start()
    {
        targetSetter = GetComponent<AIDestinationSetter>();
        indextarget = 0;
        target = waypoints[indextarget];
        targetSetter.target = target;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform == target)
        {
            indextarget ++;
            if (indextarget == waypoints.Length)
            {
                indextarget = 0;
            }
            target = waypoints[indextarget];
            targetSetter.target = target;
        }
    }
}

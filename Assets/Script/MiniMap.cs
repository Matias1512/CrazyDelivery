using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
   public GameObject cible;
    public GameObject player;
    public GameObject mapFleche;
    private float rotationModifier = 90;
    private float speed = 20;

    
    // Update is called once per frame
    void Update()
    {

        Vector3 relativePos = cible.transform.position - player.transform.position;

        float angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg - rotationModifier;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        mapFleche.transform.rotation = Quaternion.Slerp(mapFleche.transform.rotation, rotation,Time.deltaTime * speed);
    }


}

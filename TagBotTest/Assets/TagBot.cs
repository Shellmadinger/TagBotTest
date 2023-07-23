using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagBot : MonoBehaviour
{
    public Transform player;
    public float speed;
    public bool isTagged = true;
    Vector3 targetDirection;
    // Update is called once per frame
    void Update()
    {
        
        if(isTagged == true)
        {
            targetDirection = player.transform.position - transform.position;
        }
        else{
            targetDirection = transform.position- player.transform.position ;
        }

        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, speed * Time.deltaTime, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}

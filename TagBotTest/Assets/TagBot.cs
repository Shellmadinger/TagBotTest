using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagBot : MonoBehaviour
{
    public Transform player;
    public float speed;
    // Update is called once per frame
    void Update()
    {
        Vector3 targetDirection = player.transform.position - transform.position;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, speed * Time.deltaTime, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);

        transform.position += transform.forward * speed * Time.deltaTime;

    }
}

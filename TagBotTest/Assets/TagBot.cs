using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagBot : MonoBehaviour
{
    public Transform player;
    public float speed;
    public bool isTagged = true;
    Vector3 targetDirection;
    Rigidbody tagBody;

    private void Start()
    {
        tagBody = gameObject.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        
        if(isTagged == true)
        {
            targetDirection = (player.transform.position - transform.position).normalized;
        }
        else{
            targetDirection = (transform.position- player.transform.position).normalized;
        }
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, speed * Time.deltaTime, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }

    private void FixedUpdate()
    {
        tagBody.velocity = transform.forward * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "TagStickPlayer" && isTagged == false)
        {
            isTagged = true;
        }
       
    }
}

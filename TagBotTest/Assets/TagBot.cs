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

    private void Update()
    {
        if (isTagged == true)
        {
            targetDirection = (player.transform.position - transform.position).normalized;
        }
        else
        {
            targetDirection = (transform.position - player.transform.position).normalized;
        }
        transform.rotation = Quaternion.LookRotation(targetDirection);
    }
    void FixedUpdate()
    {
        tagBody.velocity = new Vector3(targetDirection.x, 0, targetDirection.y) * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "TagStickPlayer" && isTagged == false)
        {
            isTagged = true;
        }
       
    }
}

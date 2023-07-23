using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagStick : MonoBehaviour
{
    public TagBot tagBool;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "TagBodyPlayer" && tagBool.isTagged == true)
        {
            tagBool.isTagged = false;
        }
    }
}

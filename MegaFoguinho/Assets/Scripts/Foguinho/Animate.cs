using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rigidBody;
    [SerializeField]
    private Animator animator;

    // Update is called once per frame
    void Update()
    {
        //if(rigidBody.velocity.z != 0) animator.SetBool("Walking", true);
        //else animator.SetBool("Walking", false);
    }
}

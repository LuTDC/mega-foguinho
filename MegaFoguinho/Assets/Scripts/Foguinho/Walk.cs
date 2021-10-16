using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    [SerializeField]
    private GameObject leftLeg, rightLeg;

    private string previousLeg = "";

    private float speed = 0.8f;

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }

    private void Move(){
        if(Input.GetButton("LeftLeg") && !Input.GetButton("RightLeg") && previousLeg != "LeftLeg"){
            leftLeg.transform.Translate(0, 0, speed);
            previousLeg = "LeftLeg";
        }
        else if(!Input.GetButton("LeftLeg") && Input.GetButton("RightLeg") && previousLeg != "RightLeg"){
            rightLeg.transform.Translate(0, 0, speed);
            previousLeg = "RightLeg";
        }
    }

    private void Rotate(){
        if(Input.GetButton("LeftArm")) transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y, transform.position.z);
        else if(Input.GetButton("RightArm")) transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);
    }
}

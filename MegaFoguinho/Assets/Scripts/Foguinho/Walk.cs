using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    [SerializeField]
    private GameObject leftLeg, rightLeg;

    private string previousLeg = "";

    private float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        Move();
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
}

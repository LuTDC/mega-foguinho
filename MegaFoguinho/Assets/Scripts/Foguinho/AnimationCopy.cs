using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCopy : MonoBehaviour
{
    [SerializeField]
    private Transform targetLimb;
    private ConfigurableJoint configurableJoint;

    private Quaternion targetInitialRotation;

    // Start is called before the first frame update
    void Start()
    {
        configurableJoint = GetComponent<ConfigurableJoint>();
        targetInitialRotation = targetLimb.transform.localRotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.rotation = copyRotation();
    }

    private Quaternion copyRotation(){
        return Quaternion.Inverse(targetLimb.localRotation) * targetInitialRotation;
    }
}

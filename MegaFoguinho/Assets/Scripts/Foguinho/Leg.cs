using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leg : MonoBehaviour
{
    private Rigidbody rigidBody;

    [SerializeField]
    private string input, alternativeInput;

    private string lastInput = "";

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton(input) && !Input.GetButton(input)) transform.Translate(0, 0, 0.05f);
    }
}

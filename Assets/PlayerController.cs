using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float speed = 5;
    private float turnspeed = 15;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
	horizontalInput = Input.GetAxis("Horizontal");
	forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
	transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);
    }
}

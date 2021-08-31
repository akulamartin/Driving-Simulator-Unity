using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset;

    public float verticalInput;
    public float rotationSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        transform.position = plane.transform.position + offset;
        transform.Rotate(Vector3.forward * rotationSpeed * verticalInput * Time.deltaTime);
    }

}

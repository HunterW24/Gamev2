using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float spinSpeed = 30f; // Adjust this value to control the speed

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its y-axis
        transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
    }
}

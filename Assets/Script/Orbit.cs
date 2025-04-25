using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform target;
    public float orbitSpeed = 50.0f;
    public float orbitRadius = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.RotateAround(target.position, Vector3.up, orbitSpeed* Time.deltaTime); 
    }
}

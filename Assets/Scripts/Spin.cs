using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // Speed at which the object spins
    public float speed = 50.0f;
    public Vector3 rotationAxis = Vector3.up;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis, speed * Time.deltaTime);
        // Randomly change the rotation axis when the 'R' key is pressed
        if (Input.GetKeyDown(KeyCode.R))
        {
            rotationAxis = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
        }
        // Randomly change the rotation speed when the 'S' key is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            speed = Random.Range(0.0f, 100.0f);
        }
    }
}

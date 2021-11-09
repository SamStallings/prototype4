using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotateSpeed = new Vector3(0.0f, 0.5f, 0.0f);
        transform.Rotate(rotateSpeed);
    }
}

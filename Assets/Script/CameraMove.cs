using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public float cameraspeed;

    
    void Update()
    {
        transform.position += new Vector3(cameraspeed * Time.deltaTime, 0, 0);
    }
}

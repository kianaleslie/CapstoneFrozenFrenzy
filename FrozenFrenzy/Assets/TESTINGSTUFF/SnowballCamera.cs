using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballCamera : MonoBehaviour
{
    public GameObject snowball;
    Vector3 offset;
    
    void Start()
    {
        offset = transform.position - snowball.transform.position;  
    }
    void LateUpdate()
    {
        transform.position = snowball.transform.position + offset;
    }
}
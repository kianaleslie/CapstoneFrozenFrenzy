using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballManager : MonoBehaviour
{
    public float speed;
    float input;

    private void Start()
    {
        speed = 5.0f;
    }
    void Update()
    {
        input = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(input, 0, 0) * speed * Time.deltaTime);
    }

    public void FixedUpdate()
    {
        //gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 7.0f);
    }
}
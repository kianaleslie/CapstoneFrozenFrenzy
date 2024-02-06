using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnowballManager : MonoBehaviour
{

    bool moveUp, leftPressed, rightPressed, moveDown;
    bool canSwap;
    float movementspeed;

    // Start is called before the first frame update
    void Start()
    {
        movementspeed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 1.0f * movementspeed);

        if (leftPressed == true)
        {
            Debug.Log("LEFT");
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1.0f * movementspeed, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else if (rightPressed == true)
        {
            Debug.Log("RIGHT");
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1.0f * movementspeed, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else
        {
            Debug.Log("NONE");
        }
    }

    // ON SCREEN BUTTONS
    public void ResetScene()
    {
        SceneManager.LoadScene(0);
    }
    public void MoveLeftPressed()
    {
        leftPressed = true;
    }
    public void MoveLeftReleased()
    {
        leftPressed = false;
    }
    public void MoveRightPressed()
    {
        rightPressed = true;
    }
    public void MoveRightReleased()
    {
        rightPressed = false;
    }

    public void LeftExited()
    {
        leftPressed = false;
    }
    public void RightExited()
    {
        rightPressed = false;
    }
}

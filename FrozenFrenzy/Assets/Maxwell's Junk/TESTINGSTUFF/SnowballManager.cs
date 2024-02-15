using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnowballManager : MonoBehaviour
{

    bool leftPressed, rightPressed;
    public float forwardMovementspeed, sideMovementSpeed;

    public bool playingGame;

    public bool canAccel;
    public bool canBoost;
    public bool canSlow;
    public bool canStop;

    // Start is called before the first frame update
    void Start()
    {
        forwardMovementspeed = 0.0f;
        sideMovementSpeed = 0.15f;
        playingGame = false;

        canAccel = true;
        canBoost = true;
        canSlow = true;
        canStop = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (playingGame == true)
        {
            if (canAccel == true)
            {
                if (forwardMovementspeed <= 0.5f)
                {
                    canAccel = false;
                    StartCoroutine(Accelerate());
                }
            }
        }
    }

    public void FixedUpdate()
    {
        if (playingGame == true)
        {
            MovePlayer();
        }
    }

    public void MovePlayer() // Called in FixedUpdate
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 1.0f * forwardMovementspeed);

        if (leftPressed == true)
        {
            Debug.Log("LEFT");
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1.0f * sideMovementSpeed, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else if (rightPressed == true)
        {
            Debug.Log("RIGHT");
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1.0f * sideMovementSpeed, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        else
        {
            Debug.Log("NONE");
        }
    }

    public IEnumerator Accelerate() // Called in Update
    {
        yield return new WaitForSeconds(0.1f);
        forwardMovementspeed += 0.01f;
        canAccel = true;
    }

    // ON SCREEN BUTTONS
    #region
    public void ResetScene() // ResetButton
    {
        SceneManager.LoadScene(0);
    }
    public void MoveLeftPressed() // Left Button
    {
        leftPressed = true;
    }
    public void MoveLeftReleased() // Left Button
    {
        leftPressed = false;
    }
    public void LeftExited() // Left Button
    {
        leftPressed = false;
    }

    public void RightExited() // Right Button
    {
        rightPressed = false;
    }
    public void MoveRightPressed() // Right Button
    {
        rightPressed = true;
    }
    public void MoveRightReleased() // Right Button
    {
        rightPressed = false;
    }
    #endregion
}

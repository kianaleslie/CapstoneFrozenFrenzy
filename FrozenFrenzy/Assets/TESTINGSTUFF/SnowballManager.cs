using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnowballManager : MonoBehaviour
{

    bool moveUp, moveLeft, moveRight, moveDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FixedUpdate()
    {

    }

    public void ResetScene()
    {
        SceneManager.LoadScene(0);
    }

    public void MoveUp()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 1.0f);
    }

    public void MoveLeft()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1.0f, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    public void MoveRight()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1.0f, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    public void MoveDown()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 1.0f);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RollingSnowballManager : MonoBehaviour
{
    public InputAction moveAction;
    Vector2 moveValue;
    public float movementSpeed, rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 15.0f;
        rotationSpeed = 150.0f;
    }

    // Update is called once per frame
    void Update()
    {
        moveValue = moveAction.ReadValue<Vector2>();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void FixedUpdate()
    {
        // Move the object
        transform.Translate(new Vector3(moveValue.x, 0, moveValue.y) * movementSpeed * Time.deltaTime);
    }

    private void OnEnable()
    {
        moveAction.Enable();
    }

    private void OnDisable()
    {
        moveAction.Disable();
    }
}

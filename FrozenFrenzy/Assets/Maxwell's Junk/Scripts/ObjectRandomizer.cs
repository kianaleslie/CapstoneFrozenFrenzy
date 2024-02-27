using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRandomizer : MonoBehaviour
{
    [SerializeField] GameObject LeftObject;
    [SerializeField] GameObject MiddleObject;
    [SerializeField] GameObject RightObject;

    public int RandomIzer;
    // Start is called before the first frame update
    void Start()
    {
        RandomIzer = Random.Range(1, 4);
        switch (RandomIzer)
        {
            case 1: // Keep Left Object
                MiddleObject.SetActive(false);
                RightObject.SetActive(false);
                break;

            case 2: // Keep Middle Object
                LeftObject.SetActive(false);
                RightObject.SetActive(false);
                break;

            case 3: // Keep Right Object
                LeftObject.SetActive(false);
                MiddleObject.SetActive(false);
                break;
        }
    }
}

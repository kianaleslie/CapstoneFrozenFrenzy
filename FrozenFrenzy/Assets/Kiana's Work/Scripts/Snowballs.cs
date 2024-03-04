using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowballs : MonoBehaviour
{
    public SnowBallSelect snowballs;
    public GameObject[] snowballPrefabs;
    

    void Start()
    {
        foreach(var snowball in snowballPrefabs)
        {
            snowball.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        //if (snowballs.snowballList[0])
        //{
        //    snowballPrefabs
        //}
    }
}
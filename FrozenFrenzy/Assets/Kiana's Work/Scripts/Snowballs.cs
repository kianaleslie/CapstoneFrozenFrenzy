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
        if (snowballs.snowballList[0])
        {
            GameObject snowball1 = snowballPrefabs[0];
        }
        if (snowballs.snowballList[1])
        {
            GameObject snowball2 = snowballPrefabs[1];
        }
        if (snowballs.snowballList[2])
        {
            GameObject snowball3 = snowballPrefabs[2];
        }
        if (snowballs.snowballList[3])
        {
            GameObject snowball4 = snowballPrefabs[3];
        }
        if (snowballs.snowballList[4])
        {
            GameObject snowball5 = snowballPrefabs[4];
        }
        if (snowballs.snowballList[5])
        {
            GameObject snowball6 = snowballPrefabs[5];
        }
        if (snowballs.snowballList[6])
        {
            GameObject snowball7 = snowballPrefabs[6];
        }
    }
}
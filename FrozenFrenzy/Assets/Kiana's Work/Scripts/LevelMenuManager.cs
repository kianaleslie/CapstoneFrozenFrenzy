using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMenuManager : MonoBehaviour
{
    [SerializeField] public GameObject frozenLevelCanvas;
    [SerializeField] public GameObject jungleLevelCanvas;
    [SerializeField] public GameObject volcanoLevelCanvas;
    [SerializeField] public Image[] leftButton;
    [SerializeField] public Image[] rightButton;

    //kiana - start with the default frozen menu 
    private void Start()
    {
        frozenLevelCanvas.SetActive(true);
        jungleLevelCanvas.SetActive(false);
        volcanoLevelCanvas.SetActive(false);
    }

    //kiana - set active the frozen level ui 
    public void LoadFrozenLevel()
    {
        frozenLevelCanvas.SetActive(true);
        jungleLevelCanvas.SetActive(false);
        volcanoLevelCanvas.SetActive(false);

    }
    //kiana - set active the jungle level ui 
    public void LoadJungleLevel()
    {
        frozenLevelCanvas.SetActive(false);
        jungleLevelCanvas.SetActive(true);
        volcanoLevelCanvas.SetActive(false);
    }
    //kiana - set active the volcano level ui 
    public void LoadVolcanoLevel()
    {
        frozenLevelCanvas.SetActive(false);
        jungleLevelCanvas.SetActive(false);
        volcanoLevelCanvas.SetActive(true);
    }
}
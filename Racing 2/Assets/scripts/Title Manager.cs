using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public void LevelMode()
    {
        SceneManager.LoadScene("Level 1");
    } 
    
    public void TrainPlaceMode()
    {
        SceneManager.LoadScene("Train Place");
    }
    public void CarSelect()
    {
        SceneManager.LoadScene("CarSelect");   
    }
}

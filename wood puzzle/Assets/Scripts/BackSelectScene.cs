using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackSelectScene : MonoBehaviour
{
    public void OnClick(){
        ScoreManager.scoreInstance.StopTime();
        SceneManager.LoadScene("SelectScene");
    }
}

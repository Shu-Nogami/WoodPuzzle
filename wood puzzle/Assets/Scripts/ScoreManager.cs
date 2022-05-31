using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreInstance {get; private set;}
    private int moveCount = 0;
    private float time = 0f;
    private int recordTime;
    private bool isTime = false;
    private Text timeText;
    private MoveCountUI moveCountUI;
    private void Awake(){
        if(scoreInstance == null){
            scoreInstance = this;
            DontDestroyOnLoad(this);
        }
        else{
            Destroy(this);
        }
    }
    public void ScoreInitialize(){
        timeText = GameObject.Find("Time").GetComponent<Text>();
        moveCountUI = GameObject.Find("MoveCount").GetComponent<MoveCountUI>();
        moveCount = 0;
        isTime = false;
        time = 0f;
        timeText.text = "タイム: " + ((int)time).ToString();
        moveCountUI.SetMoveCount(moveCount);
    }
    public void AddMoveCount(){
        moveCount++;
        moveCountUI.SetMoveCount(moveCount);
    }
    public int GetMoveCount(){
        return moveCount;
    }
    public int GetRecordTime(){
        return recordTime;
    }
    private void FixedUpdate(){
        if(isTime == true){
            time += Time.deltaTime;
            timeText.text = "タイム: " + ((int)time).ToString();
        }
    }
    public void StopTime(){
        isTime = false;
        recordTime = (int)time;
    }
    public void StartTime(){
        isTime = true;
    }
}

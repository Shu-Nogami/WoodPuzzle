using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public static BoardManager boardInstance { get; private set; }

    [SerializeField] private List<Piece> pieces = new List<Piece>();
    [SerializeField] private MeshRenderer goalBlock;
    [SerializeField] private Canvas endGameCanvas;
    private Result endGameResult;


    private void Awake(){
        if(boardInstance == null){
            boardInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else{
            Destroy(this.gameObject);
        }
    }
    public void BoardInitialize(){
        for(int i = 1;i < 11;i++){
            pieces[i-1] = GameObject.Find("Piece" + i).GetComponent<Piece>();
        }
        goalBlock = GameObject.Find("GoalBlock").GetComponent<MeshRenderer>();
        endGameCanvas = GameObject.Find("EndGameCanvas").GetComponent<Canvas>();
        endGameResult = endGameCanvas.GetComponent<Result>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NotPickPiece(){
        foreach(Piece piece in pieces){
            piece.ResetIsMove();
        }
    }
    public void GameEnd(){
        ScoreManager.scoreInstance.StopTime();
        endGameCanvas.enabled = true;
        endGameResult.SetText(ScoreManager.scoreInstance.GetMoveCount().ToString(), ScoreManager.scoreInstance.GetRecordTime().ToString());
        //UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit();
    }
}

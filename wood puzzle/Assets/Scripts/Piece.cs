using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    private bool isMove = false;
    [SerializeField] private bool[] isMoveBool = {true, true, true, true};
    private Vector3 xAxisMove = new Vector3(2.118f, 0, 0);
    private Vector3 zAxisMove = new Vector3(0, 0, 2.118f);
    private Vector3 nextMovePosition;
    [SerializeField] private bool isGoalPiece;

    private void Awake(){
        nextMovePosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(isMove){
            this.MovePosition();
        }
        this.move();
    }
    public void SetMoveBool(int moveNum, bool isMove){
        isMoveBool[moveNum] = isMove;
    }
    private void MovePosition(){
        if(Input.GetKeyDown(KeyCode.UpArrow) && isMoveBool[0] == true){
            BoardManager.boardInstance.NotPickPiece();
            nextMovePosition = transform.position + zAxisMove;
            ScoreManager.scoreInstance.AddMoveCount();
        }
        if(Input.GetKeyDown(KeyCode.DownArrow) && isMoveBool[1] == true){
            BoardManager.boardInstance.NotPickPiece();
            nextMovePosition = transform.position - zAxisMove;
            ScoreManager.scoreInstance.AddMoveCount();
        }
        if(Input.GetKeyDown(KeyCode.RightArrow) && isMoveBool[2] == true){
            BoardManager.boardInstance.NotPickPiece();
            nextMovePosition = transform.position + xAxisMove;
            ScoreManager.scoreInstance.AddMoveCount();
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow) && isMoveBool[3] == true){
            BoardManager.boardInstance.NotPickPiece();
            nextMovePosition = transform.position - xAxisMove;
            ScoreManager.scoreInstance.AddMoveCount();
        }
    }
    void move(){
        transform.position = Vector3.MoveTowards(transform.position, nextMovePosition, 3f);
    }
    public void TrueIsMove(){
        isMove = true;
    }
    public void ResetIsMove(){
        isMove = false;
    }
    public bool GetIsGoalBool(){
        return isGoalPiece;
    }
}

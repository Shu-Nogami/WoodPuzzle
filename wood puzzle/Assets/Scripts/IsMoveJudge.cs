using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsMoveJudge : MonoBehaviour
{
    [SerializeField] private Piece piece;
    [SerializeField] private int directionNum;
    private bool isGoalPiece = false;
    private void Awake(){
        isGoalPiece = piece.GetIsGoalBool();
    }
    void OnTriggerStay(Collider other){
        if(isGoalPiece == false && (other.tag == "Wall" || other.tag == "Block"|| other.tag == "GoalBlock")){
            piece.SetMoveBool(directionNum, false);
        }
        if(isGoalPiece == true && (other.tag == "Wall" || other.tag == "Block")){
            piece.SetMoveBool(directionNum, false);
        }
    }
    void OnTriggerExit(Collider other){
        if(other.tag == "Wall" || other.tag == "Block"){
            piece.SetMoveBool(directionNum, true);
        }
    }
}

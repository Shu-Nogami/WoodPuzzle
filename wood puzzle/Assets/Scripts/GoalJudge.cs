using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalJudge : MonoBehaviour
{
    public void OnTriggerEnter(Collider other){
        if(other.tag == "Block"){
            BoardManager.boardInstance.GameEnd();
        }
    }
}

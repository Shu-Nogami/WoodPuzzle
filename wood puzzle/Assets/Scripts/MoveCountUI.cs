using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCountUI : MonoBehaviour
{
    [SerializeField] private Text text;
    private int moveCount;
    public void SetMoveCount(int num){
        moveCount = num;
        text.text = "移動回数: " + moveCount.ToString();
    }
}

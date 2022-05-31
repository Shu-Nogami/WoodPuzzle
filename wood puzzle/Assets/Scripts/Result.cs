using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    [SerializeField] private Text moveCountText;
    [SerializeField] private Text timeText;
    public void SetText(string moveCount, string time){
        moveCountText.text = moveCount;
        timeText.text = time;
    }
}

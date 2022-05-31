using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartFadeIn : MonoBehaviour
{
    private float fadeSpeed = 0.01f;
	private float red, green, blue, alfa;
 
	private bool isFadeIn = true;
 
	private Image fadeImage;
 
	void Start () {
		fadeImage = GetComponent<Image>();
		red = fadeImage.color.r;
		green = fadeImage.color.g;
		blue = fadeImage.color.b;
		alfa = fadeImage.color.a;
	}
 
	void Update () {
		if (isFadeIn) {
			FadeIn();
		}
	}
 
	void FadeIn(){
		fadeImage.enabled = true;
		alfa -= fadeSpeed;
		SetAlpha ();
		if(alfa <= 0){
			isFadeIn = false;
			BoardManager.boardInstance.BoardInitialize();
            ScoreManager.scoreInstance.ScoreInitialize();
            ScoreManager.scoreInstance.StartTime();
			this.gameObject.SetActive(false);
		}
	}
 
	void SetAlpha(){
		fadeImage.color = new Color(red, green, blue, alfa);
	}
}

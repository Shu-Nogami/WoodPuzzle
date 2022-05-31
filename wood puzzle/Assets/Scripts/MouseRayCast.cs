using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRayCast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();

        if(Physics.Raycast(ray, out hit)){
            if(hit.collider.gameObject.tag == "Block"){
                if(Input.GetMouseButtonDown(0)){
                    BoardManager.boardInstance.NotPickPiece();
                    hit.collider.gameObject.GetComponent<Piece>().TrueIsMove();
                }
            }
        }
    }
}

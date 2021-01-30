using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown(){
        //if (theCollision.gameObject.tag == "piece");
        Debug.Log("Trash picked up");
    }
}

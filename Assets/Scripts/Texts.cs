using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texts : MonoBehaviour
{
    public TextAsset textfile;
    public string[] textLines;

    // Start is called before the first frame update
    void Start()
    {
        if(textfile != null)
        {
            textLines = (textfile.text.Split('\n'));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

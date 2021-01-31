using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texts : MonoBehaviour
{
    public GameObject textBox;
    public Text theText;

    public TextAsset textfile;
    public string[] textLines;

    public int currentLine;
    public int endAtLine;


    // Start is called before the first frame update
    void Start()
    {
        if(textfile != null)
        {
            textLines = (textfile.text.Split('\n'));
        }

        if(endAtLine == 0)
        {
            endAtLine = textLines.Length - 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        theText.text = textLines[currentLine];
        if(Input.GetKeyDown(KeyCode.Space))
        {
            currentLine += 1;
        }

        if(currentLine > endAtLine)
        {
            DisableTextBox();
        }
    }

    public void EnableTextBox()
    {
        textBox.SetActive(true);
    }

    public void DisableTextBox()
    {
        textBox.SetActive(false);
        this.enabled = false;
    }
}

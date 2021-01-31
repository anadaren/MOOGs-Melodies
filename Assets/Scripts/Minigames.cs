using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigames : MonoBehaviour
{
    private SpriteRenderer theSprite;
    public int thisButtonNumber;

    private AudioSource buttonSound;

    private GameManager theGM;

    // Start is called before the first frame update
    void Start()
    {
        theSprite = GetComponent<SpriteRenderer>();
        theGM = FindObjectOfType<GameManager>();
        buttonSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            
        }
    }

    void playSound()
    {
        buttonSound.Play();
    }


    void OnMouseDown()
    {
        theSprite.color = new Color(theSprite.color.r,  theSprite.color.g, theSprite.color.b, 1f);
        buttonSound.Play();

    }

    void OnMouseUp()
    {
        theSprite.color = new Color(theSprite.color.r,  theSprite.color.g, theSprite.color.b, 0.5f);
        theGM.ColorPressed(thisButtonNumber);
        buttonSound.Stop();
    }
}

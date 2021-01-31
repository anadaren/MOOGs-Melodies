using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public SpriteRenderer[] buttons;
    public AudioSource[] buttonSounds;

    private int buttonSelect;

    public float stayPressed;
    private float stayPressedCounter;

    private int[] gameOne = {1,2,3,4,1};
    private int[] gameTwo = {1,4,1,4,3,4,2,1};
    private int[] gameThree = {3,4,3,1,4,2,2,1,3,4};

    public int[] playerInput;

    public AudioSource winSound;
    public AudioSource loseSound;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(stayPressedCounter > 0)
        {
            stayPressedCounter -= Time.deltaTime;
        } else {
            buttons[buttonSelect].color = new Color(buttons[buttonSelect].color.r+30, buttons[buttonSelect].color.g+30, buttons[buttonSelect].color.b+30, 1f);
        }
    }

    public void StartGame()
    {
        buttonSelect = gameOne[0];
        buttons[buttonSelect].color = new Color(buttons[buttonSelect].color.r-1, buttons[buttonSelect].color.g-1, buttons[buttonSelect].color.b-1, 1f);
        
        stayPressedCounter = stayPressed;
        //buttonSounds[activeSequence[positionInSequence]].Play();
    }

    public void ColorPressed(int whichButton)
    {
        /*if(whichButton == 1)
        {
            Debug.Log("Correct");
        } else {
            Debug.Log("Wrong");
        }*/
        if(playerInput.Equals(gameOne))
        {
            winSound.Play();
            SceneManager.LoadScene("train");
        } else if(playerInput.Equals(gameTwo)) {
            winSound.Play();
            SceneManager.LoadScene("train");
        } else if(playerInput.Equals(gameThree)) {
            winSound.Play();
            SceneManager.LoadScene("train");
        } else {
            loseSound.Play();
            SceneManager.LoadScene("Minigame");
        }
    }
}

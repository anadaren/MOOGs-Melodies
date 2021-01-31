using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public SpriteRenderer[] buttons;
    public AudioSource[] buttonSounds;

    public float stayPressed;
    private float stayPressedCounter;

    public float waitBetweenPressed;
    private float waitBetweenPressedCounter;

    private bool shouldBePressed;
    private bool shouldNotBePressed;

    //public List<int> gameOne = new List<int>(){1,2,3,4,1};
    //public List<int> gameTwo = new List<int>(){1,4,1,4,3,4,2,1};
    //public List<int> gameThree = new List<int>(){3,4,3,1,4,2,2,1,3,4};
    public List<int> game;
    private int positionInSequence;

    private bool gameActive;
    private int inputInSequence;

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
        if(shouldBePressed)
        {
            stayPressedCounter -= Time.deltaTime;
            if(stayPressedCounter < 0)
            {
                buttons[game[positionInSequence]].color = new Color(buttons[game[positionInSequence]].color.r, buttons[game[positionInSequence]].color.g, buttons[game[positionInSequence]].color.b, 1f);
                buttonSounds[game[positionInSequence]].Stop();
                shouldBePressed = false;

                shouldNotBePressed = true;
                waitBetweenPressedCounter = waitBetweenPressed;

                positionInSequence++;
            }
        }

        if(shouldNotBePressed)
        {
            waitBetweenPressedCounter -= Time.deltaTime;

            //checks to see if sequence is over to ley player play
            if(positionInSequence >= game.Count)
            {
                shouldNotBePressed = false;
                gameActive = true;
            } else {
                if(waitBetweenPressedCounter < 0)
                {
                    buttons[game[positionInSequence]].color = new Color(buttons[game[positionInSequence]].color.r, buttons[game[positionInSequence]].color.g, buttons[game[positionInSequence]].color.b, .75f);
                    buttonSounds[game[positionInSequence]].Play();

                    stayPressedCounter = stayPressed;
                    shouldBePressed = true;
                    shouldNotBePressed = false;
                }
            }
        }
    }

    public void StartGame()
    {
        //resets values
        positionInSequence = 0;
        inputInSequence = 0;

        buttons[game[positionInSequence]].color = new Color(buttons[game[positionInSequence]].color.r, buttons[game[positionInSequence]].color.g, buttons[game[positionInSequence]].color.b, .5f);
        buttonSounds[game[positionInSequence]].Play();

        stayPressedCounter = stayPressed;
        shouldBePressed = true;
        
    }

    public void ColorPressed(int whichButton)
    {
        if(gameActive)
        {
            if(game[inputInSequence] + 1 == whichButton)
            {
                inputInSequence++;
                if(inputInSequence >= game.Count)
                {
                    winSound.Play();
                    gameActive = false;
                    StartCoroutine(ExampleCoroutine());
                }
            } else {
                loseSound.Play();
                gameActive = false;
            }
        }



    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("train");
    }
}

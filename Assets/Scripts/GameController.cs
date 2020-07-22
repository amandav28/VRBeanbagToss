using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text score;
    public int scoreValue;
    public GameObject board;
    public Slider boardSlider;
    private Vector3 boardPos;
    private float newZPos;
    public Canvas EndCanvas;
    public Canvas directions;
    public GameObject table;
    public Image EndPanel;
    public Text EndText;
    public bagsController BagsController;

    // Start is called before the first frame update
    void Start()
    {
        resetGame();
        BagsController.BagOnDeck();
    }

    public void resetClicked()
    {
        resetGame();
        BagsController.DestroyAllBeanbags();
        BagsController.BagOnDeck();
    }

    public void resetGame()
    {
        board.transform.position = new Vector3(-3f, 0f, 11f);
        scoreValue = 0;
        boardSlider.value = 0;
        score.text = scoreValue.ToString() + "/21";
        EndCanvas.gameObject.SetActive(false);
        directions.gameObject.SetActive(true);
        table.gameObject.SetActive(true);
    }

    public void scoreAdd(string location)
    {
        if (location == "Board")
        {
            scoreValue += 1;
            score.text = scoreValue.ToString() + "/21";

        }
        if (location == "Hole")
        {

            scoreValue += 2;
            score.text = scoreValue.ToString() + "/21";
        }

        if (scoreValue == 21)
        {
            gameLose(false);
        }
        else if (scoreValue > 21)
        {
            gameLose(true);
        }
    }

    public void moveBoard()
    {
        boardPos = board.transform.position;
        newZPos = 11f - (boardSlider.value * 6);

        board.transform.position = new Vector3(boardPos.x, boardPos.y, newZPos);
    }

    public void gameLose(bool winlose)
    {
        EndCanvas.gameObject.SetActive(true);
        directions.gameObject.SetActive(false);
        table.gameObject.SetActive(false);
     
        if (!winlose)
        {
            EndPanel.color = new Color(0, 255,0);
            EndText.text = "You Win!";

        }
        else if(winlose)
        {
            EndPanel.color = new Color(255, 0, 0);
            EndText.text = "You Lose!";
        }
    }
}


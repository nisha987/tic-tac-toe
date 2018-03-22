using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GridSpace : MonoBehaviour {

    public Button button;
    public Text buttonText;
    

    private GameController gameController;

    public void setSpace()
    {
        buttonText.text = gameController.GetPlayerSide();
        button.interactable = false;
        gameController.EndTurn();
    }

    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }


}

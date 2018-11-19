using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour {

    public AudioSource buttonSound;
    public Button button;
    public Text buttonText;

    float scrollSpeed = -5f;
    Vector2 startPos;

    private GameController gameController;

    public void SetSpace()
    {
        buttonSound.PlayOneShot(buttonSound.clip);
        buttonText.text = gameController.GetPlayerSide();
        button.interactable = false;
        gameController.EndTurn();
    }

    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }

    public void Start()
    {
        startPos = transform.position;
    }

    public void Update()
    {
        float newPos = Mathf.Repeat (Time.time * scrollSpeed, 20);
            transform.position = startPos + Vector2.right * newPos;
    }
}
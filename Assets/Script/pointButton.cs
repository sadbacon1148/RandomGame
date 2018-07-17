using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointButton : MonoBehaviour {
    private int point = 500;
    private int[] points = {500,750,1000,1250,2500,5000};
    private string[] moves = { "move1","move2","move3","move4"};
    private string move;
    private Text theText;
    private float speed = 7f;
    private Image colour;

    // Use this for initialization
    void Start() {
        point = points[Random.Range(0, 5)];
        speed = Random.Range(5f, 10f);
        move = moves[Random.Range(0, 3)];
        theText = GetComponentInChildren<Text>();
        theText.text = point.ToString();

        colour = GetComponent<Image>();
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
        colour.color = newColor;

        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(onTaskClicked); //can get access on the Onclick Part 

	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-speed, 0f, 0f);
	}

    void onTaskClicked()
    {
        spawnerScript.instance.makeMove(move);
        spawnerScript.instance.addScore(point); //at first inside the parenthesis was 4200 so whenever the user click on the button the text will show at the console that the score is 4200
        Destroy(this.gameObject);
    }

}

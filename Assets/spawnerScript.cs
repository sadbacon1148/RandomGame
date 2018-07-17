using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnerScript : MonoBehaviour {

    public Text myScore;
    public static spawnerScript instance; // this is like a copy of this script
    private GameObject dancer;
    private Animator anim;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start() {
        SpawnProcess();

    }

    // Update is called once per frame
    void Update() {

    }

  


    public void SpawnProcess()
    {
        InvokeRepeating("spawn", 2.5f, 2.5f);
    }

    void spawn()
    {
        GameObject x = (GameObject)Instantiate(Resources.Load("pointButton"));
        x.transform.parent = transform;

        RectTransform position = x.GetComponent<RectTransform>();
        position.localPosition = new Vector3(0f, 0f, 0f);
        position.localScale = new Vector3(0.5693161f, 0.5693161f, 0.5693161f);

    }

    public void addScore(int theScore)
    {
        myScore.text = (int.Parse(myScore.text) + theScore).ToString();
       // removeKids();
    }

    /*private void removeKids()
    {
        foreach(Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
    */ //this function is there to remove all the buttons if you wanna destroy only one then use Destroy(this.gameObject); inside ontaskclicked 

    public void makeMove(string danceMove)
    {
        dancer = GameObject.Find("UserDefinedTarget-1/sporty_granny@Gangnam Style");
        anim = dancer.GetComponent<Animator> ();
        anim.SetTrigger(danceMove);

    }

}

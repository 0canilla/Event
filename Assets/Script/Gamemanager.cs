using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;
    public int scoreinstanciado;


    private PlayerController playerScript;
    private PointsController pointScript;
    private GoldenWall WallScript;
   
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        //playerScript.onDeath += GameOver;
        PlayerController.onDeath += GameOver;

        //pointScript = GameObject.Find("Points").GetComponent<PointsController>();
        //pointScript.onPoint += YouWin;
        PointsController.onPoint += YouWin;

        GoldenWall.onTouch += YouFinished;
    }

    private void GameOver()
    {
        scoreinstanciado = 0;
        Debug.Log("GAME OVER");
    }


    private void YouWin()
    {
        Debug.Log("YOU WIN BY TIME");
    }

    private void YouFinished()
    {
        Debug.Log("YOU WON BY FINISHING THE MINI GAME");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore()
    {
        instance.scoreinstanciado += 1;
        Debug.Log(scoreinstanciado);
    }

    public int GetScore()
    {
        return instance.scoreinstanciado;
    }
}

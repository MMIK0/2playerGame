using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    

    public GameObject player1;
    public GameObject player2;

    public int P1Life;
    public int P2Life;

    public GameObject p1Wins;
    public GameObject p2Wins;

    public GameObject [] p1Heart;
    public GameObject [] p2Heart;

    public string  mainMenu;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (P1Life <= 0){
            player1.SetActive(false);
            p2Wins.SetActive(true);
        }

         if (P2Life <= 0){
            player2.SetActive(false);
            p1Wins.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if(Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene(mainMenu);
        }
    }

    public void HurtP1 ()
    {
        P1Life -= 1;

        for(int i = 0; i < p1Heart.Length; i++) 
        {
            if(P1Life > i) 
            {
                p1Heart[i].SetActive(true);
            } else 
            {
                p1Heart[i].SetActive(false);
            }
        }
    }

    public void HurtP2 () 
    {
        P2Life -= 1;


         for(int i = 0; i < p2Heart.Length; i++) 
            {
            if(P2Life > i) 
            {
                p2Heart[i].SetActive(true);
            } else 
            {
                p2Heart[i].SetActive(false);
            }
        }
        
        }
    }


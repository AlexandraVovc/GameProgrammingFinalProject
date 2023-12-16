using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int currentQuest = 0;
    private bool quest1Complete = false;
    private bool quest2Complete = false;
    private bool quest3Complete = false;
    private bool isGameComplete = false;

    public static GameManager Instance { get; private set; }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake() { 
        // If there is an instance, and it's not me, delete myself. 
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
        DontDestroyOnLoad(Instance);
    } 

    public void UpdateQuestStatus()
    {
        switch (currentQuest) {
            case 0:
                currentQuest++;
                break;
            case 1:
                if (quest1Complete)
                {
                    currentQuest++;
                }
                break;
            case 2:
                if (quest2Complete)
                {
                    currentQuest++;
                }
                break;
            case 3:
                if (quest3Complete)
                {
                    isGameComplete = true;
                }
                break;
        }
    }
}

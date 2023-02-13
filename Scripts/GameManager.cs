using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] GameObject PremiumText;
    TextMesh PremiumTextMesh;    
    [SerializeField] GameObject ScoreText; 
    TextMesh ScoreTextMesh;
    int ScoreInt = 0;
    int PremiumInt = 0;
    [SerializeField] Button PremiumButton;  
    int Counter = 0;  
    void Start()
    {   
        instance = this;
        PremiumTextMesh = PremiumText.GetComponent<TextMesh>();
        ScoreTextMesh = ScoreText.GetComponent<TextMesh>();
    }
    
    void Update()
    {
        if(Counter%10 == 0 && ScoreInt > 0)
        {                                
            PremiumButton.interactable = true;            
        }
        else
        {
            PremiumButton.interactable = false;
        }
    }

    public void PremiumRise()
    {
        Counter++;

        PremiumInt++;        
        PremiumTextMesh.text = "Premium: " + PremiumInt;

        ScoreInt += 99;
        ScoreTextMesh.text = "Score: " + ScoreInt;

        print("SHOW ADS");
        PremiumButton.interactable = false;        
    }

    // Update is called once per frame
    public void ScoreRise()
    {
        Counter++;
        ScoreInt++;
        ScoreTextMesh.text = "Score: " + ScoreInt;
    }
}

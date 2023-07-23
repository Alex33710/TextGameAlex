using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum Stages
{
    STitleScreen, SStage1, SStage2A, SStage3A, SStage4A, SStage2B, SStage3B, SStage4B, SStage5B, SHappyEndingA, SHappyEndingB, SDeath
}
public class GameManager : MonoBehaviour
{
    public GameObject UI, Stage1, Stage2A, Stage3A,Stage4A, Stage2B, Stage3B, Stage4B, Stage5B, HappyEndingA, HappyEndingB, Death, TitleScreen;
    public Button StartButton, ExitButton, ButtonA, ButtonB, Button2AR, Button2AL, Button2BR, Button2BL, Button3AR, Button3AL, Button3BR, Button3BL, Button4AR, Button4AL, Button4BR, Button4BL, Button5BR, Button5BL;
    public int health;
    public TextMeshProUGUI HealthText;
    public Stages currentStage;

    // Start is called before the first frame update
    void Start()
    {
        TitleScreen.SetActive(true);
        StartButton.onClick.AddListener(StartGame);
        
    }

    // Update is called once per frame
    void Update()
    {
        HealthText.text = health.ToString();

        switch (currentStage)
        {
            //case Stages.STitleScreen:
              //  TitleScreen.SetActive(true);
                //break;
            case Stages.SStage1:
                Stage1.SetActive(true);
                TitleScreen.SetActive(false);
                break;
            case Stages.SStage2A:
                Stage2A.SetActive(true);
                Stage1.SetActive(false);
                break;
            case Stages.SStage3A:
                Stage3A.SetActive(true);
                Stage2A.SetActive(false);
                break;
            case Stages.SStage4A:
                Stage4A.SetActive(true);
                Stage3A.SetActive(false);
                break;
            case Stages.SStage2B:
                Stage2B.SetActive(true);
                Stage1.SetActive(false);
                break;
            case Stages.SStage3B:
                Stage3B.SetActive(true);
                Stage2B.SetActive(false);
                break;
            case Stages.SStage4B:
                Stage4B.SetActive(true);
                Stage3B.SetActive(false);
                break;
            case Stages.SStage5B:
                Stage5B.SetActive(true);
                Stage4B.SetActive(false);
                break;
            case Stages.SHappyEndingA:
                HappyEndingA.SetActive(true);
                Stage4A.SetActive(false);
                break;
            case Stages.SHappyEndingB:
                HappyEndingB.SetActive(true);
                Stage5B.SetActive(false);
                break;
            case Stages.SDeath:
                Death.SetActive(true);
                Stage2A.SetActive(false);
                Stage3A.SetActive(false);
                Stage4A.SetActive(false);
                Stage2B.SetActive(false);
                Stage3B.SetActive(false);
                Stage4B.SetActive(false);
                Stage5B.SetActive(false);
                break;
            default:
                break;


        }
    }

    public void StartGame()
    {
        currentStage = Stages.SStage1;
        health = 5;
        ButtonA.onClick.AddListener(F2A);
        ButtonB.onClick.AddListener(F2B);
    }

    public void F2A()
    {
        currentStage = Stages.SStage2A;
        if (health == 0)
        {
            currentStage = Stages.SDeath;
        }
        else
        {
            health -= 1;
        }
        Button2AL.onClick.AddListener(F3A);
        Button2AR.onClick.AddListener(F3A);
    }

    public void F3A()
    {
        currentStage = Stages.SStage3A;
        if (health == 0)
        {
            currentStage = Stages.SDeath;
        }
        else
        {
            health -= 1;
        }
        Button3AL.onClick.AddListener(F4A);
        Button3AR.onClick.AddListener(F4A);
    }

    public void F4A()
    {
        currentStage = Stages.SStage4A;
        if (health == 0)
        {
            currentStage = Stages.SDeath;
        }
        else
        {
            health -= 1;
        }
        Button4AL.onClick.AddListener(FD);
        Button4AR.onClick.AddListener(FHEA);
    }

    public void FHEA()
    {
        currentStage = Stages.SHappyEndingA;
    }
    public void F2B()
    {
        currentStage = Stages.SStage2B;
        if (health == 0)
        {
            currentStage = Stages.SDeath;
        }
        else
        {
            health -= 1;
        }
        Button2BL.onClick.AddListener(F3B);
        Button2BR.onClick.AddListener(F3B);
    }

    public void F3B()
    {
        currentStage = Stages.SStage3B;
        if (health == 0)
        {
            currentStage = Stages.SDeath;
        }
        else
        {
            health -= 1;
        }
        Button3BL.onClick.AddListener(F4B);
        Button3BR.onClick.AddListener(F4B);
    }

    public void F4B()
    {
        currentStage = Stages.SStage4B;
        if (health == 0)
        {
            currentStage = Stages.SDeath;
        }
        else
        {
            health -= 1;
        }
        Button4BL.onClick.AddListener(F5B);
        Button4BR.onClick.AddListener(F5B);
    }

    public void F5B()
    {
        currentStage = Stages.SStage5B;
        Button5BL.onClick.AddListener(FHEB);
        Button5BR.onClick.AddListener(FD);
    }

    public void FHEB()
    {
        currentStage = Stages.SHappyEndingB;
    }

    public void FD()
    {
        if (health == 0)
        {
            currentStage = Stages.SDeath;
        }
        else
        {
            health -= 2;
        }
        currentStage = Stages.SDeath;
    }
}

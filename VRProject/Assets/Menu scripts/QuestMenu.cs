using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestMenu : MonoBehaviour
{
    public Text QuestNumberText;
    public Text QuestText;
    public Text QuestTextComplete;
    private string[,] quest = new string[10, 2];

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            quest[i, 1] = "Uncompleted";
        }
        quest[0, 0] = "Make simple movement";
        quest[1, 0] = "Make simple rotation left";
        quest[2, 0] = "Make simple rotation right";
        quest[3, 0] = "Use repeat";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RightButton()
    {
        if (QuestNumberText.text != "10")
        {
            QuestNumberText.text = "" + (Convert.ToInt32(QuestNumberText.text) + 1);
            QuestText.text = quest[Convert.ToInt32(QuestNumberText.text)-1, 0];
            QuestTextComplete.text = quest[Convert.ToInt32(QuestNumberText.text)-1, 1];
        }
    }

    public void LeftButton()
    {
        if (QuestNumberText.text != "1")
        {
            QuestNumberText.text = "" + (Convert.ToInt32(QuestNumberText.text) - 1);
            QuestText.text = quest[Convert.ToInt32(QuestNumberText.text)-1, 0];
            QuestTextComplete.text = quest[Convert.ToInt32(QuestNumberText.text)-1, 1];
        }    
    }
}

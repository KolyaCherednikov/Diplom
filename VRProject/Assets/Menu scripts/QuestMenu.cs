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
    public QUESTLIST quest;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        QuestText.text = quest.GETQUEST(Convert.ToInt32(QuestNumberText.text) - 1);
        QuestTextComplete.text = quest.GETQUESTCOMPLETE(Convert.ToInt32(QuestNumberText.text) - 1);
        if (QuestTextComplete.text == "Complete")
            QuestTextComplete.color = Color.green;
        else if (QuestTextComplete.text == "Uncompleted")
            QuestTextComplete.color = Color.red;
    }

    public void RightButton()
    {
        if (QuestNumberText.text != "10")
        {
            QuestNumberText.text = "" + (Convert.ToInt32(QuestNumberText.text) + 1);
            QuestText.text = quest.GETQUEST(Convert.ToInt32(QuestNumberText.text)-1);
            QuestTextComplete.text = quest.GETQUESTCOMPLETE(Convert.ToInt32(QuestNumberText.text)-1);
        }
    }

    public void LeftButton()
    {
        if (Convert.ToInt32(QuestNumberText.text) > 1)
        {
            QuestNumberText.text = "" + (Convert.ToInt32(QuestNumberText.text) - 1);
            QuestText.text = quest.GETQUEST(Convert.ToInt32(QuestNumberText.text) - 1);
            QuestTextComplete.text = quest.GETQUESTCOMPLETE(Convert.ToInt32(QuestNumberText.text) - 1);
        }    
    }

    public void MoveComplete()
    {
        quest.SETQUESTCOMPLETE(0);
        if (QuestNumberText.text == "1")
        {
            QuestTextComplete.text = quest.GETQUESTCOMPLETE(Convert.ToInt32(QuestNumberText.text) - 1);
        }
    }

    public void RightRotateComplete()
    {
        quest.SETQUESTCOMPLETE(1);
    }

    public void LeftRotateComplete()
    {
        quest.SETQUESTCOMPLETE(2);
    }

    public void RepeatComplete()
    {
        quest.SETQUESTCOMPLETE(3);
    }
}

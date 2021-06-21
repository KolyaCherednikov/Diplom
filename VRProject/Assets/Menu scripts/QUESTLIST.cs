using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QUESTLIST : MonoBehaviour
{
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

    public string GETQUEST(int number)
    {
        return quest[number, 0];
    }

    public string GETQUESTCOMPLETE(int number)
    {
        return quest[number, 1];
    }

    public void SETQUESTCOMPLETE(int number)
    {
        quest[number, 1] = "Complete";
    }
}

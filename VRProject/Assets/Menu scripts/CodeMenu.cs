using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CodeMenu : MonoBehaviour
{
    public Text MoveText;
    public Text RotateRightText;
    public Text RotateLeftText;
    public Text RepeatText;
    public Text ValueText;
    public Button MoveButton;
    public Button RotateRightButton;
    public Button RotateLeftButton;
    public Button RepeatButton;
    public GameObject prefab;
    public RectTransform content;
    public GameObject cube;
    public Dropdown coordinatesdropdown;
    public Vector3 direction;
    public QUESTLIST quest;

    // Start is called before the first frame update
    void Start()
    {
        MoveButton.enabled = false;
        RotateLeftButton.enabled = false;
        RotateRightButton.enabled = false;
        RepeatButton.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateMove()
    {
        GameObject gm = Instantiate(this.prefab, this.content);
        gm.GetComponentInChildren<Text>().text = "MOVE " + ValueText.text + " STEPS IN ";
        if (coordinatesdropdown.value == 0)
            gm.GetComponentInChildren<Text>().text += "X-AXIS";
        else if (coordinatesdropdown.value == 1)
            gm.GetComponentInChildren<Text>().text += "Y-AXIS";
        else if (coordinatesdropdown.value == 2)
            gm.GetComponentInChildren<Text>().text += "Z-AXIS";
        content.GetChild(content.childCount - 1).GetChild(1).GetComponent<Text>().text = "1";
        content.GetChild(content.childCount - 1).GetChild(2).GetComponent<Text>().text = ValueText.text;
        content.GetChild(content.childCount - 1).GetChild(3).GetComponent<Text>().text = Convert.ToString(coordinatesdropdown.value);
        quest.SETQUESTCOMPLETE(0);
    }

    public void GenerateRotateRight()
    {
        GameObject gm = Instantiate(this.prefab, this.content);
        gm.GetComponentInChildren<Text>().text = "ROTATE " + ValueText.text + " RIGHT";
        content.GetChild(content.childCount - 1).GetChild(1).GetComponent<Text>().text = "2";
        content.GetChild(content.childCount - 1).GetChild(2).GetComponent<Text>().text = ValueText.text;
        content.GetChild(content.childCount - 1).GetChild(3).GetComponent<Text>().text = Convert.ToString(coordinatesdropdown.value);
        quest.SETQUESTCOMPLETE(1);
    }

    public void GenerateRotateLeft()
    {
        GameObject gm = Instantiate(this.prefab, this.content);
        gm.GetComponentInChildren<Text>().text = "ROTATE " + ValueText.text + " LEFT";
        content.GetChild(content.childCount - 1).GetChild(1).GetComponent<Text>().text = "3";
        content.GetChild(content.childCount - 1).GetChild(2).GetComponent<Text>().text = ValueText.text;
        content.GetChild(content.childCount - 1).GetChild(3).GetComponent<Text>().text = Convert.ToString(coordinatesdropdown.value);
        quest.SETQUESTCOMPLETE(2);
    }

    public void GenerateRepeate()
    {
        GameObject gm = Instantiate(this.prefab, this.content);
        gm.GetComponentInChildren<Text>().text = "REPEAT " + ValueText.text + " TIMES{";
        content.GetChild(content.childCount - 1).GetChild(1).GetComponent<Text>().text = "4";
        content.GetChild(content.childCount - 1).GetChild(2).GetComponent<Text>().text = ValueText.text;
        content.GetChild(content.childCount - 1).GetChild(3).GetComponent<Text>().text = Convert.ToString(coordinatesdropdown.value);
        quest.SETQUESTCOMPLETE(3);
        //GenerateOpen();
        GenerateClose();
    }

    public void GenerateClose()
    {
        GameObject gm = Instantiate(this.prefab, this.content);
        gm.GetComponentInChildren<Text>().text = "}";
        content.GetChild(content.childCount - 1).GetChild(1).GetComponent<Text>().text = "5";
        content.GetChild(content.childCount - 1).GetChild(2).GetComponent<Text>().text = ValueText.text;
        content.GetChild(content.childCount - 1).GetChild(3).GetComponent<Text>().text = Convert.ToString(coordinatesdropdown.value);
    }

    public void NextValue()
    {
        ValueText.text = "" + (Convert.ToInt32(ValueText.text)+1);
        MoveText.text = "Move "+ ValueText.text + " steps";
        RotateRightText.text = "Rotate "+ ValueText.text + " right";
        RotateLeftText.text = "Rotate " + ValueText.text + " left";
        RepeatText.text = "Repeat " + ValueText.text + " times";
        if (Convert.ToInt32(ValueText.text) == 0)
        {
            MoveButton.enabled = false;
            RotateLeftButton.enabled = false;
            RotateRightButton.enabled = false;
            RepeatButton.enabled = false;
        }
        else if (Convert.ToInt32(ValueText.text) < 0)
        {
            MoveButton.enabled = true;
            RotateLeftButton.enabled = false;
            RotateRightButton.enabled = false;
            RepeatButton.enabled = false;
        }
        else
        {
            MoveButton.enabled = true;
            RotateLeftButton.enabled = true;
            RotateRightButton.enabled = true;
            RepeatButton.enabled = true;
        }
    }

    public void BackValue()
    {
        ValueText.text = "" + (Convert.ToInt32(ValueText.text) - 1);
        MoveText.text = "Move " + ValueText.text + " steps";
        RotateRightText.text = "Rotate " + ValueText.text + " right";
        RotateLeftText.text = "Rotate " + ValueText.text + " left";
        RepeatText.text = "Repeat " + ValueText.text + " times";
        if (Convert.ToInt32(ValueText.text) == 0)
        {
            MoveButton.enabled = false;
            RotateLeftButton.enabled = false;
            RotateRightButton.enabled = false;
            RepeatButton.enabled = false;
        }
        else if (Convert.ToInt32(ValueText.text) < 0)
        {
            MoveButton.enabled = true;
            RotateLeftButton.enabled = false;
            RotateRightButton.enabled = false;
            RepeatButton.enabled = false;
        }
        else
        {
            MoveButton.enabled = true;
            RotateLeftButton.enabled = true;
            RotateRightButton.enabled = true;
            RepeatButton.enabled = true;
        }
    }

    public void GoButton()
    {
        string operation;
        int amount;
        string XYZ;
        int amountofchilds = content.childCount;
        for (int i = 0; i < amountofchilds; i++)
        {
            operation = content.GetChild(i).GetChild(1).GetComponent<Text>().text;
            amount = Convert.ToInt32(content.GetChild(i).GetChild(2).GetComponent<Text>().text);
            XYZ = content.GetChild(i).GetChild(3).GetComponent<Text>().text;
            if (operation == "1")
            {
                Move(""+amount, XYZ);
            }
            else if(operation == "2")
            {
                RotateRight(amount);
            }
            else if (operation == "3")
            {
                RotateLeft(amount);
            }
            else if (operation == "4")
            {
                int howmuchrepeats = 0;
                int start = i + 1;
                int end = i + 2;
                for(int y = i+1; y < amountofchilds; y++)
                {
                    if (content.GetChild(y).GetChild(1).GetComponent<Text>().text == "5" && howmuchrepeats == 0)
                    {
                        end = y;
                        i = y;
                        //Debug.LogError(y);
                        break;
                    }
                    else if(content.GetChild(y).GetChild(1).GetComponent<Text>().text == "4")
                    {
                        howmuchrepeats++;
                    }
                    else if (content.GetChild(y).GetChild(1).GetComponent<Text>().text == "5")
                    {
                        howmuchrepeats--;
                    }
                }

                Repeat(amount, start, end);
            }
        }
    }

    public void Move(string number, string coordinate)
    {
        float temp = (float.Parse(number))/10;
        if (coordinate == "0")
            cube.transform.Translate(temp, 0, 0);
        else if(coordinate == "1")
            cube.transform.Translate(0, temp, 0);
        else if(coordinate == "2")
            cube.transform.Translate(0, 0, temp);
    }

    public void RotateRight(int number)
    {
        cube.transform.Rotate(Vector3.up, number);
    }

    public void RotateLeft(int number)
    {
        cube.transform.Rotate(Vector3.up, -number);
    }

    public void ClearButton()
    {
        for(int i = content.GetChildCount(); i > 0; i--) {
            Destroy(content.GetChild(i-1).gameObject);
        }
    }

    public void ResetButton()
    {
        cube.transform.localPosition = new Vector3(10f, 2f, 20f);
        cube.transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);
    }

    public void Repeat(int amountinrepeat, int startinrepeat, int endinrepeat)
    {
        string operation;
        int amount;
        string XYZ;
        for (int repeats = 0; repeats<amountinrepeat; repeats++)
        {
            for (int i = startinrepeat; i < endinrepeat; i++)
            {
                //Debug.Log("NumofIIIrepeats" + i);
                operation = content.GetChild(i).GetChild(1).GetComponent<Text>().text;
                amount = Convert.ToInt32(content.GetChild(i).GetChild(2).GetComponent<Text>().text);
                XYZ = content.GetChild(i).GetChild(3).GetComponent<Text>().text;

                if (operation == "1")
                {
                    Move("" + amount, XYZ);
                }
                else if (operation == "2")
                {
                    RotateRight(amount);
                }
                else if (operation == "3")
                {
                    RotateLeft(amount);
                }
                else if (operation == "4")
                {
                    int howmuchrepeats = 0;
                    int start = i + 1;
                    int end = i + 2;
                    for (int y = i+1; y < endinrepeat; y++)
                    {
                        Debug.LogError(y);
                        if (content.GetChild(y).GetChild(1).GetComponent<Text>().text == "5" && howmuchrepeats == 0)
                        {
                            end = y;
                            i = y;
                            Debug.LogError(y);
                            break;
                        }
                        else if (content.GetChild(y).GetChild(1).GetComponent<Text>().text == "4")
                        {
                            howmuchrepeats++;
                        }
                        else if (content.GetChild(y).GetChild(1).GetComponent<Text>().text == "5")
                        {
                            howmuchrepeats--;
                        }
                    }

                    Repeat(amount, start, end);
                }
            }
        }
    }
}

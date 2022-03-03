using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayNameAndScore : MonoBehaviour
{
    public GameObject displayText;
    void Start()
    {
        displayText.GetComponent<Text>().text = " Name : " + MenuUIHandler.playerName;
    }
}

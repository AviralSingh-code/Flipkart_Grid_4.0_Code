using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonTextChange : MonoBehaviour
{
    public Text buttonText;
    // public Text buttonTextTarget; //to change the text of the flip coin balance
    [SerializeField] private Text buttonTextTarget;
    // [SerializeField] private GameObject otherPlayerPanel;
    // [SerializeField] private GameObject leaveRoomPanel;
    public void NewText()
    {
        buttonTextTarget.text = (int.Parse(buttonTextTarget.text)-int.Parse(buttonText.text)).ToString();
        buttonText.text = "Bought!";
    }
}

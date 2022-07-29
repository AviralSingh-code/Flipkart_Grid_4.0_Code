using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Recharge : MonoBehaviour
{
    public Button btnClick;
    public InputField inputUser;
    public Text buttonText;
    private void Start()
    {
        btnClick.onClick.AddListener(GetInputOnClickHandler);
    }

    public void GetInputOnClickHandler()
    {
        buttonText.text = (int.Parse(buttonText.text)+int.Parse(inputUser.text)).ToString();
        // Debug.Log("Input value :" + inputUser.text);
    }
}

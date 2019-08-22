using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatWindow : MonoBehaviour
{
    public GameObject mChatMsg;
    private Transform mScrollView;
    private Transform mContent;
    private InputField mInputField;
    private Button mSubmit;

    private void Start()
    {
        mScrollView = transform.Find("ScrollView");
        mContent = mScrollView.Find("Viewport/Content");
        mInputField = transform.Find("InputField").GetComponent<InputField>();
        mSubmit = transform.Find("submit").GetComponent<Button>();
        mSubmit.onClick.AddListener(OnClickSubmit);
    }

    private void OnClickSubmit()
    {
        GameObject msg = Instantiate(mChatMsg, mContent);
        msg.transform.Find("MessageText").GetComponent<Text>().text = mInputField.text;
        
    }
}

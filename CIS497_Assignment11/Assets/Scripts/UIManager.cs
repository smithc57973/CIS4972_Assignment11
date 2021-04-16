using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    public Text text;

    public void AddText(string s)
    {
        text.text += "\n" + s;
    }
}

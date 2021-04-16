/*
 * Chris Smith
 * UIManager
 * Assignment 11
 * A singleton approach to managing UI elements.
 */

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove : MonoBehaviour
{
    public bool stoveLit;

    // Start is called before the first frame update
    void Start()
    {
        stoveLit = false;
    }

    public void LightStove()
    {
        if (!stoveLit)
        {
            stoveLit = true;
            UIManager.Instance.AddText("Stove Lit");
        }
    }

    public void UnlightStove()
    {
        if (stoveLit)
        {
            stoveLit = false;
            UIManager.Instance.AddText("Stove Unlit");
        }
    }

    public void CookFood(List<string> ingreds)
    {
        LightStove();
        foreach (string item in ingreds)
        {
            UIManager.Instance.AddText("Cooking" + item);
        }
    }
}

/*
 * Chris Smith
 * Fridge
 * Assignment 11
 * A class definining a fridge and its methods.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fridge : MonoBehaviour
{
    public List<string> ingredients;
    public List<string> inventory;
    public bool doorOpen;

    // Start is called before the first frame update
    void Start()
    {
        ingredients.Add("Noodles");
        ingredients.Add("Meat");
        ingredients.Add("Sauce");
        doorOpen = false;
    }
    
    public void OpenFridge()
    {
        if (!doorOpen)
        {
            doorOpen = true;
            UIManager.Instance.AddText("Fridge Opened");
        }
    }

    public void CloseFridge()
    {
        if (doorOpen)
        {
            doorOpen = false;
            UIManager.Instance.AddText("Fridge Closed");
        }
    }

    public void GatherIngredients()
    {
        UIManager.Instance.AddText("Gathering Ingredients...");
        OpenFridge();
        foreach (string item in ingredients)
        {
            inventory.Add(item);
        }
        ingredients.Clear();
    }

    public void ReplaceIngredients()
    {
        UIManager.Instance.AddText("Replacing Ingredients...");
        foreach (string item in inventory)
        {
            ingredients.Add(item);
        }
        inventory.Clear();
        CloseFridge();
    }
}

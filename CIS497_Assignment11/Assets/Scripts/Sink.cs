/*
 * Chris Smith
 * Sink
 * Assignment 11
 * A class definining a sink and its methods.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sink : MonoBehaviour
{
    public int numDishes;

    // Start is called before the first frame update
    void Start()
    {
        numDishes = 0;
    }

    public void AddDish()
    {
        numDishes++;
        UIManager.Instance.AddText("Dish Added");
    }

    public void RemoveDish()
    {
        if (numDishes > 0)
        {
            numDishes--;
            UIManager.Instance.AddText("Dish Removed");
        }
    }

    public void CleanDishes(int amount)
    {
        UIManager.Instance.AddText("Cleaning Dishes...");
        for (int i = 0; i < amount; i++)
        {
            RemoveDish();
        }
    }
}

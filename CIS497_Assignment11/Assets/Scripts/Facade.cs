/*
 * Chris Smith
 * Facade
 * Assignment 11
 * A class definining a Facade pattern with methods to control fridge, stove, and sink.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : MonoBehaviour
{
    public int guests;
    public Fridge fridge;
    public Stove stove;
    public Sink sink;

    public void MakeDinner(int servings)
    {
        fridge.GatherIngredients();
        stove.CookFood(fridge.inventory);
        for (int i = 0; i < servings; i++)
        {
            sink.AddDish();
        }
    }

    public void CleanUp()
    {
        fridge.ReplaceIngredients();
        stove.UnlightStove();
        sink.CleanDishes(sink.numDishes);
    }
}

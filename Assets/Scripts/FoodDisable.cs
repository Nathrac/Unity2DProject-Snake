using System;
using UnityEngine;

public class FoodDisable : MonoBehaviour
{
    public static event Action foodEaten;

    private void OnDisable()
    {
        foodEaten?.Invoke();
    }

}

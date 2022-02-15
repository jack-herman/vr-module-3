using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
public class InstantiateManager : MonoBehaviour
{
    public GameObject popcornPrefab;
    public GameObject drinkPrefab;
    int i = 0;
    int j = 0;

    public void spawnPopcorn()
    {
        GameObject popcornObject = Instantiate(popcornPrefab, new Vector3(i * 0.5f, 0f, 0f), Quaternion.Euler(0f, i * 30f, 0f));
        popcornObject.name = "Popcorn " + i.ToString();
        i++;
    }

    public void spawnDrink()
    {
        GameObject drinkObject = Instantiate(drinkPrefab, new Vector3(i * 0.5f, 0f, 0f), Quaternion.Euler(0f, i * 30f, 0f));
        drinkObject.name = "Drink " + j.ToString();
        j++;
    }

}
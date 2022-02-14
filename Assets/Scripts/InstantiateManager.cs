using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
public class InstantiateManager : MonoBehaviour
{
    public GameObject boxPrefab;
    int i = 0;

    public void spawn()
    {
        GameObject instantiatedObject = Instantiate(boxPrefab, new Vector3(i * 0.5f, 0f, 0f), Quaternion.Euler(0f, i * 30f, 0f));
        instantiatedObject.name = "Box " + i.ToString();
        i++;
    }

}
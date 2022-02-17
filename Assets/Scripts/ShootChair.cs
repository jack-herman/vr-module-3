using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootChair : MonoBehaviour
{
    public GameObject chair;
    public float speed = 10.0f;

    public bool flag = false; 
    public GameObject wScream;
   
    void Update()
    {
        if(flag == true){
            float yNew = chair.transform.position.y + speed * Time.deltaTime;
            chair.transform.position = new Vector3(chair.transform.position.x, yNew, chair.transform.position.z);
        }

    }

    public void makeChairFly()
    {
        flag = true;
        StartCoroutine(spawnSound());
  
    }

    private IEnumerator spawnSound()
    {
        GameObject scream = Instantiate(wScream, Vector3.zero, Quaternion.identity); 
        yield return new WaitForSeconds(3);
        Destroy(scream);
    } 
}

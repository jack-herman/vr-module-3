using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preparer : MonoBehaviour
{
    public UnityEngine.Video.VideoPlayer vp;
    // Start is called before the first frame update
    void Start()
    {
        vp.Prepare();
    }

   
}

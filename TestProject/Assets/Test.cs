using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private int hoge = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(true)
        {
            Debug.Log(string.Format("hoge:{0}", hoge));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

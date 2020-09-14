using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractChange : MonoBehaviour
{
    public string ChangeName;

    // Use this for initialization
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

    }


    public abstract bool applyChange();


}

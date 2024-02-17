using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class MakeVisible : MonoBehaviour
{
    [SerializeField] GameObject[] objectToMakeVisible;
    [SerializeField] GameObject[] tirggerObjects;

    int loopCount;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject _objects in objectToMakeVisible)
        {
            _objects.SetActive(false);
        }
            
    }

    // Update is called once per frame
    void Update()
    {
       

        for (int i = 0; i < tirggerObjects.Length; i++)
        {
            loopCount = i;
            OnTriggerEnter(tirggerObjects[i].GetComponent<BoxCollider>());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Entered");
            int objectIndex = LoopCount();

            objectToMakeVisible[objectIndex].SetActive(true);
        }
    }

    private int LoopCount()
    {
        int _loopcount;

        _loopcount = loopCount;

        return _loopcount;
    }
}

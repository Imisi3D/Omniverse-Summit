using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MakeVisibleWorkingVersion : MonoBehaviour
{
     /*I've set up the namespaces incase you want to change this to UI
     instead of using GameObject*/ 
    
    [SerializeField] GameObject objectToMakeVisible;
    
    // Start is called before the first frame update
    void Start()
    {
        objectToMakeVisible.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Entered");
            objectToMakeVisible.SetActive(true);
        }
    }
}

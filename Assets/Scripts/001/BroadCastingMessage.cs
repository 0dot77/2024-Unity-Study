using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroadCastingMessage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.BroadcastMessage("MessageStart");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

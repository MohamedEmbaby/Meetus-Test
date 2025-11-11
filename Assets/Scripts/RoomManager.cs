using RTLTMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Debugs;

public class RoomManager : MonoBehaviour
{
    public RTLTextMeshPro Name;
    void Start()
    {
        Name.text = PlayerController.Instance.Name;
        Debugs.Instance.Log("Player " + Name.text + " joined room", DebugType.Normal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

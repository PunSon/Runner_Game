using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager Manager;
    void OnTriggerEnter()
    {
        Manager.levelEnd();
    }
}

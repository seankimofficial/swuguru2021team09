using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialoguetrigger : MonoBehaviour
{
    public Dialogue_ info;

    public void Trigger()
    {
        var system = FindObjectOfType<DialogueSystem>();
        system.Begin(info);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour   //INHERITANCE
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EventHandler.Instance.GoalPassed();
        }
    }
}

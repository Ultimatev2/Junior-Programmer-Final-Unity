using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventHandler : MonoBehaviour  //INHERITANCE
{
    public static EventHandler Instance;
    [SerializeField] GameObject goal1, goal2, goal3;
    void Start()  //POLYMORPHISM
    {
        Instance = this;
    }
    public void GoalPassed()  //ABSTRACTION
    {
        if (goal1.activeInHierarchy)
        {
            goal1.SetActive(false);
            goal2.SetActive(true);
        }
        else if (goal2.activeInHierarchy)
        {
            goal2.SetActive(false);
            goal3.SetActive(true);
        }
        else if (goal3.activeInHierarchy)
        {
            MenuUIHandler.Instance.Winner();
        }
    }
}

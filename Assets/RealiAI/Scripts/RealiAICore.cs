using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RealiAI
{
    public class RealiAICore : MonoBehaviour
    {
        Time timeNow = new Time(00);
    }

    enum relationType
    {
        empty,
        married,
        lover,
        friend,
        familiar,
        strange,
        child,
        mother,
        father,
        sibling
    }

    enum gender
    {
        none,
        female,
        male
    }

    enum jobType 
    {
        none,
        talk
    }

    [System.Serializable]
    public class Schedule
    {
    }
}
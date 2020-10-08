using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RealiAI
{
    [System.Serializable, CreateAssetMenu(menuName = "RealiAI/Jobs/EmtyJob")]
    public class RealiAIJob : ScriptableObject
    {
        [SerializeField] private string jobTitle;
        [Range(0.0f, 10.0f),SerializeField] private float jobImportance;

        [SerializeField] private Time startTime;

    }

    public enum JobType 
    {
        empty,
        dialogue
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RealiAI
{
    [System.Serializable, CreateAssetMenu(menuName = "RealiAI/Dialogue")]
    public class RealiAIDialogue : ScriptableObject
    {
        [SerializeField] private string[] dialogue;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RealiAI
{
    [System.Serializable, CreateAssetMenu(menuName = "RealiAI/Personality")]
    public class RealiAIPersonality : ScriptableObject
    {
        [Range(0, 10)]
        private int thirst;
        [Range(0, 10)]
        private int hunger;

    }
}

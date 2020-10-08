using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RealiAI
{
    [System.Serializable, CreateAssetMenu(menuName = "RealiAI/DialogueConditional")]
    public class RealiAIDialogueConditional : RealiAIDialogue
    {
        [SerializeField] private int speakerAgeLimit;
        [SerializeField] private int listenerAgeLimit;
        [SerializeField] private relationType speakerRelation;
        [SerializeField] private relationType listenerRelation;
        [SerializeField] private gender speakerGender;
        [SerializeField] private gender listenerGender;
        [SerializeField] private Time timeLimitMin;
        [SerializeField] private Time timeLimitMax;
    }
}


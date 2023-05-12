using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


namespace CharacterSystem
{
    [Serializable]
    public class NeedsBox
    {
        [Range(0f, 100f)]
        public float state;
        public Needs needType;
        public float decayRate = 1f;
        public float satsificationRate;

        public NeedsBox(Needs needs)
        {
            needType = needs;
        }
        public void Decay()
        {
            state -= decayRate * Time.deltaTime;
            ClampValue();
        }
        public void Satisfy()
        {
            state += satsificationRate * Time.deltaTime;
            ClampValue();
        }
        public void ClampValue()
        {
            state = Mathf.Clamp(state, 0f, 100f);
        }
    }

    //made an enumerator to creat a collection of needs constants
    public enum Needs
    {
        Hunger,
        Bladder,
        Hygiene,
        Fun,
        Energy,
    }
    public class Tenant : MonoBehaviour
    {
        public List<NeedsBox> needs;
        public const int CharacterNeedsCount = 5;

        [ContextMenu("Initialize Needs List")]
        public void InitializeNeeds() 
        {
            //To be able to create the needs with value
            needs = new List<NeedsBox>();
            for (int i = 0; i < CharacterNeedsCount; i++)
            {
                needs.Add(new NeedsBox((Needs)i));
            }
        }
        private void Update()
        {
            NeedChanger();
        }

        private void NeedChanger()
        {
            for(int i = 0; i < needs.Count; i++)
            {
                needs[i].Decay();
                needs[i].Satisfy();
            }
        }
    }

}



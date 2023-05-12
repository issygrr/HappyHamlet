using CharacterSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedsPanel : MonoBehaviour
{
    [SerializeField] List<UIController> children;
    [SerializeField] Tenant testChar;
    // Update is called once per frame
    void Update()
    {
        UpdatePanel(testChar);
    }
    public void UpdatePanel(Tenant testChar)
    {
        for(int i = 0; i < children.Count; i++)
        {
            children[i].SetStatus(testChar.needs[i].state);
        }
    }
}

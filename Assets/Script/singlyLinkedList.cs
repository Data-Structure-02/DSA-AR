using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class singlyLinkedList : MonoBehaviour
{
    [SerializeField] private Button addButton;
    [SerializeField] private Button deleteButton;
    private int currentObj;

    private void Awake()
    {
        SelectObj(0);
    }

    private void SelectObj(int _index)
    {
        addButton.interactable = (_index != transform.childCount - 1);
        deleteButton.interactable = (_index != 0);

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }
    }

    public void ChangeObj(int _change)
    {
        currentObj += _change;
        SelectObj(currentObj);
    }
}

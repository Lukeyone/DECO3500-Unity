using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BubbleFilter : MonoBehaviour
{
    Bubble[] _bubbles;
    FilterType _selectedFilter = FilterType.Majors;

    void Start()
    {
        _bubbles = FindObjectsOfType<Bubble>();
        FilterBubbles();
    }

    public void OnDropdownValueChanged(int value)
    {
        switch (value)
        {
            case 0:
                _selectedFilter = FilterType.Majors;
                break;
            case 1:
                _selectedFilter = FilterType.Interests;
                break;
            case 2:
                _selectedFilter = FilterType.TeachingStaff;
                break;
            case 3:
                _selectedFilter = FilterType.Levels;
                break;
            case 4:
                _selectedFilter = FilterType.Friends;
                break;
            case 5:
                _selectedFilter = FilterType.Classmates;
                break;
            default:
                _selectedFilter = FilterType.None;
                break;
        }
        FilterBubbles();
    }

    void FilterBubbles()
    {
        if (_bubbles == null)
        {
            Debug.LogError("WHERE ARE THE BUBBLES");
            return;
        }
        foreach (var b in _bubbles)
        {
            b.CheckFilter(_selectedFilter);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplayUI : MonoBehaviour
{
    public enum MapState
    {
        WorldView = 0, // The default state
        EventBriefView = 1 // When user clicks on one of the map's buildings to quickly view information. 
    }

    public MapState currentState;
    

}

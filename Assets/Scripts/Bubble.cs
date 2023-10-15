using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bubble : MonoBehaviour
{
    [SerializeField] bool _isActive = false; // true if the correct filter is chosen
    [SerializeField] FilterType containFilters;
    [SerializeField] float _fadeOutDistance = 1.3f;
    Transform _player;
    Image _bubbleImage;
    Image[] _friendsImages;
    enum FadeState
    {
        In,
        FadingOut, // fade out to show friends
        Out,
        FadingIn
    }
    FadeState _fadeState = FadeState.In;

    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        _bubbleImage = GetComponent<Image>();
        _friendsImages = GetComponentsInChildren<Image>();
    }

    public void CheckFilter(FilterType selectedFilter)
    {
        _isActive = (selectedFilter & containFilters) != 0;

    }

    void Update()
    {
        float distToPlayer = Vector3.Distance(transform.position, _player.position);
        Debug.Log("Test " + distToPlayer);

        switch (_fadeState)
        {
            case FadeState.In:

                if (distToPlayer < _fadeOutDistance)
                {
                    _fadeState = FadeState.FadingOut;
                }
                break;
            case FadeState.Out:
                if (distToPlayer > _fadeOutDistance)
                {
                    _fadeState = FadeState.FadingIn;
                }
                break;
            case FadeState.FadingIn:
                break;
            case FadeState.FadingOut:
                break;
        }

    }

}

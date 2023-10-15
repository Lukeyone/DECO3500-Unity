using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Bubble : MonoBehaviour
{
    [SerializeField] bool _isActive = false; // true if the correct filter is chosen
    [SerializeField] FilterType containFilters;
    [SerializeField] float _fadeOutDistance = 1.3f;
    Transform _player;
    CanvasGroup _canvasGroup;
    Image _bubbleImage;
    float _bubbleOriginalAlpha;
    List<Image> _friendsImages;
    enum FadeState
    {
        In,
        Out
    }
    FadeState _fadeState = FadeState.In;

    void Awake()
    {
        DOTween.Init();
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        _canvasGroup = GetComponent<CanvasGroup>();
        _bubbleImage = GetComponent<Image>();
        _friendsImages = GetComponentsInChildren<Image>().ToList();
        _friendsImages.RemoveAt(0); // Remove parent
        _bubbleOriginalAlpha = _bubbleImage.color.a;
    }

    public void CheckFilter(FilterType selectedFilter)
    {
        _isActive = (selectedFilter & containFilters) != 0;
        float _fadeDuration = 1f;
        _canvasGroup.DOFade(_isActive ? 1 : 0, _fadeDuration);
    }

    void Update()
    {
        if (!_isActive) return;
        float distToPlayer = Vector2.Distance(transform.position, _player.position);

        switch (_fadeState)
        {
            case FadeState.In:

                if (distToPlayer < _fadeOutDistance)
                {
                    FadeBubble(true);
                    _fadeState = FadeState.Out;
                }
                break;
            case FadeState.Out:
                if (distToPlayer > _fadeOutDistance)
                {
                    FadeBubble(false);
                    _fadeState = FadeState.In;
                }
                break;
        }
    }

    void FadeBubble(bool isFadeOut)
    {
        float fadeDuration = 1;
        _bubbleImage.DOFade(isFadeOut ? 0 : _bubbleOriginalAlpha, fadeDuration);
        for (int i = 0; i < _friendsImages.Count; i++)
        {
            var friendsImage = _friendsImages[i];
            friendsImage.DOFade(isFadeOut ? 1 : 0, fadeDuration);
        }
    }
}

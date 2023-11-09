using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
    public class ScaleIconOnPoint : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [Header("Configuration")]
        [SerializeField] private GameObject iconObj;
        [Range(1.1f, 1.25f)]
        [SerializeField] private float multiplyValue;
        
        private Vector3 originalScale;

        private void Start()
        {
            originalScale = iconObj.transform.localScale;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            ChangeIconScale(multiplyValue);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            iconObj.transform.localScale = originalScale;
        }

        private void ChangeIconScale(float value)
        {
            iconObj.transform.localScale *= value;
        }
        
        
    }
}

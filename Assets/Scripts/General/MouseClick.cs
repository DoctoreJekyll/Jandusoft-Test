using System;
using TMPro;
using UnityEngine;

namespace General
{
    public class MouseClick : MonoBehaviour
    {

        [SerializeField] private TMP_Text scoreText;
        private int ghostPoint = 0;
        
        
        void Update()
        {
            scoreText.text = ghostPoint.ToString();
            
            if (Input.GetMouseButtonDown(0))
            {
                LaunchRaycast();
            }
        }


        private void LaunchRaycast()
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Ghost"))
                {
                    ghostPoint += 1;
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}

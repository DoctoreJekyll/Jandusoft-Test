using UnityEngine;

namespace General
{
    public class FadeAnim : MonoBehaviour
    {

        private Animator animator;
        
        void Start()
        {
            animator = GetComponent<Animator>();
            FadeOut();
        }

        private void FadeIn()
        {
            animator.Play("FadeInAnim");
        }

        private void FadeOut()
        {
            animator.Play("FadeOutAnim");
        }

    }
}

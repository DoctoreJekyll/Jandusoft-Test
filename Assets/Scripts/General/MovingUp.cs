using UnityEngine;

namespace General
{
    public class MovingUp : MonoBehaviour
    {
        private Rigidbody2D rb2d;
        [SerializeField] private float speed;
        
        // Start is called before the first frame update
        void Start()
        {
            rb2d = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            rb2d.velocity = Vector2.up * speed;
        }
    }
}

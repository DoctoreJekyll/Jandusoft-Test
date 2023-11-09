using UnityEngine;

namespace UI
{
    public class URLButton : MonoBehaviour
    {
        public void OpenURLOnClick()
        {
            Application.OpenURL("https://www.jandusoft.com/");
        }
    }
}

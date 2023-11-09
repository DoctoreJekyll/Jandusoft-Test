using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class LoadSceneOnClick : MonoBehaviour
    {

        public void LoadSceneByString(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
        
        
    }
}

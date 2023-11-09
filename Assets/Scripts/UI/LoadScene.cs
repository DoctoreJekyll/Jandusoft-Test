using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class LoadScene : MonoBehaviour
    {

        [SerializeField] private string sceneName;

        public void LoadSceneByString()
        {
            SceneManager.LoadScene(sceneName);
        }


    }
}

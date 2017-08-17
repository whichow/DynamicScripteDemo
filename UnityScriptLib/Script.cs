using UnityEngine;

namespace UnityScriptLib
{
    public class Script : MonoBehaviour
    {
        void Start()
        {
            Data data = new Data("Jone", 21);
            Debug.Log(data.ToString());

            GameObject instance = Instantiate(Resources.Load("enemy", typeof(GameObject))) as GameObject;

        }
    }
}

using UnityEngine;

namespace KC_RemoveUpdatePopup
{
    public class RemoveUpdatePopup : MonoBehaviour
    {
        public void Preload(KCModHelper helper)
        {
            
        }
        
        public void Start()
        {
            // Delete update news
            Destroy(GameObject.Find("UpdateContainer"));
            Destroy(GameObject.Find("UpdateDescription"));
        }
    }
}
using UnityEngine;

namespace KeySystem
{
    public class KeyItemController : MonoBehaviour
    {
        [SerializeField] private bool securityDoor = false;
        [SerializeField] private bool redKeycard = false;

        [SerializeField] private KeyInventory _keyInventory = null;

        private KeyDoorController doorObject;

        private void Start()
        {
            if (securityDoor)
            {
                doorObject = GetComponent<KeyDoorController>();
            }
        }
        
        public void ObjectInteraction()
        {
            if (securityDoor)
            {
                doorObject.PlayAnimation();
            }

            else if(redKeycard)
            {
                _keyInventory.hasRedKey = true;
                gameObject.SetActive(false);
            }
        }
    }
}
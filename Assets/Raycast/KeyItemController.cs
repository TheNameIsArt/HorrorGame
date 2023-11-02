using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeySystem
{
    public class KeyItemController : MonoBehaviour
    {
        [SerializeField] private bool BlackKeyDoor = false;
        [SerializeField] private bool GreenKeyDoor = false;
        [SerializeField] private bool BlueKeyDoor = false;
        [SerializeField] private bool RedKeyDoor = false;
        [SerializeField] private bool blackKey = false;
        [SerializeField] private bool greenKey = false;
        [SerializeField] private bool blueKey = false;
        [SerializeField] private bool redKey = false;

        [SerializeField] private KeyInventory _keyInventory = null;

        private KeyDoorController doorObject;

        private void Start()
        {
            if(BlackKeyDoor)
            {
                doorObject = GetComponent<KeyDoorController>();
            }

            if(GreenKeyDoor)
            {
                doorObject = GetComponent<KeyDoorController>();
            }

            if(BlueKeyDoor)
            {
                doorObject = GetComponent<KeyDoorController>();
            }

            if(RedKeyDoor)
            {
                doorObject = GetComponent<KeyDoorController>();
            }
        }

        public void ObjectInteraction()
        {
            if (BlackKeyDoor)
            {
                doorObject.PlayAnimation();
            }

            else if (blackKey)
            {
                _keyInventory.hasKey = true;
                gameObject.SetActive(false);
            }

            if (GreenKeyDoor)
            {
                doorObject.PlayAnimation();
            }

            else if (greenKey)
            {
                _keyInventory.hasKey = true;
                gameObject.SetActive(false);
            }

            if (BlueKeyDoor)
            {
                doorObject.PlayAnimation();
            }

            else if (blueKey)
            {
                _keyInventory.hasKey = true;
                gameObject.SetActive(false);
            }

            if (RedKeyDoor)
            {
                doorObject.PlayAnimation();
            }

            else if (redKey)
            {
                _keyInventory.hasKey = true;
                gameObject.SetActive(false);
            }
        }
    }
}


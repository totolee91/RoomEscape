using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RoomEscape
{
    public class StealDoor : SceneObject
    {
        Transform _doorPanelTrans;
        [SerializeField]bool _opened = false;


        protected override void Start()
        {
            base.Start();


            _doorPanelTrans = GetComponent<Transform>();


            _opened = false;
        }


        protected override void OnMouseDown()
        {
            base.OnMouseDown();

            // 문을 열고 닫고


            if (_opened == false) // 문이 닫혀있으면, 열고
            {
                Open();

                
            }
            else if (_opened) // 문이 열려있으면, 닫고
            {
                Close();
            }

        }

        public void Open()
        {
            _opened = true;

            //_doorPanelTrans = transform.Find("StealDoor_Room");

            float x = _doorPanelTrans.localPosition.x;
            float y = _doorPanelTrans.localPosition.y;
            float z = _doorPanelTrans.localPosition.z;

            _doorPanelTrans.localPosition = new Vector3(x, y, z);
            _doorPanelTrans.rotation = Quaternion.Euler(0, 40, 0);

        }

        public void Close()
        {
            _opened = false;

            //_doorPanelTrans = transform.Find("StealDoor_Room");

            float x = _doorPanelTrans.localPosition.x;
            float y = _doorPanelTrans.localPosition.y;
            float z = _doorPanelTrans.localPosition.z;

            _doorPanelTrans.localPosition = new Vector3(x, y, z);
            _doorPanelTrans.rotation = Quaternion.Euler(0, 90, 0);
        }

    }
}

using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
	public class Joystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
	{
		public enum AxisOption
		{
			// Options for which axes to use
			Both, // Use both
			OnlyHorizontal, // Only horizontal
			OnlyVertical // Only vertical
		}

		private int MovementRange = Screen.width / 16;
		public AxisOption axesToUse = AxisOption.Both; // The options for the axes that the still will use
		public string horizontalAxisName = "Horizontal"; // The name given to the horizontal axis for the cross platform input
		public string verticalAxisName = "Vertical"; // The name given to the vertical axis for the cross platform input

		Vector3 m_StartPos;
		bool m_UseX; // Toggle for using the x axis
		bool m_UseY; // Toggle for using the Y axis
		CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis; // Reference to the joystick in the cross platform input
		CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis; // Reference to the joystick in the cross platform input

		void OnEnable()
		{
			CreateVirtualAxes();
		}

        void Start()
        {
            m_StartPos = transform.position;
        }

        public void FixedUpdate()
        {
            Vector3 qm_StartPos = transform.position;
        }


        void UpdateVirtualAxes(Vector3 value)
		{
            var delta = m_StartPos - value;
            delta.y = -delta.y;
            // このコードの存在意義が分からない
            // delta /= MovementRange;
            if (m_UseX)
            {
                m_HorizontalVirtualAxis.Update(-delta.x);
            }

            if (m_UseY)
            {
                m_VerticalVirtualAxis.Update(delta.y);
            }
        }

		void CreateVirtualAxes()
		{
            // set axes to use
            m_UseX = (axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyHorizontal);
            m_UseY = (axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyVertical);

            // create new axes based on axes to use
            if (m_UseX)
            {
                // modify
                if (CrossPlatformInputManager.AxisExists(horizontalAxisName))
                {
                    CrossPlatformInputManager.UnRegisterVirtualAxis(horizontalAxisName);
                }
                m_HorizontalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(horizontalAxisName);
                CrossPlatformInputManager.RegisterVirtualAxis(m_HorizontalVirtualAxis);
                //m_HorizontalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(horizontalAxisName);
                //CrossPlatformInputManager.RegisterVirtualAxis(m_HorizontalVirtualAxis);
            }
            if (m_UseY)
            {
                // modify
                if (CrossPlatformInputManager.AxisExists(verticalAxisName))
                {
                    CrossPlatformInputManager.UnRegisterVirtualAxis(verticalAxisName);
                }
                m_VerticalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(verticalAxisName);
                CrossPlatformInputManager.RegisterVirtualAxis(m_VerticalVirtualAxis);
                //m_VerticalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(verticalAxisName);
                //CrossPlatformInputManager.RegisterVirtualAxis(m_VerticalVirtualAxis);
            }
        }


		public void OnDrag(PointerEventData data)
		{
			Vector3 newPos = Vector3.zero;

            float deltaX = 0;
            float deltaY = 0;

            if (m_UseX)
            {
                deltaX = data.position.x - m_StartPos.x;
            }

            if (m_UseY)
            {
                deltaY = data.position.y - m_StartPos.y;
            }

            // 正の数に変換
            float absoluteX = deltaX > 0 ? deltaX : -deltaX;
            float absoluteY = deltaY > 0 ? deltaY : -deltaY;

            // 初期位置からの絶対値を比較
            if (((absoluteX * absoluteX) + (absoluteY * absoluteY)) > (MovementRange * MovementRange))
            {
                // 角度からX、Yの位置を特定
                float angle = Mathf.Atan2(deltaX, deltaY);
                deltaX = MovementRange * Mathf.Sin(angle);
                deltaY = MovementRange* Mathf.Cos(angle);
            }

            newPos.x = deltaX;
            newPos.y = deltaY;

            transform.position = new Vector3(m_StartPos.x + newPos.x, m_StartPos.y + newPos.y, m_StartPos.z + newPos.z);
            UpdateVirtualAxes(transform.position);
        }


		public void OnPointerUp(PointerEventData data)
		{
			transform.position = m_StartPos;
			UpdateVirtualAxes(m_StartPos);
		}


		public void OnPointerDown(PointerEventData data) { }

		void OnDisable()
		{
			// remove the joysticks from the cross platform input
			if (m_UseX)
			{
				m_HorizontalVirtualAxis.Remove();
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis.Remove();
			}
		}

        public void ResetPosition()
        {
            transform.position = m_StartPos;
        }
	}
}
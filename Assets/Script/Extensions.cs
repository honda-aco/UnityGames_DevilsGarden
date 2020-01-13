using UnityEngine;
using System;
using System.Collections;

namespace Assets.Script
{
    public static class Extensions
    {
        /// <summary>
        /// 渡された処理を指定時間後に実行する
        /// </summary>
        /// <param name="monoBehaviour"></param>
        /// <param name="waitTime"></param>
        /// <param name="functionIf"></param>
        /// <returns></returns>
        public static IEnumerator DelayMethod(this MonoBehaviour monoBehaviour, float waitTime, Action action)
        {
            yield return new WaitForSeconds(waitTime);
            action();
        }

        /// <summary>
        /// オブジェクトの移動
        /// </summary>
        /// <param name="gameObject"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static bool Move(this GameObject gameObject, Vector3 destination, float range, float moveSpeed)
        {
            if ((gameObject.transform.position.x > destination.x - range && gameObject.transform.position.x < destination.x + range)
             && (gameObject.transform.position.y > destination.y - range && gameObject.transform.position.y < destination.y + range)
             && (gameObject.transform.position.z > destination.z - range && gameObject.transform.position.z < destination.z + range))
            {
                return true;
            }
            else
            {
                Vector3 direction = (destination - gameObject.transform.position).normalized;

                direction.x *= moveSpeed;
                direction.y *= moveSpeed;
                direction.z *= moveSpeed;

                Vector3 workVector3 = gameObject.transform.position + direction;
                gameObject.transform.position = workVector3;
                return false;
            }
        }

        /// <summary>
        /// オブジェクトの向き変更
        /// </summary>
        /// <param name="targetObject"></param>
        /// <param name="gameObject"></param>
        /// <param name="speed"></param>
        /// <returns></returns>
        public static bool Slope(this GameObject targetObject, GameObject gameObject, float speed = 0.3f)
        {
            Quaternion quaternion = targetObject.transform.rotation;
            targetObject.transform.LookAt(gameObject.transform.position);
            float y = targetObject.transform.eulerAngles.y;

            targetObject.transform.rotation = quaternion;
            targetObject.transform.Rotate(new Vector3(0, 1, 0), speed);

            if (y - targetObject.transform.eulerAngles.y < speed * 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// カメラのズーム
        /// </summary>
        /// <param name="camera"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static bool Zoom(this Camera camera, float size, float speed = 0.1f)
        {
            if (camera.orthographicSize > size)
            {
                camera.orthographicSize -= speed;
                if (camera.orthographicSize <= size)
                {
                    return true;
                }
            }
            else
            {
                camera.orthographicSize += speed;
                if (camera.orthographicSize >= size)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

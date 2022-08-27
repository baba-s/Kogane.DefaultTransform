using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// Transform の初期値を保持しておくためのコンポーネント
    /// </summary>
    [DisallowMultipleComponent]
    [DefaultExecutionOrder( -1000 )]
    public sealed class DefaultTransform : MonoBehaviour
    {
        //================================================================================
        // プロパティ
        //================================================================================
        public Vector3    DefaultPosition         { get; private set; }
        public Vector3    DefaultLocalPosition    { get; private set; }
        public Quaternion DefaultRotation         { get; private set; }
        public Quaternion DefaultLocalRotation    { get; private set; }
        public Vector3    DefaultEulerAngles      { get; private set; }
        public Vector3    DefaultLocalEulerAngles { get; private set; }
        public Vector3    DefaultLocalScale       { get; private set; }

        //================================================================================
        // 関数
        //================================================================================
        /// <summary>
        /// 初期化される時に呼び出されます
        /// </summary>
        private void Awake()
        {
            var t = transform;

            DefaultPosition         = t.position;
            DefaultLocalPosition    = t.localPosition;
            DefaultRotation         = t.rotation;
            DefaultLocalRotation    = t.localRotation;
            DefaultEulerAngles      = t.eulerAngles;
            DefaultLocalEulerAngles = t.localEulerAngles;
            DefaultLocalScale       = t.localScale;
        }
    }
}
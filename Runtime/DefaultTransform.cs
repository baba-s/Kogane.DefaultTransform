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
        // 変数
        //================================================================================
        private Vector3    m_defaultPosition;
        private Vector3    m_defaultLocalPosition;
        private Quaternion m_defaultRotation;
        private Vector3    m_defaultEulerAngles;
        private Vector3    m_defaultLocalEulerAngles;
        private Vector3    m_defaultLocalScale;
        private bool       m_isInitialize;

        //================================================================================
        // プロパティ
        //================================================================================
        public Vector3 DefaultPosition
        {
            get => m_defaultPosition;
            private set
            {
                Initialize();
                m_defaultPosition = value;
            }
        }

        public Vector3 DefaultLocalPosition
        {
            get => m_defaultLocalPosition;
            private set
            {
                Initialize();
                m_defaultLocalPosition = value;
            }
        }

        public Quaternion DefaultRotation
        {
            get => m_defaultRotation;
            private set
            {
                Initialize();
                m_defaultRotation = value;
            }
        }

        public Quaternion DefaultLocalRotation { get; private set; }

        public Vector3 DefaultEulerAngles
        {
            get => m_defaultEulerAngles;
            private set
            {
                Initialize();
                m_defaultEulerAngles = value;
            }
        }

        public Vector3 DefaultLocalEulerAngles
        {
            get => m_defaultLocalEulerAngles;
            private set
            {
                Initialize();
                m_defaultLocalEulerAngles = value;
            }
        }

        public Vector3 DefaultLocalScale
        {
            get => m_defaultLocalScale;
            private set
            {
                Initialize();
                m_defaultLocalScale = value;
            }
        }

        //================================================================================
        // 関数
        //================================================================================
        /// <summary>
        /// 初期化される時に呼び出されます
        /// </summary>
        private void Awake()
        {
            Initialize();
        }

        /// <summary>
        /// 初期化します
        /// </summary>
        private void Initialize()
        {
            if ( m_isInitialize ) return;
            m_isInitialize = true;

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
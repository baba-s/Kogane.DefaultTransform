# Kogane Default Transform

Transform の初期値を保持しておくためのコンポーネント

## 使用例

```csharp
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    public DefaultTransform m_defaultTransform;

    private void Update()
    {
        transform.position         = m_defaultTransform.DefaultPosition;
        transform.localPosition    = m_defaultTransform.DefaultLocalPosition;
        transform.rotation         = m_defaultTransform.DefaultRotation;
        transform.localRotation    = m_defaultTransform.DefaultLocalRotation;
        transform.eulerAngles      = m_defaultTransform.DefaultEulerAngles;
        transform.localEulerAngles = m_defaultTransform.DefaultLocalEulerAngles;
        transform.localScale       = m_defaultTransform.DefaultLocalScale;
    }
}
```
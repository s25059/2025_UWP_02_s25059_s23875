using UnityEngine;

namespace Enemy
{
    [CreateAssetMenu(menuName = "Enemy/New Enemy")]
    public class EnemySO : ScriptableObject
    {
        private string _enemyName;
        private int _damage;
    }
}

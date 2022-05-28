using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(menuName = "Player/Game Metrics", fileName = "GameMetrics", order = 0)]
    public class GameMetrics : ScriptableObject
    {
        public float LimitRight => limitRight;
        public float LimitLeft => limitLeft;

        private float limitRight;
        private float limitLeft;

        private void OnEnable()
        {
            if (Camera.main != null)
            {
                var planes = GeometryUtility.CalculateFrustumPlanes(Camera.main);
                limitRight = planes[0].distance;
                limitLeft = -planes[1].distance;
            }
        }
    }
}

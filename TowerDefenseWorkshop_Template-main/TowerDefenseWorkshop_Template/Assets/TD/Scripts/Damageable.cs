namespace GSGD1
{
	using UnityEngine;

	public class Damageable : MonoBehaviour
	{
		[SerializeField]
		private float _health = 1f;

		[SerializeField]
		private bool _destroyIfKilled = true;

		[SerializeField]
		private Transform _aimPosition = null;

		[SerializeField]
		private ParticleSystem _deathParticle = null;

		public delegate void DamageableEvent(Damageable caller, float currentHealth, float damageTaken);
		private event DamageableEvent _damageTaken = null;

		public event DamageableEvent DamageTaken
		{
			add
			{
				_damageTaken -= value;
				_damageTaken += value;
			}
			remove
			{
				_damageTaken -= value;
			}
		}

		public Vector3 GetAimPosition()
		{
			return _aimPosition.position;
		}

		public void TakeDamage(float damage)
		{
			_health -= damage;

			if (_health <= 0f)
			{
				_damageTaken?.Invoke(this, _health, damage);

				if (_destroyIfKilled == true)
				{
					DoDestroy();
				}
			}
		}

		private void DoDestroy()
		{
			var particle = Instantiate(_deathParticle);
			particle.transform.position = transform.position;
			Destroy(gameObject);
		}
	}
}
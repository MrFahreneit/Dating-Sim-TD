namespace GSGD1
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class LevelReferences : Singleton<LevelReferences>
	{
		[SerializeField]
		private PlayerPickerController _playerPickerController = null;

		[SerializeField]
		private SpawnerManager _spawnerManager = null;

		public StatsManager _statsManager = null;

		public PlayerPickerController PlayerPickerController => _playerPickerController;
		public SpawnerManager SpawnerManager => _spawnerManager;
		public DatingMenu _datingMenu = null;
		ublic EntityManager entityManager = null;

		public EnemyCountManager enemyCountManager = null;

		public Daycycle _daycycle;
}
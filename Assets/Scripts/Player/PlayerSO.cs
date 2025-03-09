using UnityEngine;

namespace Player
{
	[CreateAssetMenu(menuName="Player/New Player")]
	public class PlayerSO : ScriptableObject
	{
	    private string _playerName;
	    private int _playerScore;
	}
}
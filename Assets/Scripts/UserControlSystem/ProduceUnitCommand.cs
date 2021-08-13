using UnityEngine;

public class ProduceUnitCommand : IProduceUnitCommand
{
	public GameObject UnitPrefab => _unitPrefab;
	//private GameObject _unitPrefab;
	[InjectAsset("Chomper")] private GameObject _unitPrefab;

	/*public ProduceUnitCommand(GameObject unitPrefab)
	{
		_unitPrefab = unitPrefab;
	}*/

}

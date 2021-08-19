using System.Threading.Tasks;
using UnityEngine;

public class PatrolCommandExecutor : CommandExecutorBase<IPatrolCommand>
{
	public override Task ExecuteSpecificCommand(IPatrolCommand command)
	{
		Debug.Log($"{name} patroling!");
		return Task.CompletedTask;
	}
}
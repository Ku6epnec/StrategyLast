using System.Threading;
using UnityEngine;

public class StopCommandExecutor : CommandExecutorBase<IStopCommand>
{
	public CancellationTokenSource CancellationTokenSource { get; set; }

	public override void ExecuteSpecificCommand(IStopCommand command)
	{
		Debug.Log("I STOP");
		CancellationTokenSource?.Cancel();
	}
}
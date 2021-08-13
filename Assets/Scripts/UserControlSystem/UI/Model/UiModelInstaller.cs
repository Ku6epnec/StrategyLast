using UnityEngine;
using Zenject;

public class UiModelInstaller : MonoInstaller
{
	[SerializeField] private AssetsContext _legacyContext;
	[SerializeField] private Vector3Value _vector3;
	public override void InstallBindings()
	{
		Container.Bind<AssetsContext>().FromInstance(_legacyContext);
		Container.Bind<Vector3Value>().FromInstance(_vector3);

		Container.Bind<CommandCreatorBase<IProduceUnitCommand>>()
		.To<ProduceUnitCommandCommandCreator>().AsTransient();
		Container.Bind<CommandCreatorBase<IAttackCommand>>()
		.To<AttackCommandCommandCreator>().AsTransient();
		Container.Bind<CommandCreatorBase<IMoveCommand>>()
		.To<MoveCommandCommandCreator>().AsTransient();
		Container.Bind<CommandCreatorBase<IPatrolCommand>>()
		.To<PatrolCommandCommandCreator>().AsTransient();
		Container.Bind<CommandCreatorBase<IStopCommand>>()
		.To<StopCommandCommandCreator>().AsTransient();

		Container.Bind<CommandButtonsModel>().AsTransient();
	}
}
using UnityEngine;
using Zenject;

public class FirstPersonInstaller : MonoInstaller
{
    [SerializeField] private PlayerUnit _playerUnit;
    public override void InstallBindings()
    {
        var playerInstance = Container.InstantiatePrefabForComponent<PlayerUnit>(_playerUnit);
        Container.Bind<PlayerUnit>().FromInstance(playerInstance).AsSingle();
    }
}

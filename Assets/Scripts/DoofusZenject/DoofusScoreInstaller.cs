using Zenject;

public class DoofusScoreInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IDoofusScore>().To<DoofusScore>().AsSingle();
    }
}

using TinyECS;

public class World
{
    public static Engine e;
    public static void Init()
    {
        e = new Engine();
        // add comp to sharedConfig
        e.sharedConfig.AddComp(new PlayerComp());
        e.sharedConfig.AddComp(new EnemyComp());
        e.sharedConfig.AddComp(new DeckComp());

        // add system
        e.AddSystem(new GameInitSys());
    }
}

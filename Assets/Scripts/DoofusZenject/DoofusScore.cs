public class DoofusScore : IDoofusScore
{
    public int Score { get; private set; }

    public void IncrementScore() => Score++;
}
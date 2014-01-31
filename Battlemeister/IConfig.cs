namespace Battlemeister
{
    public interface IConfig
    {
        string ApiUri { get; }
    }

    public class DefaultConfig : IConfig
    {
        public string ApiUri
        {
            get { return "http://eu.battle.net/"; }
        }
    }
}
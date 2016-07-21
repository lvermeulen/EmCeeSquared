namespace EmCeeSquared
{
    public class EmCeeSquaredConfiguration
    {
        public Router Router { get; set; }
        public Consul Consul { get; set; }
    }

    public class Router
    {
        public string Prefix { get; set; }
    }

    public class Consul
    {
        public string Host { get; set; }
        public int? Port { get; set; }
        public bool IgnoreCriticalServices { get; set; }
    }
}
namespace Shadowsocks.Model
{
    public class ServersConfig
    {
        public string version { get; set; }
        public string remarks { get; set; }
        public Server[] servers { get; set; }
    }
}

using Computer_Advance__WF.Computer_Component;

namespace Computer_Advance__WF
{
    public class Configuration
    {
        public string Name { get; set; }
        public CPU CPU { get; set; }
        public GPU GPU { get; set; }
        public RAM RAM { get; set; }
        public SSD SSD { get; set; }
        public Motherboard Motherboard { get; set; }
        public PowerSupply PowerSupply { get; set; }

    }
}

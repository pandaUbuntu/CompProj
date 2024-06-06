using System.Windows.Forms;

namespace Computer_Advance__WF
{
    public class Director
    {
        private readonly Interface1 _builder;

        public Director(Interface1 builder)
        {
            _builder = builder;
        }

        public Computer.Computer BuildComputer()
        {
            _builder.BuilderName();

            _builder.BuilderCPU();

            _builder.BuilderGPU();

            _builder.BuilderSSD();

            _builder.BuilderRAM();

            _builder.BuilderMotherboard();

            _builder.BuilderPowerSupply();

            return _builder.GetComputer();
        }

        public Computer.Computer BuildComputerIntegratedVideoCard()
        {
            _builder.BuilderName();

            _builder.BuilderCPU();

            _builder.BuilderSSD();

            _builder.BuilderRAM();

            _builder.BuilderMotherboard();

            _builder.BuilderPowerSupply();

            return _builder.GetComputer();
        }
    }
}

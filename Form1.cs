using Computer_Advance__WF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Computer_Advance__WF
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Computer> computers;

        public Form1()
        {
            InitializeComponent();

            ComputerBuilder computerBuild = new ComputerBuilder();

            computerBuild
                .addedName("Visage")
                .addedMotherboard(2, 4, "MSI dragon age 228", 4000)
                .addedPoweSupply("Ksas BOOM", 800, 500)
                .addedCpu("Ryzen 5 5600", 4999, 3700)
                .addedGpu("Rtx 4060", 12540, 8)
                .addedSsd("Kingston G 500", 2000, 1000)
                .addedSsd("Kingston G 500", 2000, 1000)
                .addedRam("Hyper X Slim Shady", 3000, 16)
                .addedRam("Hyper X Slim Shady", 3000, 16)
                .addedRam("Hyper X Slim Shady", 3000, 16)
                .addedRam("Hyper X Slim Shady", 3000, 16)
                .addNewComputer()
                .reset()

                .addedName("Ruleschule")
                .addedMotherboard(2, 4, "MSI dragon age 228", 4000)
                .addedPoweSupply("Ksas BOOM", 800, 500)
                .addedCpu("Ryzen 5 5600", 4999, 3700)
                .addedGpu("Rtx 4060", 12540, 8)
                .addedSsd("Kingston G 500", 2000, 1000)
                .addedSsd("Kingston G 500", 2000, 1000)
                .addedRam("Hyper X Slim Shady", 3000, 16)
                .addedRam("Hyper X Slim Shady", 3000, 16)
                .addedRam("Hyper X Slim Shady", 3000, 16)
                .addedRam("Hyper X Slim Shady", 3000, 16)
                .addNewComputer()
                .reset()

                .addedName("BigBoss")
                .addedMotherboard(2, 4, "MSI dragon age 228", 4000)
                .addedPoweSupply("Ksas BOOM", 800, 500)
                .addedCpu("Ryzen 5 5600", 4999, 3700)
                .addedGpu("Rtx 4060", 12540, 8)
                .addedSsd("Kingston G 500", 2000, 1000)
                .addedSsd("Kingston G 500", 2000, 1000)
                .addedRam("Hyper X Slim Shady", 3000, 16)
                .addedRam("Hyper X Slim Shady", 3000, 16)
                .addedRam("Hyper X Slim Shady", 3000, 16)
                .addedRam("Hyper X Slim Shady", 3000, 16)
                .addNewComputer()
                .reset()

                .addedName("Kiryto")
                .addedMotherboard(2, 4, "MSI dragon age 228", 4000)
                .addedPoweSupply("Ksas BOOM", 800, 500)
                .addedCpu("Ryzen 5 5600", 4999, 3700)
                .addedGpu("Rtx 4060", 12540, 8)
                .addedSsd("Kingston G 500", 2000, 1000)
                .addedSsd("Kingston G 500", 2000, 1000)
                .addedRam("Hyper X Slim Shady", 3000, 16)
                .addedRam("Hyper X Slim Shady", 3000, 16)
                .addedRam("Hyper X Slim Shady", 3000, 16)
                .addedRam("Hyper X Slim Shady", 3000, 16)
                .addNewComputer();


            computers = computerBuild.getDictionaryComputers();
            addItemsInComputer();
        }


        private void addItemsInComputer()
        {
            comboBox2.Items.AddRange(computers.Keys.ToArray());
        }

        private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            createComboBoxComponent();
            addItemsInComponent();
        }

        private void createComboBoxComponent()
        {
            this.comboBox1.Dock = DockStyle.Bottom;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(586, 27);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
        }

        private void addItemsInComponent()
        {
            comboBox1.Items.AddRange(computers[comboBox2.Text].getAllComponentNames().ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(computers[comboBox2.Text].getComponent(comboBox1.Text).getAllData());
        }
    }
}

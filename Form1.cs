using AeropuertosAPJ.Models;
using AeropuertosAPJ.Services;

namespace WinFormsAppAeropuertosNuget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            ServiceAeropuertos service = new ServiceAeropuertos();
            AirportList list = await service.GetAirportsListAsync();
            foreach (Airport c in list.Airports)
            {
                this.listAeropuertos.Items.Add(c.Name + " " + c.IcaoCode);
            }
        }
    }
}

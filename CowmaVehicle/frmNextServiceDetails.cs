using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CowmaVehicle
{
    public partial class frmNextServiceDetails : Form
    {

        //to get the vehicle number for hesding display
        string vehicleNo = vehicleMaster.VehicleNo;

        //declaring the global variables for the all KMs text box values
        public static string engineOilKMs;
        public static string gearAndCrownOilKMs;
        public static string wheelGreaseKMs;
        public static string clutchPlateKMs;
        public static string breakeLineKMs;

        public frmNextServiceDetails()
        {
            InitializeComponent();
        }

        private void AddHeading(string text)//function to add heading in this form with dynamic parameter
        {
            Label headingLabel = new Label();
            headingLabel.Text = text;
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font(headingLabel.Font.Name, 20);
            this.Controls.Add(headingLabel);
            headingLabel.Location = new Point(280, 70);
            headingLabel.BackColor = Color.FromArgb(230, 255, 179);
        }

        private void frmNextServiceDetails_Load(object sender, EventArgs e)
        {

            //calling addHeading function and passing the vehicle number parameter
            AddHeading(vehicleNo);

            //to assign the default values
            txtEngineOilKMs.Text = "";
            txtGearAndCrownOilKMs.Text = "";
            txtWheelGreaseKMs.Text = "";
            txtClutchPlateKMs.Text = "";
            txtBreakLineKMs.Text = "";

        }

        private void btnBack_Click(object sender, EventArgs e)//this window closed if the back button is clicked
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //to store the values to variables
            engineOilKMs = txtEngineOilKMs.Text;
            gearAndCrownOilKMs = txtGearAndCrownOilKMs.Text;
            wheelGreaseKMs = txtWheelGreaseKMs.Text;
            clutchPlateKMs = txtClutchPlateKMs.Text;
            breakeLineKMs = txtBreakLineKMs.Text;

            this.Close();

        }

        //to allow only numierical values in all the text box
        private void txtEngineOilKMs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGearAndCrownOilKMs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtWheelGreaseKMs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtClutchPlateKMs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBreakLineKMs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

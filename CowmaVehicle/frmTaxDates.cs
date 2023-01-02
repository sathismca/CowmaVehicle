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
    public partial class frmTaxDates : Form
    {
        public frmTaxDates()
        {
            InitializeComponent();
        }

        //to get the vehicle number for hesding display
        string vehicleNo = vehicleMaster.VehicleNo;

        //creating the globale variable for all date time picker
        public static string insuranceFromDate,insuranceToDate;
        public static string fcFromDate, fcToDate;
        public static string pollutionTaxFromDate, pollutionTaxToDate;
        public static string advtTaxFromDate, advtTaxToDate;
        public static string tnTaxFromDate, tnTaxToDate;
        public static string klTaxFromDate, klTaxToDate;
        public static string tnPermitFromDate, tnPermitToDate;
        public static string klPermitFromDate, klPermitToDate;

        //to get the tax checkBox status in this variables from vehicle form
        bool chkBoxInsuranceStatus = vehicleMaster.chkBoxInsuranceStatus;
        bool chkBoxFCStatus = vehicleMaster.chkBoxFCStatus;
        bool chkBoxPollutionStatus = vehicleMaster.chkBoxPollutionStatus;
        bool chkBoxAdvtStatus = vehicleMaster.chkBoxAdvtTaxStatus;
        bool chkBoxTNTaxStatus = vehicleMaster.chkBoxTNTaxStatus;
        bool chkBoxKLTaxStatus = vehicleMaster.chkBoxKLTaxStatus;
        bool chkBoxTNPermitStatus = vehicleMaster.chkBoxTNPermitStatus;
        bool chkBoxKLPermitStatus = vehicleMaster.chkBoxKLPermitStatus;

        


        private void hideTaxDates()//to hide non applicable tax dates
        {
            if(chkBoxInsuranceStatus==false)
            {
                lblInsurance.Visible = false;
                lbl1.Visible = false;
                dtimeInsuranceFromDate.Visible = false;
                dtimeInsuranceToDate.Visible = false;
            }

            if(chkBoxFCStatus==false)
            {
                lblFC.Visible = false;
                lbl2.Visible = false;
                dtimeFCFromDate.Visible = false;
                dtimeFCToDate.Visible = false;
            }

            if (chkBoxPollutionStatus == false)
            {
                lblPollutionTax.Visible = false;
                lbl3.Visible = false;
                dtimePollutionTaxFromDate.Visible = false;
                dtimePollutionTaxToDate.Visible = false;
            }

            if (chkBoxAdvtStatus == false)
            {
                lblAdvtTax.Visible = false;
                lbl4.Visible = false;
                dtimeAdvtTaxFromDate.Visible = false;
                dtimeAdvtTaxToDate.Visible = false;
            }

            if (chkBoxTNTaxStatus == false)
            {
                lblTNTax.Visible = false;
                lbl5.Visible = false;
                dtimeTNTaxFromDate.Visible = false;
                dtimeTNTaxToDate.Visible = false;
            }

            if (chkBoxKLTaxStatus == false)
            {
                lblKLTax.Visible = false;
                lbl6.Visible = false;
                dtimeKLTaxFromDate.Visible = false;
                dtimeKLTaxToDate.Visible = false;
            }

            if (chkBoxTNPermitStatus == false)
            {
                lblTNPermit.Visible = false;
                lbl7.Visible = false;
                dtimeTNPermitFromDate.Visible = false;
                dtimeTNPermitToDate.Visible = false;
            }

            if (chkBoxKLPermitStatus == false)
            {
                lblKLPermit.Visible = false;
                lbl8.Visible = false;
                dtimeKLPermitFromDate.Visible = false;
                dtimeKLPermitToDate.Visible = false;
            }
        }

        private void AddHeading(string text)//function to add heading in this form with dynamic parameter
        {
            Label headingLabel = new Label();
            headingLabel.Text = text;
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font(headingLabel.Font.Name, 20);
            this.Controls.Add(headingLabel);
            headingLabel.Location = new Point(315, 48);
            headingLabel.BackColor = Color.FromArgb(230, 255, 179);
        }

        private void reSetDateTimePicker()//function to reset date time picker
        {
            dtimeInsuranceFromDate.Format = DateTimePickerFormat.Custom;
            dtimeInsuranceFromDate.CustomFormat = "'From'";
            dtimeInsuranceToDate.Format = DateTimePickerFormat.Custom;
            dtimeInsuranceToDate.CustomFormat = "'To'";

            dtimeFCFromDate.Format = DateTimePickerFormat.Custom;
            dtimeFCFromDate.CustomFormat = "'From'";
            dtimeFCToDate.Format = DateTimePickerFormat.Custom;
            dtimeFCToDate.CustomFormat = "'To'";
            
            dtimePollutionTaxFromDate.Format = DateTimePickerFormat.Custom;
            dtimePollutionTaxFromDate.CustomFormat = "'From'";
            dtimePollutionTaxToDate.Format = DateTimePickerFormat.Custom;
            dtimePollutionTaxToDate.CustomFormat = "'To'";

            dtimeAdvtTaxFromDate.Format = DateTimePickerFormat.Custom;
            dtimeAdvtTaxFromDate.CustomFormat = "'From'";
            dtimeAdvtTaxToDate.Format = DateTimePickerFormat.Custom;
            dtimeAdvtTaxToDate.CustomFormat = "'To'";

            dtimeTNTaxFromDate.Format = DateTimePickerFormat.Custom;
            dtimeTNTaxFromDate.CustomFormat = "'From'";
            dtimeTNTaxToDate.Format = DateTimePickerFormat.Custom;
            dtimeTNTaxToDate.CustomFormat = "'To'";

            dtimeKLTaxFromDate.Format = DateTimePickerFormat.Custom;
            dtimeKLTaxFromDate.CustomFormat = "'From'";
            dtimeKLTaxToDate.Format = DateTimePickerFormat.Custom;
            dtimeKLTaxToDate.CustomFormat = "'To'";

            dtimeTNPermitFromDate.Format = DateTimePickerFormat.Custom;
            dtimeTNPermitFromDate.CustomFormat = "'From'";
            dtimeTNPermitToDate.Format = DateTimePickerFormat.Custom;
            dtimeTNPermitToDate.CustomFormat = "'To'";

            dtimeKLPermitFromDate.Format = DateTimePickerFormat.Custom;
            dtimeKLPermitFromDate.CustomFormat = "'From'";
            dtimeKLPermitToDate.Format = DateTimePickerFormat.Custom;
            dtimeKLPermitToDate.CustomFormat = "'To'";
        }

        private void dtimeInsuranceFromDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format property to default format
            dtimeInsuranceFromDate.Format = DateTimePickerFormat.Long;
        }

        private void dtimePollutionTaxFromDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format property to default format
            dtimePollutionTaxFromDate.Format = DateTimePickerFormat.Long;
        }

        private void dtimePollutionTaxToDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format property to default format
            dtimePollutionTaxToDate.Format = DateTimePickerFormat.Long;
        }

        private void dtimeAdvtTaxFromDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format property to default format
            dtimeAdvtTaxFromDate.Format = DateTimePickerFormat.Long;
        }

        private void dtimeAdvtTaxToDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format property to default format
            dtimeAdvtTaxToDate.Format = DateTimePickerFormat.Long;
        }

        private void dtimeTNTaxFromDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format property to default format
            dtimeTNTaxFromDate.Format = DateTimePickerFormat.Long;
        }

        private void dtimeTNTaxToDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format property to default format
            dtimeTNTaxToDate.Format = DateTimePickerFormat.Long;
        }

        private void dtimeKLTaxFromDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format property to default format
            dtimeKLTaxFromDate.Format = DateTimePickerFormat.Long;
        }

        private void dtimeKLTaxToDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format property to default format
            dtimeKLTaxToDate.Format = DateTimePickerFormat.Long;
        }

        private void dtimeTNPermitFromDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format property to default format
            dtimeTNPermitFromDate.Format = DateTimePickerFormat.Long;
        }

        private void dtimeTNPermitToDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format property to default format
            dtimeTNPermitToDate.Format = DateTimePickerFormat.Long;
        }

        private void dtimeKLPermitFromDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format property to default format
            dtimeKLPermitFromDate.Format = DateTimePickerFormat.Long;
        }

        private void dtimeKLPermitToDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format property to default format
            dtimeKLPermitToDate.Format = DateTimePickerFormat.Long;
        }

        private void dtimeFCFromDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format property to default format
            dtimeFCFromDate.Format = DateTimePickerFormat.Long;
        }

        private void dtimeFCToDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format property to default format
            dtimeFCToDate.Format = DateTimePickerFormat.Long;
        }

        private void dtimeInsuranceToDate_ValueChanged(object sender, EventArgs e)
        {
            // Set the Format property to default format
            dtimeInsuranceToDate.Format = DateTimePickerFormat.Long;
        }

        private void frmTaxDates_Load(object sender, EventArgs e)
        {
            //calling the function to hide the tax dates that are not applicable
            hideTaxDates();

            //calling addHeading function and passing the vehicle number parameter
            AddHeading(vehicleNo);

            //calling function To reset the datetimePicker 
            reSetDateTimePicker();
            

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //to assign the all selected date time to globalvariable
            insuranceFromDate = dtimeInsuranceFromDate.Text;
            insuranceToDate = dtimeInsuranceToDate.Text;

            fcFromDate = dtimeFCFromDate.Text;
            fcToDate = dtimeFCToDate.Text;

            pollutionTaxFromDate = dtimePollutionTaxFromDate.Text;
            pollutionTaxToDate = dtimePollutionTaxToDate.Text;

            advtTaxFromDate = dtimeAdvtTaxFromDate.Text;
            advtTaxToDate = dtimeAdvtTaxToDate.Text;

            tnTaxFromDate = dtimeTNTaxFromDate.Text;
            tnTaxToDate = dtimeTNTaxToDate.Text;

            klTaxFromDate = dtimeKLTaxFromDate.Text;
            klTaxToDate = dtimeKLTaxToDate.Text;

            tnPermitFromDate = dtimeTNPermitFromDate.Text;
            tnPermitToDate = dtimeTNPermitToDate.Text;

            klPermitFromDate = dtimeKLPermitFromDate.Text;
            klPermitToDate = dtimeKLPermitToDate.Text;

            //to close popup after getting values
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //to close popup after getting values
            this.Close();
        }
    }
}

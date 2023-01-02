using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//for sql operations
using System.IO;//to access the files in system
using System.Configuration;

namespace CowmaVehicle
{
    public partial class vehicleMaster : Form
    {
        public static string VehicleNo;//to get the vehicle no to all forms
        SqlConnection con;//using the con variable sql connection can accessd
        ErrorHandler objErrorHandler = new ErrorHandler();
        string userName = loginForm.userName;//track the user name
        string rbresult;//global variable radio button result
        //assigning the minium date value to minDateTime variable
        DateTime minDateTime = new DateTime(1800,01,01);
        List<Image> imageList = new List<Image>();//global image list variable

        //set default chechBox variable satus to false
        public static bool chkBoxInsuranceStatus = false;
        public static bool chkBoxFCStatus = false;
        public static bool chkBoxPollutionStatus = false;
        public static bool chkBoxAdvtTaxStatus = false;
        public static bool chkBoxTNTaxStatus = false;
        public static bool chkBoxKLTaxStatus = false;
        public static bool chkBoxTNPermitStatus = false;
        public static bool chkBoxKLPermitStatus = false;

        public vehicleMaster()
        {
            InitializeComponent();
        }
        
        private void loadDataToDataGridDataGridView()
        {

            con.Open();

            // Create a command to retrieve the data from the database
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[tblVehicleMaster]", con);
            
            // Use a DataAdapter to fill a DataTable with the data
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // Set the DataGridView's DataSource to the DataTable
            dataGridView1.DataSource = table;
            
            // Set the Visible property of the [vehicleNo], [vehicleModel], [regDate], and [location] columns to true, and set the Visible property of all other columns to false
            dataGridView1.Columns["vehicleNo"].Visible = true;
            dataGridView1.Columns["vehicleModel"].Visible = true;
            dataGridView1.Columns["regDate"].Visible = true;
            dataGridView1.Columns["location"].Visible = true;

            //Setting the Header name
            dataGridView1.Columns["vehicleNo"].HeaderText = "Vehicle No";
            dataGridView1.Columns["vehicleModel"].HeaderText = "Model";
            dataGridView1.Columns["regDate"].HeaderText = "Registration";
            dataGridView1.Columns["location"].HeaderText = "Location";

            //To align the header to center
            dataGridView1.Columns["vehicleNo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["vehicleModel"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["regDate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["location"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            //to change the header font etc
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);

            //hiding other coloumns
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name != "vehicleNo" && column.Name != "vehicleModel" && column.Name != "regDate" && column.Name != "location")
                {
                    column.Visible = false;
                }
            }

            //setting row hight for all
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 30;
            }
            //setting column width and alignment for all cells
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dataGridView1.Columns[column.Index].Width = 141;
                dataGridView1.Columns[column.Index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            //to set the color and font for all content
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.Font=new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            dataGridView1.RowTemplate.Height = 30;
            
            //to set the color and font for 1st column
            dataGridView1.Columns[1].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13.0F, FontStyle.Bold);
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Black;

            //to select the entire row
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //make the dataGridView Only readable
            dataGridView1.ReadOnly = true;

            con.Close();
        }

        private void loadDataToComboboxes()//function to load data the all comboboxes from data base
        {
            //creating queries to delect datas from table
            String query1 = "select * from tblVehicleWheelSize";
            String query2 = "select * from tblVehicleType";
            String query3 = "select * from tblVehicleFuelType";
            String query4 = "select * from tblVehicleLocation";

            //creating comand for all combobox
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlCommand cmd3 = new SqlCommand(query3, con);
            SqlCommand cmd4 = new SqlCommand(query4, con);

            //opening sql connection
            con.Open();

            //loading the datas to all comboboxes from data base
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                comBoxFittingWheelSize.Items.Add(reader1["wheelSize"].ToString());
            }

            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                comBoxVehicleType.Items.Add(reader2["vehicleType"].ToString());
            }

            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                comBoxFuelType.Items.Add(reader3["fuelType"].ToString());
            }

            SqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                comBoxLocation.Items.Add(reader4["locations"].ToString());
            }
            //closing sql connection
            con.Close();
        }

        private void clear_data()//function to clear the all text box values and reset others
        {
            txtVehicleNo.Text = "";
            txtVehicleModel.Text = "";
            txtWheelCount.Text = "";
            comBoxFittingWheelSize.SelectedItem = "SELECT";
            comBoxVehicleType.SelectedItem = "SELECT";
            comBoxFuelType.SelectedItem = "SELECT";
            rdbtnOld.Checked = false;
            rdbtnNew.Checked = false;
            txtRCDetails.Text = "";
            txtKMsDriven.Text = "";
            txtMileagePerLtr.Text = "";
            comBoxLocation.SelectedItem = "SELECT";
            foreach (CheckBox checkBox in this.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = false;
            }
            listView1.Items.Clear();
            pictureBox1.Image = null;
        }

        private void readOnly()//function to set only view
        {
            txtVehicleNo.Enabled = false;
            txtVehicleModel.Enabled = false;
            txtWheelCount.Enabled = false;
            comBoxFittingWheelSize.Enabled = false;
            comBoxVehicleType.Enabled = false;
            comBoxFuelType.Enabled = false;
            dtimeRegistrationDate.Enabled = false;
            dtimePurchasedDate.Enabled = false;
            rdbtnOld.Enabled = false;
            rdbtnNew.Enabled = false;
            txtRCDetails.Enabled = false;
            txtKMsDriven.Enabled = false;
            txtMileagePerLtr.Enabled = false;
            comBoxLocation.Enabled = false;

            foreach (CheckBox checkBox in this.Controls.OfType<CheckBox>())
            {
                checkBox.Enabled = false;
            }
            listView1.Enabled = false;
            pictureBox1.Enabled = false;
        }

        int currentImageIndex = 0;//global variable for image index
        private void DisplayNextImage()//function to display next image
        {
            if (currentImageIndex < imageList.Count - 1)
            {
                currentImageIndex++;
                pictureBox1.Image = imageList[currentImageIndex];
            }
        }

        private void DisplayPreviousImage()//function to display previous image
        {
            if (currentImageIndex > 0)
            {
                currentImageIndex--;
                pictureBox1.Image = imageList[currentImageIndex];
            }
        }

        private void btnUploadVehiclePhotos_Click(object sender, EventArgs e)//to upload images files from syatem
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                openFileDialog1.Title = "Select image files";
                openFileDialog1.Multiselect = true;// to get multiple photos selected

                imageList.Clear();//clearing global imagelist
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //taking multiple images
                    foreach (string fileName in openFileDialog1.FileNames)
                    {
                        Image image = Image.FromFile(fileName);
                        Image tempImage = (Image)image.Clone();

                        ListViewItem item = new ListViewItem(fileName);
                        listView1.Items.Add(item);

                        // Add the image to a list of images
                        imageList.Add(tempImage);
                    }
                    //adding column
                    listView1.Columns.Add("PHOTOS LIST", 500, HorizontalAlignment.Left);
                    listView1.View = View.Details;//to align file names
                    listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;

                    //to fit the image into picture box
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    // Set the PictureBox's image to the first image in the list
                    pictureBox1.Image = imageList[0];
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Your file is missing");
                MessageBox.Show(es.Message);
            }
        }
        private void btnNextImage_Click(object sender, EventArgs e)//to show the next Images in pictureBox
        {
            
            DisplayNextImage();//calling function to show next image
        }

        private void btnPreviousImage_Click(object sender, EventArgs e)//to show the Previous Images in pictureBox
        {
            
            DisplayPreviousImage();//calling the function to show next image
        }

        private void btnClose_Click(object sender, EventArgs e)//to close the program
        {
            Application.Exit();//to close the program
        }

        private void btnSave_Click(object sender, EventArgs e)//to save all the details to data base
        {
            //if statement to fill all fields
            if (!string.IsNullOrWhiteSpace(txtVehicleNo.Text) &&
                !string.IsNullOrWhiteSpace(txtVehicleModel.Text) &&
                !string.IsNullOrWhiteSpace(txtWheelCount.Text) &&
                (comBoxFittingWheelSize.Text != "SELECT") &&
                (comBoxVehicleType.Text != "SELECT") &&
                (comBoxFuelType.Text != "SELECT") &&
                !string.IsNullOrWhiteSpace(txtRCDetails.Text) &&
                !string.IsNullOrWhiteSpace(txtKMsDriven.Text) &&
                !string.IsNullOrWhiteSpace(txtMileagePerLtr.Text) &&
                (comBoxLocation.Text != "SELECT") &&
                (rdbtnNew.Checked || rdbtnOld.Checked))
            {
                //to get the next service kMs in this variables
                string engineOilKMs = frmNextServiceDetails.engineOilKMs;
                string gearAndCrownOilKMs = frmNextServiceDetails.gearAndCrownOilKMs;
                string wheelGreaseKMs = frmNextServiceDetails.wheelGreaseKMs;
                string clutchPlateKMs = frmNextServiceDetails.clutchPlateKMs;
                string breakeLineKMs = frmNextServiceDetails.breakeLineKMs;

                //to get tax dates in this variables
                string insurance = "Insurance";
                DateTime insuranceFromDate;
                if (frmTaxDates.insuranceFromDate == "From")
                {
                    insuranceFromDate = minDateTime;
                }
                else
                {
                    insuranceFromDate = Convert.ToDateTime(frmTaxDates.insuranceFromDate);
                }
                DateTime insuranceToDate;

                if (frmTaxDates.insuranceToDate == "To")

                {
                    insuranceToDate = minDateTime;
                }
                    else
                {
                    insuranceToDate = Convert.ToDateTime(frmTaxDates.insuranceToDate);
                }
                
                string fc = "FC";
                DateTime fcFromDate;
                if (frmTaxDates.fcFromDate == "From")
                {
                    fcFromDate = minDateTime;
                }
                else
                {
                    fcFromDate = Convert.ToDateTime(frmTaxDates.fcFromDate);
                }
                DateTime fcToDate;

                if (frmTaxDates.fcToDate == "To")

                {
                    fcToDate = minDateTime;
                }
                else
                {
                    fcToDate = Convert.ToDateTime(frmTaxDates.fcToDate);
                }
                
                string pollution = "Pollution";
                DateTime pollutionTaxFromDate;
                if (frmTaxDates.pollutionTaxFromDate == "From")
                {
                    pollutionTaxFromDate = minDateTime;
                }
                else
                {
                    pollutionTaxFromDate = Convert.ToDateTime(frmTaxDates.pollutionTaxFromDate);
                }
                DateTime pollutionTaxToDate;

                if (frmTaxDates.pollutionTaxToDate == "To")

                {
                    pollutionTaxToDate = minDateTime;
                }
                else
                {
                    pollutionTaxToDate = Convert.ToDateTime(frmTaxDates.pollutionTaxToDate);
                }

                string advt = "Advt";
                DateTime advtTaxFromDate;
                if (frmTaxDates.advtTaxFromDate == "From")
                {
                    advtTaxFromDate = minDateTime;
                }
                else
                {
                    advtTaxFromDate = Convert.ToDateTime(frmTaxDates.advtTaxFromDate);
                }
                DateTime advtTaxToDate;

                if (frmTaxDates.advtTaxToDate == "To")

                {
                    advtTaxToDate = minDateTime;
                }
                else
                {
                    advtTaxToDate = Convert.ToDateTime(frmTaxDates.advtTaxToDate);
                }

                string tnTax = "TnTax";
                DateTime tnTaxFromDate;
                if (frmTaxDates.tnTaxFromDate == "From")
                {
                    tnTaxFromDate = minDateTime;
                }
                else
                {
                    tnTaxFromDate = Convert.ToDateTime(frmTaxDates.tnTaxFromDate);
                }
                DateTime tnTaxToDate;

                if (frmTaxDates.tnTaxToDate == "To")

                {
                    tnTaxToDate = minDateTime;
                }
                else
                {
                    tnTaxToDate = Convert.ToDateTime(frmTaxDates.tnTaxToDate);
                }

                string klTax = "KlTax";
                DateTime klTaxFromDate;
                if (frmTaxDates.klTaxFromDate == "From")
                {
                    klTaxFromDate = minDateTime;
                }
                else
                {
                    klTaxFromDate = Convert.ToDateTime(frmTaxDates.klTaxFromDate);
                }
                DateTime klTaxToDate;

                if (frmTaxDates.klTaxToDate == "To")

                {
                    klTaxToDate = minDateTime;
                }
                else
                {
                    klTaxToDate = Convert.ToDateTime(frmTaxDates.klTaxToDate);
                }

                string tnPermit = "TnPermit";
                DateTime tnPermitFromDate;
                if (frmTaxDates.tnPermitFromDate == "From")
                {
                    tnPermitFromDate = minDateTime;
                }
                else
                {
                    tnPermitFromDate = Convert.ToDateTime(frmTaxDates.tnPermitFromDate);
                }
                DateTime tnPermitToDate;

                if (frmTaxDates.tnPermitToDate == "To")

                {
                    tnPermitToDate = minDateTime;
                }
                else
                {
                    tnPermitToDate = Convert.ToDateTime(frmTaxDates.tnPermitToDate);
                }

                string klPermit = "KlPermit";
                DateTime klPermitFromDate;
                if (frmTaxDates.klPermitFromDate == "From")
                {
                    klPermitFromDate = minDateTime;
                }
                else
                {
                    klPermitFromDate = Convert.ToDateTime(frmTaxDates.klPermitFromDate);
                }
                DateTime klPermitToDate;

                if (frmTaxDates.klPermitToDate == "To")

                {
                    klPermitToDate = minDateTime;
                }
                else
                {
                    klPermitToDate = Convert.ToDateTime(frmTaxDates.klPermitToDate);
                }

                con.Open();//sql connection opens here

                SqlTransaction transaction = con.BeginTransaction();//transaction begin here

                try
                {
                    // Define a DataTable to hold the values to insert
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("vehicleNo");
                    dataTable.Columns.Add("tax");
                    dataTable.Columns.Add("fDate");
                    dataTable.Columns.Add("tDate");
                    dataTable.Columns.Add("createdBy");
                    dataTable.Columns.Add("createdOn");
                    dataTable.Columns.Add("modifiedBy");
                    dataTable.Columns.Add("modifiedOn");
                    dataTable.Columns.Add("isDeleted");

                    // Add the values to the DataTable
                    dataTable.Rows.Add(VehicleNo,insurance, insuranceFromDate, insuranceToDate,userName,DateTime.Now,userName,DateTime.Now,1);
                    dataTable.Rows.Add(VehicleNo,fc, fcFromDate, fcToDate, userName, DateTime.Now, userName, DateTime.Now, 1);
                    dataTable.Rows.Add(VehicleNo,pollution, pollutionTaxFromDate, pollutionTaxToDate, userName, DateTime.Now, userName, DateTime.Now, 1);
                    dataTable.Rows.Add(VehicleNo,advt, advtTaxFromDate, advtTaxToDate, userName, DateTime.Now, userName, DateTime.Now, 1);
                    dataTable.Rows.Add(VehicleNo,tnTax, tnTaxFromDate, tnTaxToDate, userName, DateTime.Now, userName, DateTime.Now, 1);
                    dataTable.Rows.Add(VehicleNo,klTax, klTaxFromDate, klTaxToDate, userName, DateTime.Now, userName, DateTime.Now, 1);
                    dataTable.Rows.Add(VehicleNo,tnPermit, tnPermitFromDate, tnPermitToDate, userName, DateTime.Now, userName, DateTime.Now, 1);
                    dataTable.Rows.Add(VehicleNo,klPermit, klPermitFromDate, klPermitToDate, userName, DateTime.Now, userName, DateTime.Now, 1);

                    // Use the SqlBulkCopy class to insert the data from the DataTable into the database
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(con, SqlBulkCopyOptions.Default, transaction))
                    {
                        bulkCopy.DestinationTableName = "tblTaxDates";
                        
                        bulkCopy.ColumnMappings.Add("vehicleNo", "vehicleNo");
                        bulkCopy.ColumnMappings.Add("tax", "tax");
                        bulkCopy.ColumnMappings.Add("fDate", "fDate");
                        bulkCopy.ColumnMappings.Add("tDate", "tDate");
                        bulkCopy.ColumnMappings.Add("createdBy", "createdBy");
                        bulkCopy.ColumnMappings.Add("createdOn", "createdOn");
                        bulkCopy.ColumnMappings.Add("modifiedBy", "modifiedBy");
                        bulkCopy.ColumnMappings.Add("modifiedOn", "modifiedOn");
                        bulkCopy.ColumnMappings.Add("isDeleted", "isDeleted");

                        bulkCopy.WriteToServer(dataTable);
                    }



                    if (rdbtnNew.Checked == true)//to get the radio button value
                    {
                        rbresult = "1";
                    }
                    else if (rdbtnOld.Checked == true)
                    {
                        rbresult = "0";
                    }
                    SqlCommand command = new SqlCommand("insert_VehicleMaster", con, transaction);//using storeProcedure the datas are inserting

                    command.CommandType = CommandType.StoredProcedure;

                    //--inserting data to tblVehicleMaster
                    command.Parameters.AddWithValue("@vehicleNo", txtVehicleNo.Text);
                    command.Parameters.AddWithValue("@vehicleModel", txtVehicleModel.Text);
                    command.Parameters.AddWithValue("@wheelCount", txtWheelCount.Text);
                    command.Parameters.AddWithValue("@wheelSize", comBoxFittingWheelSize.Text);
                    command.Parameters.AddWithValue("@vehicleType", comBoxVehicleType.Text);
                    command.Parameters.AddWithValue("@fuelType", comBoxFuelType.Text);
                    command.Parameters.AddWithValue("@regDate", dtimeRegistrationDate.Text);
                    command.Parameters.AddWithValue("@purchDate", dtimePurchasedDate.Text);
                    command.Parameters.AddWithValue("@oldNew", rbresult);
                    command.Parameters.AddWithValue("@rcDetails", txtRCDetails.Text);
                    command.Parameters.AddWithValue("@kmDriven", txtKMsDriven.Text);
                    command.Parameters.AddWithValue("@mileage", txtMileagePerLtr.Text);
                    command.Parameters.AddWithValue("@location", comBoxLocation.Text);
                    command.Parameters.AddWithValue("@createdBy", userName);
                    command.Parameters.AddWithValue("@modifiedBy", userName);
                    command.Parameters.AddWithValue("@isDeleted", 1);

                    //inserting data to tblVehicleTax
                    command.Parameters.AddWithValue("@fc", SqlDbType.Bit).Value = chkBoxFC.Checked;
                    command.Parameters.AddWithValue("@insurance", SqlDbType.Bit).Value = chkBoxInsurance.Checked;
                    command.Parameters.AddWithValue("@pollution", SqlDbType.Bit).Value = chkBoxPollutionn.Checked;
                    command.Parameters.AddWithValue("@tnTax", SqlDbType.Bit).Value = chkBoxTNTax.Checked;
                    command.Parameters.AddWithValue("@klTax", SqlDbType.Bit).Value = chkBoxKLTax.Checked;
                    command.Parameters.AddWithValue("@advtTax", SqlDbType.Bit).Value = chkBoxAdvtTax.Checked;
                    command.Parameters.AddWithValue("@tnPermit", SqlDbType.Bit).Value = chkBoxTNPermit.Checked;
                    command.Parameters.AddWithValue("@klPermit", SqlDbType.Bit).Value = chkBoxKLPermit.Checked;

                    //first stored procedures commands are executing
                    command.ExecuteNonQuery();

                    try//to catch the image inserting error
                    {
                        //using image stored procedure
                        SqlCommand command1 = new SqlCommand("insert_VehicleImages", con, transaction);//using storeProcedure the datas are inserting

                        command1.CommandType = CommandType.StoredProcedure;
                        foreach (Image image in imageList)
                        {
                            //creating memory for image
                            using (MemoryStream ms = new MemoryStream())
                            {
                                image.Save(ms, image.RawFormat);
                                byte[] imageData = ms.ToArray();

                                command1.Parameters.Clear();
                                // Insert the image into the database using parameters
                                command1.Parameters.AddWithValue("@vehicleNo", txtVehicleNo.Text);
                                command1.Parameters.AddWithValue("@images", imageData);
                                command1.Parameters.AddWithValue("@createdBy", userName);
                                command1.Parameters.AddWithValue("@modifiedBy", userName);
                                command1.Parameters.AddWithValue("@isDeleted", 1);
                                command1.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (FileNotFoundException)//if the image file is not found the error is catched
                    {
                        MessageBox.Show("Image File Not Found in the Syatem");
                        throw new Exception();
                    }

                    SqlCommand command2 = new SqlCommand("insert_tblNextServiceKms", con, transaction);//using storeProcedure the datas are inserting

                    command2.CommandType = CommandType.StoredProcedure;

                    //--inserting data to tblVehicleMaster
                    command2.Parameters.AddWithValue("@vehicleNo", txtVehicleNo.Text);
                    command2.Parameters.AddWithValue("@engineOilKms", engineOilKMs);
                    command2.Parameters.AddWithValue("@gearOilKms", gearAndCrownOilKMs);
                    command2.Parameters.AddWithValue("@greaseKms", wheelGreaseKMs);
                    command2.Parameters.AddWithValue("@clutchKms", clutchPlateKMs);
                    command2.Parameters.AddWithValue("@breakKms", breakeLineKMs);
                    command2.Parameters.AddWithValue("@createdBy", userName);
                    command2.Parameters.AddWithValue("@modifiedBy", userName);
                    command2.Parameters.AddWithValue("@isDeleted", 1);


                    //first stored procedures commands are executing
                    command2.ExecuteNonQuery();

                    transaction.Commit();//to comitt all transaction
                    MessageBox.Show("Data's Saved Sucessfully");

                    con.Close();//sql connection closed here
                    clear_data();//function to reset all text boxs and others

                }
                catch (Exception ex)//if there is any error in transaction it throw error and rollbacked
                {
                    MessageBox.Show(ex.Message);
                    Console.WriteLine("Error: " + ex.Message);
                    transaction.Rollback();
                    con.Close();
                }
            }

            else
            {
                MessageBox.Show("Please Provide All Details");
            }
        }

        private void vehicleMaster_Load(object sender, EventArgs e)
        {
            try
            {
                //to store the connection details in con string
                string strcon = ConfigurationManager.ConnectionStrings["DatLocation"].ConnectionString;
                con = new SqlConnection(strcon);

                //calling the function to load the data into all comboboxes
                loadDataToComboboxes();

                //calling function to clear if any previous data in the form
                clear_data();

                //calling function to load the data from dataBase to DataGridView
                loadDataToDataGridDataGridView();

                readOnly();

            }
            catch (Exception objException)//to catch errors in the connection
            {
                objErrorHandler.ErrorMsg = objException;
                objErrorHandler.CreateLog();
                MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(objException.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void txtVehicleNo_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Check if the character is a capital letter or a number
            if (!char.IsLetter(e.KeyChar) && !char.IsUpper(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Cancel the key press
                e.Handled = true;
            }

            // Check if the character is a lower case letter
            if (char.IsLetter(e.KeyChar) && char.IsLower(e.KeyChar))
            {
                // Convert the character to upper case
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }


        //to get only numarical values
        private void txtWheelCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKMsDriven_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMileagePerLtr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void comBoxLocation_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void comBoxLocation_Click(object sender, EventArgs e)
        {

        }

        private void btnClickHereToAddNextServiceKMs_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtVehicleNo.Text))//to provide vehicle number
            {
                VehicleNo = txtVehicleNo.Text;

                // Create an instance of the pop-up form
                frmNextServiceDetails popup = new frmNextServiceDetails();

                //to hide all the close,mnimize and maximize controls
                popup.ControlBox = false;
                popup.MinimizeBox = false;
                popup.MaximizeBox = false;

                // Show the pop-up form as a modal dialog box
                popup.ShowDialog();
            }

            else
            {
                MessageBox.Show("Please Provide Vehicle Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClickToAddTaxDates_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtVehicleNo.Text))//to provide vehicle number
            {
                VehicleNo = txtVehicleNo.Text;

                // Create an instance of the pop-up form
                frmTaxDates popup = new frmTaxDates();

                //to hide all the close,mnimize and maximize controls
                popup.ControlBox = false;
                popup.MinimizeBox = false;
                popup.MaximizeBox = false;

                // Show the pop-up form as a modal dialog box
                popup.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Provide Vehicle Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //get the status of all ckeck box
        private void chkBoxFC_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxFC.Checked == true)
            {
                chkBoxFCStatus = true;
            }
            else
            {
                chkBoxFCStatus = false;
            }
        }

        private void chkBoxInsurance_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxInsurance.Checked == true)
            {
                chkBoxInsuranceStatus = true;
            }
            else
            {
                chkBoxInsuranceStatus = false;
            }
        }

        private void chkBoxPollution_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxPollutionn.Checked == true)
            {
                chkBoxPollutionStatus = true;
            }
            else
            {
                chkBoxPollutionStatus = false;
            }
        }

        private void chkBoxTNTax_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxTNTax.Checked == true)
            {
                chkBoxTNTaxStatus = true;
            }
            else
            {
                chkBoxTNTaxStatus = false;
            }
        }

        private void chkBoxKLTax_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxKLTax.Checked == true)
            {
                chkBoxKLTaxStatus = true;
            }
            else
            {
                chkBoxKLTaxStatus = false;
            }
        }

        private void chkBoxAdvtTax_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxAdvtTax.Checked == true)
            {
                chkBoxAdvtTaxStatus = true;
            }
            else
            {
                chkBoxAdvtTaxStatus = false;
            }
        }

        private void chkBoxTNPermit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxTNPermit.Checked == true)
            {
                chkBoxTNPermitStatus = true;
            }
            else
            {
                chkBoxTNPermitStatus = false;
            }
        }

        private void chkBoxKLPermit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxKLPermit.Checked == true)
            {
                chkBoxKLPermitStatus = true;
            }
            else
            {
                chkBoxKLPermitStatus = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {//to insert the values in main form ,from data base
                string vehicleNoClick = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                con.Open();

                // Use the ID to query the database for additional information
                string query = "SELECT * FROM tblVehicleTax WHERE vehicleNo = @ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", vehicleNoClick);

                // Use a DataAdapter and DataSet to retrieve the data
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                // Get the first table from the DataSet (there should only be one)
                DataTable dataTable = dataSet.Tables[0];

                //load data to current form, from data base
                txtVehicleNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtVehicleModel.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtWheelCount.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                comBoxFittingWheelSize.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                comBoxVehicleType.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                comBoxFuelType.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                dtimeRegistrationDate.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                dtimePurchasedDate.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                string btn = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                if (btn == "1")// to get radioButton value from database
                {
                    rdbtnNew.Checked = true;
                }
                else
                {
                    rdbtnOld.Checked = true;
                }
                txtRCDetails.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtKMsDriven.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtMileagePerLtr.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                comBoxLocation.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                
                //to check the check box status from data base
                if (dataTable.Rows.Count > 0)
                {
                    if (dataTable.Rows[0]["fc"].ToString()=="True")//data table returns true or false becaus it saved as bits types
                    {
                        chkBoxFC.Checked = true;
                    }
                    else { chkBoxFC.Checked = false; }

                    if (dataTable.Rows[0]["insurance"].ToString() == "True")
                    {
                        chkBoxInsurance.Checked = true;
                    }
                    else { chkBoxInsurance.Checked = false; }

                    if (dataTable.Rows[0]["pollution"].ToString() == "True")
                    {
                        chkBoxPollutionn.Checked = true;
                    }
                    else { chkBoxPollutionn.Checked = false; }

                    if (dataTable.Rows[0]["tnTax"].ToString() == "True")
                    {
                        chkBoxTNTax.Checked = true;
                    }
                    else { chkBoxTNTax.Checked = false; }

                    if (dataTable.Rows[0]["klTax"].ToString() == "Trur")
                    {
                        chkBoxKLTax.Checked = true;
                    }
                    else { chkBoxKLTax.Checked = false; }

                    if (dataTable.Rows[0]["advtTax"].ToString() == "True")
                    {
                        chkBoxAdvtTax.Checked = true;
                    }
                    else{ chkBoxAdvtTax.Checked = false; }

                    if (dataTable.Rows[0]["tnPermit"].ToString() == "True")
                    {
                       chkBoxTNPermit.Checked = true;
                    }
                    else { chkBoxTNPermit.Checked = false; }

                    if (dataTable.Rows[0]["klPermit"].ToString() == "True")
                    {
                        chkBoxKLPermit.Checked = true;
                    }
                    else { chkBoxKLPermit.Checked = false; }
                }

                con.Close();//closing the connection
            }

            catch (Exception es)
            {
                MessageBox.Show("Please Click The Content Or Vehicle No");
                con.Close();
            }

            try
            {//to get the images to picture box from database
                string vehicleNoClick = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                //clearing both imagelist and listview if any privious content
                imageList.Clear();
                listView1.Clear();
                //setting image index to zero to show next and privious image
                currentImageIndex = 0;

                List<byte[]> imageDataList = new List<byte[]>();//creating new byte list to get image from data base

                con.Open();

                // Use the ID to query the database for additional information
                string query = "SELECT * FROM tblVehicleImages WHERE vehicleNo = @ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", vehicleNoClick);

                SqlDataReader reader = cmd.ExecuteReader();//creating data reader
                while (reader.Read())
                {
                    imageDataList.Add((byte[])reader["images"]);
                }
                int index = 1;
                foreach (byte[] imageData in imageDataList)
                {
                    MemoryStream ms = new MemoryStream(imageData);
                    Image image = Image.FromStream(ms);
                    imageList.Add(image);
                    ListViewItem item = new ListViewItem("Vehicle Image "+index );//adding name to the list view
                    listView1.Items.Add(item);
                    index++;
                }
                listView1.Columns.Add("PHOTOS LIST", 500, HorizontalAlignment.Left);
                listView1.View = View.Details;//to align file names
                listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;

                //to fit the image into picture box
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                // Set the PictureBox's image to the first image in the list
                pictureBox1.Image = imageList[0];
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show("Please Click The Content Or Vehicle No");
                con.Close();
            }

            try
            {//to get the values to nextServiceDetailsForm from data base
                string vehicleNoClick = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                con.Open();

                // Use the ID to query the database for additional information
                string query = "SELECT * FROM tblNextServiceKms WHERE vehicleNo = @ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", vehicleNoClick);

                // Use a DataAdapter and DataSet to retrieve the data
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                // Get the first table from the DataSet (there should only be one)
                DataTable dataTable = dataSet.Tables[0];
                //load the data to the variable on the another form
                foreach (DataRow row in dataTable.Rows)
                {
                    frmNextServiceDetails.engineOilKMs = row["engineOilKms"].ToString();
                    frmNextServiceDetails.gearAndCrownOilKMs = row["gearOilKms"].ToString();
                    frmNextServiceDetails.wheelGreaseKMs = row["greaseKms"].ToString();
                    frmNextServiceDetails.clutchPlateKMs = row["clutchKms"].ToString();
                    frmNextServiceDetails.breakeLineKMs = row["breakKms"].ToString();
                }
                con.Close();
            }
            catch(Exception es)
            {
                MessageBox.Show("Please Click The Content Or Vehicle No");
                con.Close();
            }

            try
            {//to get the values to taxdates form, from data base
                
                string vehicleNoClick = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                con.Open();

                // Use the ID to query the database for additional information
                string query = "SELECT * FROM tblTaxDates WHERE vehicleNo = @ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", vehicleNoClick);

                // Use a DataAdapter and DataSet to retrieve the data
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                // Get the first table from the DataSet (there should only be one)
                DataTable dataTable = dataSet.Tables[0];

                if (dataTable.Rows.Count > 0)
                {
                    //loading the data to the variable to another form
                    frmTaxDates.insuranceFromDate = dataTable.Rows[0]["fDate"].ToString();
                    frmTaxDates.insuranceToDate = dataTable.Rows[0]["tDate"].ToString();
                    frmTaxDates.fcFromDate = dataTable.Rows[1]["fDate"].ToString();
                    frmTaxDates.fcToDate = dataTable.Rows[1]["tDate"].ToString();
                    frmTaxDates.pollutionTaxFromDate = dataTable.Rows[2]["fDate"].ToString();
                    frmTaxDates.pollutionTaxToDate = dataTable.Rows[2]["tDate"].ToString();
                    frmTaxDates.advtTaxFromDate = dataTable.Rows[3]["fDate"].ToString();
                    frmTaxDates.advtTaxToDate = dataTable.Rows[3]["tDate"].ToString();
                    frmTaxDates.tnTaxFromDate = dataTable.Rows[4]["fDate"].ToString();
                    frmTaxDates.tnTaxToDate = dataTable.Rows[4]["tDate"].ToString();
                    frmTaxDates.klTaxFromDate = dataTable.Rows[5]["fDate"].ToString();
                    frmTaxDates.klTaxToDate = dataTable.Rows[5]["tDate"].ToString();
                    frmTaxDates.tnPermitFromDate = dataTable.Rows[6]["fDate"].ToString();
                    frmTaxDates.tnPermitToDate = dataTable.Rows[6]["tDate"].ToString();
                    frmTaxDates.klPermitFromDate = dataTable.Rows[7]["fDate"].ToString();
                    frmTaxDates.klPermitToDate = dataTable.Rows[7]["tDate"].ToString();
                }
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show("Please Click The Content Or Vehicle No");
                con.Close();
            }
        }




    }
}


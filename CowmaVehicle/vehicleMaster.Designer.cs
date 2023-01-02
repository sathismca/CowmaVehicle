namespace CowmaVehicle
{
    partial class vehicleMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUploadVehiclePhotos = new System.Windows.Forms.Button();
            this.dtimeRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.rdbtnNew = new System.Windows.Forms.RadioButton();
            this.comBoxVehicleType = new System.Windows.Forms.ComboBox();
            this.chkBoxFC = new System.Windows.Forms.CheckBox();
            this.txtWheelCount = new System.Windows.Forms.TextBox();
            this.txtVehicleModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comBoxFuelType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtimePurchasedDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbtnOld = new System.Windows.Forms.RadioButton();
            this.txtRCDetails = new System.Windows.Forms.TextBox();
            this.txtKMsDriven = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMileagePerLtr = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comBoxLocation = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chkBoxAdvtTax = new System.Windows.Forms.CheckBox();
            this.chkBoxInsurance = new System.Windows.Forms.CheckBox();
            this.chkBoxPollutionn = new System.Windows.Forms.CheckBox();
            this.chkBoxKLPermit = new System.Windows.Forms.CheckBox();
            this.chkBoxKLTax = new System.Windows.Forms.CheckBox();
            this.chkBoxTNPermit = new System.Windows.Forms.CheckBox();
            this.chkBoxTNTax = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClickHereToAddNextServiceKMs = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comBoxFittingWheelSize = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearchVehicleNo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.btnPreviousImage = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClickToAddTaxDates = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleNo.Location = new System.Drawing.Point(271, 18);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(250, 31);
            this.txtVehicleNo.TabIndex = 0;
            this.txtVehicleNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVehicleNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle No.";
            // 
            // btnUploadVehiclePhotos
            // 
            this.btnUploadVehiclePhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadVehiclePhotos.Location = new System.Drawing.Point(711, 548);
            this.btnUploadVehiclePhotos.Name = "btnUploadVehiclePhotos";
            this.btnUploadVehiclePhotos.Size = new System.Drawing.Size(173, 48);
            this.btnUploadVehiclePhotos.TabIndex = 2;
            this.btnUploadVehiclePhotos.Text = "Upload Vehicle Photos";
            this.btnUploadVehiclePhotos.UseVisualStyleBackColor = true;
            this.btnUploadVehiclePhotos.Click += new System.EventHandler(this.btnUploadVehiclePhotos_Click);
            // 
            // dtimeRegistrationDate
            // 
            this.dtimeRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeRegistrationDate.Location = new System.Drawing.Point(271, 220);
            this.dtimeRegistrationDate.Name = "dtimeRegistrationDate";
            this.dtimeRegistrationDate.Size = new System.Drawing.Size(250, 31);
            this.dtimeRegistrationDate.TabIndex = 3;
            // 
            // rdbtnNew
            // 
            this.rdbtnNew.AutoSize = true;
            this.rdbtnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnNew.Location = new System.Drawing.Point(271, 287);
            this.rdbtnNew.Name = "rdbtnNew";
            this.rdbtnNew.Size = new System.Drawing.Size(72, 29);
            this.rdbtnNew.TabIndex = 4;
            this.rdbtnNew.TabStop = true;
            this.rdbtnNew.Text = "New";
            this.rdbtnNew.UseVisualStyleBackColor = true;
            // 
            // comBoxVehicleType
            // 
            this.comBoxVehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxVehicleType.FormattingEnabled = true;
            this.comBoxVehicleType.Location = new System.Drawing.Point(271, 150);
            this.comBoxVehicleType.Name = "comBoxVehicleType";
            this.comBoxVehicleType.Size = new System.Drawing.Size(250, 33);
            this.comBoxVehicleType.TabIndex = 5;
            // 
            // chkBoxFC
            // 
            this.chkBoxFC.AutoSize = true;
            this.chkBoxFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxFC.Location = new System.Drawing.Point(271, 495);
            this.chkBoxFC.Name = "chkBoxFC";
            this.chkBoxFC.Size = new System.Drawing.Size(65, 29);
            this.chkBoxFC.TabIndex = 6;
            this.chkBoxFC.Text = "F.C";
            this.chkBoxFC.UseVisualStyleBackColor = true;
            this.chkBoxFC.CheckedChanged += new System.EventHandler(this.chkBoxFC_CheckedChanged);
            // 
            // txtWheelCount
            // 
            this.txtWheelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWheelCount.Location = new System.Drawing.Point(271, 84);
            this.txtWheelCount.Name = "txtWheelCount";
            this.txtWheelCount.Size = new System.Drawing.Size(250, 31);
            this.txtWheelCount.TabIndex = 7;
            this.txtWheelCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWheelCount_KeyPress);
            // 
            // txtVehicleModel
            // 
            this.txtVehicleModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleModel.Location = new System.Drawing.Point(271, 51);
            this.txtVehicleModel.Name = "txtVehicleModel";
            this.txtVehicleModel.Size = new System.Drawing.Size(250, 31);
            this.txtVehicleModel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fitting Wheel Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Wheel Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vehicle Model";
            // 
            // comBoxFuelType
            // 
            this.comBoxFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxFuelType.FormattingEnabled = true;
            this.comBoxFuelType.Location = new System.Drawing.Point(271, 185);
            this.comBoxFuelType.Name = "comBoxFuelType";
            this.comBoxFuelType.Size = new System.Drawing.Size(250, 33);
            this.comBoxFuelType.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fuel Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Vehicle Type";
            // 
            // dtimePurchasedDate
            // 
            this.dtimePurchasedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimePurchasedDate.Location = new System.Drawing.Point(271, 253);
            this.dtimePurchasedDate.Name = "dtimePurchasedDate";
            this.dtimePurchasedDate.Size = new System.Drawing.Size(250, 31);
            this.dtimePurchasedDate.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Purchased Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Registration Date";
            // 
            // rdbtnOld
            // 
            this.rdbtnOld.AutoSize = true;
            this.rdbtnOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnOld.Location = new System.Drawing.Point(405, 287);
            this.rdbtnOld.Name = "rdbtnOld";
            this.rdbtnOld.Size = new System.Drawing.Size(63, 29);
            this.rdbtnOld.TabIndex = 19;
            this.rdbtnOld.TabStop = true;
            this.rdbtnOld.Text = "Old";
            this.rdbtnOld.UseVisualStyleBackColor = true;
            // 
            // txtRCDetails
            // 
            this.txtRCDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRCDetails.Location = new System.Drawing.Point(271, 319);
            this.txtRCDetails.Multiline = true;
            this.txtRCDetails.Name = "txtRCDetails";
            this.txtRCDetails.Size = new System.Drawing.Size(250, 73);
            this.txtRCDetails.TabIndex = 20;
            // 
            // txtKMsDriven
            // 
            this.txtKMsDriven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKMsDriven.Location = new System.Drawing.Point(270, 395);
            this.txtKMsDriven.Name = "txtKMsDriven";
            this.txtKMsDriven.Size = new System.Drawing.Size(250, 31);
            this.txtKMsDriven.TabIndex = 21;
            this.txtKMsDriven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKMsDriven_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "KMs Driven";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(71, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "R.C Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(69, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "New or Old Vehicle";
            // 
            // txtMileagePerLtr
            // 
            this.txtMileagePerLtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMileagePerLtr.Location = new System.Drawing.Point(270, 428);
            this.txtMileagePerLtr.Name = "txtMileagePerLtr";
            this.txtMileagePerLtr.Size = new System.Drawing.Size(250, 31);
            this.txtMileagePerLtr.TabIndex = 25;
            this.txtMileagePerLtr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMileagePerLtr_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(69, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "Mileage Per Ltr";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(69, 461);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "Location";
            // 
            // comBoxLocation
            // 
            this.comBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxLocation.FormattingEnabled = true;
            this.comBoxLocation.Location = new System.Drawing.Point(270, 461);
            this.comBoxLocation.Name = "comBoxLocation";
            this.comBoxLocation.Size = new System.Drawing.Size(250, 33);
            this.comBoxLocation.TabIndex = 28;
            this.comBoxLocation.Click += new System.EventHandler(this.comBoxLocation_Click);
            this.comBoxLocation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comBoxLocation_MouseClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(69, 495);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 25);
            this.label14.TabIndex = 29;
            this.label14.Tag = "Tax Ap";
            this.label14.Text = "Tax Applicable";
            // 
            // chkBoxAdvtTax
            // 
            this.chkBoxAdvtTax.AutoSize = true;
            this.chkBoxAdvtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxAdvtTax.Location = new System.Drawing.Point(557, 530);
            this.chkBoxAdvtTax.Name = "chkBoxAdvtTax";
            this.chkBoxAdvtTax.Size = new System.Drawing.Size(116, 29);
            this.chkBoxAdvtTax.TabIndex = 30;
            this.chkBoxAdvtTax.Text = "Advt Tax";
            this.chkBoxAdvtTax.UseVisualStyleBackColor = true;
            this.chkBoxAdvtTax.CheckedChanged += new System.EventHandler(this.chkBoxAdvtTax_CheckedChanged);
            // 
            // chkBoxInsurance
            // 
            this.chkBoxInsurance.AutoSize = true;
            this.chkBoxInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxInsurance.Location = new System.Drawing.Point(414, 495);
            this.chkBoxInsurance.Name = "chkBoxInsurance";
            this.chkBoxInsurance.Size = new System.Drawing.Size(125, 29);
            this.chkBoxInsurance.TabIndex = 31;
            this.chkBoxInsurance.Text = "Insurance";
            this.chkBoxInsurance.UseVisualStyleBackColor = true;
            this.chkBoxInsurance.CheckedChanged += new System.EventHandler(this.chkBoxInsurance_CheckedChanged);
            // 
            // chkBoxPollutionn
            // 
            this.chkBoxPollutionn.AutoSize = true;
            this.chkBoxPollutionn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxPollutionn.Location = new System.Drawing.Point(557, 495);
            this.chkBoxPollutionn.Name = "chkBoxPollutionn";
            this.chkBoxPollutionn.Size = new System.Drawing.Size(114, 29);
            this.chkBoxPollutionn.TabIndex = 32;
            this.chkBoxPollutionn.Text = "Pollution";
            this.chkBoxPollutionn.UseVisualStyleBackColor = true;
            this.chkBoxPollutionn.CheckedChanged += new System.EventHandler(this.chkBoxPollution_CheckedChanged);
            // 
            // chkBoxKLPermit
            // 
            this.chkBoxKLPermit.AutoSize = true;
            this.chkBoxKLPermit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxKLPermit.Location = new System.Drawing.Point(414, 565);
            this.chkBoxKLPermit.Name = "chkBoxKLPermit";
            this.chkBoxKLPermit.Size = new System.Drawing.Size(124, 29);
            this.chkBoxKLPermit.TabIndex = 33;
            this.chkBoxKLPermit.Text = "KL Permit";
            this.chkBoxKLPermit.UseVisualStyleBackColor = true;
            this.chkBoxKLPermit.CheckedChanged += new System.EventHandler(this.chkBoxKLPermit_CheckedChanged);
            // 
            // chkBoxKLTax
            // 
            this.chkBoxKLTax.AutoSize = true;
            this.chkBoxKLTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxKLTax.Location = new System.Drawing.Point(414, 530);
            this.chkBoxKLTax.Name = "chkBoxKLTax";
            this.chkBoxKLTax.Size = new System.Drawing.Size(99, 29);
            this.chkBoxKLTax.TabIndex = 34;
            this.chkBoxKLTax.Text = "KL Tax";
            this.chkBoxKLTax.UseVisualStyleBackColor = true;
            this.chkBoxKLTax.CheckedChanged += new System.EventHandler(this.chkBoxKLTax_CheckedChanged);
            // 
            // chkBoxTNPermit
            // 
            this.chkBoxTNPermit.AutoSize = true;
            this.chkBoxTNPermit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxTNPermit.Location = new System.Drawing.Point(271, 564);
            this.chkBoxTNPermit.Name = "chkBoxTNPermit";
            this.chkBoxTNPermit.Size = new System.Drawing.Size(126, 29);
            this.chkBoxTNPermit.TabIndex = 35;
            this.chkBoxTNPermit.Text = "TN Permit";
            this.chkBoxTNPermit.UseVisualStyleBackColor = true;
            this.chkBoxTNPermit.CheckedChanged += new System.EventHandler(this.chkBoxTNPermit_CheckedChanged);
            // 
            // chkBoxTNTax
            // 
            this.chkBoxTNTax.AutoSize = true;
            this.chkBoxTNTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxTNTax.Location = new System.Drawing.Point(271, 530);
            this.chkBoxTNTax.Name = "chkBoxTNTax";
            this.chkBoxTNTax.Size = new System.Drawing.Size(101, 29);
            this.chkBoxTNTax.TabIndex = 36;
            this.chkBoxTNTax.Text = "TN Tax";
            this.chkBoxTNTax.UseVisualStyleBackColor = true;
            this.chkBoxTNTax.CheckedChanged += new System.EventHandler(this.chkBoxTNTax_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(711, 631);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 29);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(842, 631);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 29);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(973, 631);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 29);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1235, 631);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 29);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClickHereToAddNextServiceKMs
            // 
            this.btnClickHereToAddNextServiceKMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickHereToAddNextServiceKMs.Location = new System.Drawing.Point(76, 613);
            this.btnClickHereToAddNextServiceKMs.Name = "btnClickHereToAddNextServiceKMs";
            this.btnClickHereToAddNextServiceKMs.Size = new System.Drawing.Size(321, 47);
            this.btnClickHereToAddNextServiceKMs.TabIndex = 41;
            this.btnClickHereToAddNextServiceKMs.Text = "Click Here to Add Next Service KMs";
            this.btnClickHereToAddNextServiceKMs.UseVisualStyleBackColor = true;
            this.btnClickHereToAddNextServiceKMs.Click += new System.EventHandler(this.btnClickHereToAddNextServiceKMs_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(711, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 277);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comBoxFittingWheelSize
            // 
            this.comBoxFittingWheelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxFittingWheelSize.FormattingEnabled = true;
            this.comBoxFittingWheelSize.Location = new System.Drawing.Point(271, 116);
            this.comBoxFittingWheelSize.Name = "comBoxFittingWheelSize";
            this.comBoxFittingWheelSize.Size = new System.Drawing.Size(250, 33);
            this.comBoxFittingWheelSize.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(714, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(196, 25);
            this.label15.TabIndex = 45;
            this.label15.Text = "Search Vehicle No.";
            // 
            // txtSearchVehicleNo
            // 
            this.txtSearchVehicleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchVehicleNo.Location = new System.Drawing.Point(916, 33);
            this.txtSearchVehicleNo.Name = "txtSearchVehicleNo";
            this.txtSearchVehicleNo.Size = new System.Drawing.Size(293, 31);
            this.txtSearchVehicleNo.TabIndex = 44;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1237, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 31);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(890, 368);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 228);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(711, 368);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(173, 174);
            this.listView1.TabIndex = 48;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnNextImage
            // 
            this.btnNextImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNextImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextImage.Location = new System.Drawing.Point(1305, 463);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(29, 31);
            this.btnNextImage.TabIndex = 49;
            this.btnNextImage.Text = ">";
            this.btnNextImage.UseVisualStyleBackColor = false;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // btnPreviousImage
            // 
            this.btnPreviousImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPreviousImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousImage.Location = new System.Drawing.Point(890, 463);
            this.btnPreviousImage.Name = "btnPreviousImage";
            this.btnPreviousImage.Size = new System.Drawing.Size(29, 31);
            this.btnPreviousImage.TabIndex = 50;
            this.btnPreviousImage.Text = "<";
            this.btnPreviousImage.UseVisualStyleBackColor = false;
            this.btnPreviousImage.Click += new System.EventHandler(this.btnPreviousImage_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1104, 631);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 29);
            this.btnRefresh.TabIndex = 51;
            this.btnRefresh.Text = "Clear";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClickToAddTaxDates
            // 
            this.btnClickToAddTaxDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickToAddTaxDates.Location = new System.Drawing.Point(456, 613);
            this.btnClickToAddTaxDates.Name = "btnClickToAddTaxDates";
            this.btnClickToAddTaxDates.Size = new System.Drawing.Size(215, 47);
            this.btnClickToAddTaxDates.TabIndex = 52;
            this.btnClickToAddTaxDates.Text = "Click to Add Tax Dates";
            this.btnClickToAddTaxDates.UseVisualStyleBackColor = true;
            this.btnClickToAddTaxDates.Click += new System.EventHandler(this.btnClickToAddTaxDates_Click);
            // 
            // vehicleMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 680);
            this.Controls.Add(this.btnClickToAddTaxDates);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPreviousImage);
            this.Controls.Add(this.btnNextImage);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSearchVehicleNo);
            this.Controls.Add(this.comBoxFittingWheelSize);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClickHereToAddNextServiceKMs);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkBoxTNTax);
            this.Controls.Add(this.chkBoxTNPermit);
            this.Controls.Add(this.chkBoxKLTax);
            this.Controls.Add(this.chkBoxKLPermit);
            this.Controls.Add(this.chkBoxPollutionn);
            this.Controls.Add(this.chkBoxInsurance);
            this.Controls.Add(this.chkBoxAdvtTax);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comBoxLocation);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMileagePerLtr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtKMsDriven);
            this.Controls.Add(this.txtRCDetails);
            this.Controls.Add(this.rdbtnOld);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtimePurchasedDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comBoxFuelType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVehicleModel);
            this.Controls.Add(this.txtWheelCount);
            this.Controls.Add(this.chkBoxFC);
            this.Controls.Add(this.comBoxVehicleType);
            this.Controls.Add(this.rdbtnNew);
            this.Controls.Add(this.dtimeRegistrationDate);
            this.Controls.Add(this.btnUploadVehiclePhotos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVehicleNo);
            this.Name = "vehicleMaster";
            this.Text = "Vehicle Info Master";
            this.Load += new System.EventHandler(this.vehicleMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVehicleNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUploadVehiclePhotos;
        private System.Windows.Forms.DateTimePicker dtimeRegistrationDate;
        private System.Windows.Forms.RadioButton rdbtnNew;
        private System.Windows.Forms.ComboBox comBoxVehicleType;
        private System.Windows.Forms.CheckBox chkBoxFC;
        private System.Windows.Forms.TextBox txtWheelCount;
        private System.Windows.Forms.TextBox txtVehicleModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comBoxFuelType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtimePurchasedDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbtnOld;
        private System.Windows.Forms.TextBox txtRCDetails;
        private System.Windows.Forms.TextBox txtKMsDriven;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMileagePerLtr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comBoxLocation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkBoxAdvtTax;
        private System.Windows.Forms.CheckBox chkBoxInsurance;
        private System.Windows.Forms.CheckBox chkBoxPollutionn;
        private System.Windows.Forms.CheckBox chkBoxKLPermit;
        private System.Windows.Forms.CheckBox chkBoxKLTax;
        private System.Windows.Forms.CheckBox chkBoxTNPermit;
        private System.Windows.Forms.CheckBox chkBoxTNTax;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClickHereToAddNextServiceKMs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comBoxFittingWheelSize;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSearchVehicleNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Button btnPreviousImage;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClickToAddTaxDates;
    }
}


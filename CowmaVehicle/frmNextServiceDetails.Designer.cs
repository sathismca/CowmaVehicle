namespace CowmaVehicle
{
    partial class frmNextServiceDetails
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEngineOilKMs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGearAndCrownOilKMs = new System.Windows.Forms.TextBox();
            this.txtWheelGreaseKMs = new System.Windows.Forms.TextBox();
            this.txtClutchPlateKMs = new System.Windows.Forms.TextBox();
            this.txtBreakLineKMs = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(485, 407);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 42);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Engine Oil KMs";
            // 
            // txtEngineOilKMs
            // 
            this.txtEngineOilKMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEngineOilKMs.Location = new System.Drawing.Point(409, 120);
            this.txtEngineOilKMs.Name = "txtEngineOilKMs";
            this.txtEngineOilKMs.Size = new System.Drawing.Size(290, 38);
            this.txtEngineOilKMs.TabIndex = 2;
            this.txtEngineOilKMs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEngineOilKMs_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Next Sevice KMs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gear and Crown Oil KMs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wheel Grease KMs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Clutch Plate KMs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Break Line KMs";
            // 
            // txtGearAndCrownOilKMs
            // 
            this.txtGearAndCrownOilKMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGearAndCrownOilKMs.Location = new System.Drawing.Point(409, 173);
            this.txtGearAndCrownOilKMs.Name = "txtGearAndCrownOilKMs";
            this.txtGearAndCrownOilKMs.Size = new System.Drawing.Size(290, 38);
            this.txtGearAndCrownOilKMs.TabIndex = 9;
            this.txtGearAndCrownOilKMs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGearAndCrownOilKMs_KeyPress);
            // 
            // txtWheelGreaseKMs
            // 
            this.txtWheelGreaseKMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWheelGreaseKMs.Location = new System.Drawing.Point(409, 223);
            this.txtWheelGreaseKMs.Name = "txtWheelGreaseKMs";
            this.txtWheelGreaseKMs.Size = new System.Drawing.Size(290, 38);
            this.txtWheelGreaseKMs.TabIndex = 10;
            this.txtWheelGreaseKMs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWheelGreaseKMs_KeyPress);
            // 
            // txtClutchPlateKMs
            // 
            this.txtClutchPlateKMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClutchPlateKMs.Location = new System.Drawing.Point(409, 273);
            this.txtClutchPlateKMs.Name = "txtClutchPlateKMs";
            this.txtClutchPlateKMs.Size = new System.Drawing.Size(290, 38);
            this.txtClutchPlateKMs.TabIndex = 11;
            this.txtClutchPlateKMs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClutchPlateKMs_KeyPress);
            // 
            // txtBreakLineKMs
            // 
            this.txtBreakLineKMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakLineKMs.Location = new System.Drawing.Point(409, 326);
            this.txtBreakLineKMs.Name = "txtBreakLineKMs";
            this.txtBreakLineKMs.Size = new System.Drawing.Size(290, 38);
            this.txtBreakLineKMs.TabIndex = 12;
            this.txtBreakLineKMs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBreakLineKMs_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(214, 407);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(96, 42);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmNextServiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 508);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtBreakLineKMs);
            this.Controls.Add(this.txtClutchPlateKMs);
            this.Controls.Add(this.txtWheelGreaseKMs);
            this.Controls.Add(this.txtGearAndCrownOilKMs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEngineOilKMs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Name = "frmNextServiceDetails";
            this.Text = "frmNextServiceDetails";
            this.Load += new System.EventHandler(this.frmNextServiceDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEngineOilKMs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGearAndCrownOilKMs;
        private System.Windows.Forms.TextBox txtWheelGreaseKMs;
        private System.Windows.Forms.TextBox txtClutchPlateKMs;
        private System.Windows.Forms.TextBox txtBreakLineKMs;
        private System.Windows.Forms.Button btnOk;
    }
}
/*
 * Created by SharpDevelop.
 * User: srossmann
 * Date: 13.02.2015
 * Time: 11:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EasyModbusClientExample
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnReadHoldingRegisters;
		private System.Windows.Forms.TextBox txtStartingAddressInput;
		private System.Windows.Forms.Label txtStartingAddress;
		private System.Windows.Forms.Label txtNumberOfValues;
		private System.Windows.Forms.TextBox txtNumberOfValuesInput;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnReadHoldingRegisters = new System.Windows.Forms.Button();
            this.txtStartingAddressInput = new System.Windows.Forms.TextBox();
            this.txtStartingAddress = new System.Windows.Forms.Label();
            this.txtNumberOfValues = new System.Windows.Forms.Label();
            this.txtNumberOfValuesInput = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblStopbits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReadHoldingRegisters
            // 
            this.btnReadHoldingRegisters.Location = new System.Drawing.Point(466, 32);
            this.btnReadHoldingRegisters.Name = "btnReadHoldingRegisters";
            this.btnReadHoldingRegisters.Size = new System.Drawing.Size(99, 36);
            this.btnReadHoldingRegisters.TabIndex = 7;
            this.btnReadHoldingRegisters.Text = "Send";
            this.btnReadHoldingRegisters.UseVisualStyleBackColor = true;
            this.btnReadHoldingRegisters.Click += new System.EventHandler(this.btnReadHoldingRegisters_Click);
            // 
            // txtStartingAddressInput
            // 
            this.txtStartingAddressInput.Location = new System.Drawing.Point(179, 32);
            this.txtStartingAddressInput.Multiline = true;
            this.txtStartingAddressInput.Name = "txtStartingAddressInput";
            this.txtStartingAddressInput.Size = new System.Drawing.Size(281, 36);
            this.txtStartingAddressInput.TabIndex = 9;
            this.txtStartingAddressInput.Text = "1";
            // 
            // txtStartingAddress
            // 
            this.txtStartingAddress.Location = new System.Drawing.Point(38, 91);
            this.txtStartingAddress.Name = "txtStartingAddress";
            this.txtStartingAddress.Size = new System.Drawing.Size(118, 31);
            this.txtStartingAddress.TabIndex = 10;
            this.txtStartingAddress.Text = "Send Data";
            this.txtStartingAddress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNumberOfValues
            // 
            this.txtNumberOfValues.Location = new System.Drawing.Point(4, 152);
            this.txtNumberOfValues.Name = "txtNumberOfValues";
            this.txtNumberOfValues.Size = new System.Drawing.Size(152, 28);
            this.txtNumberOfValues.TabIndex = 12;
            this.txtNumberOfValues.Text = "Receive Data/Response";
            this.txtNumberOfValues.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.txtNumberOfValues.Click += new System.EventHandler(this.txtNumberOfValues_Click);
            // 
            // txtNumberOfValuesInput
            // 
            this.txtNumberOfValuesInput.Location = new System.Drawing.Point(179, 91);
            this.txtNumberOfValuesInput.Multiline = true;
            this.txtNumberOfValuesInput.Name = "txtNumberOfValuesInput";
            this.txtNumberOfValuesInput.Size = new System.Drawing.Size(281, 36);
            this.txtNumberOfValuesInput.TabIndex = 11;
            this.txtNumberOfValuesInput.Text = "1";
            this.txtNumberOfValuesInput.TextChanged += new System.EventHandler(this.txtNumberOfValuesInput_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 152);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(455, 157);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblStopbits
            // 
            this.lblStopbits.Location = new System.Drawing.Point(7, 32);
            this.lblStopbits.Name = "lblStopbits";
            this.lblStopbits.Size = new System.Drawing.Size(149, 34);
            this.lblStopbits.TabIndex = 48;
            this.lblStopbits.Text = "Command Send";
            this.lblStopbits.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 316);
            this.Controls.Add(this.lblStopbits);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNumberOfValues);
            this.Controls.Add(this.txtNumberOfValuesInput);
            this.Controls.Add(this.txtStartingAddress);
            this.Controls.Add(this.txtStartingAddressInput);
            this.Controls.Add(this.btnReadHoldingRegisters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Neo Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblStopbits;
    }
}

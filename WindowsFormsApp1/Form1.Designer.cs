namespace WindowsFormsApp1
{
	partial class Form1
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
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxOperation = new System.Windows.Forms.ComboBox();
			this.buttonDo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(70, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(22, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "xml";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(200, 34);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(647, 20);
			this.textBox3.TabIndex = 1;
			this.textBox3.Text = "add xml path";
			this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(70, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "number of times";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(200, 79);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(467, 20);
			this.textBox4.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(70, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "operation";
			// 
			// comboBoxOperation
			// 
			this.comboBoxOperation.FormattingEnabled = true;
			this.comboBoxOperation.Items.AddRange(new object[] {
            "Add",
            "Subtract",
            "Multiply",
            "Divide",
            "Power of",
            "Root of"});
			this.comboBoxOperation.Location = new System.Drawing.Point(200, 124);
			this.comboBoxOperation.Name = "comboBoxOperation";
			this.comboBoxOperation.Size = new System.Drawing.Size(121, 21);
			this.comboBoxOperation.TabIndex = 5;
			this.comboBoxOperation.Text = "choose";
			this.comboBoxOperation.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
			// 
			// buttonDo
			// 
			this.buttonDo.Location = new System.Drawing.Point(200, 172);
			this.buttonDo.Name = "buttonDo";
			this.buttonDo.Size = new System.Drawing.Size(75, 23);
			this.buttonDo.TabIndex = 6;
			this.buttonDo.Text = "Do";
			this.buttonDo.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(1004, 236);
			this.Controls.Add(this.buttonDo);
			this.Controls.Add(this.comboBoxOperation);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label2);
			this.Name = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBoxOperation;
		private System.Windows.Forms.Button buttonDo;
	}
}


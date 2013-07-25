/*
 * Created by SharpDevelop.
 * User: kits
 * Date: 7/25/2013
 * Time: 2:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TEST
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(36, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(36, 38);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 68);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(124, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "หา ห.ร.ม / ค.ร.น";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(17, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "A";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(17, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(19, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "B";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(36, 99);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(99, 20);
			this.textBox3.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(2, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "ห.ร.ม =";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(2, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "ค.ร.น =";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(36, 125);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(99, 20);
			this.textBox4.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(143, 152);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "GCD & LCM";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
	}
}

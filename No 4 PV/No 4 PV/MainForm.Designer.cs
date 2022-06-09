/*
 * Created by SharpDevelop.
 * User: User
 * Date: 10/05/2022
 * Time: 18:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UTS_PV
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
			System.Windows.Forms.Label label4;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.ResetBtn = new System.Windows.Forms.Button();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.UpdateBtn = new System.Windows.Forms.Button();
			this.InsertBtn = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.DataGridView1Cell = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.KarakterUtama = new System.Windows.Forms.TextBox();
			this.TanggalLiris = new System.Windows.Forms.TextBox();
			this.Penulis = new System.Windows.Forms.TextBox();
			this.NamaAnime = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1Cell)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			label4.Location = new System.Drawing.Point(347, 176);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(95, 20);
			label4.TabIndex = 19;
			label4.Text = "Tanggal Liris";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(855, 47);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(130, 75);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 31;
			this.pictureBox1.TabStop = false;
			// 
			// ResetBtn
			// 
			this.ResetBtn.Location = new System.Drawing.Point(941, 275);
			this.ResetBtn.Name = "ResetBtn";
			this.ResetBtn.Size = new System.Drawing.Size(75, 23);
			this.ResetBtn.TabIndex = 29;
			this.ResetBtn.Text = "Reset";
			this.ResetBtn.UseVisualStyleBackColor = true;
			this.ResetBtn.Click += new System.EventHandler(this.ResetBtnClick);
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.Location = new System.Drawing.Point(841, 275);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
			this.DeleteBtn.TabIndex = 28;
			this.DeleteBtn.Text = "Delete";
			this.DeleteBtn.UseVisualStyleBackColor = true;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtnClick);
			// 
			// UpdateBtn
			// 
			this.UpdateBtn.Location = new System.Drawing.Point(733, 275);
			this.UpdateBtn.Name = "UpdateBtn";
			this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
			this.UpdateBtn.TabIndex = 27;
			this.UpdateBtn.Text = "Update";
			this.UpdateBtn.UseVisualStyleBackColor = true;
			this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtnClick);
			// 
			// InsertBtn
			// 
			this.InsertBtn.Location = new System.Drawing.Point(635, 275);
			this.InsertBtn.Name = "InsertBtn";
			this.InsertBtn.Size = new System.Drawing.Size(75, 23);
			this.InsertBtn.TabIndex = 26;
			this.InsertBtn.Text = "Insert";
			this.InsertBtn.UseVisualStyleBackColor = true;
			this.InsertBtn.Click += new System.EventHandler(this.InsertBtnClick);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(37, 42);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(215, 20);
			this.textBox5.TabIndex = 0;
			this.textBox5.TextChanged += new System.EventHandler(this.TextBox5TextChanged);
			// 
			// DataGridView1Cell
			// 
			this.DataGridView1Cell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1Cell.Location = new System.Drawing.Point(368, 341);
			this.DataGridView1Cell.Name = "DataGridView1Cell";
			this.DataGridView1Cell.Size = new System.Drawing.Size(425, 150);
			this.DataGridView1Cell.TabIndex = 30;
			this.DataGridView1Cell.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellCellContentClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Location = new System.Drawing.Point(702, 144);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(283, 100);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pencarian";
			// 
			// KarakterUtama
			// 
			this.KarakterUtama.Location = new System.Drawing.Point(477, 207);
			this.KarakterUtama.Name = "KarakterUtama";
			this.KarakterUtama.Size = new System.Drawing.Size(153, 20);
			this.KarakterUtama.TabIndex = 24;
			// 
			// TanggalLiris
			// 
			this.TanggalLiris.Location = new System.Drawing.Point(477, 176);
			this.TanggalLiris.Name = "TanggalLiris";
			this.TanggalLiris.Size = new System.Drawing.Size(153, 20);
			this.TanggalLiris.TabIndex = 23;
			// 
			// Penulis
			// 
			this.Penulis.Location = new System.Drawing.Point(477, 144);
			this.Penulis.Name = "Penulis";
			this.Penulis.Size = new System.Drawing.Size(153, 20);
			this.Penulis.TabIndex = 22;
			// 
			// NamaAnime
			// 
			this.NamaAnime.Location = new System.Drawing.Point(476, 102);
			this.NamaAnime.Name = "NamaAnime";
			this.NamaAnime.Size = new System.Drawing.Size(154, 20);
			this.NamaAnime.TabIndex = 21;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(347, 207);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 20;
			this.label5.Text = "Karakter Utama";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(347, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 18;
			this.label3.Text = "Penulis";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(347, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 17;
			this.label2.Text = "Nama Anime";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(591, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 23);
			this.label1.TabIndex = 16;
			this.label1.Text = "Daftar Anime";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1362, 539);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.ResetBtn);
			this.Controls.Add(this.DeleteBtn);
			this.Controls.Add(this.UpdateBtn);
			this.Controls.Add(this.InsertBtn);
			this.Controls.Add(this.DataGridView1Cell);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.KarakterUtama);
			this.Controls.Add(this.TanggalLiris);
			this.Controls.Add(this.Penulis);
			this.Controls.Add(this.NamaAnime);
			this.Controls.Add(this.label5);
			this.Controls.Add(label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UTS PV";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1Cell)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button ResetBtn;
		private System.Windows.Forms.Button DeleteBtn;
		private System.Windows.Forms.Button UpdateBtn;
		private System.Windows.Forms.Button InsertBtn;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.DataGridView DataGridView1Cell;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox KarakterUtama;
		private System.Windows.Forms.TextBox TanggalLiris;
		private System.Windows.Forms.TextBox Penulis;
		private System.Windows.Forms.TextBox NamaAnime;
	}
}

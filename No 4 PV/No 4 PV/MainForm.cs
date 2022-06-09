/*
 * Created by SharpDevelop.
 * User: User
 * Date: 10/05/2022
 * Time: 18:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Data;

namespace UTS_PV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = animasi; Uid = root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public void ReadData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from anime";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"dftpesan") > 0){
					DataGridView1Cell.DataSource = ds;
					DataGridView1Cell.DataMember = "dftpesan";
				}
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void Kartun(){
					try{
						mycommand.Connection = co;
						myadapter.SelectCommand = mycommand;
						mycommand.CommandText = "select * from anime where NamaAnime like '%"+NamaAnime.Text+"%' or Penulis like '%"+Penulis.Text+"%' or TanggalLiris like '%"+TanggalLiris.Text+"%' or KarakterUtama like '%"+KarakterUtama.Text+"%'";
						DataSet ds = new DataSet();
		
						if (myadapter.Fill(ds,"dftpesan") > 0){
							DataGridView1Cell.DataSource = ds;
							DataGridView1Cell.DataMember = "dftpesan";
						}
					}
					catch (Exception ex){
						MessageBox.Show(ex.ToString());
					}
				}
				
		public void InsertData(){
			try{
				mycommand.Connection=co;
				mycommand.CommandText="insert into anime values('"+NamaAnime.Text+"','"+Penulis.Text+"','"+TanggalLiris.Text+"','"+KarakterUtama.Text+"')";
				myadapter.SelectCommand= mycommand;				
				if (mycommand.ExecuteNonQuery() == 1){
				MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
				ReadData();
				}
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void UpdateData(){
			try{
				mycommand.Connection=co;
				mycommand.CommandText = "update anime set NamaAnime='"+NamaAnime.Text+"',Penulis='"+Penulis.Text+"',TanggalLiris='"+TanggalLiris.Text+"',KarakterUtama='"+KarakterUtama.Text+"' where Nama Anime ='"+NamaAnime.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void DeleteData(){
			try{
				mycommand.Connection=co;
				mycommand.CommandText="delete from anime where NamaAnime ='"+NamaAnime.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
				}
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void ResetData(){
			NamaAnime.Text="";
			Penulis.Text="";
			TanggalLiris.Text="";
			KarakterUtama.Text="";
			Kartun();
		}
		public MainForm()
		{
			InitializeComponent();
			
		}
		
		
		void InsertBtnClick(object sender, EventArgs e)
		{
			InsertData();
		}
		void UpdateBtnClick(object sender, EventArgs e)
		{
			UpdateData();
		}
		void DeleteBtnClick(object sender, EventArgs e)
		{
			DeleteData();
		}
		void ResetBtnClick(object sender, EventArgs e)
		{
			ResetData();
		}
		void DataGridView1CellCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		   NamaAnime.Text = DataGridView1Cell.Rows[e.RowIndex].Cells[0].Value.ToString();
			Penulis.Text = DataGridView1Cell.Rows[e.RowIndex].Cells[1].Value.ToString();
			TanggalLiris.Text = DataGridView1Cell.Rows[e.RowIndex].Cells[2].Value.ToString();
			KarakterUtama.Text = DataGridView1Cell.Rows[e.RowIndex].Cells[3].Value.ToString();
		}
		void TextBox5TextChanged(object sender, EventArgs e)
		{
			Kartun();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			co.Open();
			ReadData();
		}
		
		
		
	}
}

using AgentRating3.Properties;
using Delfin.AgentRating;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

namespace AgentRating3
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, RoutedEventArgs e)
		{
			AvalonDbDataContext avalonDbDataContext = new AvalonDbDataContext();
			List<int> nums = new List<int>()
			{
				19050,
				14986,
				5218
			};
			DateTime date = DateTime.Now.Date;
			DateTime dateTime = new DateTime(date.Year, 1, 1);
			DateTime dateTime1 = new DateTime(date.Year - 1, date.Month, date.Day);
			DateTime dateTime2 = new DateTime(dateTime1.Year, 1, 1);
			RatingHelper ratingHelper = new RatingHelper();
			ratingHelper.GetRating(dateTime, date, dateTime2, dateTime1, PartnerSaleType.BySum);
		}

		private void button1_Click_1(object sender, RoutedEventArgs e)
		{
		}

		private void button2_Click(object sender, RoutedEventArgs e)
		{
			if (!this.YearRatimg.IsChecked.Value)
			{
				this.MakeRating();
			}
			else
			{
				this.MakeRatingYear();
			}
			this.UpdatePartnerInfo();
			this.UpdateCoord();
			MessageBox.Show("Рейтинг сформирован");
		}

		private void MakeRating()
		{
			Rating rating = (new RatingHelper()).GetRating(this.datePicker1.SelectedDate.Value, this.datePicker2.SelectedDate.Value, this.datePicker3.SelectedDate.Value, this.datePicker4.SelectedDate.Value, (this.radioButton_Sum.IsChecked.Value ? PartnerSaleType.BySum : PartnerSaleType.ByMen));
			SqlConnection sqlConnection = new SqlConnection(Settings.Default.GoshaConnectionString);
			sqlConnection.Open();
			SqlCommand sqlCommand = new SqlCommand("DELETE FROM dlf_PartnerRating", sqlConnection)
			{
				CommandTimeout = 0
			};
			sqlCommand.ExecuteNonQuery();
			sqlCommand.CommandText = "\r\nINSERT INTO dlf_PartnerRating(PRA_No, PRA_Medal, PRA_Shift, PRA_PRKey, PRA_City)\r\nVALUES(@PRA_No, @PRA_Medal, @PRA_Shift, @PRA_PRKey, @PRA_City)\r\n";
			sqlCommand.Parameters.Add("@PRA_No", SqlDbType.Int);
			sqlCommand.Parameters.Add("@PRA_Medal", SqlDbType.Int);
			sqlCommand.Parameters.Add("@PRA_Shift", SqlDbType.Int);
			sqlCommand.Parameters.Add("@PRA_PRKey", SqlDbType.Int);
			sqlCommand.Parameters.Add("@PRA_City", SqlDbType.VarChar);
			foreach (Rating.City city in rating.Cities)
			{
				sqlCommand.Parameters["@PRA_City"].Value = city.Name;
				foreach (Rating.Place place in city.Places)
				{
					sqlCommand.Parameters["@PRA_No"].Value = place.No;
					sqlCommand.Parameters["@PRA_Medal"].Value = place.Medal;
					sqlCommand.Parameters["@PRA_Shift"].Value = place.Shift;
					sqlCommand.Parameters["@PRA_PRKey"].Value = place.Partner.Id;
					sqlCommand.ExecuteNonQuery();
				}
			}
			sqlConnection.Close();
		}

		private void MakeRatingYear()
		{
			Rating rating = (new RatingHelper()).GetRating(this.datePicker1.SelectedDate.Value, this.datePicker2.SelectedDate.Value, this.datePicker3.SelectedDate.Value, this.datePicker4.SelectedDate.Value, (this.radioButton_Sum.IsChecked.Value ? PartnerSaleType.BySum : PartnerSaleType.ByMen));
			SqlConnection sqlConnection = new SqlConnection(Settings.Default.GoshaConnectionString);
			sqlConnection.Open();
			SqlCommand sqlCommand = new SqlCommand("DELETE FROM dlf_PartnerRatingYear", sqlConnection)
			{
				CommandTimeout = 0
			};
			sqlCommand.ExecuteNonQuery();
			sqlCommand.CommandText = "\r\nINSERT INTO dlf_PartnerRatingYear(PRAY_No, PRAY_Medal, PRAY_Shift, PRAY_PRKey, PRAY_City)\r\nVALUES(@PRA_No, @PRA_Medal, @PRA_Shift, @PRA_PRKey, @PRA_City)\r\n";
			sqlCommand.Parameters.Add("@PRA_No", SqlDbType.Int);
			sqlCommand.Parameters.Add("@PRA_Medal", SqlDbType.Int);
			sqlCommand.Parameters.Add("@PRA_Shift", SqlDbType.Int);
			sqlCommand.Parameters.Add("@PRA_PRKey", SqlDbType.Int);
			sqlCommand.Parameters.Add("@PRA_City", SqlDbType.VarChar);
			foreach (Rating.City city in rating.Cities)
			{
				sqlCommand.Parameters["@PRA_City"].Value = city.Name;
				foreach (Rating.Place place in city.Places)
				{
					sqlCommand.Parameters["@PRA_No"].Value = place.No;
					sqlCommand.Parameters["@PRA_Medal"].Value = place.Medal;
					sqlCommand.Parameters["@PRA_Shift"].Value = place.Shift;
					sqlCommand.Parameters["@PRA_PRKey"].Value = place.Partner.Id;
					sqlCommand.ExecuteNonQuery();
				}
			}
			sqlConnection.Close();
		}

		private void UpdateCoord()
		{
			SqlConnection sqlConnection = new SqlConnection(Settings.Default.GoshaConnectionString);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("\r\nSELECT PI_PRKey, PI_CoordX, PI_CoordY, PI_Address\r\nFROM dlf_PartnerRating r INNER JOIN\r\n\tdlf_PartnerInfo i ON PRA_PRKey = PI_PRKey\r\nWHERE PI_CoordX IS NULL AND PI_CoordY IS NULL AND PI_Address IS NOT NULL\r\nUNION\r\nSELECT PI_PRKey, PI_CoordX, PI_CoordY, PI_Address\r\nFROM dlf_PartnerRatingYear r INNER JOIN\r\n\tdlf_PartnerInfo i ON PRAY_PRKey = PI_PRKey\r\nWHERE PI_CoordX IS NULL AND PI_CoordY IS NULL AND PI_Address IS NOT NULL\r\n", sqlConnection);
			sqlDataAdapter.SelectCommand.CommandTimeout = 0;
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			SqlCommand sqlCommand = new SqlCommand("\r\nUPDATE dlf_PartnerInfo SET PI_CoordX = @PI_CoordX, PI_CoordY = @PI_CoordY\r\nWHERE PI_PRKey = @PI_PRKey\r\n", sqlConnection);
			sqlCommand.Parameters.Add("@PI_CoordX", SqlDbType.Decimal);
			sqlCommand.Parameters.Add("@PI_CoordY", SqlDbType.Decimal);
			sqlCommand.Parameters.Add("@PI_PRKey", SqlDbType.Int);
			sqlConnection.Open();
			sqlCommand.CommandTimeout = 0;
			foreach (DataRow row in dataTable.Rows)
			{
				sqlCommand.Parameters["@PI_PRKey"].Value = row["PI_PRKey"];
				Point point = RatingHelper.Geocode(string.Concat(row["PI_Address"]));
				if ((point.X == -1000 ? false : point.Y != -1000))
				{
					sqlCommand.Parameters["@PI_CoordX"].Value = point.X;
					sqlCommand.Parameters["@PI_CoordY"].Value = point.Y;
				}
				else
				{
					sqlCommand.Parameters["@PI_CoordX"].Value = Convert.DBNull;
					sqlCommand.Parameters["@PI_CoordY"].Value = Convert.DBNull;
				}
				sqlCommand.ExecuteNonQuery();
			}
			sqlConnection.Close();
		}

		private void UpdatePartnerInfo()
		{
			SqlConnection sqlConnection = new SqlConnection(Settings.Default.GoshaConnectionString);
			SqlCommand sqlCommand = new SqlCommand("\r\nINSERT INTO dlf_PartnerInfo(PI_PRKey, PI_Name, PI_OfficeAddress, PI_Address, PI_OfficePhone, PI_Web)\r\nSELECT PR_KEY, REPLACE(PR_NAME,'~',''), PR_ADRESS, PR_ADRESS, PR_PHONES, PR_HOMEPAGE\r\nFROM dlf_PartnerRating INNER JOIN\r\n\ttbl_Partners ON PRA_PRKey = PR_KEY\r\nWHERE NOT EXISTS(SELECT * FROM dlf_PartnerInfo WHERE PI_PRKey = PR_KEY)\r\n\r\nINSERT INTO dlf_PartnerInfo(PI_PRKey, PI_Name, PI_OfficeAddress, PI_Address, PI_OfficePhone, PI_Web)\r\nSELECT PR_KEY, REPLACE(PR_NAME,'~',''), PR_ADRESS, PR_ADRESS, PR_PHONES, PR_HOMEPAGE\r\nFROM dlf_PartnerRatingYear INNER JOIN\r\n\ttbl_Partners ON PRAY_PRKey = PR_KEY\r\nWHERE NOT EXISTS(SELECT * FROM dlf_PartnerInfo WHERE PI_PRKey = PR_KEY)\r\n", sqlConnection);
			sqlConnection.Open();
			sqlCommand.CommandTimeout = 0;
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			DateTime date = DateTime.Now.Date;
			while (date.DayOfWeek != DayOfWeek.Monday)
			{
				date = date.AddDays(-1);
			}
			this.datePicker2.SelectedDate = new DateTime?(date);
			DatePicker nullable = this.datePicker1;
			DateTime now = DateTime.Now;
			nullable.SelectedDate = new DateTime?(new DateTime(now.Year - 1, 1, 1));
			DatePicker datePicker = this.datePicker3;
			now = DateTime.Now;
			datePicker.SelectedDate = new DateTime?(new DateTime(now.Year - 1, 1, 1));
			this.datePicker4.SelectedDate = new DateTime?(date.AddDays(-7));
		}
	}
}
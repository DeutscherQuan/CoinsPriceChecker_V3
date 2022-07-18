using System;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CoinGecko.Clients;
using CoinGecko.Interfaces;
using MySql.Data.MySqlClient;

namespace ThongTinTienAo
{
    public partial class formGraph : Form
    {
        public formGraph(string nameCoin)
        {
            _client = CoinGeckoClient.Instance;
            _nameCoin = nameCoin;
            InitializeComponent();
        }

        private readonly ICoinGeckoClient _client;

        private readonly string _nameCoin;

        private void formGraph_Load(object sender, EventArgs e)
        {
            fillchart();
            chtCoin.Series[0].Name = _nameCoin;
            chtCoin.Series[0].ChartType = SeriesChartType.Column;

        }

        private static readonly DateTime epoch = new DateTime(1970, 1, 1);

        public static DateTime FromUnixTime(long unixTime)
        {
            return epoch.AddSeconds(unixTime);
        }

        private async void fillchart()
        {
            
            try
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=geckocoin_data;";
                string query = " CREATE TABLE `geckocoin_data`.`" + _nameCoin + "` (`time` INT NOT NULL , `price` DOUBLE NOT NULL ) ENGINE = InnoDB;";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                //MessageBox.Show("Tạo bảng oke");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=geckocoin_data;";
                string query = "TRUNCATE TABLE " + _nameCoin + ";";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                // Show any error message.
                databaseConnection.Open();

                MessageBox.Show(ex.Message);
            }
            StringBuilder command = new StringBuilder();

            var result = await _client.CoinsClient.GetMarketChartsByCoinId(_nameCoin, "usd", "max");
            foreach(var value in result.Prices)
            {
                value[0] = value[0] / 1000;
                Console.Write(FromUnixTime((long)value[0]));
                Console.Write(", ");
                Console.WriteLine(value[1]);

                chtCoin.Series[0].Points.AddXY(FromUnixTime((long)value[0]).ToString().Substring(0,11), value[1]);
                //query = "INSERT INTO " + _nameCoin + "(`time`, `price`) VALUES ('" + value[0] + "', '" + value[1] + "');";
                command.Append("INSERT INTO " + _nameCoin + "(`time`, `price`) VALUES ('" + value[0] + "', '" + value[1] + "');");


            }
            try
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=geckocoin_data;";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(command.ToString(), databaseConnection);
                commandDatabase.CommandTimeout = 60;

                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                //MessageBox.Show("Cập nhật dữ liệu Oke");

                databaseConnection.Close();
            }
            catch
            {

            }

        }
    }
}

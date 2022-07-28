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
            // show graph
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
                // declare the name of MySQL file 
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=geckocoin_data;";
                // creat table
                // InnoDB could explain what MySQL version we are using
                string query = " CREATE TABLE `geckocoin_data`.`" + _nameCoin + "` (`time` INT NOT NULL , `price` DOUBLE NOT NULL, `volume` BIGINT NOT NULL, `marketcap` BIGINT NOT NULL ) ENGINE = InnoDB;";
                // send databaseCoinnection and send it to connectionString
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                // read the query and send to databaseConnection
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

                //read the query above
                commandDatabase.CommandTimeout = 60;

                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                //MessageBox.Show("Tạo bảng oke");

                databaseConnection.Close();
            }
            // if could not connect the database, query the TRUNCATE TABLE
            catch (Exception ex)
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=geckocoin_data;";
                //** test a random example and write error message, because C# could not try-catch the error like MySQL
                string query = "TRUNCATE TABLE " + _nameCoin + ";";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

                // read the query above
                commandDatabase.CommandTimeout = 60;

                // Show any error message.
                databaseConnection.Open();
                MessageBox.Show(ex.Message);
            }

            StringBuilder command = new StringBuilder();
            var result = await _client.CoinsClient.GetMarketChartsByCoinId(_nameCoin, "usd", "max");

            // get only Prices value
            for (long i = 0; i < result.Prices.Length; i++)// var value in result.Prices)
            {
                // insert the below data into the created table
                command.Append("INSERT INTO " + _nameCoin + "(`time`, `price`, `volume`, `marketcap`) VALUES ('" + result.Prices[i][0] + "', '" + result.Prices[i][1] + "', '" + (result.TotalVolumes[i][1]).ToString()
                + "', '" + (result.MarketCaps[i][1]).ToString() + "');");               
                // get the first line
                result.Prices[i][0] = result.Prices[i][0] / 1000;
                /*Console.Write(FromUnixTime((long)result.Prices[i][0]));
                Console.Write(",                    ");*/
                Console.Write(result.Prices[i][1]);
                Console.Write(",                    ");
                Console.WriteLine(result.TotalVolumes[i][0]);
                Console.Write(",                    ");
                Console.WriteLine(result.MarketCaps[i][0]);
            



            // AddXY is function to draw the graph
            // transform to String and start form 0 to 11 characters
            chtCoin.Series[0].Points.AddXY(FromUnixTime((long)result.Prices[i][0]).ToString().Substring(0,11), result.Prices[i][1]);                        
              
            }

            try
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=geckocoin_data;";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(command.ToString(), databaseConnection);
                commandDatabase.CommandTimeout = 60;

                // get the data from the table and show in MySQL 
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();           

                databaseConnection.Close();
            }
            catch
            {

            }

        }

        private void chtCoin_Click(object sender, EventArgs e)
        {

        }
    }
}

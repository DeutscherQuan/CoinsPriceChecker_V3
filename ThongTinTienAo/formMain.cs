using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using CoinGecko.Clients;
using System.Net.Http;
using MySql.Data.MySqlClient;
using System.Text;
using CoinGecko.Interfaces;

namespace ThongTinTienAo
{
    public partial class formMain : Form
    {
        private readonly ICoinGeckoClient _client;
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
                string query = " CREATE TABLE `geckocoin_data`.`" + "bitcoin" + "` (`time` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP , `price` DOUBLE NOT NULL ) ENGINE = InnoDB;";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                // creat the table
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=geckocoin_data;";
                string query = "TRUNCATE TABLE " + "bitcoin" + ";";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                // Show any error message.
                    databaseConnection.Open();

                MessageBox.Show(ex.Message);
            }
            StringBuilder command = new StringBuilder();

            var result = await _client.CoinsClient.GetMarketChartsByCoinId("bitcoin", "usd", "max");          
            foreach (var value in result.Prices)
            {
                value[0] = value[0] / 1000;                
                Console.Write(FromUnixTime((long)value[0]));
                Console.Write(", ");
                Console.WriteLine(value[1]);

              
                command.Append("INSERT INTO " + "bitcoin" + "(`time`, `price`) VALUES ('" + value[0] + "', '" + value[1] + "');");


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
        private async void fillchart2()
        {

            try
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=geckocoin_data;";
                string query = " CREATE TABLE `geckocoin_data`.`" + "tether" + "` (`time` INT NOT NULL , `price` DOUBLE NOT NULL ) ENGINE = InnoDB;";

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
                string query = "TRUNCATE TABLE " + "tether" + ";";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                // Show any error message.
                databaseConnection.Open();

                MessageBox.Show(ex.Message);
            }
            StringBuilder command = new StringBuilder();

            var result = await _client.CoinsClient.GetMarketChartsByCoinId("tether", "usd", "max");
            foreach (var value in result.Prices)
            {
                value[0] = value[0] / 1000;
                Console.Write(FromUnixTime((long)value[0]));
                Console.Write(", ");
                Console.WriteLine(value[1]);

                //chtCoin.Series[0].Points.AddXY(FromUnixTime((long)value[0]).ToString().Substring(0, 11), value[1]);
                //query = "INSERT INTO " + _nameCoin + "(`time`, `price`) VALUES ('" + value[0] + "', '" + value[1] + "');";
                command.Append("INSERT INTO " + "tether" + "(`time`, `price`) VALUES ('" + value[0] + "', '" + value[1] + "');");


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

        private async void fillchart3()
        {

            try
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=geckocoin_data;";
                string query = " CREATE TABLE `geckocoin_data`.`" + "ethereum" + "` (`time` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP , `price` DOUBLE NOT NULL ) ENGINE = InnoDB;";

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
                string query = "TRUNCATE TABLE " + "ethereum" + ";";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                // Show any error message.
                databaseConnection.Open();

                MessageBox.Show(ex.Message);
            }
            StringBuilder command = new StringBuilder();

            var result = await _client.CoinsClient.GetMarketChartsByCoinId(
                "ethereum", "usd", "max");
            foreach (var value in result.Prices)
            {
                value[0] = value[0] / 1000;
                Console.Write(FromUnixTime((long)value[0]));
                Console.Write(", ");
                Console.WriteLine(value[1]);

                //chtCoin.Series[0].Points.AddXY(FromUnixTime((long)value[0]).ToString().Substring(0, 11), value[1]);
                //query = "INSERT INTO " + _nameCoin + "(`time`, `price`) VALUES ('" + value[0] + "', '" + value[1] + "');";
                command.Append("INSERT INTO " + "ethereum" + "(`time`, `price`) VALUES ('" + value[0] + "', '" + value[1] + "');");


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

        private async void fillchart4()
        {

            try
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=geckocoin_data;";
                string query = " CREATE TABLE `geckocoin_data`.`" + "ripple" + "` (`time` INT NOT NULL , `price` DOUBLE NOT NULL ) ENGINE = InnoDB;";

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
                string query = "TRUNCATE TABLE " + "ripple" + ";";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                // Show any error message.
                databaseConnection.Open();

                MessageBox.Show(ex.Message);
            }
            StringBuilder command = new StringBuilder();

            var result = await _client.CoinsClient.GetMarketChartsByCoinId("ripple", "usd", "max");
            foreach (var value in result.Prices)
            {
                value[0] = value[0] / 1000;
                Console.Write(FromUnixTime((long)value[0]));
                Console.Write(", ");
                Console.WriteLine(value[1]);

                //chtCoin.Series[0].Points.AddXY(FromUnixTime((long)value[0]).ToString().Substring(0, 11), value[1]);
                //query = "INSERT INTO " + _nameCoin + "(`time`, `price`) VALUES ('" + value[0] + "', '" + value[1] + "');";
                command.Append("INSERT INTO " + "ripple" + "(`time`, `price`) VALUES ('" + value[0] + "', '" + value[1] + "');");


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


        private async void fillchart7()
        {

            try
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=geckocoin_data;";
                string query = " CREATE TABLE `geckocoin_data`.`" + "litecoin" + "` (`time` INT NOT NULL , `price` DOUBLE NOT NULL ) ENGINE = InnoDB;";

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
                string query = "TRUNCATE TABLE " + "litecoin" + ";";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                // Show any error message.
                databaseConnection.Open();

                MessageBox.Show(ex.Message);
            }
            StringBuilder command = new StringBuilder();

            var result = await _client.CoinsClient.GetMarketChartsByCoinId("litecoin", "usd", "max");
            foreach (var value in result.Prices)
            {
                value[0] = value[0] / 1000;
                Console.Write(FromUnixTime((long)value[0]));
                Console.Write(", ");
                Console.WriteLine(value[1]);

                //chtCoin.Series[0].Points.AddXY(FromUnixTime((long)value[0]).ToString().Substring(0, 11), value[1]);
                //query = "INSERT INTO " + _nameCoin + "(`time`, `price`) VALUES ('" + value[0] + "', '" + value[1] + "');";
                command.Append("INSERT INTO " + "litecoin" + "(`time`, `price`) VALUES ('" + value[0] + "', '" + value[1] + "');");


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

        private async void fillchart8()
        {

            try
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=geckocoin_data;";
                string query = " CREATE TABLE `geckocoin_data`.`" + "eos" + "` (`time` INT NOT NULL , `price` DOUBLE NOT NULL ) ENGINE = InnoDB;";

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
                string query = "TRUNCATE TABLE " + "eos" + ";";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                // Show any error message.
                databaseConnection.Open();

                MessageBox.Show(ex.Message);
            }
            StringBuilder command = new StringBuilder();

            var result = await _client.CoinsClient.GetMarketChartsByCoinId("eos", "usd", "max");
            foreach (var value in result.Prices)
            {
                value[0] = value[0] / 1000;
                Console.Write(FromUnixTime((long)value[0]));
                Console.Write(", ");
                Console.WriteLine(value[1]);                
                command.Append("INSERT INTO " + "eos" + "(`time`, `price`) VALUES ('" + value[0] + "', '" + value[1] + "');");

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

        public formMain()
        {
            _client = CoinGeckoClient.Instance;
            InitializeComponent();
            fillchart();
            fillchart2();
            fillchart3();
            fillchart4();
            fillchart7();
            fillchart8();
        }

        private async void tmrUpdateTop3_Tick(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings();

            PingClient pingClient = new PingClient(httpClient, serializerSettings);
            SimpleClient simpleClient = new SimpleClient(httpClient, serializerSettings);

            try
            {
                // Check data status
                if ((await pingClient.GetPingAsync()).GeckoSays != string.Empty)
                {
                    // Getting current price of tether in usd
                    string ids = "tether";
                    string vsCurrencies = "usd";
                    lblCoinTop6.Text = ((await simpleClient.GetSimplePrice(new[] { ids }, new[] { vsCurrencies }))["tether"]["usd"]).ToString();
                    // Getting current price of tether in usd
                    await Task.Delay(100); 

                    ids = "ethereum";
                    vsCurrencies = "usd";
                    lblCoinTop2.Text = ((await simpleClient.GetSimplePrice(new[] { ids }, new[] { vsCurrencies }))["ethereum"]["usd"]).ToString();
                    await Task.Delay(100); 

                    // Getting current price of tether in usd
                    ids = "bitcoin";
                    vsCurrencies = "usd";
                    lblCoinTop1.Text = ((await simpleClient.GetSimplePrice(new[] { ids }, new[] { vsCurrencies }))["bitcoin"]["usd"]).ToString();
                    await Task.Delay(100); 

                    ids = "ripple";
                    vsCurrencies = "usd";
                    lblCoinTop4.Text = ((await simpleClient.GetSimplePrice(new[] { ids }, new[] { vsCurrencies }))["ripple"]["usd"]).ToString();
                    await Task.Delay(100);                                


                    ids = "litecoin";
                    vsCurrencies = "usd";
                    lblCoinTop5.Text = ((await simpleClient.GetSimplePrice(new[] { ids }, new[] { vsCurrencies }))["litecoin"]["usd"]).ToString();
                    await Task.Delay(100); 

                    ids = "eos";
                    vsCurrencies = "usd";
                    lblCoinTop8.Text = ((await simpleClient.GetSimplePrice(new[] { ids }, new[] { vsCurrencies }))["eos"]["usd"]).ToString();
                    await Task.Delay(100); 

                }
            }
            catch
            {
                await Task.Delay(100);
            }
        }

        private async void btnTim_Click(object sender, EventArgs e)
        {   
            // send and receive requirement
            HttpClient httpClient = new HttpClient();

            // format the data in Json file
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings();

            // an object sended to httpClient to send and receive data and format Json file
            PingClient pingClient = new PingClient(httpClient, serializerSettings);
            SimpleClient simpleClient = new SimpleClient(httpClient, serializerSettings);
            CoinGeckoClient coinClient = new CoinGeckoClient(httpClient, serializerSettings);

            // show CoinPrice
            lblGiaTien.Text = "Checking.....";
            try
            {
                // Check CoinGecko API status
                // if the data is not empty (can get data)
                if ((await pingClient.GetPingAsync()).GeckoSays != string.Empty)
                {
                    try
                    {
                        // save name coin into ids
                        string ids = tbxNameCoin1.Text;
                        // choose unit to convert
                        string vsCurrencies = "usd";
                        // print
                        lblGiaTien.Text = "Coin Price " + ids + ": " +
                            ((await simpleClient.GetSimplePrice(new[] { ids }, new[] { vsCurrencies }))[ids]["usd"]).ToString()
                            + "$";
                    }
                    catch
                    {
                        MessageBox.Show("The currency you entered does not exist ");
                    }
                }
            }
            catch
            {

            }
        }

        private void btnDoThi_Click(object sender, EventArgs e)
        {
            if (lblGiaTien.Text.Length > 20)
            {   
                // open the Graph with the parameter in tbxNameCoin1
                formGraph fr = new formGraph(tbxNameCoin1.Text);
                fr.Show();

            }
            else
            {
                MessageBox.Show("Can not open the graph");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblGiaTien_Click(object sender, EventArgs e)
        {

        }

        private void lblTop3_Click(object sender, EventArgs e)
        {

        }

        private void lblCoinTop3_Click(object sender, EventArgs e)
        {

        }

        private void lblCoinTop1_Click(object sender, EventArgs e)
        {

        }

        private void lblCoinTop2_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblCoinTop4_Click(object sender, EventArgs e)
        {

        }

        private void tbxNameCoin1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCoinTop5_Click(object sender, EventArgs e)
        {

        }

        private void lblCoinTop7_Click(object sender, EventArgs e)
        {

        }

        private void lblCoinTop8_Click(object sender, EventArgs e)
        {

        }
    }
}

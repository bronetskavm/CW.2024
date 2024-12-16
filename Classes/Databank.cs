using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_DB.Classes
{
    static class Databank
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static SQLiteConnection m_dbConnection;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS0649 // Field 'Databank.OpenDatebase' is never assigned to, and will always have its default value null
        public static string OpenDatebase;
#pragma warning restore CS0649 // Field 'Databank.OpenDatebase' is never assigned to, and will always have its default value null
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public static string FilePath = "C:\\Users\\illya\\OneDrive\\Desktop\\курсач\\";

        public static List<Accounts> accounts = new List<Accounts>();
        public static List<Storage> storages = new List<Storage>();
        public static List<Providers> providers = new List<Providers>();
        public static List<Deliverys> Deliverys = new List<Deliverys>();
        public static List<Zvits> Zvits = new List<Zvits>();
        public static List<AllZvitStatics> AllZvitStatics = new List<AllZvitStatics>();

        public static List<TableMain> tableMains = new List<TableMain>();

        public static int AccountIdNow = 0;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static string AccPosition;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static string BufferItemsForDecoded;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public static void SelectAccounts()
        {
            string sql = "select * from Accounts";
            SQLiteCommand cmd = new SQLiteCommand(sql, Databank.m_dbConnection);
            cmd = new SQLiteCommand(sql, Databank.m_dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            Databank.accounts.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string surname = reader.GetString(2);
                    string password = reader.GetString(3);
                    string position = reader.GetString(4);

                    Accounts account = new Accounts(id, name, surname, password, position);
                    Databank.accounts.Add(account);
                }
            }
        }

        public static void SelectStorage()
        {
            string sql = "select * from Storage";
            SQLiteCommand cmd = new SQLiteCommand(sql, Databank.m_dbConnection);
            cmd = new SQLiteCommand(sql, Databank.m_dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            Databank.storages.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string name = reader.GetString(1);
                    int number = reader.GetInt32(2);
                    double price = reader.GetDouble(3);
                    double allprice = reader.GetDouble(4);
                    string expDate = reader.GetString(5);
                    int provId = reader.GetInt32(6);
                    int delivId = reader.GetInt32(7);

                    Storage stroge = new Storage(id, name, number, price, allprice, expDate, provId, delivId);
                    Databank.storages.Add(stroge);
                }
            }
        }

        public static void SelectProviders()
        {
            string sql = "select * from Providers";
            SQLiteCommand cmd = new SQLiteCommand(sql, Databank.m_dbConnection);
            cmd = new SQLiteCommand(sql, Databank.m_dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            Databank.providers.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string surname = reader.GetString(2);
                    string contact = reader.GetString(3);

                    Providers provider = new Providers(id, name, surname, contact);
                    Databank.providers.Add(provider);
                }
            }
        }

        public static void SelectDelivers()
        {
            string sql = "select * from Deliverys";
            SQLiteCommand cmd = new SQLiteCommand(sql, Databank.m_dbConnection);
            cmd = new SQLiteCommand(sql, Databank.m_dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            Databank.Deliverys.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string prodId = reader.GetString(1);
                    string name = reader.GetString(2);
                    int number = reader.GetInt32(3);
                    double price = reader.GetDouble(4);
                    double allprice = reader.GetDouble(5);
                    string arrival = reader.GetString(6);
                    int provId = reader.GetInt32(7);

                    Deliverys delivery = new Deliverys(id, prodId, name, number, price, allprice, arrival, provId);
                    Databank.Deliverys.Add(delivery);
                }
            }
        }

        public static void SelectZvits()
        {
            string sql = "select * from Zvits";
            SQLiteCommand cmd = new SQLiteCommand(sql, Databank.m_dbConnection);
            cmd = new SQLiteCommand(sql, Databank.m_dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            Databank.Zvits.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string dataid = reader.GetString(0);
                    string prodid = reader.GetString(1);
                    string prodname = reader.GetString(2);
                    int number = reader.GetInt32(3);
                    double price = reader.GetDouble(4);
                    double allprice = reader.GetDouble(5);
                    int accId = reader.GetInt32(6);

                    Zvits zvit = new Zvits(dataid, prodid, prodname, number, price, allprice, accId);
                    Databank.Zvits.Add(zvit);
                }
            }
        }
        public static void SelectAllZvits()
        {
            string sql = "select * from AllZvitsStatics";
            SQLiteCommand cmd = new SQLiteCommand(sql, Databank.m_dbConnection);
            cmd = new SQLiteCommand(sql, Databank.m_dbConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            Databank.AllZvitStatics.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string dateId = reader.GetString(1);
                    double income = reader.GetDouble(2);
                    double netincome = reader.GetDouble(3);

                    AllZvitStatics allZvit = new AllZvitStatics(id, dateId, income, netincome);
                    Databank.AllZvitStatics.Add(allZvit);
                }
            }
        }
        public static void tableInput(Frm_Main frm_Main, int id_storage, string decode)
        {
            double finallyPrice = 0;
            bool new_items = true;
            DataTable table = new DataTable();

            table.Columns.Add("ID товару", typeof(string));
            table.Columns.Add("Назва товару", typeof(string));
            table.Columns.Add("Ціна/шт", typeof(double));
            table.Columns.Add("Кількість", typeof(int));
            table.Columns.Add("Загальна вартість", typeof(double));

            for (int i = 0; i < Databank.tableMains.Count; i++)
            {
                if (decode == Databank.tableMains[i].Id)
                {
                    new_items = false;
                    Databank.tableMains[i].Number++;
                    Databank.tableMains[i].AllPrice = Databank.tableMains[i].Price * Databank.tableMains[i].Number;
                    break;
                }
            }

            if (new_items)
            {
                TableMain tableMain = new TableMain(Databank.storages[id_storage].Id, Databank.storages[id_storage].Name, Databank.storages[id_storage].Price, 1, Databank.storages[id_storage].Price * 1);
                Databank.tableMains.Add(tableMain);
            }

            for (int i = 0; i < Databank.tableMains.Count; i++)
            {
                table.Rows.Add(Databank.tableMains[i].Id, Databank.tableMains[i].Name, Databank.tableMains[i].Price, Databank.tableMains[i].Number, Databank.tableMains[i].AllPrice);
                finallyPrice += Databank.tableMains[i].AllPrice;
            }

            frm_Main.dataGridView1.DataSource = table;
            frm_Main.FinallyPrice.Text = finallyPrice.ToString();
        }

        public static void InputDeliversTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID товару", typeof(string));
            table.Columns.Add("Назва товару", typeof(string));
            table.Columns.Add("Ціна/шт", typeof(double));
            table.Columns.Add("Кількість", typeof(int));
            table.Columns.Add("Загальна вартість", typeof(double));
        }

        public static void addItemsToDelivTable(int id, string decoded, string nameProduct, int numbers, double pricePiece, string arrival, int providerId)
        {
            double allPrice = numbers * pricePiece;

            Deliverys delivery = new Deliverys(id, decoded, nameProduct, numbers, pricePiece, allPrice, arrival, providerId);
            Databank.Deliverys.Add(delivery);
        }

        public static void addItemsToStorageTable(string id, string name, int number, double price, string expirationDate, int providerId, int deliveryId, bool IsUpdate)
        {
            price = price + Math.Round(price * 0.30);
            string sql = "";
            SQLiteCommand command = new SQLiteCommand(sql, Databank.m_dbConnection);
            double allprice = number * price;

            if (IsUpdate)
            {
                sql = $"update Storage set ID = '{id}', Name = '{name}', Number = '{number}', [Price/Piece] = '{price}', AllPrice = '{allprice}', ExpirationDate = '{expirationDate}', ProviderID = '{providerId}', DeliveryID = '{deliveryId}' where DeliveryID = '{deliveryId}'";
                command = new SQLiteCommand(sql, Databank.m_dbConnection);
                command.ExecuteNonQuery();
            }
            else
            {
                sql = $"insert into Storage (ID, Name, Number, [Price/Piece], AllPrice, ExpirationDate, ProviderID, DeliveryID) values ('{id}', '{name}', '{number}', '{price}', '{allprice}', '{expirationDate}', '{providerId}', '{deliveryId}')";
                command = new SQLiteCommand(sql, Databank.m_dbConnection);
                command.ExecuteNonQuery();
            }
        }

        public static void addItemsToZvits(string prodId, string name, int number, double price, int accId)
        {
            SelectZvits();
            DateTime now = DateTime.Now;
            string date = $"{now.Day}.{now.Month}.{now.Year}";
            double allPrice = number * price;

            string sql = "";
            SQLiteCommand command = new SQLiteCommand(sql, Databank.m_dbConnection);
            sql = $"insert into Zvits (DateID, ProductID, ProductName, Numbers, Price, AllPrice, AccountID) values ('{date}', '{prodId}', '{name}', '{number}', '{price}', '{allPrice}', '{accId}')";
            command = new SQLiteCommand(sql, Databank.m_dbConnection);
            command.ExecuteNonQuery();
        }

        public static void DeleteItemsAfterSellInStorage(string ProductId, int number)
        {
            string sql = "";
            SQLiteCommand command = new SQLiteCommand(sql, Databank.m_dbConnection);
            for (int i = 0; i < Databank.storages.Count; i++)
            {
                if (Databank.storages[i].Id == ProductId)
                {
                    sql = $"update Storage set Number = {Databank.storages[i].Number - number}, AllPrice = {Databank.storages[i].AllPrice - (number * Databank.storages[i].Price)} where ID = '{ProductId}'";
                    command = new SQLiteCommand(sql, Databank.m_dbConnection);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

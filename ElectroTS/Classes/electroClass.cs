using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ElectroTransport.Classes {
    class electroClass {
        //Getters та Setters
        public int TransportID { get; set; }
        public string Finish1 { get; set; }
        public string Finish2 { get; set; }
        public string Interval { get; set; }
        public string Stops1 { get; set; }
        public string Stops2 { get; set; }
        public string Price { get; set; }
        public string Тип { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Пошук даних в БД
        public DataTable Select() {
            //1. Пікдлючення до БД
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try {
                //2. Запит SQL
                string sql = "SELECT * FROM table_marshrut";

                //Створення cmd за допомогою sql та conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Створення SQL DataAdapter за допомогою cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            } catch (Exception ex) {

            } finally {
                conn.Close();
            }
            return dt;
        }

        //Запис даних в БД
        public bool Insert(electroClass m) {
            //Створення стандартно типу повернення та встановлення його значення false
            bool isSuccess = false;

            //1. Пікдлючення до БД
            SqlConnection conn = new SqlConnection(myconnstrng);
            try {
                //2. Запит SQL для запису даних в БД
                string sql = "INSERT INTO table_marshrut (TransportID, Finish1, Finish2, Interval, Stops1, Stops2, Price, Тип) VALUES (@TransportID, @Finish1, @Finish2, @Interval, @Stops1, @Stops2, @Price, @Тип)";

                //Створення cmd за допомогою sql та conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Створення параметрів для додавання даних
                cmd.Parameters.AddWithValue("@TransportID", m.TransportID);
                cmd.Parameters.AddWithValue("@Finish1", m.Finish1);
                cmd.Parameters.AddWithValue("@Finish2", m.Finish2);
                cmd.Parameters.AddWithValue("@Interval", m.Interval);
                cmd.Parameters.AddWithValue("@Stops1", m.Stops1);
                cmd.Parameters.AddWithValue("@Stops2", m.Stops2);
                cmd.Parameters.AddWithValue("@Price", m.Price);
                cmd.Parameters.AddWithValue("@Тип", m.Тип);

                //Підключення відкрито
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //Якщо запит виконується успішно тоді значення рядків буде більше за 0, в іншому випадку його значення буде 0
                if (rows > 0) {
                    isSuccess = true;
                } else {
                    isSuccess = false;
                }
            } catch (Exception ex) {

            } finally {
                conn.Close();
            }
            return isSuccess;
        }

        //Оновлення даних в БД
        public bool Update(electroClass m) {
            //Створення стандартно типу повернення та встановлення його значення false
            bool isSuccess = false;

            //1. Пікдлючення до БД
            SqlConnection conn = new SqlConnection(myconnstrng);
            try {
                //Запит SQL для оновлення даних в БД
                string sql = "UPDATE table_marshrut SET Finish1=@Finish1, Finish2=@Finish2, Interval=@Interval, Stops1=@Stops1, Stops2=@Stops2, Price=@Price, Тип=@Тип WHERE TransportID=@TransportID";

                //Створення cmd за допомогою sql та conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Створення параметрві для додавання даних
                cmd.Parameters.AddWithValue("@Finish1", m.Finish1);
                cmd.Parameters.AddWithValue("@Finish2", m.Finish2);
                cmd.Parameters.AddWithValue("@Interval", m.Interval);
                cmd.Parameters.AddWithValue("@Stops1", m.Stops1);
                cmd.Parameters.AddWithValue("@Stops2", m.Stops2);
                cmd.Parameters.AddWithValue("@Price", m.Price);
                cmd.Parameters.AddWithValue("@Тип", m.Тип);
                cmd.Parameters.AddWithValue("@TransportID", m.TransportID);
                //Підключення відкрито
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //Якщо запит виконується успішно тоді значення рядків буде більше за 0, в іншому випадку його значення буде 0
                if (rows > 0) {
                    isSuccess = true;
                }
                else {
                    isSuccess = false;
                }
            } catch (Exception ex) {

            } finally {
                conn.Close();
            }
            return isSuccess;
        }
        
        //Видалення даних з БД
        public bool Delete(electroClass m) {
            //Створення стандартно типу повернення та встановлення його значення false
            bool isSuccess = false;

            //1. Пікдлючення до БД
            SqlConnection conn = new SqlConnection(myconnstrng);
            try {
                //Запит SQL для видалення даних в БД
                string sql = "DELETE FROM table_marshrut WHERE TransportID=@TransportID";

                //Створення cmd за допомогою sql та conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TransportID", m.TransportID);
                //Підключення відкрито
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //Якщо запит виконується успішно тоді значення рядків буде більше за 0, в іншому випадку його значення буде 0
                if (rows > 0) {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            } catch (Exception ex) {

            } finally{
                //Підключення закрито
                conn.Close();
            }
            return isSuccess;
        }

    }
}
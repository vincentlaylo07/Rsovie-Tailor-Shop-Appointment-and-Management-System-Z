using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.Classes
{
    internal class DatabaseClass
    {
        static string databaseConnection = ConfigurationManager.ConnectionStrings["databaseConnection"].ConnectionString;

        public void InsertHashedPassword(string hashedPassword)
        {
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                string query = "INSERT INTO AdminPassword (Password) VALUES (@Password)";

                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        public string GetStoredHashedPassword() // Method to retrieve hashed password from the database
        {
            string? hashedPassword = null;

            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                string query = "SELECT TOP 1 Password FROM AdminPassword"; // Query to retrieve the password

                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        hashedPassword = result.ToString();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message); // Handle the exception appropriately
                }
            }
            return hashedPassword;
        }

        public int ExecuteScalar(string query)
        {
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    var result = command.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1; // Return a default value or handle error as needed
                }
            }
        }

        // Method to Insert Customers and retrieve the generated ID
        public int InsertIntoCustomersAndGetId(string fullname, string address)
        {
            string query = $@"INSERT INTO Customers (Fullname, Address) 
                            OUTPUT INSERTED.customer_id 
                            VALUES ('{fullname}', '{address}')";

            return ExecuteScalar(query);
        }

        public int InsertIntoCustomerContactsAndGetId(int customerId, string email, string contactNo)
        {
            string query = $@"INSERT INTO CustomerContacts (customer_id, Email, Contact_no) 
                            OUTPUT INSERTED.customer_contact_id 
                            VALUES ({customerId}, '{email}', '{contactNo}')";

            return ExecuteScalar(query);
        }

        public int InsertIntoCustomerOrdersAndGetId(int customerId, int uniform, int jersey, int printing, int others)
        {
            string query = $@"INSERT INTO CustomerOrders (customer_id, Uniform, Jersey, Printing, Others) 
                     OUTPUT INSERTED.customer_order_id 
                     VALUES ({customerId}, {uniform}, {jersey}, {printing}, {others})";

            return ExecuteScalar(query);
        }

        public int InsertIntoCustomerDescriptionsAndGetId(int customerId, string description)
        {
            string query = $@"INSERT INTO CustomerDescriptions (customer_id, Description) 
                            OUTPUT INSERTED.customer_description_id 
                            VALUES ({customerId}, '{description}')";

            return ExecuteScalar(query);
        }

        public int InsertIntoAppointmentSubmitAndGetId(int customerId, DateTime customerSubmitTime)
        {
            string query = $@"INSERT INTO AppointmentSubmit (customer_id, customer_submit_time) 
                    OUTPUT INSERTED.appointment_id 
                    VALUES ({customerId}, '{customerSubmitTime.ToString("yyyy-MM-dd HH:mm:ss")}')";

            return ExecuteScalar(query);
        }

        public DataTable LoadDataGridTable()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string query = @"
                    SELECT
                        Customers.customer_id AS Id,
                        AppointmentSubmit.customer_submit_time AS 'Submit Time',
                        Customers.Fullname AS 'Full Name',
                        Customers.Address,
                        CustomerContacts.Email,
                        CustomerContacts.Contact_no AS 'Contact No',
                        CustomerOrders.Uniform,
                        CustomerOrders.Jersey,
                        CustomerOrders.Printing,
                        CustomerOrders.Others,
                        CustomerDescriptions.Description
                    FROM Customers
                    LEFT JOIN CustomerContacts ON Customers.customer_id = CustomerContacts.customer_id
                    LEFT JOIN CustomerOrders ON Customers.customer_id = CustomerOrders.customer_id
                    LEFT JOIN CustomerDescriptions ON Customers.customer_id = CustomerDescriptions.customer_id
                    LEFT JOIN AppointmentSubmit ON Customers.customer_id = AppointmentSubmit.customer_id
                    WHERE Customers.customer_id NOT IN (SELECT DISTINCT customer_id FROM TransactionDetails)
                    ORDER BY Customers.customer_id DESC";

                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    sqlConnection.Open();
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public DataTable SearchData(string valueToSearch)
        {
            DataTable dataTable = new DataTable();

            try
            {
                string query = @"
                    SELECT
                        Customers.customer_id AS Id,
                        CONVERT(VARCHAR(15), AppointmentSubmit.customer_submit_time, 107) AS 'Submit Time',
                        Customers.Fullname AS 'Full Name',
                        Customers.Address,
                        CustomerContacts.Email,
                        CustomerContacts.Contact_no AS 'Contact No',
                        CustomerOrders.Uniform,
                        CustomerOrders.Jersey,
                        CustomerOrders.Printing,
                        CustomerOrders.Others,
                        CustomerDescriptions.Description
                    FROM Customers
                    LEFT JOIN CustomerContacts ON Customers.customer_id = CustomerContacts.customer_id
                    LEFT JOIN CustomerOrders ON Customers.customer_id = CustomerOrders.customer_id
                    LEFT JOIN CustomerDescriptions ON Customers.customer_id = CustomerDescriptions.customer_id
                    LEFT JOIN AppointmentSubmit ON Customers.customer_id = AppointmentSubmit.customer_id
                    WHERE 
                        (
                            Customers.customer_id NOT IN (SELECT customer_id FROM TransactionDetails)
                            OR
                            Customers.customer_id IS NULL
                        )
                        AND (
                            Customers.Fullname LIKE @SearchValue 
                            OR
                            Customers.Address LIKE @SearchValue 
                            OR
                            CustomerContacts.Email LIKE @SearchValue 
                            OR
                            CustomerContacts.Contact_no LIKE @SearchValue 
                            OR
                            CustomerDescriptions.Description LIKE @SearchValue
                            OR
                            CONVERT(VARCHAR(15), AppointmentSubmit.customer_submit_time, 107) LIKE @SearchValue
                        )
                    ";

                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@SearchValue", "%" + valueToSearch + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        sqlConnection.Open();
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public void InsertIntoTransactionDetails(int customerId, int scheduleId, int payment, int change, int cost)
        {
            try
            {
                if (!CustomerIdExists(customerId))
                {
                    MessageBox.Show("Customer ID not found.");
                    return;
                }

                if (!ScheduleIdExists(scheduleId))
                {
                    MessageBox.Show("Schedule ID not found.");
                    return;
                }

                string query = @"
            INSERT INTO TransactionDetails (customer_id, schedule_id, payment, change, cost, submit_time)
            VALUES (@customerId, @scheduleId, @payment, @change, @cost, GETDATE())";

                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@scheduleId", scheduleId);
                    command.Parameters.AddWithValue("@payment", payment);
                    command.Parameters.AddWithValue("@change", change);
                    command.Parameters.AddWithValue("@cost", cost);

                    sqlConnection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool ScheduleIdExists(int scheduleId)
        {
            bool exists = false;

            try
            {
                string query = "SELECT COUNT(*) FROM Schedules WHERE schedule_id = @ScheduleId";

                using (SqlConnection connection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ScheduleId", scheduleId);
                    connection.Open();

                    int count = (int)command.ExecuteScalar();
                    exists = count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return exists;
        }

        // Check if Customer ID exists
        private bool CustomerIdExists(int customerId)
        {
            string query = "SELECT COUNT(*) FROM Customers WHERE customer_id = @customerId";
            int count = 0;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    sqlConnection.Open();
                    count = (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return count > 0;
        }

        public void DeleteIdAppointment(int id)
        {
            try
            {
                bool customerExists = false;

                using (SqlConnection connection = new SqlConnection(databaseConnection))
                {
                    connection.Open();

                    // Check if the customer exists before deletion
                    using (SqlCommand checkCommand = new SqlCommand("SELECT 1 FROM Customers WHERE customer_id = @Id", connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = checkCommand.ExecuteReader())
                        {
                            customerExists = reader.HasRows;
                        }
                    }

                    if (!customerExists)
                    {
                        MessageBox.Show("Customer ID not found.");
                        return;
                    }

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        // Delete related schedules
                        command.CommandText = "DELETE FROM Schedules WHERE customer_id = @Id";
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();

                        // Delete other related records
                        command.CommandText = "DELETE FROM AppointmentSubmit WHERE customer_id = @Id";
                        command.ExecuteNonQuery();

                        command.CommandText = "DELETE FROM CustomerContacts WHERE customer_id = @Id";
                        command.ExecuteNonQuery();

                        command.CommandText = "DELETE FROM CustomerOrders WHERE customer_id = @Id";
                        command.ExecuteNonQuery();

                        command.CommandText = "DELETE FROM CustomerDescriptions WHERE customer_id = @Id";
                        command.ExecuteNonQuery();

                        // Delete from Customers table
                        command.CommandText = "DELETE FROM Customers WHERE customer_id = @Id";
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable FinishedAppointments()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string query = @"
                    SELECT
                        AppointmentSubmit.customer_submit_time AS SubmitTime,
                        AppointmentSubmit.customer_id AS CustomerId,
                        Schedules.schedule_id AS ScheduleId,
                        Customers.Fullname AS FullName,
                        TransactionDetails.cost AS Cost,
                        TransactionDetails.payment AS Payment,
                        TransactionDetails.change AS Change
                    FROM AppointmentSubmit
                    LEFT JOIN Customers ON AppointmentSubmit.customer_id = Customers.customer_id
                    LEFT JOIN TransactionDetails ON AppointmentSubmit.customer_id = TransactionDetails.customer_id
                    LEFT JOIN Schedules ON TransactionDetails.schedule_id = Schedules.schedule_id
                    WHERE TransactionDetails.payment IS NOT NULL
                    ORDER BY SubmitTime DESC";

                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    sqlConnection.Open();
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public DataTable SearchFinishedAppointments(string searchValue)
        {
            DataTable dataTable = new DataTable();

            try
            {
                string query = @"
                    SELECT
                        AppointmentSubmit.customer_submit_time AS submit_time,
                        AppointmentSubmit.customer_id,
                        Customers.Fullname,
                        TransactionDetails.cost,
                        TransactionDetails.payment,
                        TransactionDetails.change,
                        Schedules.schedule_id
                    FROM AppointmentSubmit
                    LEFT JOIN Customers ON AppointmentSubmit.customer_id = Customers.customer_id
                    LEFT JOIN TransactionDetails ON AppointmentSubmit.customer_id = TransactionDetails.customer_id
                    LEFT JOIN Schedules ON TransactionDetails.schedule_id = Schedules.schedule_id
                    WHERE 
                        AppointmentSubmit.customer_submit_time LIKE @SearchValue
                        OR AppointmentSubmit.customer_id LIKE @SearchValue
                        OR Customers.Fullname LIKE @SearchValue
                        OR TransactionDetails.cost LIKE @SearchValue
                        OR TransactionDetails.payment LIKE @SearchValue
                        OR TransactionDetails.change LIKE @SearchValue
                        OR Schedules.schedule_id LIKE @SearchValue";

                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        sqlConnection.Open();
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public void InsertSchedule(int customerId, DateTime scheduleDate, TimeSpan scheduleTime)
        {
            string query = @"
                INSERT INTO Schedules (customer_id, schedule_date, schedule_time)
                VALUES (@customerId, @scheduleDate, @scheduleTime)";

            try
            {
                using (SqlConnection connection = new SqlConnection(databaseConnection))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@customerId", customerId);
                        command.Parameters.AddWithValue("@scheduleDate", scheduleDate.Date);
                        command.Parameters.AddWithValue("@scheduleTime", scheduleTime);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Method to retrieve scheduleId based on customerId
        public int GetScheduleId(int customerId)
        {
            int scheduleId = -1; // Initialize with a default value or error code

            try
            {
                string query = "SELECT schedule_id FROM Schedules WHERE customer_id = @customerId";

                using (SqlConnection connection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        scheduleId = Convert.ToInt32(result); // Retrieve the scheduleId
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return scheduleId;
        }

        public DataTable ScheduleGridTable()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string query = @"
            SELECT
                schedule_id AS Id,
                customer_id AS CustomerId,
                schedule_date AS ScheduleDate,
                schedule_time AS ScheduleTime
            FROM Schedules
            WHERE customer_id NOT IN (SELECT DISTINCT customer_id FROM TransactionDetails)";

                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    sqlConnection.Open();
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public DataTable ScheduleGridTableSearch(string searchValue)
        {
            DataTable dataTable = new DataTable();

            try
            {
                string query = @"
            SELECT
                customer_id AS CustomerID,
                schedule_date AS ScheduleDate,
                schedule_time AS ScheduleTime
            FROM Schedules
            WHERE 
                customer_id NOT IN (SELECT DISTINCT customer_id FROM TransactionDetails)
                AND (
                    CONVERT(VARCHAR, customer_id) LIKE @SearchValue OR
                    CONVERT(VARCHAR, schedule_date, 23) LIKE @SearchValue OR
                    CONVERT(VARCHAR, schedule_time, 108) LIKE @SearchValue
                )";

                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        sqlConnection.Open();
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public void DeleteSchedule(int scheduleId)
        {
            try
            {
                bool scheduleExists = false;

                using (SqlConnection connection = new SqlConnection(databaseConnection))
                {
                    connection.Open();

                    // Check if the schedule exists before deletion
                    string checkQuery = "SELECT 1 FROM Schedules WHERE schedule_id = @ScheduleId";

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@ScheduleId", scheduleId);

                        using (SqlDataReader reader = checkCommand.ExecuteReader())
                        {
                            scheduleExists = reader.HasRows;
                        }
                    }

                    if (!scheduleExists)
                    {
                        MessageBox.Show("Schedule ID not found.");
                        return;
                    }

                    // Delete the schedule
                    string deleteQuery = "DELETE FROM Schedules WHERE schedule_id = @ScheduleId";

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@ScheduleId", scheduleId);
                        deleteCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable ScheduleGridTablePayment()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string query = @"
            SELECT
                schedule_id AS ScheduleId,
                customer_id AS CustomerId
            FROM Schedules
            WHERE customer_id NOT IN (SELECT DISTINCT customer_id FROM TransactionDetails)";

                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    sqlConnection.Open();
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public DataTable ChartDataTransaction()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string query = @"
                    SELECT YEAR(submit_time) AS Year, SUM(cost) AS Cost
                    FROM TransactionDetails
                    GROUP BY YEAR(submit_time)
                    ORDER BY YEAR(submit_time) DESC";

                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    sqlConnection.Open();
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public DataTable FinishedCustomerCountByYear()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string query = @"
            SELECT YEAR(AppointmentSubmit.customer_submit_time) AS [Year], COUNT(AppointmentSubmit.customer_id) AS [CustomerCount]
            FROM AppointmentSubmit
            WHERE AppointmentSubmit.customer_id IN (SELECT DISTINCT customer_id FROM TransactionDetails)
            GROUP BY YEAR(AppointmentSubmit.customer_submit_time)
            ORDER BY [Year] DESC";

                using (SqlConnection sqlConnection = new SqlConnection(databaseConnection))
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    sqlConnection.Open();
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }
    }
}
using System;
using System.Data;
using System.Data.SqlClient; 

namespace HomeworkAutoLevelLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSet = new DataSet("ShopDB");
            //var adapter = new SqlDataAdapter("Select * from Products", "Server=DESKTOP-3S2N5VP; Database=ShopDB; Trusted_Connection = true;");
            //adapter.Fill(dataSet);

            var employeeTable = dataSet.Tables.Add("Employees");
            var employeeIdColumn = new DataColumn("Id", Type.GetType("System.Int32"));
            employeeIdColumn.ReadOnly = true;
            employeeIdColumn.AutoIncrement = true;
            employeeIdColumn.AutoIncrementSeed = 1;
            employeeIdColumn.AutoIncrementStep = 1;
            employeeIdColumn.AllowDBNull = false;

            var employeeFullNameColumn = new DataColumn("FullName", Type.GetType("System.String"));
            var employeeSalaryColumn = new DataColumn("Salary", Type.GetType("System.Double"));
            employeeTable.Columns.AddRange(  new DataColumn[]
            { 
                employeeIdColumn,
                employeeFullNameColumn,
                employeeSalaryColumn
            });
            employeeTable.PrimaryKey = new DataColumn[] { employeeIdColumn };

            var productTable = dataSet.Tables.Add("Products");
            var productIdColumn = new DataColumn("Id", Type.GetType("System.Int32"));
            productIdColumn.ReadOnly = true;
            productIdColumn.AutoIncrement = true;
            productIdColumn.AutoIncrementSeed = 1;
            productIdColumn.AutoIncrementStep = 1;
            productIdColumn.AllowDBNull = false;

            var productNameColumn = new DataColumn("Name", Type.GetType("System.String"));
            productNameColumn.AllowDBNull = false;
            var producPriceColumn = new DataColumn("Price", Type.GetType("System.Int32"));
            producPriceColumn.AllowDBNull = false; 
            productTable.Columns.AddRange(new DataColumn[]
            {
                productIdColumn,
                productNameColumn,
                producPriceColumn
            });
            productTable.PrimaryKey = new DataColumn[] { productIdColumn };            

            var orderTable = dataSet.Tables.Add("Orders");
            var orderIdColumn = new DataColumn("Id", Type.GetType("System.Int32"));
            orderIdColumn.ReadOnly = true;
            orderIdColumn.AutoIncrement = true;
            orderIdColumn.AutoIncrementSeed = 1;
            orderIdColumn.AutoIncrementStep = 1;
            orderIdColumn.AllowDBNull = false;

            var orderDateColumn = new DataColumn("Date", Type.GetType("System.DateTime"));
            var orderSummaColumn = new DataColumn("Summa", Type.GetType("System.Double"));
            var orderCustomerIdColumn = new DataColumn("CustomerId", Type.GetType("System.Int32"));
            var orderOrderDetailIdColumn = new DataColumn("OrderDetailId", Type.GetType("System.Int32"));
            var orderProductIdColumn = new DataColumn("ProductId", Type.GetType("System.Int32"));
            var orderEmployeeIdColumn = new DataColumn("EmployeeId", Type.GetType("System.Int32"));
            orderTable.Columns.AddRange(new DataColumn[]
            {
                orderIdColumn,
                orderDateColumn,
                orderSummaColumn,
                orderProductIdColumn,
                orderOrderDetailIdColumn,
                orderCustomerIdColumn,
                orderEmployeeIdColumn
                
            });
            orderTable.PrimaryKey = new DataColumn[] { orderIdColumn };

            var orderDetailTable = dataSet.Tables.Add("OrderDetails");
            var orderDetailIdColumn = new DataColumn("Id", Type.GetType("System.Int32"));
            orderDetailIdColumn.ReadOnly = true;
            orderDetailIdColumn.AutoIncrement = true;
            orderDetailIdColumn.AutoIncrementSeed = 1;
            orderDetailIdColumn.AutoIncrementStep = 1;
            orderDetailIdColumn.AllowDBNull = false;

            var orderDetailDescriptionColumn = new DataColumn("Description", Type.GetType("System.String"));
            orderDetailTable.Columns.AddRange(new DataColumn[]
            {
                orderDetailIdColumn,
                orderDetailDescriptionColumn
            });
            orderDetailTable.PrimaryKey = new DataColumn[] { orderDetailIdColumn };

            var customerTable = dataSet.Tables.Add("Customers");
            var customerIdColumn = new DataColumn("Id", Type.GetType("System.Int32"));
            customerIdColumn.ReadOnly = true;
            customerIdColumn.AutoIncrement = true;
            customerIdColumn.AutoIncrementSeed = 1;
            customerIdColumn.AutoIncrementStep = 1;
            customerIdColumn.AllowDBNull = false;

            var customeFullNameColumn = new DataColumn("FullName", Type.GetType("System.String"));
            var customerPhoneColumn = new DataColumn("Phone", Type.GetType("System.String"));
            customerTable.Columns.AddRange(new DataColumn[]
            {
                customerIdColumn,
                customeFullNameColumn,
                customerPhoneColumn
            });
            customerTable.PrimaryKey = new DataColumn[] { customerIdColumn };
            
            dataSet.AcceptChanges();
        }
    }
}

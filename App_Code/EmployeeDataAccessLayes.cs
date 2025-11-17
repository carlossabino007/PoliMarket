using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Descripción breve de EmployeeDataAccessLayes
/// </summary>
public class EmployeeDataAccessLayes
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Photo { get; set; }
    }


    public EmployeeDataAccessLayes()
	{
	
	}

    public static List<Employee> GetAllEmployees()
    {
        List<Employee> listEmployees = new List<Employee>();

        string CS = ConfigurationManager.ConnectionStrings["BaseWebKardexConnectionString2"].ConnectionString;
        using (SqlConnection con = new SqlConnection(CS))
        {
            SqlCommand cmd = new SqlCommand("Select * from tblEmployeeFoto", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId = Convert.ToInt32(rdr["EmployeeId"]);
                employee.Name = rdr["Name"].ToString();
                employee.Gender = rdr["Gender"].ToString();
                employee.City = rdr["City"].ToString();
                employee.Photo = rdr["PhotoPath"].ToString();

                listEmployees.Add(employee);
            }
        }

        return listEmployees;
    }

}
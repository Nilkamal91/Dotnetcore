using MySql.Data.MySqlClient;    
using System;    
using System.Collections.Generic;    
    
namespace app.Models    
{    
    public class ProductStyle    
    {    
        public string ConnectionString { get; set; }    
    
        public ProductStyle(string connectionString)    
        {    
            this.ConnectionString = connectionString;    
        }    
    
        private MySqlConnection GetConnection()    
        {    
            return new MySqlConnection(ConnectionString);    
        } 

    public List<XXIBM_PRODUCT_STYLE> GetAllXXIBM_PRODUCT_STYLEs()  
    {  
        List<XXIBM_PRODUCT_STYLE> list = new List<XXIBM_PRODUCT_STYLE>();  
      
        using (MySqlConnection conn = GetConnection())  
        {  
            conn.Open();  
            MySqlCommand cmd = new MySqlCommand("select * from XXIBM_PRODUCT_STYLE where Item Number < 10", conn);  
      
            using (var reader = cmd.ExecuteReader())  
            {  
                while (reader.Read())  
                {  
                    list.Add(new XXIBM_PRODUCT_STYLE()  
                    {  
                        Item Number = Convert.ToInt32(reader["Item Number"]),  
                        Description = reader["Description"].ToString(),  
                        Long Description = reader["Long Description"].ToString(),  
                        Catalogue Category = Convert.ToInt32(reader["Catalogue Category"]),  
                        Brand = reader["Brand"].ToString()  
                    });  
                }  
            }  
        }  
        return list;  
    }
 
    }  
}  
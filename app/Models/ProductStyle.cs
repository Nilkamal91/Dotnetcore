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
            MySqlCommand cmd = new MySqlCommand("select * from XXIBM_PRODUCT_STYLE where Item_Number", conn);  
      
            using (var reader = cmd.ExecuteReader())  
            {  
                while (reader.Read())  
                {  
                    list.Add(new XXIBM_PRODUCT_STYLE()  
                    {  
                        Item_Number = Convert.ToInt32(reader["Item_Number"]),  
                        Description = reader["Description"].ToString(),  
                        Long_Description = reader["Long_Description"].ToString(),  
                        Catalogue_Category = Convert.ToInt32(reader["Catalogue_Category"]),  
                        Brand = reader["Brand"].ToString()  
                    });  
                }  
            }  
        }  
        return list;  
    }
 
    }  
}  
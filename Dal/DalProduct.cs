using System;
using System.Collections.Generic;
using DataModel;
using IDal;
using MySql.Data.MySqlClient;

namespace Dal
{
    public class DalProduct : IDalProduct
    {
        private readonly DatabaseAcces dal = new DatabaseAcces();
        public bool AddProduct(ProductModel newproduct)
        {
            bool productadded = false;
            string query = "INSERT INTO product(Name,  Quantity, Sellprice, wholesaleprice, Serialnumber) " +
                           "VALUES (@name,@quantity,@sellprice,@wholesaleprice,@serialnumber)";
            dal.conn.Open();
            MySqlCommand command = new MySqlCommand(query, dal.conn);
            command.Parameters.Add(new MySqlParameter("@name", newproduct.Name));
            command.Parameters.Add(new MySqlParameter("@wholesaleprice", newproduct.WholeSalePrice));
            command.Parameters.Add(new MySqlParameter("@quantity", newproduct.Quantity));
            command.Parameters.Add(new MySqlParameter("@sellprice", newproduct.RetailPrice));
            command.Parameters.Add(new MySqlParameter("@serialnumber", newproduct.SerialNumber));
            try
            {
                command.ExecuteNonQuery();
                if (command.ExecuteNonQuery().Equals(1))
                {
                    dal.conn.Close();
                    productadded = true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                dal.conn.Close();
            }

            return productadded;
        }

        public bool AddProducts(List<ProductModel> addproducts)
        {
            bool succesful = false;
            string query = "INSERT INTO product(Name,  Quantity, Sellprice, wholesaleprice, Serialnumber) " +
                           "VALUES (@name,@quantity,@sellprice,@wholesaleprice,@serialnumber)";
            dal.conn.Open();
            MySqlCommand command = new MySqlCommand(query);
            try
            {
                foreach (ProductModel product in addproducts)
                {
                    command.Parameters.Add(new MySqlParameter("@name", product.Name));
                    command.Parameters.Add(new MySqlParameter("@wholesaleprice", product.WholeSalePrice));
                    command.Parameters.Add(new MySqlParameter("@quantity", product.Quantity));
                    command.Parameters.Add(new MySqlParameter("@sellprice", product.RetailPrice));
                    command.Parameters.Add(new MySqlParameter("@serialnumber", product.SerialNumber));
                    command.ExecuteNonQuery();
                }

                succesful = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                dal.conn.Close();
            }

            return succesful;
        }

        public bool ChangeProduct(ProductModel product)
        {
            bool succesful = false;
            dal.conn.Open();
            string query =
                "UPDATE product SET  Name = @name, Description = @wholesaleprice, Quantity = @quantity, Sellprice = @sellprice WHERE Serialnumber = @serialnumber";

            MySqlCommand command = new MySqlCommand(query, dal.conn);
            command.Parameters.Add(new MySqlParameter("@name", product.Name));
            command.Parameters.Add(new MySqlParameter("@wholesaleprice", product.WholeSalePrice));
            command.Parameters.Add(new MySqlParameter("@quantity", product.Quantity));
            command.Parameters.Add(new MySqlParameter("@sellprice", product.RetailPrice));
            command.Parameters.Add(new MySqlParameter("@serialnumber", product.SerialNumber));

            try
            {
                command.ExecuteNonQuery();
                succesful = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                dal.conn.Close();
            }
            return succesful;
        }

        public ProductModel GetProduct(int id)
        {
            dal.conn.Open();
            ProductModel data = new ProductModel();
            string query = "Select * FROM Product WHERE serialnumber = @SerialNumber";

            MySqlCommand command = new MySqlCommand(query, dal.conn);
            command.Parameters.Add(new MySqlParameter("@SerialNumber", id));
            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data.SerialNumber = reader.GetInt32(5);
                    data.Name = reader.GetString("Name");
                    data.Quantity = reader.GetInt32(2);
                    data.RetailPrice = reader.GetDecimal(3);
                    data.WholeSalePrice= reader.GetDecimal(4);

                }

                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                dal.conn.Close();
            }
        }

        public List<ProductModel> Products()
        {
            List<ProductModel> productList = new List<ProductModel>();
            string query = "SELECT * FROM product";
            dal.conn.Open();
            MySqlCommand command = new MySqlCommand(query, dal.conn);
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                //read through all the data
                while (reader.Read())
                {
                    //create productlist
                    ProductModel product = new ProductModel()
                    {
                        SerialNumber = reader.GetInt32("serialnumber"),
                        Name = reader.GetString("Name"),
                        Quantity = reader.GetInt16(" quantity"),
                        RetailPrice = reader.GetDecimal("Sellprice"),
                        WholeSalePrice = reader.GetDecimal("Serialnumber")
                    };
                    // save uitlening to the list
                    productList.Add(product);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                dal.conn.Close();
            }

            return productList;
        }

        public bool RemoveProduct(ProductModel product)
        {
            bool Succeful = false;
            //todo string open  command close
            
            try
            {
                Succeful = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                dal.conn.Close();
            }

            return Succeful;
        }
    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region Additional Namespaces
using NorthwindSystem.Data;     //access to data definitions
using NorthwindSystem.DAL;      //access to context class
using System.Data.SqlClient;    //access to SqlParameter();
#endregion

namespace NorthwindSystem.BLL
{
    //this class will be called from an external source
    //in our example, this source will be the web page
    //naming standard is <T>Controller which represents
    //    a particular data class (sql table)
    public class ProductController
    {
        //code methods which will be called for processing
        //methods will be public
        //these methods are referred to as the system interface

        //a method to lookup a record on the database table
        //    by primary key
        //input: primary key value
        //output: instance of data class
        public Product Product_Get(int productid)
        {
            //the processing of the request will be done
            //  in a transaction using the Context class
            //a) instance of Context class
            //b) issue the request for lookup via the appropriate
            //      DbSet<T>
            //c) return results
            using (var context = new NorthwindContext())
            {
                return context.Products.Find(productid);
            }
        }

        //a method to retreive all records on the DbSet<T>
        //input: none
        //ouput: List<T>
        public List<Product> Product_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }
        //at times you will to do a NON-PRIMARY KEY lookup
        //you will NOT be able to use .Find(pkey)
        //you can call sql procedures via your context class
        //  within your bll class method
        //we will use .Database.SqlQuery<T>()   NOT the DbSet<T>
        //the argument(s) for SqlQuery are 
        // a) the sql procedure execute statement (as a string)
        // b) IF REQUIRED, any arguments for the procedure
        //passing the data arguments to the procedure will make use of 
        //  new.SqlParameter() object
        //the SqlParameter object needs a using clause: System.data.SqlClient
        //SqlParameter takes two arguments
        // a) procedure parameter name 
        // b) value to be passed
        public List<Product> Product_GetByCategory(int categoryid)
        {
            using (var context = new NorthwindContext())
            {
                //normally you will find that data from EntityFramework
                //  returns as an IEnumerable<T> datatype
                //one can convert the IEnumerable<T> to a List<T> using .ToList()
                IEnumerable<Product> results =
                    context.Database.SqlQuery<Product>(
                        "Products_GetByCategories @CategoryID",
                        new SqlParameter("CategoryID",categoryid));
                return results.ToList();
            }
        }
    }



}

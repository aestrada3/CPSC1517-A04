using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this class needs to have access to ADO.net EntityFrameWork
//the Nuget package EntityFrameWork has already been added to this project
//this project also needs the assembly System.Data.Entity
//this project will need using clauses that point to 
//  a)the system.data.entity namespace
//  b)your data project namespace

#region
using System.Data.Entity;
using NorthwindSystem.Data;
#endregion

namespace NorthwindSystem.DAL
{
    //the class access internal restrict calls to this class
    //  to methods within this project
    //this context class needs to inherit DbContext from
    //  EntityFramework
    //make sure this is "internal"
    internal class NorthwindContext : DbContext
    {
        //setup your class default contructor to supply your connection string name
        // to the DbContext inherited class
        public NorthwindContext():base("NWDB")
        {

        }

        //create an EntityFramework DbSet<T> for each mapped
        //  sql table
        // <T> is your class in the .Data project
        public DbSet<Product> Products { get; set; }

    }
}

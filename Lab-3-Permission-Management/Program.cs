using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Permission_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add 4 users with none permissions (Admin, operator, manager,senior)
            User operatorUser = new User("operator");
            User SeniorUser = new User("senior");
            User managerUser = new User("manager");
            User adminUser = new User("admin");
            /**
             * 
             * Add read permission to operatorUser look at line 25 to line 31
             * Add read, write, execute permissions to manager
             
             * Add read, write permissions to senior
             * Add full permission(read,write,execution) to admin
             */
            managerUser.AddPermission(Permissions.Read);
            managerUser.AddPermission(Permissions.Write);
            managerUser.AddPermission(Permissions.Execute);

            SeniorUser.AddPermission(Permissions.Read);
            SeniorUser.AddPermission(Permissions.Write);

            adminUser.AddPermission(Permissions.Read);
            adminUser.AddPermission(Permissions.Write);
            adminUser.AddPermission(Permissions.Execute);

            operatorUser.AddPermission(Permissions.Read);

            SeniorUser.RemovePermission(Permissions.Write);
            if (SeniorUser.HasPermission(Permissions.Write))
                Console.WriteLine("Senior user has write permission");
            else
                Console.WriteLine("Senior user does not have write permission");

            if (managerUser.HasPermission(Permissions.Execute))
                Console.WriteLine("Manger User has execute permission");
            else
                Console.WriteLine("Manger User does not have execute permission");

            if (adminUser.HasPermission(Permissions.Execute | Permissions.Write | Permissions.Read))
                Console.WriteLine("Admin possess all permissions");
            else
                Console.WriteLine("Admin does not possess all permissions");

            if (operatorUser.HasPermission(Permissions.Read))
                Console.WriteLine("Operator has read permission");
            else
                Console.WriteLine("Operator does not have read permission");

            /**
             * Look at tasks description in lab3.1 and complete the remaining tasks
             */
        }
    }
}
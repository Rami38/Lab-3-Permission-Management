using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_3_Permission_Management
{
    public class User
    {
        private Permissions permissions;
        private string name;

        public User(string name, Permissions initialPermissions = Permissions.None)
        {
            this.name = name;
            this.permissions = initialPermissions;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public Permissions GetPermissions()
        {
            return permissions;
        }

        public void SetPermissions(Permissions newPermissions)
        {
            permissions = newPermissions;
        }

        public void AddPermission(Permissions permission)
        {
            permissions |= permission;
        }

        public void RemovePermission(Permissions permission)
        {
            permissions &= ~permission;
        }

        public void MultiplyPermission(Permissions permission1, Permissions permission2)
        {   
            Permissions combined = permission1 | permission2;
            permissions |= combined;
        }

        public void RemoveMultiplyPermission(Permissions permission1, Permissions permission2)
        {
            Permissions combined = permission1 | permission2;
            permissions &= ~combined;
        }

        public bool HasPermission(Permissions permission)
        {
            return (permissions & permission) == permission;
        }
    }
}
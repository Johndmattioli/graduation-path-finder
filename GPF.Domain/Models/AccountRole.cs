﻿namespace GPF.Domain.Models
{
    public class AccountRole : ValueDescription
    {
        private AccountRole(string value, string description)
        {
            _value = value;
            _description = description;
        }
        
        public static readonly AccountRole Administrator = new AccountRole("A", "Administrator");
        public static readonly AccountRole Faculty = new AccountRole("F", "Faculty");
        public static readonly AccountRole Student = new AccountRole("S", "Student");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace LibrarySystem.Models
{
    public class AuthService
    {
        // Global in-memory user list
        public static List<UserRecord> UserList = new List<UserRecord>();

        // Method to register a new student
        public bool RegisterUser(string studentNoStr, string firstName, string lastName, string password)
        {
            // Parse Student Number string to integer
            if (!int.TryParse(studentNoStr, out int memberId))
            {
                return false; // Failed if input is not a valid number
            }

            // Check if user already exists
            if (UserList.Any(u => u.MemberID == memberId))
            {
                return false; // Duplicate MemberID
            }

            // Save new user
            UserRecord newUser = new UserRecord
            {
                MemberID = memberId,
                FullName = $"{firstName} {lastName}",
                Password = password,
                Role = "student"
            };

            UserList.Add(newUser);
            return true;
        }

        // Method to validate login credentials
        public UserRecord ValidateLogin(string memberIdStr, string password)
        {
            if (!int.TryParse(memberIdStr, out int memberId))
            {
                return null;
            }

            return UserList.FirstOrDefault(u => u.MemberID == memberId && u.Password == password);
        }
    }
}
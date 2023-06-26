using Firebase.Auth;
using Firebase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace project2.Services
{
    public class UserRepository
    {
        string webAPIKey = "AIzaSyA3GbH6VbljJpwTGkbQvDzaCb-u3mAQkx8";
        FirebaseAuthProvider authProvider;
        public UserRepository()
        {
            authProvider = new FirebaseAuthProvider(new FirebaseConfig(webAPIKey));
        }
        public async Task<bool> Register(string email, string name, string password)
        {
            var token = await authProvider.CreateUserWithEmailAndPasswordAsync(email, password, name);
            if (!string.IsNullOrEmpty(token.FirebaseToken))
            {
                return true;
            }
            return false;
        }

        public async Task<string> SignIn(string email, string password)
        {
            var token = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
            if (!string.IsNullOrEmpty(token.FirebaseToken))
            {
                return token.FirebaseToken;
            }
            return "";
        }
    }
}

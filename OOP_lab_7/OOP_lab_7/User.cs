using System;

namespace OOP_lab_7
{
    [Serializable]
    public class User<T> {
        public T id;

        public string name;
        public string email;
        public string password;

        public User() {
            name = "";
            password = "";
            email = "";
            id = default;
        }

        public User(T id, string name, string email, string password) {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
        }
    }
}

using OOP_lab_8;

List<User> users = new List<User>();

int usersCount = 0;
int userIndex = 0;

Console.Write("Enter users count: ");
int.TryParse(Console.ReadLine(), out usersCount);

for (int i = 0; i < usersCount; i++) { 
    User newUser = new User();
    newUser.EOnLevelUpgrade += Notificator.CongratulatWithNewLvl;

    users.Add(newUser);
}

Console.Write($"Enter user index, from 0 to {usersCount - 1}: ");
int.TryParse(Console.ReadLine(),out userIndex);

users[userIndex].AddExperience(1000);

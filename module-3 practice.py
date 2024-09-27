class User:
    def __init__(self, name, email, role):
        self.name = name
        self.email = email
        self.role = role

class UserManager:
    def __init__(self):
        self.users = []

    def add_user(self, name, email, role):
        self.users.append(User(name, email, role))

    def remove_user(self, email):
        self.users = [user for user in self.users if user.email != email]

    def update_user(self, email, name=None, role=None):
        for user in self.users:
            if user.email == email:
                if name:
                    user.name = name
                if role:
                    user.role = role

    def list_users(self):
        for user in self.users:
            print(user.name, user.email, user.role)



manager = UserManager()

manager.add_user("Rishat" , "rishka-04@mail.ru" , "Admin")
manager.add_user("Damir" , "damir-05@mail.ru" , "Admin1")
manager.list_users()

print ("update")
manager.update_user("damir-05@mail.ru", name="Alexandr")
manager.list_users()

print ("remove")
manager.remove_user("rishka-04@mail.ru")
manager.list_users()

print ("add")
manager.add_user("Sasha" , "sasha-01@gmail.ru" , "Admin5")
manager.list_users()
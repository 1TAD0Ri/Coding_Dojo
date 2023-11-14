class User:
    def __init__(self, first_name, last_name, email, age, is_rewards_member=False, gold_card_points=0):
        self.first_name = first_name
        self.last_name = last_name
        self.email = email
        self.age = age
        self.is_rewards_member = is_rewards_member
        self.gold_card_points = gold_card_points

    def display_info(self):
        print(f"Name: {self.first_name} {self.last_name}")
        print(f"Email: {self.email}")
        print(f"Age: {self.age}")
        print(f"Rewards Member: {self.is_rewards_member}")
        print(f"Gold Card Points: {self.gold_card_points}")

        
def enroll(self):
            self.its_rewards_member = True
            self.gold_card_points = 200
            print(f"enrolled in the rewards program , gold card set to 200.")



#     def spend_points(self, amount):
#         if self.is_rewards_member:
#             if self.gold_card_points >= amount:
#                 self.gold_card_points -= amount
#                 print(f"Spent {amount} gold card points. Remaining points: {self.gold_card_points}")
#             else:
#                 print("Insufficient gold card points.")
#         else:
#             print("Must be a rewards member to spend gold card points.")









































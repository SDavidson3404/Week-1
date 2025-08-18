def categorize_age(age):
    if 1 <= age <= 3:
        return "Toddler"
    elif 4 <= age <= 12:
        return "Child"
    elif 13 <= age <= 19:
        return "Teenager"
    elif 20 <= age <= 59:
        return "Adult"
    elif age >= 60:
        return "Senior"
    else:
        return "Invalid age"

# Input the age
try:
    age = int(input("Enter your age: "))
    category = categorize_age(age)
    print(f"You are categorized as: {category}")
except ValueError:
    print("Please enter a valid number.")